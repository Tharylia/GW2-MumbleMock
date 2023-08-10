using Estreya.MumbleMock.Extensions;
using Estreya.MumbleMock.Logging;
using Estreya.MumbleMock.Models;
using Estreya.MumbleMock.MumbleLink;
using Gw2Sharp.Mumble;
using Gw2Sharp.Mumble.Models;
using Gw2Sharp.WebApi.V2.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Estreya.MumbleMock;

public partial class MainForm : Form
{
    private uint _uiTick = 0;
    private Gw2MumbleClientWriter _mumbleWriter;
    private Logger _logger;
    private List<Race>? _races;
    private List<Profession>? _professions;
    private List<Specialization>? _specializations;
    private List<Map>? _maps;
    private List<World>? _worlds;
    private List<MountType>? _mounts;
    private Process? _selectedProcess;

    private ComboBoxHandler<string> _raceHandler;
    private ComboBoxHandler<string> _professionHandler;
    private ComboBoxHandler<string> _specializationHandler;
    private ComboBoxHandler<string> _mountHandler;
    private ComboBoxHandler<string> _uiScaleHandler;
    private ComboBoxHandler<string> _mapTypeHandler;
    private ComboBoxHandler<string> _mapIdHandler;
    private ComboBoxHandler<string> _worldHandler;

    public MainForm()
    {
        this.InitializeComponent();

        this._logger = new Logger(this.rtb_Log);

        this.RegisterHandlers();

        this.FormClosed += this.MainForm_FormClosed;
        this.Load += this.MainForm_Load;

        this._uiScaleHandler.ComboBox.SelectedIndex = 0;
        this.tb_UI_CompassRotation.Enabled = this.cb_UI_IsCompassRotationEnabled.Checked;

        this._logger = new Logger(this.rtb_Log);

        this.CreateAndOpenMumbleWriter();
    }

    [MemberNotNull(
        nameof(_raceHandler),
        nameof(_professionHandler),
        nameof(_specializationHandler),
        nameof(_mountHandler),
        nameof(_uiScaleHandler),
        nameof(_mapTypeHandler),
        nameof(_mapIdHandler),
        nameof(_worldHandler))]
    private void RegisterHandlers()
    {
        this._raceHandler = new ComboBoxHandler<string>(this.cb_Identity_Race);
        this._professionHandler = new ComboBoxHandler<string>(this.cb_Identity_Profession);
        this._specializationHandler = new ComboBoxHandler<string>(this.cb_Identity_Spec);
        this._mountHandler = new ComboBoxHandler<string>(this.cb_Identity_Mount);
        this._uiScaleHandler = new ComboBoxHandler<string>(this.cb_UI_Scale);
        this._mapTypeHandler = new ComboBoxHandler<string>(this.cb_Map_ID);
        this._mapIdHandler = new ComboBoxHandler<string>(this.cb_Map_Type);
        this._worldHandler = new ComboBoxHandler<string>(this.cb_World_ID);
    }

    private async void MainForm_Load(object? sender, EventArgs e)
    {
            await this.LoadAPIValues();
            this.FillAPIValues();
        }

    private void MainForm_FormClosed(object? sender, FormClosedEventArgs e)
    {
        this._mumbleWriter?.Dispose();
    }

    private float[] GetAvatarPositon()
    {
        float x = string.IsNullOrWhiteSpace(this.tb_AvatarPosition_X.Text) ? 0 : float.Parse(this.tb_AvatarPosition_X.Text, CultureInfo.InvariantCulture);
        float y = string.IsNullOrWhiteSpace(this.tb_AvatarPosition_Y.Text) ? 0 : float.Parse(this.tb_AvatarPosition_Y.Text, CultureInfo.InvariantCulture);
        float z = string.IsNullOrWhiteSpace(this.tb_AvatarPosition_Z.Text) ? 0 : float.Parse(this.tb_AvatarPosition_Z.Text, CultureInfo.InvariantCulture);

        return new[] { x, y, z };
    }

    private float[] GetAvatarFront()
    {
        float x = string.IsNullOrWhiteSpace(this.tb_AvatarFront_X.Text) ? 0 : float.Parse(this.tb_AvatarFront_X.Text, CultureInfo.InvariantCulture);
        float y = string.IsNullOrWhiteSpace(this.tb_AvatarFront_Y.Text) ? 0 : float.Parse(this.tb_AvatarFront_Y.Text, CultureInfo.InvariantCulture);
        float z = string.IsNullOrWhiteSpace(this.tb_AvatarFront_Z.Text) ? 0 : float.Parse(this.tb_AvatarFront_Z.Text, CultureInfo.InvariantCulture);

        return new[] { x, y, z };
    }

    private float[] GetCameraPositon()
    {
        float x = string.IsNullOrWhiteSpace(this.tb_CameraPosition_X.Text) ? 0 : float.Parse(this.tb_CameraPosition_X.Text, CultureInfo.InvariantCulture);
        float y = string.IsNullOrWhiteSpace(this.tb_CameraPosition_Y.Text) ? 0 : float.Parse(this.tb_CameraPosition_Y.Text, CultureInfo.InvariantCulture);
        float z = string.IsNullOrWhiteSpace(this.tb_CameraPosition_Z.Text) ? 0 : float.Parse(this.tb_CameraPosition_Z.Text, CultureInfo.InvariantCulture);

        return new[] { x, y, z };
    }

    private float[] GetCameraFront()
    {
        float x = string.IsNullOrWhiteSpace(this.tb_CameraFront_X.Text) ? 0 : float.Parse(this.tb_CameraFront_X.Text, CultureInfo.InvariantCulture);
        float y = string.IsNullOrWhiteSpace(this.tb_CameraFront_Y.Text) ? 0 : float.Parse(this.tb_CameraFront_Y.Text, CultureInfo.InvariantCulture);
        float z = string.IsNullOrWhiteSpace(this.tb_CameraFront_Z.Text) ? 0 : float.Parse(this.tb_CameraFront_Z.Text, CultureInfo.InvariantCulture);

        return new[] { x, y, z };
    }

    private unsafe Gw2LinkedMem GetMumbleData()
    {
        Gw2LinkedMem mem = new Gw2LinkedMem()
        {
            uiVersion = 1,
            uiTick = _uiTick,
            context = new Gw2Context(),
            contextLen = (uint)Marshal.SizeOf<Gw2Context>()
        };

        float[] avatarPosition = this.GetAvatarPositon();
        mem.fAvatarPosition[0] = avatarPosition[0];
        mem.fAvatarPosition[1] = avatarPosition[1];
        mem.fAvatarPosition[2] = avatarPosition[2];

        float[] avatarFront = this.GetAvatarFront();
        mem.fAvatarFront[0] = avatarFront[0];
        mem.fAvatarFront[1] = avatarFront[1];
        mem.fAvatarFront[2] = avatarFront[2];

        char[] nameChars = "Guild Wars 2".ToCharArray();
        for (int i = 0; i < 256 && i < nameChars.Length; i++)
        {
            mem.name[i] = nameChars[i];
        }

        float[] cameraPosition = this.GetCameraPositon();
        mem.fCameraPosition[0] = cameraPosition[0];
        mem.fCameraPosition[1] = cameraPosition[1];
        mem.fCameraPosition[2] = cameraPosition[2];

        float[] cameraFront = this.GetCameraFront();
        mem.fCameraFront[0] = cameraFront[0];
        mem.fCameraFront[1] = cameraFront[1];
        mem.fCameraFront[2] = cameraFront[2];

        JObject identity = new JObject
        {
            { "name", this.tb_Identity_Name.Text },
            { "race", this.GetRace() },
            { "profession", this.GetProfession() },
            { "spec", this.GetSpecialization() },
            { "world_id", this.GetWorld() },
            { "team_color_id", 0 },
            { "commander", this.cb_Identity_IsCommander.Checked },
            { "fov", this.GetFOV() },
            { "uisz", this.GetUIScale() },
        };

        char[] identityString = identity.ToString().ToCharArray();
        for (int i = 0; i < 256 && i < identityString.Length; i++)
        {
            mem.identity[i] = identityString[i];
        }

        for (int i = 0; i < Gw2Context.SOCKET_ADDRESS_SIZE; i++)
        {
            mem.context.socketAddress[i] = 0;
        }

        mem.context.mapId = this.GetMap();
        mem.context.mapType = this.GetMapType();
        mem.context.shardId = 0;
        mem.context.instance = 0;
        mem.context.buildId = string.IsNullOrWhiteSpace(this.tb_Game_BuildId.Text) ? 0 : Convert.ToUInt32(this.tb_Game_BuildId.Text);
        mem.context.uiState = this.GetUIState();

        var compassSize = this.GetCompassSize();
        mem.context.compassWidth = (ushort)compassSize.Width;
        mem.context.compassHeight = (ushort)compassSize.Height;
        mem.context.compassRotation = this.GetCompassRotation();

        var playerMapPosition = this.GetPlayerMapPosition();
        mem.context.playerMapX = playerMapPosition.X;
        mem.context.playerMapY = playerMapPosition.Y;

        var mapCenter = this.GetMapCenter();
        mem.context.mapCenterX = mapCenter.X;
        mem.context.mapCenterY = mapCenter.Y;
        mem.context.mapScale = this.GetMapScale();
        mem.context.processId = (uint)(this._selectedProcess?.Id ?? 0);
        mem.context.mount = (Gw2Sharp.Models.MountType)this.GetMount();

        return mem;
    }

    private float GetFOV()
    {
        return string.IsNullOrWhiteSpace(this.tb_UI_FOV.Text) ? 0.873f : float.Parse(this.tb_UI_FOV.Text, CultureInfo.InvariantCulture);
    }

    private int GetRace()
    {
        string? value = this._raceHandler?.GetValueAsText(null);
        return (value?.ToLowerInvariant()) switch
        {
            "asura" or null or "" => 0,
            "charr" => 1,
            "human" => 2,
            "norn" => 3,
            "sylvari" => 4,
            _ => throw new ArgumentException($"Invalid race."),
        };
    }

    private int GetProfession()
    {
        string? value = this._professionHandler?.GetValueAsText(null);
        return (value?.ToLowerInvariant()) switch
        {
            null or "" => 0,
            "guardian" => 1,
            "warrior" => 2,
            "engineer" => 3,
            "ranger" => 4,
            "thief" => 5,
            "elementalist" => 6,
            "mesmer" => 7,
            "necromancer" => 8,
            "revenant" => 9,
            _ => throw new ArgumentException($"Invalid profession."),
        };
    }

    private int GetMount()
    {
        string? value = this._mountHandler?.GetValueAsText(null);
        return (value?.ToLowerInvariant()) switch
        {
            null or "" => 0,
            "jackal" => 1,
            "griffon" => 2,
            "springer" => 3,
            "skimmer" => 4,
            "raptor" => 5,
            "roller beetle" => 6,
            "warclaw" => 7,
            "skyscale" => 8,
            "skiff" => 9,
            "siege turtle" => 10,
            _ => throw new ArgumentException($"Invalid mount."),
        };
    }

    private int GetUIScale()
    {
        string? value = this._uiScaleHandler?.GetValueAsText(null);
        return (value?.ToLowerInvariant()) switch
        {
            null or "" or "small" => 0,
            "normal" => 1,
            "large" => 2,
            "larger" => 3,
            _ => throw new ArgumentException($"Invalid ui scale."),
        };
    }

    private uint GetMapType()
    {
        string? value = this._mapTypeHandler?.GetValueAsText(null);
        return (value?.ToLowerInvariant()) switch
        {
            null or "" => 9,
            "public" => 5,
            "instance" => 4,
            "center" => 9,
            "bluehome" => 10,
            "greenhome" => 11,
            "redhome" => 12,
            "tutorial" => 7,
            "pvp" => 2,
            "jumppuzzle" => 14,
            "edgeofthemists" => 15,
            _ => 99//throw new ArgumentException($"Invalid ui scale."),
        };
    }

    private int GetSpecialization()
    {
        string value = this._specializationHandler.GetValueAsText(null) ?? "0";
        Specialization? spec = this._specializations?.FirstOrDefault(x => x.Name == value);
        return spec is not null ? spec.Id : int.Parse(value, CultureInfo.InvariantCulture);
    }

    private int GetWorld()
    {
        string value = this._worldHandler.GetValueAsText(null) ?? "0";
        World? world = this._worlds?.FirstOrDefault(x => x.Name == value);
        return world is not null ? world.Id : int.Parse(value, CultureInfo.InvariantCulture);
    }

    private uint GetMap()
    {
        string value = this._mapIdHandler.GetValueAsText(null) ?? "0";
        Map? map = this._maps?.FirstOrDefault(x => x.Name == value);
        return map is not null ? (uint)map.Id : uint.Parse(value, CultureInfo.InvariantCulture);
    }

    private UiState GetUIState()
    {
        UiState uiState = new UiState();

        if (this.cb_UI_IsMapOpen.Checked) uiState |= UiState.IsMapOpen;
        if (this.cb_UI_IsCompassTopRight.Checked) uiState |= UiState.IsCompassTopRight;
        if (this.cb_UI_IsCompassRotationEnabled.Checked) uiState |= UiState.IsCompassRotationEnabled;
        if (this.cb_UI_DoesGameHaveFocus.Checked) uiState |= UiState.DoesGameHaveFocus;
        if (this.cb_UI_IsCompetitiveMode.Checked) uiState |= UiState.IsCompetitiveMode;
        if (this.cb_UI_DoesAnyInputHaveFocus.Checked) uiState |= UiState.DoesAnyInputHaveFocus;
        if (this.cb_UI_IsInCombat.Checked) uiState |= UiState.IsInCombat;

        return uiState;
    }

    private Size GetCompassSize()
    {
        return new Size(
            string.IsNullOrWhiteSpace(this.tb_UI_CompassWidth.Text) ? 0 : ushort.Parse(this.tb_UI_CompassWidth.Text, CultureInfo.InvariantCulture),
            string.IsNullOrWhiteSpace(this.tb_UI_CompassHeight.Text) ? 0 : ushort.Parse(this.tb_UI_CompassHeight.Text, CultureInfo.InvariantCulture)
        );
    }

    private float GetCompassRotation()
    {
        return !this.cb_UI_IsCompassRotationEnabled.Checked || string.IsNullOrWhiteSpace(this.tb_UI_CompassRotation.Text) ? 0f : float.Parse(this.tb_UI_CompassRotation.Text, CultureInfo.InvariantCulture);
    }

    private Vector2 GetPlayerMapPosition()
    {
        return new Vector2(
            string.IsNullOrWhiteSpace(this.tb_Map_PlayerX.Text) ? 0 : float.Parse(this.tb_Map_PlayerX.Text, CultureInfo.InvariantCulture),
            string.IsNullOrWhiteSpace(this.tb_Map_PlayerY.Text) ? 0 : float.Parse(this.tb_Map_PlayerY.Text, CultureInfo.InvariantCulture)
        );
    }

    private Vector2 GetMapCenter()
    {
        return new Vector2(
            string.IsNullOrWhiteSpace(this.tb_Map_CenterX.Text) ? 0 : float.Parse(this.tb_Map_CenterX.Text, CultureInfo.InvariantCulture),
            string.IsNullOrWhiteSpace(this.tb_Map_CenterY.Text) ? 0 : float.Parse(this.tb_Map_CenterY.Text, CultureInfo.InvariantCulture)
        );
    }

    private float GetMapScale()
    {
        return string.IsNullOrWhiteSpace(this.tb_Map_Scale.Text) ? 0 : float.Parse(this.tb_Map_Scale.Text, CultureInfo.InvariantCulture);
    }

    private unsafe void MumbleUpdate_timer_Tick(object sender, EventArgs e)
    {
        if (this._mumbleWriter is null) return;

        try
        {
            this._uiTick++;

            Gw2LinkedMem data = this.GetMumbleData();

            this._mumbleWriter.Write(data);

            if (this.cb_Log_LogMumbleUpdated.Checked)
            {
                this._logger.Info($"Memory map \"{this._mumbleWriter.MumbleLinkName}\" updated for ui tick {data.uiTick}.");
            }
        }
        catch (Exception ex)
        {
            this._logger.Error($"Memory map \"{this._mumbleWriter.MumbleLinkName}\" failed to update: {ex.Message}");
        }
    }

    private void btn_Start_Click(object sender, EventArgs e)
    {
        this.MumbleUpdate_timer.Start();
        this.btn_Start.Enabled = false;
        this.btn_Stop.Enabled = true;
    }

    private void btn_Stop_Click(object sender, EventArgs e)
    {
        this.MumbleUpdate_timer.Stop();
        this.btn_Start.Enabled = true;
        this.btn_Stop.Enabled = false;
    }

    private async Task LoadAPIValues()
    {
        this._logger.Info("Loading API values...");

        Gw2Sharp.Connection connection = new Gw2Sharp.Connection();
        using Gw2Sharp.Gw2Client client = new Gw2Sharp.Gw2Client(connection);

        Task<Gw2Sharp.WebApi.V2.IApiV2ObjectList<Map>> mapsTask = client.WebApi.V2.Maps.AllAsync();
        Task<Gw2Sharp.WebApi.V2.IApiV2ObjectList<Race>> racesTask = client.WebApi.V2.Races.AllAsync();
        Task<Gw2Sharp.WebApi.V2.IApiV2ObjectList<Specialization>> specializationTask = client.WebApi.V2.Specializations.AllAsync();
        Task<Gw2Sharp.WebApi.V2.IApiV2ObjectList<Profession>> professionsTask = client.WebApi.V2.Professions.AllAsync();
        Task<Gw2Sharp.WebApi.V2.IApiV2ObjectList<World>> worldsTask = client.WebApi.V2.Worlds.AllAsync();
        Task<Gw2Sharp.WebApi.V2.IApiV2ObjectList<MountType>> mountsTask = client.WebApi.V2.Mounts.Types.AllAsync();
        Task<Build> buildIdTask = client.WebApi.V2.Build.GetAsync();

        try
        {
            await Task.WhenAll(mapsTask, racesTask, specializationTask, professionsTask, worldsTask, mountsTask, buildIdTask);
        }
        catch (Exception) { }

        if (mapsTask.IsCompletedSuccessfully)
        {
            this._maps = mapsTask.Result.ToList();
        }
        else
        {
            this._logger.Warn($"Failed to load maps from api: {mapsTask.Exception?.Message}");
        }

        if (racesTask.IsCompletedSuccessfully)
        {
            this._races = racesTask.Result.ToList();
        }
        else
        {
            this._logger.Warn($"Failed to load races from api: {racesTask.Exception?.Message}");
        }

        if (specializationTask.IsCompletedSuccessfully)
        {
            this._specializations = specializationTask.Result.ToList();
        }
        else
        {
            this._logger.Warn($"Failed to load maps from api: {specializationTask.Exception?.Message}");
        }

        if (professionsTask.IsCompletedSuccessfully)
        {
            this._professions = professionsTask.Result.ToList();
        }
        else
        {
            this._logger.Warn($"Failed to load maps from api: {professionsTask.Exception?.Message}");
        }

        if (worldsTask.IsCompletedSuccessfully)
        {
            this._worlds = worldsTask.Result.ToList();
        }
        else
        {
            this._logger.Warn($"Failed to load maps from api: {worldsTask.Exception?.Message}");
        }

        if (mountsTask.IsCompletedSuccessfully)
        {
            this._mounts = mountsTask.Result.ToList();
        }
        else
        {
            this._logger.Warn($"Failed to load maps from api: {mountsTask.Exception?.Message}");
        }

        if (buildIdTask.IsCompletedSuccessfully)
        {
            this.tb_Game_BuildId.Text = buildIdTask.Result?.Id.ToString();
        }
        else
        {
            this._logger.Warn($"Failed to load build id from api: {buildIdTask.Exception?.Message}");
        }

        this._logger.Info("Loading API values finished.");
    }

    private void FillAPIValues()
    {
        if (this._races is not null)
        {
            this._raceHandler.ComboBox.Items.AddRange(this._races.Select(x => x.Name).ToArray());
        }
        else
        {
            this._raceHandler.ComboBox.DropDownStyle = ComboBoxStyle.DropDown;
        }

        if (this._professions is not null)
        {
            this._professionHandler.ComboBox.Items.AddRange(this._professions.OrderBy(x => x.Name).Select(x => x.Name).ToArray());
        }
        else
        {
            this._professionHandler.ComboBox.DropDownStyle = ComboBoxStyle.DropDown;
        }

        if (this._specializations is not null)
        {
            this._specializationHandler.ComboBox.Items.AddRange(this._specializations.OrderBy(x => x.Name).Select(x => x.Name).ToArray());
        }
        else
        {
            this._specializationHandler.ComboBox.DropDownStyle = ComboBoxStyle.DropDown;
        }

        if (this._maps is not null)
        {
            this._mapIdHandler.ComboBox.Items.AddRange(this._maps.OrderBy(x => x.Name).Select(x => x.Name).ToArray());
            this._mapTypeHandler.ComboBox.Items.AddRange(this._maps.Select(x => x.Type.ToString()).Distinct().ToArray());
        }
        else
        {
            this._mapIdHandler.ComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            this._mapTypeHandler.ComboBox.DropDownStyle = ComboBoxStyle.DropDown;
        }

        if (this._worlds is not null)
        {
            this._worldHandler.ComboBox.Items.AddRange(this._worlds.OrderBy(x => x.Name).Select(x => x.Name).ToArray());
        }
        else
        {
            this._worldHandler.ComboBox.DropDownStyle = ComboBoxStyle.DropDown;
        }

        this._mountHandler.ComboBox.Items.Add(string.Empty);
        if (this._mounts is not null)
        {
            this._mountHandler.ComboBox.Items.AddRange(this._mounts.Select(x => x.Name).ToArray());
        }
        else
        {
            this._mountHandler.ComboBox.DropDownStyle = ComboBoxStyle.DropDown;
        }
    }

    private void btn_Game_SelectProcess_Click(object sender, EventArgs e)
    {
        SelectProcessForm form = new SelectProcessForm();

        DialogResult result = form.ShowDialog();

        if (result == DialogResult.OK)
        {
            this._selectedProcess = form.SelectedProcess;
            if (this._selectedProcess != null)
            {
                this.lbl_Game_ProcessId_Value.Text = $"{this._selectedProcess.ProcessName} - {this._selectedProcess.Id}";
            }
        }
    }

    private void cb_UI_IsCompassRotationEnabled_CheckedChanged(object sender, EventArgs e)
    {
        this.tb_UI_CompassRotation.Enabled = this.cb_UI_IsCompassRotationEnabled.Checked;
    }

    [MemberNotNull(nameof(_mumbleWriter))]
    private void CreateAndOpenMumbleWriter()
    {
        if (this._mumbleWriter is not null)
        {
            this._mumbleWriter.Write(new Gw2LinkedMem());
            this._mumbleWriter.Dispose();
            this._logger.Info($"Memory Map \"{this._mumbleWriter.MumbleLinkName}\" deleted.");
        }

        this._uiTick = 0;
        this._mumbleWriter = new Gw2MumbleClientWriter("MumbleLink");
        this._mumbleWriter.Open();

        this._logger.Info($"Memory Map \"{this._mumbleWriter.MumbleLinkName}\" connected.");
    }

    private void btn_RecreateMemoryMap_Click(object sender, EventArgs e)
    {
        this.CreateAndOpenMumbleWriter();
    }

    private void tsmi_Export_Click(object sender, EventArgs e)
    {
        var sfd = new SaveFileDialog
        {
            Filter = "JSON (*.json)|*.json",
            FileName = "MumbleMock.json"
        };

        var result = sfd.ShowDialog();

        if (result != DialogResult.OK) return;

        var compassSize = this.GetCompassSize();
        var json = JsonConvert.SerializeObject(new SaveData()
        {
            AvatarPosition = this.GetAvatarPositon().ToVector3(),
            AvatarFront = this.GetAvatarFront().ToVector3(),
            AvatarTop = Vector3.Zero,
            CameraPosition = this.GetCameraPositon().ToVector3(),
            CameraFront = this.GetCameraFront().ToVector3(),
            CameraTop = Vector3.Zero,
            Identity = new Identity()
            {
                Name = this.tb_Identity_Name.Text,
                Race = this.cb_Identity_Race.SelectedItem?.ToString(),
                Profession = this.cb_Identity_Profession.SelectedItem?.ToString(),
                Specialization = this.cb_Identity_Spec.SelectedItem?.ToString(),
                WorldId = this.cb_World_ID.SelectedItem?.ToString(),
                UISize = this.cb_UI_Scale.SelectedItem?.ToString(),
                TeamColorId = 0,
                IsCommander = this.cb_Identity_IsCommander.Checked,
                FOV = this.GetFOV()
            },
            Context = new Context()
            {
                BuildId = this.tb_Game_BuildId.Text,
                UiState = this.GetUIState(),
                CompassHeight = (ushort)compassSize.Height,
                CompassWidth = (ushort)compassSize.Width,
                CompassRotation = this.GetCompassRotation(),
                PlayerPosition = this.GetPlayerMapPosition(),
                MapCenter = this.GetMapCenter(),
                MapScale = this.GetMapScale(),
                MapId = this.cb_Map_ID.SelectedItem?.ToString(),
                MapType = this.cb_Map_Type.SelectedItem?.ToString(),
                Mount = this.cb_Identity_Mount.SelectedItem?.ToString(),
            }
        }, this.GetJsonSerializerSettings()) ;

        System.IO.File.WriteAllText(sfd.FileName, json);
    }

    private void tsmi_Import_Click(object sender, EventArgs e)
    {
        var ofd = new OpenFileDialog()
        {
            Filter = "JSON (*.json)|*.json",
            FileName = "MumbleMock.json",
            CheckFileExists = true
        };

        var result = ofd.ShowDialog();

        if (result != DialogResult.OK) return;

        var json = System.IO.File.ReadAllText(ofd.FileName);

        var saveData = JsonConvert.DeserializeObject<SaveData>(json);

        if (saveData is null) return;

        this.tb_AvatarPosition_X.Text = saveData.AvatarPosition.X.ToString();
        this.tb_AvatarPosition_Y.Text = saveData.AvatarPosition.Y.ToString();
        this.tb_AvatarPosition_Z.Text = saveData.AvatarPosition.Z.ToString();
        this.tb_AvatarFront_X.Text = saveData.AvatarFront.X.ToString();
        this.tb_AvatarFront_Y.Text = saveData.AvatarFront.Y.ToString();
        this.tb_AvatarFront_Z.Text = saveData.AvatarFront.Z.ToString();
        this.tb_CameraPosition_X.Text = saveData.CameraPosition.X.ToString();
        this.tb_CameraPosition_Y.Text = saveData.CameraPosition.Y.ToString();
        this.tb_CameraPosition_Z.Text = saveData.CameraPosition.Z.ToString();
        this.tb_CameraFront_X.Text = saveData.CameraFront.X.ToString();
        this.tb_CameraFront_Y.Text = saveData.CameraFront.Y.ToString();
        this.tb_CameraFront_Z.Text = saveData.CameraFront.Z.ToString();

        if (saveData.Identity is not null)
        {
            this.tb_Identity_Name.Text = saveData.Identity.Name;
            this._raceHandler.SetValue(saveData.Identity.Race);
            this._professionHandler.SetValue(saveData.Identity.Profession);
            this._specializationHandler.SetValue(saveData.Identity.Specialization);
            this._worldHandler.SetValue(saveData.Identity.WorldId);
            this._uiScaleHandler.SetValue(saveData.Identity.UISize);
            this.cb_Identity_IsCommander.Checked = saveData.Identity.IsCommander;
            this.tb_UI_FOV.Text = saveData.Identity.FOV.ToString();
        }

        if (saveData.Context is not null)
        {
            this.tb_Game_BuildId.Text = saveData.Context.BuildId;
            this.cb_UI_IsMapOpen.Checked = saveData.Context.UiState.HasFlag(UiState.IsMapOpen);
            this.cb_UI_IsCompassTopRight.Checked = saveData.Context.UiState.HasFlag(UiState.IsCompassTopRight);
            this.cb_UI_IsCompassRotationEnabled.Checked = saveData.Context.UiState.HasFlag(UiState.IsCompassRotationEnabled);
            this.cb_UI_DoesGameHaveFocus.Checked = saveData.Context.UiState.HasFlag(UiState.DoesGameHaveFocus);
            this.cb_UI_IsCompetitiveMode.Checked = saveData.Context.UiState.HasFlag(UiState.IsCompetitiveMode);
            this.cb_UI_DoesAnyInputHaveFocus.Checked = saveData.Context.UiState.HasFlag(UiState.DoesAnyInputHaveFocus);
            this.cb_UI_IsInCombat.Checked = saveData.Context.UiState.HasFlag(UiState.IsInCombat);

            this.tb_UI_CompassWidth.Text = saveData.Context.CompassWidth.ToString();
            this.tb_UI_CompassHeight.Text = saveData.Context.CompassHeight.ToString();
            this.tb_UI_CompassRotation.Text = saveData.Context.CompassRotation.ToString();

            this.tb_Map_PlayerX.Text = saveData.Context.PlayerPosition.X.ToString();
            this.tb_Map_PlayerY.Text = saveData.Context.PlayerPosition.Y.ToString();

            this.tb_Map_CenterX.Text = saveData.Context.MapCenter.X.ToString();
            this.tb_Map_CenterY.Text = saveData.Context.MapCenter.Y.ToString();
            this.tb_Map_Scale.Text = saveData.Context.MapScale.ToString();

            this._mapIdHandler.SetValue(saveData.Context.MapId);
            this._mapTypeHandler.SetValue(saveData.Context.MapType);

            this._mountHandler.SetValue(saveData.Context.Mount);
        }
    }

    private void GetSaveData()
    {
        var saveData = new SaveData();
    }

    private JsonSerializerSettings GetJsonSerializerSettings()
    {
        var settings = new JsonSerializerSettings()
        {
            Formatting = Formatting.Indented,
        };

        settings.Converters.Add(new StringEnumConverter());

        return settings;
    }
}
