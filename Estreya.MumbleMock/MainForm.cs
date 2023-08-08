using Estreya.MumbleMock.Logging;
using Estreya.MumbleMock.MumbleLink;
using Gw2Sharp.Mumble;
using Gw2Sharp.Mumble.Models;
using Gw2Sharp.WebApi.V2.Models;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

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

    public MainForm()
    {
        this.InitializeComponent();
        this.FormClosed += this.MainForm_FormClosed;
        this.Load += this.MainForm_Load;
        this.cb_UI_Scale.SelectedIndex = 0;
        this.tb_UI_CompassRotation.Enabled = this.cb_UI_IsCompassRotationEnabled.Checked;

        this._logger = new Logger(this.rtb_Log);

        this._mumbleWriter = new Gw2MumbleClientWriter("MumbleLink");
        this._mumbleWriter.Open();

        this._logger.Info("Memory Map connected.");
    }

    private async void MainForm_Load(object? sender, EventArgs e)
    {
        try
        {
            await this.LoadAPIValues();
            this.FillAPIValues();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error loading API values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
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
            { "fov", string.IsNullOrWhiteSpace(this.tb_UI_FOV.Text) ? 0.873 : float.Parse(this.tb_UI_FOV.Text, CultureInfo.InvariantCulture) },
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
        mem.context.compassWidth = string.IsNullOrWhiteSpace(this.tb_UI_CompassWidth.Text) ? (ushort)0 : ushort.Parse(this.tb_UI_CompassWidth.Text, CultureInfo.InvariantCulture);
        mem.context.compassHeight = string.IsNullOrWhiteSpace(this.tb_UI_CompassHeight.Text) ? (ushort)0 : ushort.Parse(this.tb_UI_CompassHeight.Text, CultureInfo.InvariantCulture);
        mem.context.compassRotation = !this.cb_UI_IsCompassRotationEnabled.Checked || string.IsNullOrWhiteSpace(this.tb_UI_CompassRotation.Text) ? (ushort)0 : ushort.Parse(this.tb_UI_CompassRotation.Text, CultureInfo.InvariantCulture);
        mem.context.playerMapX = string.IsNullOrWhiteSpace(this.tb_Map_PlayerX.Text) ? 0 : float.Parse(this.tb_Map_PlayerX.Text, CultureInfo.InvariantCulture);
        mem.context.playerMapY = string.IsNullOrWhiteSpace(this.tb_Map_PlayerY.Text) ? 0 : float.Parse(this.tb_Map_PlayerY.Text, CultureInfo.InvariantCulture);
        mem.context.mapCenterX = string.IsNullOrWhiteSpace(this.tb_Map_CenterX.Text) ? 0 : float.Parse(this.tb_Map_CenterX.Text, CultureInfo.InvariantCulture);
        mem.context.mapCenterY = string.IsNullOrWhiteSpace(this.tb_Map_CenterY.Text) ? 0 : float.Parse(this.tb_Map_CenterY.Text, CultureInfo.InvariantCulture);
        mem.context.mapScale = string.IsNullOrWhiteSpace(this.tb_Map_Scale.Text) ? 0 : float.Parse(this.tb_Map_Scale.Text, CultureInfo.InvariantCulture);
        mem.context.processId = (uint)(this._selectedProcess?.Id ?? 0);
        mem.context.mount = (Gw2Sharp.Models.MountType)this.GetMount();

        return mem;
    }

    private int GetRace()
    {
        return (this.cb_Identity_Race.SelectedItem?.ToString()?.ToLowerInvariant()) switch
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
        return (this.cb_Identity_Profession.SelectedItem?.ToString()?.ToLowerInvariant()) switch
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
        return (this.cb_Identity_Mount.SelectedItem?.ToString()?.ToLowerInvariant()) switch
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
        return (this.cb_UI_Scale.SelectedItem?.ToString()?.ToLowerInvariant()) switch
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
        return (this.cb_Map_Type.SelectedItem?.ToString()?.ToLowerInvariant()) switch
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
        return Convert.ToInt32(this._specializations?.FirstOrDefault(x => x.Name == this.cb_Identity_Spec.SelectedItem?.ToString())?.Id ?? 0);
    }

    private int GetWorld()
    {
        return Convert.ToInt32(this._worlds?.FirstOrDefault(x => x.Name == this.cb_World_ID.SelectedItem?.ToString())?.Id ?? 0);
    }

    private uint GetMap()
    {
        return Convert.ToUInt32(this._maps?.FirstOrDefault(x => x.Name == this.cb_Map_ID.SelectedItem?.ToString())?.Id ?? 0);
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

    private unsafe void MumbleUpdate_timer_Tick(object sender, EventArgs e)
    {
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

        Gw2Sharp.WebApi.V2.IApiV2ObjectList<Map> maps = await client.WebApi.V2.Maps.AllAsync();
        this._maps = maps.ToList();

        Gw2Sharp.WebApi.V2.IApiV2ObjectList<Race> races = await client.WebApi.V2.Races.AllAsync();
        this._races = races.ToList();

        Gw2Sharp.WebApi.V2.IApiV2ObjectList<Specialization> specializations = await client.WebApi.V2.Specializations.AllAsync();
        this._specializations = specializations.ToList();

        Gw2Sharp.WebApi.V2.IApiV2ObjectList<Profession> professions = await client.WebApi.V2.Professions.AllAsync();
        this._professions = professions.ToList();

        Gw2Sharp.WebApi.V2.IApiV2ObjectList<World> worlds = await client.WebApi.V2.Worlds.AllAsync();
        this._worlds = worlds.ToList();

        Gw2Sharp.WebApi.V2.IApiV2ObjectList<MountType> mounts = await client.WebApi.V2.Mounts.Types.AllAsync();
        this._mounts = mounts.ToList();

        Build build = await client.WebApi.V2.Build.GetAsync();
        this.tb_Game_BuildId.Text = build.Id.ToString();

        this._logger.Info("Loading API values finished.");
    }

    private void FillAPIValues()
    {
        if (this._races is not null)
        {
            this.cb_Identity_Race.Items.AddRange(this._races.Select(x => x.Name).ToArray());
        }

        if (this._professions is not null)
        {
            this.cb_Identity_Profession.Items.AddRange(this._professions.Select(x => x.Name).ToArray());
        }

        if (this._specializations is not null)
        {
            this.cb_Identity_Spec.Items.AddRange(this._specializations.Select(x => x.Name).ToArray());
        }

        if (this._maps is not null)
        {
            this.cb_Map_ID.Items.AddRange(this._maps.Select(x => x.Name).ToArray());
            this.cb_Map_Type.Items.AddRange(this._maps.Select(x => x.Type.ToString()).Distinct().ToArray());
        }

        if (this._worlds is not null)
        {
            this.cb_World_ID.Items.AddRange(this._worlds.Select(x => x.Name).ToArray());
        }

        this.cb_Identity_Mount.Items.Add(string.Empty);
        if (this._mounts is not null)
        {
            this.cb_Identity_Mount.Items.AddRange(this._mounts.Select(x => x.Name).ToArray());
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
}
