namespace Estreya.MumbleMock;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.MumbleUpdate_timer = new System.Windows.Forms.Timer(this.components);
        gb_AvatarPosition = new GroupBox();
        lbl_AvatarPosition_Z = new Label();
        tb_AvatarPosition_Z = new TextBox();
        lbl_AvatarPosition_Y = new Label();
        tb_AvatarPosition_Y = new TextBox();
        lbl_AvatarPosition_X = new Label();
        tb_AvatarPosition_X = new TextBox();
        gb_AvatarFront = new GroupBox();
        lbl_AvatarFront_Z = new Label();
        tb_AvatarFront_Z = new TextBox();
        lbl_AvatarFront_Y = new Label();
        tb_AvatarFront_Y = new TextBox();
        lbl_AvatarFront_X = new Label();
        tb_AvatarFront_X = new TextBox();
        gb_CameraFront = new GroupBox();
        lbl_CameraFront_Z = new Label();
        tb_CameraFront_Z = new TextBox();
        lbl_CameraFront_Y = new Label();
        tb_CameraFront_Y = new TextBox();
        lbl_CameraFront_X = new Label();
        tb_CameraFront_X = new TextBox();
        gb_CameraPosition = new GroupBox();
        lbl_CameraPosition_Z = new Label();
        tb_CameraPosition_Z = new TextBox();
        lbl_CameraPosition_Y = new Label();
        tb_CameraPosition_Y = new TextBox();
        lbl_CameraPosition_X = new Label();
        tb_CameraPosition_X = new TextBox();
        gb_Identity = new GroupBox();
        cb_Identity_IsCommander = new CheckBox();
        cb_Identity_Mount = new ComboBox();
        lbl_Identity_Mount = new Label();
        cb_Identity_Spec = new ComboBox();
        cb_Identity_Profession = new ComboBox();
        cb_Identity_Race = new ComboBox();
        lbl_Identity_Spec = new Label();
        lbl_Identity_Profession = new Label();
        lbl_Identity_Race = new Label();
        lbl_Identity_Name = new Label();
        tb_Identity_Name = new TextBox();
        gb_Status = new GroupBox();
        btn_Start = new Button();
        btn_Stop = new Button();
        cb_Log_LogMumbleUpdated = new CheckBox();
        rtb_Log = new RichTextBox();
        gb_MapAndWorld = new GroupBox();
        lbl_Map_Scale = new Label();
        tb_Map_Scale = new TextBox();
        lbl_Map_CenterY = new Label();
        tb_Map_CenterY = new TextBox();
        lbl_Map_CenterX = new Label();
        tb_Map_CenterX = new TextBox();
        lbl_Map_PlayerY = new Label();
        cb_World_ID = new ComboBox();
        tb_Map_PlayerY = new TextBox();
        lbl_World_Id = new Label();
        lbl_Map_PlayerX = new Label();
        cb_Map_ID = new ComboBox();
        tb_Map_PlayerX = new TextBox();
        cb_Map_Type = new ComboBox();
        lbl_Map_Type = new Label();
        lbl_Map_ID = new Label();
        gb_Game = new GroupBox();
        btn_Game_SelectProcess = new Button();
        lbl_Game_ProcessId_Value = new Label();
        tb_Game_BuildId = new TextBox();
        lbl_Game_ProcessId = new Label();
        lbl_Game_BuildId = new Label();
        gb_UI = new GroupBox();
        lbl_UI_CompassRotation = new Label();
        tb_UI_CompassRotation = new TextBox();
        lbl_UI_CompassHeight = new Label();
        cb_UI_Scale = new ComboBox();
        tb_UI_CompassHeight = new TextBox();
        lbl_UI_Scale = new Label();
        lbl_UI_CompassWidth = new Label();
        tb_UI_CompassWidth = new TextBox();
        lbl_UI_FOV = new Label();
        cb_UI_IsInCombat = new CheckBox();
        tb_UI_FOV = new TextBox();
        cb_UI_IsCompetitiveMode = new CheckBox();
        cb_UI_DoesAnyInputHaveFocus = new CheckBox();
        cb_UI_DoesGameHaveFocus = new CheckBox();
        cb_UI_IsCompassTopRight = new CheckBox();
        cb_UI_IsCompassRotationEnabled = new CheckBox();
        cb_UI_IsMapOpen = new CheckBox();
        gb_AvatarPosition.SuspendLayout();
        gb_AvatarFront.SuspendLayout();
        gb_CameraFront.SuspendLayout();
        gb_CameraPosition.SuspendLayout();
        gb_Identity.SuspendLayout();
        gb_Status.SuspendLayout();
        gb_MapAndWorld.SuspendLayout();
        gb_Game.SuspendLayout();
        gb_UI.SuspendLayout();
        this.SuspendLayout();
        // 
        // MumbleUpdate_timer
        // 
        this.MumbleUpdate_timer.Tick += this.MumbleUpdate_timer_Tick;
        // 
        // gb_AvatarPosition
        // 
        gb_AvatarPosition.Controls.Add(lbl_AvatarPosition_Z);
        gb_AvatarPosition.Controls.Add(tb_AvatarPosition_Z);
        gb_AvatarPosition.Controls.Add(lbl_AvatarPosition_Y);
        gb_AvatarPosition.Controls.Add(tb_AvatarPosition_Y);
        gb_AvatarPosition.Controls.Add(lbl_AvatarPosition_X);
        gb_AvatarPosition.Controls.Add(tb_AvatarPosition_X);
        gb_AvatarPosition.Location = new Point(12, 12);
        gb_AvatarPosition.Name = "gb_AvatarPosition";
        gb_AvatarPosition.Size = new Size(248, 112);
        gb_AvatarPosition.TabIndex = 0;
        gb_AvatarPosition.TabStop = false;
        gb_AvatarPosition.Text = "Avatar Position";
        // 
        // lbl_AvatarPosition_Z
        // 
        lbl_AvatarPosition_Z.AutoSize = true;
        lbl_AvatarPosition_Z.Location = new Point(6, 83);
        lbl_AvatarPosition_Z.Name = "lbl_AvatarPosition_Z";
        lbl_AvatarPosition_Z.Size = new Size(17, 15);
        lbl_AvatarPosition_Z.TabIndex = 5;
        lbl_AvatarPosition_Z.Text = "Z:";
        // 
        // tb_AvatarPosition_Z
        // 
        tb_AvatarPosition_Z.Location = new Point(29, 80);
        tb_AvatarPosition_Z.Name = "tb_AvatarPosition_Z";
        tb_AvatarPosition_Z.Size = new Size(213, 23);
        tb_AvatarPosition_Z.TabIndex = 4;
        tb_AvatarPosition_Z.Text = "0";
        // 
        // lbl_AvatarPosition_Y
        // 
        lbl_AvatarPosition_Y.AutoSize = true;
        lbl_AvatarPosition_Y.Location = new Point(6, 54);
        lbl_AvatarPosition_Y.Name = "lbl_AvatarPosition_Y";
        lbl_AvatarPosition_Y.Size = new Size(17, 15);
        lbl_AvatarPosition_Y.TabIndex = 3;
        lbl_AvatarPosition_Y.Text = "Y:";
        // 
        // tb_AvatarPosition_Y
        // 
        tb_AvatarPosition_Y.Location = new Point(29, 51);
        tb_AvatarPosition_Y.Name = "tb_AvatarPosition_Y";
        tb_AvatarPosition_Y.Size = new Size(213, 23);
        tb_AvatarPosition_Y.TabIndex = 2;
        tb_AvatarPosition_Y.Text = "0";
        // 
        // lbl_AvatarPosition_X
        // 
        lbl_AvatarPosition_X.AutoSize = true;
        lbl_AvatarPosition_X.Location = new Point(6, 25);
        lbl_AvatarPosition_X.Name = "lbl_AvatarPosition_X";
        lbl_AvatarPosition_X.Size = new Size(17, 15);
        lbl_AvatarPosition_X.TabIndex = 1;
        lbl_AvatarPosition_X.Text = "X:";
        // 
        // tb_AvatarPosition_X
        // 
        tb_AvatarPosition_X.Location = new Point(29, 22);
        tb_AvatarPosition_X.Name = "tb_AvatarPosition_X";
        tb_AvatarPosition_X.Size = new Size(213, 23);
        tb_AvatarPosition_X.TabIndex = 0;
        tb_AvatarPosition_X.Text = "0";
        // 
        // gb_AvatarFront
        // 
        gb_AvatarFront.Controls.Add(lbl_AvatarFront_Z);
        gb_AvatarFront.Controls.Add(tb_AvatarFront_Z);
        gb_AvatarFront.Controls.Add(lbl_AvatarFront_Y);
        gb_AvatarFront.Controls.Add(tb_AvatarFront_Y);
        gb_AvatarFront.Controls.Add(lbl_AvatarFront_X);
        gb_AvatarFront.Controls.Add(tb_AvatarFront_X);
        gb_AvatarFront.Location = new Point(266, 12);
        gb_AvatarFront.Name = "gb_AvatarFront";
        gb_AvatarFront.Size = new Size(248, 112);
        gb_AvatarFront.TabIndex = 6;
        gb_AvatarFront.TabStop = false;
        gb_AvatarFront.Text = "Avatar Front";
        // 
        // lbl_AvatarFront_Z
        // 
        lbl_AvatarFront_Z.AutoSize = true;
        lbl_AvatarFront_Z.Location = new Point(6, 83);
        lbl_AvatarFront_Z.Name = "lbl_AvatarFront_Z";
        lbl_AvatarFront_Z.Size = new Size(17, 15);
        lbl_AvatarFront_Z.TabIndex = 5;
        lbl_AvatarFront_Z.Text = "Z:";
        // 
        // tb_AvatarFront_Z
        // 
        tb_AvatarFront_Z.Location = new Point(29, 80);
        tb_AvatarFront_Z.Name = "tb_AvatarFront_Z";
        tb_AvatarFront_Z.Size = new Size(213, 23);
        tb_AvatarFront_Z.TabIndex = 4;
        tb_AvatarFront_Z.Text = "0";
        // 
        // lbl_AvatarFront_Y
        // 
        lbl_AvatarFront_Y.AutoSize = true;
        lbl_AvatarFront_Y.Location = new Point(6, 54);
        lbl_AvatarFront_Y.Name = "lbl_AvatarFront_Y";
        lbl_AvatarFront_Y.Size = new Size(17, 15);
        lbl_AvatarFront_Y.TabIndex = 3;
        lbl_AvatarFront_Y.Text = "Y:";
        // 
        // tb_AvatarFront_Y
        // 
        tb_AvatarFront_Y.Location = new Point(29, 51);
        tb_AvatarFront_Y.Name = "tb_AvatarFront_Y";
        tb_AvatarFront_Y.Size = new Size(213, 23);
        tb_AvatarFront_Y.TabIndex = 2;
        tb_AvatarFront_Y.Text = "0";
        // 
        // lbl_AvatarFront_X
        // 
        lbl_AvatarFront_X.AutoSize = true;
        lbl_AvatarFront_X.Location = new Point(6, 25);
        lbl_AvatarFront_X.Name = "lbl_AvatarFront_X";
        lbl_AvatarFront_X.Size = new Size(17, 15);
        lbl_AvatarFront_X.TabIndex = 1;
        lbl_AvatarFront_X.Text = "X:";
        // 
        // tb_AvatarFront_X
        // 
        tb_AvatarFront_X.Location = new Point(29, 22);
        tb_AvatarFront_X.Name = "tb_AvatarFront_X";
        tb_AvatarFront_X.Size = new Size(213, 23);
        tb_AvatarFront_X.TabIndex = 0;
        tb_AvatarFront_X.Text = "0";
        // 
        // gb_CameraFront
        // 
        gb_CameraFront.Controls.Add(lbl_CameraFront_Z);
        gb_CameraFront.Controls.Add(tb_CameraFront_Z);
        gb_CameraFront.Controls.Add(lbl_CameraFront_Y);
        gb_CameraFront.Controls.Add(tb_CameraFront_Y);
        gb_CameraFront.Controls.Add(lbl_CameraFront_X);
        gb_CameraFront.Controls.Add(tb_CameraFront_X);
        gb_CameraFront.Location = new Point(774, 12);
        gb_CameraFront.Name = "gb_CameraFront";
        gb_CameraFront.Size = new Size(248, 112);
        gb_CameraFront.TabIndex = 8;
        gb_CameraFront.TabStop = false;
        gb_CameraFront.Text = "Camera Front";
        // 
        // lbl_CameraFront_Z
        // 
        lbl_CameraFront_Z.AutoSize = true;
        lbl_CameraFront_Z.Location = new Point(6, 83);
        lbl_CameraFront_Z.Name = "lbl_CameraFront_Z";
        lbl_CameraFront_Z.Size = new Size(17, 15);
        lbl_CameraFront_Z.TabIndex = 5;
        lbl_CameraFront_Z.Text = "Z:";
        // 
        // tb_CameraFront_Z
        // 
        tb_CameraFront_Z.Location = new Point(29, 80);
        tb_CameraFront_Z.Name = "tb_CameraFront_Z";
        tb_CameraFront_Z.Size = new Size(213, 23);
        tb_CameraFront_Z.TabIndex = 4;
        tb_CameraFront_Z.Text = "0";
        // 
        // lbl_CameraFront_Y
        // 
        lbl_CameraFront_Y.AutoSize = true;
        lbl_CameraFront_Y.Location = new Point(6, 54);
        lbl_CameraFront_Y.Name = "lbl_CameraFront_Y";
        lbl_CameraFront_Y.Size = new Size(17, 15);
        lbl_CameraFront_Y.TabIndex = 3;
        lbl_CameraFront_Y.Text = "Y:";
        // 
        // tb_CameraFront_Y
        // 
        tb_CameraFront_Y.Location = new Point(29, 51);
        tb_CameraFront_Y.Name = "tb_CameraFront_Y";
        tb_CameraFront_Y.Size = new Size(213, 23);
        tb_CameraFront_Y.TabIndex = 2;
        tb_CameraFront_Y.Text = "0";
        // 
        // lbl_CameraFront_X
        // 
        lbl_CameraFront_X.AutoSize = true;
        lbl_CameraFront_X.Location = new Point(6, 25);
        lbl_CameraFront_X.Name = "lbl_CameraFront_X";
        lbl_CameraFront_X.Size = new Size(17, 15);
        lbl_CameraFront_X.TabIndex = 1;
        lbl_CameraFront_X.Text = "X:";
        // 
        // tb_CameraFront_X
        // 
        tb_CameraFront_X.Location = new Point(29, 22);
        tb_CameraFront_X.Name = "tb_CameraFront_X";
        tb_CameraFront_X.Size = new Size(213, 23);
        tb_CameraFront_X.TabIndex = 0;
        tb_CameraFront_X.Text = "0";
        // 
        // gb_CameraPosition
        // 
        gb_CameraPosition.Controls.Add(lbl_CameraPosition_Z);
        gb_CameraPosition.Controls.Add(tb_CameraPosition_Z);
        gb_CameraPosition.Controls.Add(lbl_CameraPosition_Y);
        gb_CameraPosition.Controls.Add(tb_CameraPosition_Y);
        gb_CameraPosition.Controls.Add(lbl_CameraPosition_X);
        gb_CameraPosition.Controls.Add(tb_CameraPosition_X);
        gb_CameraPosition.Location = new Point(520, 12);
        gb_CameraPosition.Name = "gb_CameraPosition";
        gb_CameraPosition.Size = new Size(248, 112);
        gb_CameraPosition.TabIndex = 7;
        gb_CameraPosition.TabStop = false;
        gb_CameraPosition.Text = "Camera Position";
        // 
        // lbl_CameraPosition_Z
        // 
        lbl_CameraPosition_Z.AutoSize = true;
        lbl_CameraPosition_Z.Location = new Point(6, 83);
        lbl_CameraPosition_Z.Name = "lbl_CameraPosition_Z";
        lbl_CameraPosition_Z.Size = new Size(17, 15);
        lbl_CameraPosition_Z.TabIndex = 5;
        lbl_CameraPosition_Z.Text = "Z:";
        // 
        // tb_CameraPosition_Z
        // 
        tb_CameraPosition_Z.Location = new Point(29, 80);
        tb_CameraPosition_Z.Name = "tb_CameraPosition_Z";
        tb_CameraPosition_Z.Size = new Size(213, 23);
        tb_CameraPosition_Z.TabIndex = 4;
        tb_CameraPosition_Z.Text = "0";
        // 
        // lbl_CameraPosition_Y
        // 
        lbl_CameraPosition_Y.AutoSize = true;
        lbl_CameraPosition_Y.Location = new Point(6, 54);
        lbl_CameraPosition_Y.Name = "lbl_CameraPosition_Y";
        lbl_CameraPosition_Y.Size = new Size(17, 15);
        lbl_CameraPosition_Y.TabIndex = 3;
        lbl_CameraPosition_Y.Text = "Y:";
        // 
        // tb_CameraPosition_Y
        // 
        tb_CameraPosition_Y.Location = new Point(29, 51);
        tb_CameraPosition_Y.Name = "tb_CameraPosition_Y";
        tb_CameraPosition_Y.Size = new Size(213, 23);
        tb_CameraPosition_Y.TabIndex = 2;
        tb_CameraPosition_Y.Text = "0";
        // 
        // lbl_CameraPosition_X
        // 
        lbl_CameraPosition_X.AutoSize = true;
        lbl_CameraPosition_X.Location = new Point(6, 25);
        lbl_CameraPosition_X.Name = "lbl_CameraPosition_X";
        lbl_CameraPosition_X.Size = new Size(17, 15);
        lbl_CameraPosition_X.TabIndex = 1;
        lbl_CameraPosition_X.Text = "X:";
        // 
        // tb_CameraPosition_X
        // 
        tb_CameraPosition_X.Location = new Point(29, 22);
        tb_CameraPosition_X.Name = "tb_CameraPosition_X";
        tb_CameraPosition_X.Size = new Size(213, 23);
        tb_CameraPosition_X.TabIndex = 0;
        tb_CameraPosition_X.Text = "0";
        // 
        // gb_Identity
        // 
        gb_Identity.Controls.Add(cb_Identity_IsCommander);
        gb_Identity.Controls.Add(cb_Identity_Mount);
        gb_Identity.Controls.Add(lbl_Identity_Mount);
        gb_Identity.Controls.Add(cb_Identity_Spec);
        gb_Identity.Controls.Add(cb_Identity_Profession);
        gb_Identity.Controls.Add(cb_Identity_Race);
        gb_Identity.Controls.Add(lbl_Identity_Spec);
        gb_Identity.Controls.Add(lbl_Identity_Profession);
        gb_Identity.Controls.Add(lbl_Identity_Race);
        gb_Identity.Controls.Add(lbl_Identity_Name);
        gb_Identity.Controls.Add(tb_Identity_Name);
        gb_Identity.Location = new Point(12, 130);
        gb_Identity.Name = "gb_Identity";
        gb_Identity.Size = new Size(502, 190);
        gb_Identity.TabIndex = 6;
        gb_Identity.TabStop = false;
        gb_Identity.Text = "Identity";
        // 
        // cb_Identity_IsCommander
        // 
        cb_Identity_IsCommander.AutoSize = true;
        cb_Identity_IsCommander.Location = new Point(6, 167);
        cb_Identity_IsCommander.Name = "cb_Identity_IsCommander";
        cb_Identity_IsCommander.Size = new Size(104, 19);
        cb_Identity_IsCommander.TabIndex = 23;
        cb_Identity_IsCommander.Text = "Is Commander";
        cb_Identity_IsCommander.UseVisualStyleBackColor = true;
        // 
        // cb_Identity_Mount
        // 
        cb_Identity_Mount.DropDownStyle = ComboBoxStyle.DropDownList;
        cb_Identity_Mount.FormattingEnabled = true;
        cb_Identity_Mount.Location = new Point(77, 138);
        cb_Identity_Mount.Name = "cb_Identity_Mount";
        cb_Identity_Mount.Size = new Size(419, 23);
        cb_Identity_Mount.TabIndex = 12;
        // 
        // lbl_Identity_Mount
        // 
        lbl_Identity_Mount.AutoSize = true;
        lbl_Identity_Mount.Location = new Point(6, 141);
        lbl_Identity_Mount.Name = "lbl_Identity_Mount";
        lbl_Identity_Mount.Size = new Size(46, 15);
        lbl_Identity_Mount.TabIndex = 11;
        lbl_Identity_Mount.Text = "Mount:";
        // 
        // cb_Identity_Spec
        // 
        cb_Identity_Spec.DropDownStyle = ComboBoxStyle.DropDownList;
        cb_Identity_Spec.FormattingEnabled = true;
        cb_Identity_Spec.Location = new Point(77, 109);
        cb_Identity_Spec.Name = "cb_Identity_Spec";
        cb_Identity_Spec.Size = new Size(419, 23);
        cb_Identity_Spec.TabIndex = 10;
        // 
        // cb_Identity_Profession
        // 
        cb_Identity_Profession.DropDownStyle = ComboBoxStyle.DropDownList;
        cb_Identity_Profession.FormattingEnabled = true;
        cb_Identity_Profession.Location = new Point(77, 80);
        cb_Identity_Profession.Name = "cb_Identity_Profession";
        cb_Identity_Profession.Size = new Size(419, 23);
        cb_Identity_Profession.TabIndex = 9;
        // 
        // cb_Identity_Race
        // 
        cb_Identity_Race.DropDownStyle = ComboBoxStyle.DropDownList;
        cb_Identity_Race.FormattingEnabled = true;
        cb_Identity_Race.Location = new Point(77, 51);
        cb_Identity_Race.Name = "cb_Identity_Race";
        cb_Identity_Race.Size = new Size(419, 23);
        cb_Identity_Race.TabIndex = 8;
        // 
        // lbl_Identity_Spec
        // 
        lbl_Identity_Spec.AutoSize = true;
        lbl_Identity_Spec.Location = new Point(6, 112);
        lbl_Identity_Spec.Name = "lbl_Identity_Spec";
        lbl_Identity_Spec.Size = new Size(35, 15);
        lbl_Identity_Spec.TabIndex = 7;
        lbl_Identity_Spec.Text = "Spec:";
        // 
        // lbl_Identity_Profession
        // 
        lbl_Identity_Profession.AutoSize = true;
        lbl_Identity_Profession.Location = new Point(6, 83);
        lbl_Identity_Profession.Name = "lbl_Identity_Profession";
        lbl_Identity_Profession.Size = new Size(65, 15);
        lbl_Identity_Profession.TabIndex = 5;
        lbl_Identity_Profession.Text = "Profession:";
        // 
        // lbl_Identity_Race
        // 
        lbl_Identity_Race.AutoSize = true;
        lbl_Identity_Race.Location = new Point(6, 54);
        lbl_Identity_Race.Name = "lbl_Identity_Race";
        lbl_Identity_Race.Size = new Size(35, 15);
        lbl_Identity_Race.TabIndex = 3;
        lbl_Identity_Race.Text = "Race:";
        // 
        // lbl_Identity_Name
        // 
        lbl_Identity_Name.AutoSize = true;
        lbl_Identity_Name.Location = new Point(6, 25);
        lbl_Identity_Name.Name = "lbl_Identity_Name";
        lbl_Identity_Name.Size = new Size(42, 15);
        lbl_Identity_Name.TabIndex = 1;
        lbl_Identity_Name.Text = "Name:";
        // 
        // tb_Identity_Name
        // 
        tb_Identity_Name.Location = new Point(77, 22);
        tb_Identity_Name.Name = "tb_Identity_Name";
        tb_Identity_Name.Size = new Size(419, 23);
        tb_Identity_Name.TabIndex = 0;
        // 
        // gb_Status
        // 
        gb_Status.Controls.Add(btn_Start);
        gb_Status.Controls.Add(btn_Stop);
        gb_Status.Controls.Add(cb_Log_LogMumbleUpdated);
        gb_Status.Controls.Add(rtb_Log);
        gb_Status.Dock = DockStyle.Bottom;
        gb_Status.Location = new Point(0, 574);
        gb_Status.Name = "gb_Status";
        gb_Status.Size = new Size(1034, 157);
        gb_Status.TabIndex = 7;
        gb_Status.TabStop = false;
        gb_Status.Text = "Status";
        // 
        // btn_Start
        // 
        btn_Start.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btn_Start.Location = new Point(872, 18);
        btn_Start.Name = "btn_Start";
        btn_Start.Size = new Size(75, 23);
        btn_Start.TabIndex = 3;
        btn_Start.Text = "Start";
        btn_Start.UseVisualStyleBackColor = true;
        btn_Start.Click += this.btn_Start_Click;
        // 
        // btn_Stop
        // 
        btn_Stop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btn_Stop.Enabled = false;
        btn_Stop.Location = new Point(953, 18);
        btn_Stop.Name = "btn_Stop";
        btn_Stop.Size = new Size(75, 23);
        btn_Stop.TabIndex = 2;
        btn_Stop.Text = "Stop";
        btn_Stop.UseVisualStyleBackColor = true;
        btn_Stop.Click += this.btn_Stop_Click;
        // 
        // cb_Log_LogMumbleUpdated
        // 
        cb_Log_LogMumbleUpdated.AutoSize = true;
        cb_Log_LogMumbleUpdated.Location = new Point(6, 22);
        cb_Log_LogMumbleUpdated.Name = "cb_Log_LogMumbleUpdated";
        cb_Log_LogMumbleUpdated.Size = new Size(188, 19);
        cb_Log_LogMumbleUpdated.TabIndex = 1;
        cb_Log_LogMumbleUpdated.Text = "Log sucessfull mumble update";
        cb_Log_LogMumbleUpdated.UseVisualStyleBackColor = true;
        // 
        // rtb_Log
        // 
        rtb_Log.Dock = DockStyle.Bottom;
        rtb_Log.Location = new Point(3, 47);
        rtb_Log.Name = "rtb_Log";
        rtb_Log.ReadOnly = true;
        rtb_Log.Size = new Size(1028, 107);
        rtb_Log.TabIndex = 0;
        rtb_Log.Text = "";
        // 
        // gb_MapAndWorld
        // 
        gb_MapAndWorld.Controls.Add(lbl_Map_Scale);
        gb_MapAndWorld.Controls.Add(tb_Map_Scale);
        gb_MapAndWorld.Controls.Add(lbl_Map_CenterY);
        gb_MapAndWorld.Controls.Add(tb_Map_CenterY);
        gb_MapAndWorld.Controls.Add(lbl_Map_CenterX);
        gb_MapAndWorld.Controls.Add(tb_Map_CenterX);
        gb_MapAndWorld.Controls.Add(lbl_Map_PlayerY);
        gb_MapAndWorld.Controls.Add(cb_World_ID);
        gb_MapAndWorld.Controls.Add(tb_Map_PlayerY);
        gb_MapAndWorld.Controls.Add(lbl_World_Id);
        gb_MapAndWorld.Controls.Add(lbl_Map_PlayerX);
        gb_MapAndWorld.Controls.Add(cb_Map_ID);
        gb_MapAndWorld.Controls.Add(tb_Map_PlayerX);
        gb_MapAndWorld.Controls.Add(cb_Map_Type);
        gb_MapAndWorld.Controls.Add(lbl_Map_Type);
        gb_MapAndWorld.Controls.Add(lbl_Map_ID);
        gb_MapAndWorld.Location = new Point(520, 130);
        gb_MapAndWorld.Name = "gb_MapAndWorld";
        gb_MapAndWorld.Size = new Size(502, 265);
        gb_MapAndWorld.TabIndex = 11;
        gb_MapAndWorld.TabStop = false;
        gb_MapAndWorld.Text = "Map / World";
        // 
        // lbl_Map_Scale
        // 
        lbl_Map_Scale.AutoSize = true;
        lbl_Map_Scale.Location = new Point(6, 228);
        lbl_Map_Scale.Name = "lbl_Map_Scale";
        lbl_Map_Scale.Size = new Size(64, 15);
        lbl_Map_Scale.TabIndex = 19;
        lbl_Map_Scale.Text = "Map Scale:";
        // 
        // tb_Map_Scale
        // 
        tb_Map_Scale.Location = new Point(94, 225);
        tb_Map_Scale.Name = "tb_Map_Scale";
        tb_Map_Scale.Size = new Size(402, 23);
        tb_Map_Scale.TabIndex = 18;
        tb_Map_Scale.Text = "0";
        // 
        // lbl_Map_CenterY
        // 
        lbl_Map_CenterY.AutoSize = true;
        lbl_Map_CenterY.Location = new Point(6, 199);
        lbl_Map_CenterY.Name = "lbl_Map_CenterY";
        lbl_Map_CenterY.Size = new Size(82, 15);
        lbl_Map_CenterY.TabIndex = 17;
        lbl_Map_CenterY.Text = "Map Center Y:";
        // 
        // tb_Map_CenterY
        // 
        tb_Map_CenterY.Location = new Point(94, 196);
        tb_Map_CenterY.Name = "tb_Map_CenterY";
        tb_Map_CenterY.Size = new Size(402, 23);
        tb_Map_CenterY.TabIndex = 16;
        tb_Map_CenterY.Text = "0";
        // 
        // lbl_Map_CenterX
        // 
        lbl_Map_CenterX.AutoSize = true;
        lbl_Map_CenterX.Location = new Point(6, 170);
        lbl_Map_CenterX.Name = "lbl_Map_CenterX";
        lbl_Map_CenterX.Size = new Size(82, 15);
        lbl_Map_CenterX.TabIndex = 15;
        lbl_Map_CenterX.Text = "Map Center X:";
        // 
        // tb_Map_CenterX
        // 
        tb_Map_CenterX.Location = new Point(94, 167);
        tb_Map_CenterX.Name = "tb_Map_CenterX";
        tb_Map_CenterX.Size = new Size(402, 23);
        tb_Map_CenterX.TabIndex = 14;
        tb_Map_CenterX.Text = "0";
        // 
        // lbl_Map_PlayerY
        // 
        lbl_Map_PlayerY.AutoSize = true;
        lbl_Map_PlayerY.Location = new Point(6, 141);
        lbl_Map_PlayerY.Name = "lbl_Map_PlayerY";
        lbl_Map_PlayerY.Size = new Size(52, 15);
        lbl_Map_PlayerY.TabIndex = 9;
        lbl_Map_PlayerY.Text = "Player Y:";
        // 
        // cb_World_ID
        // 
        cb_World_ID.DropDownStyle = ComboBoxStyle.DropDownList;
        cb_World_ID.FormattingEnabled = true;
        cb_World_ID.Items.AddRange(new object[] { "" });
        cb_World_ID.Location = new Point(94, 80);
        cb_World_ID.Name = "cb_World_ID";
        cb_World_ID.Size = new Size(402, 23);
        cb_World_ID.TabIndex = 13;
        // 
        // tb_Map_PlayerY
        // 
        tb_Map_PlayerY.Location = new Point(94, 138);
        tb_Map_PlayerY.Name = "tb_Map_PlayerY";
        tb_Map_PlayerY.Size = new Size(402, 23);
        tb_Map_PlayerY.TabIndex = 8;
        tb_Map_PlayerY.Text = "0";
        // 
        // lbl_World_Id
        // 
        lbl_World_Id.AutoSize = true;
        lbl_World_Id.Location = new Point(6, 83);
        lbl_World_Id.Name = "lbl_World_Id";
        lbl_World_Id.Size = new Size(56, 15);
        lbl_World_Id.TabIndex = 10;
        lbl_World_Id.Text = "World ID:";
        // 
        // lbl_Map_PlayerX
        // 
        lbl_Map_PlayerX.AutoSize = true;
        lbl_Map_PlayerX.Location = new Point(6, 112);
        lbl_Map_PlayerX.Name = "lbl_Map_PlayerX";
        lbl_Map_PlayerX.Size = new Size(52, 15);
        lbl_Map_PlayerX.TabIndex = 7;
        lbl_Map_PlayerX.Text = "Player X:";
        // 
        // cb_Map_ID
        // 
        cb_Map_ID.DropDownStyle = ComboBoxStyle.DropDownList;
        cb_Map_ID.FormattingEnabled = true;
        cb_Map_ID.Items.AddRange(new object[] { "" });
        cb_Map_ID.Location = new Point(94, 22);
        cb_Map_ID.Name = "cb_Map_ID";
        cb_Map_ID.Size = new Size(402, 23);
        cb_Map_ID.TabIndex = 9;
        // 
        // tb_Map_PlayerX
        // 
        tb_Map_PlayerX.Location = new Point(94, 109);
        tb_Map_PlayerX.Name = "tb_Map_PlayerX";
        tb_Map_PlayerX.Size = new Size(402, 23);
        tb_Map_PlayerX.TabIndex = 6;
        tb_Map_PlayerX.Text = "0";
        // 
        // cb_Map_Type
        // 
        cb_Map_Type.DropDownStyle = ComboBoxStyle.DropDownList;
        cb_Map_Type.FormattingEnabled = true;
        cb_Map_Type.Items.AddRange(new object[] { "" });
        cb_Map_Type.Location = new Point(94, 51);
        cb_Map_Type.Name = "cb_Map_Type";
        cb_Map_Type.Size = new Size(402, 23);
        cb_Map_Type.TabIndex = 8;
        // 
        // lbl_Map_Type
        // 
        lbl_Map_Type.AutoSize = true;
        lbl_Map_Type.Location = new Point(6, 54);
        lbl_Map_Type.Name = "lbl_Map_Type";
        lbl_Map_Type.Size = new Size(61, 15);
        lbl_Map_Type.TabIndex = 3;
        lbl_Map_Type.Text = "Map Type:";
        // 
        // lbl_Map_ID
        // 
        lbl_Map_ID.AutoSize = true;
        lbl_Map_ID.Location = new Point(6, 25);
        lbl_Map_ID.Name = "lbl_Map_ID";
        lbl_Map_ID.Size = new Size(48, 15);
        lbl_Map_ID.TabIndex = 1;
        lbl_Map_ID.Text = "Map ID:";
        // 
        // gb_Game
        // 
        gb_Game.Controls.Add(btn_Game_SelectProcess);
        gb_Game.Controls.Add(lbl_Game_ProcessId_Value);
        gb_Game.Controls.Add(tb_Game_BuildId);
        gb_Game.Controls.Add(lbl_Game_ProcessId);
        gb_Game.Controls.Add(lbl_Game_BuildId);
        gb_Game.Location = new Point(520, 401);
        gb_Game.Name = "gb_Game";
        gb_Game.Size = new Size(502, 83);
        gb_Game.TabIndex = 14;
        gb_Game.TabStop = false;
        gb_Game.Text = "Game";
        // 
        // btn_Game_SelectProcess
        // 
        btn_Game_SelectProcess.Location = new Point(421, 51);
        btn_Game_SelectProcess.Name = "btn_Game_SelectProcess";
        btn_Game_SelectProcess.Size = new Size(75, 23);
        btn_Game_SelectProcess.TabIndex = 15;
        btn_Game_SelectProcess.Text = "Select";
        btn_Game_SelectProcess.UseVisualStyleBackColor = true;
        btn_Game_SelectProcess.Click += this.btn_Game_SelectProcess_Click;
        // 
        // lbl_Game_ProcessId_Value
        // 
        lbl_Game_ProcessId_Value.AutoSize = true;
        lbl_Game_ProcessId_Value.Location = new Point(76, 54);
        lbl_Game_ProcessId_Value.Name = "lbl_Game_ProcessId_Value";
        lbl_Game_ProcessId_Value.Size = new Size(0, 15);
        lbl_Game_ProcessId_Value.TabIndex = 14;
        // 
        // tb_Game_BuildId
        // 
        tb_Game_BuildId.Location = new Point(77, 22);
        tb_Game_BuildId.Name = "tb_Game_BuildId";
        tb_Game_BuildId.Size = new Size(419, 23);
        tb_Game_BuildId.TabIndex = 11;
        // 
        // lbl_Game_ProcessId
        // 
        lbl_Game_ProcessId.AutoSize = true;
        lbl_Game_ProcessId.Location = new Point(6, 54);
        lbl_Game_ProcessId.Name = "lbl_Game_ProcessId";
        lbl_Game_ProcessId.Size = new Size(64, 15);
        lbl_Game_ProcessId.TabIndex = 3;
        lbl_Game_ProcessId.Text = "Process ID:";
        // 
        // lbl_Game_BuildId
        // 
        lbl_Game_BuildId.AutoSize = true;
        lbl_Game_BuildId.Location = new Point(6, 25);
        lbl_Game_BuildId.Name = "lbl_Game_BuildId";
        lbl_Game_BuildId.Size = new Size(51, 15);
        lbl_Game_BuildId.TabIndex = 1;
        lbl_Game_BuildId.Text = "Build ID:";
        // 
        // gb_UI
        // 
        gb_UI.Controls.Add(lbl_UI_CompassRotation);
        gb_UI.Controls.Add(tb_UI_CompassRotation);
        gb_UI.Controls.Add(lbl_UI_CompassHeight);
        gb_UI.Controls.Add(cb_UI_Scale);
        gb_UI.Controls.Add(tb_UI_CompassHeight);
        gb_UI.Controls.Add(lbl_UI_Scale);
        gb_UI.Controls.Add(lbl_UI_CompassWidth);
        gb_UI.Controls.Add(tb_UI_CompassWidth);
        gb_UI.Controls.Add(lbl_UI_FOV);
        gb_UI.Controls.Add(cb_UI_IsInCombat);
        gb_UI.Controls.Add(tb_UI_FOV);
        gb_UI.Controls.Add(cb_UI_IsCompetitiveMode);
        gb_UI.Controls.Add(cb_UI_DoesAnyInputHaveFocus);
        gb_UI.Controls.Add(cb_UI_DoesGameHaveFocus);
        gb_UI.Controls.Add(cb_UI_IsCompassTopRight);
        gb_UI.Controls.Add(cb_UI_IsCompassRotationEnabled);
        gb_UI.Controls.Add(cb_UI_IsMapOpen);
        gb_UI.Location = new Point(12, 326);
        gb_UI.Name = "gb_UI";
        gb_UI.Size = new Size(502, 245);
        gb_UI.TabIndex = 16;
        gb_UI.TabStop = false;
        gb_UI.Text = "UI";
        // 
        // lbl_UI_CompassRotation
        // 
        lbl_UI_CompassRotation.AutoSize = true;
        lbl_UI_CompassRotation.Location = new Point(6, 216);
        lbl_UI_CompassRotation.Name = "lbl_UI_CompassRotation";
        lbl_UI_CompassRotation.Size = new Size(107, 15);
        lbl_UI_CompassRotation.TabIndex = 25;
        lbl_UI_CompassRotation.Text = "Compass Rotation:";
        // 
        // tb_UI_CompassRotation
        // 
        tb_UI_CompassRotation.Location = new Point(119, 213);
        tb_UI_CompassRotation.Name = "tb_UI_CompassRotation";
        tb_UI_CompassRotation.Size = new Size(377, 23);
        tb_UI_CompassRotation.TabIndex = 24;
        tb_UI_CompassRotation.Text = "0";
        // 
        // lbl_UI_CompassHeight
        // 
        lbl_UI_CompassHeight.AutoSize = true;
        lbl_UI_CompassHeight.Location = new Point(6, 187);
        lbl_UI_CompassHeight.Name = "lbl_UI_CompassHeight";
        lbl_UI_CompassHeight.Size = new Size(98, 15);
        lbl_UI_CompassHeight.TabIndex = 23;
        lbl_UI_CompassHeight.Text = "Compass Height:";
        // 
        // cb_UI_Scale
        // 
        cb_UI_Scale.DropDownStyle = ComboBoxStyle.DropDownList;
        cb_UI_Scale.FormattingEnabled = true;
        cb_UI_Scale.Items.AddRange(new object[] { "Small", "Normal", "Large", "Larger" });
        cb_UI_Scale.Location = new Point(119, 126);
        cb_UI_Scale.Name = "cb_UI_Scale";
        cb_UI_Scale.Size = new Size(377, 23);
        cb_UI_Scale.TabIndex = 15;
        // 
        // tb_UI_CompassHeight
        // 
        tb_UI_CompassHeight.Location = new Point(119, 184);
        tb_UI_CompassHeight.Name = "tb_UI_CompassHeight";
        tb_UI_CompassHeight.Size = new Size(377, 23);
        tb_UI_CompassHeight.TabIndex = 22;
        tb_UI_CompassHeight.Text = "0";
        // 
        // lbl_UI_Scale
        // 
        lbl_UI_Scale.AutoSize = true;
        lbl_UI_Scale.Location = new Point(6, 129);
        lbl_UI_Scale.Name = "lbl_UI_Scale";
        lbl_UI_Scale.Size = new Size(44, 15);
        lbl_UI_Scale.TabIndex = 14;
        lbl_UI_Scale.Text = "UI Size:";
        // 
        // lbl_UI_CompassWidth
        // 
        lbl_UI_CompassWidth.AutoSize = true;
        lbl_UI_CompassWidth.Location = new Point(6, 158);
        lbl_UI_CompassWidth.Name = "lbl_UI_CompassWidth";
        lbl_UI_CompassWidth.Size = new Size(94, 15);
        lbl_UI_CompassWidth.TabIndex = 21;
        lbl_UI_CompassWidth.Text = "Compass Width:";
        // 
        // tb_UI_CompassWidth
        // 
        tb_UI_CompassWidth.Location = new Point(119, 155);
        tb_UI_CompassWidth.Name = "tb_UI_CompassWidth";
        tb_UI_CompassWidth.Size = new Size(377, 23);
        tb_UI_CompassWidth.TabIndex = 20;
        tb_UI_CompassWidth.Text = "0";
        // 
        // lbl_UI_FOV
        // 
        lbl_UI_FOV.AutoSize = true;
        lbl_UI_FOV.Location = new Point(6, 100);
        lbl_UI_FOV.Name = "lbl_UI_FOV";
        lbl_UI_FOV.Size = new Size(77, 15);
        lbl_UI_FOV.TabIndex = 7;
        lbl_UI_FOV.Text = "Field of View:";
        // 
        // cb_UI_IsInCombat
        // 
        cb_UI_IsInCombat.AutoSize = true;
        cb_UI_IsInCombat.Location = new Point(6, 72);
        cb_UI_IsInCombat.Name = "cb_UI_IsInCombat";
        cb_UI_IsInCombat.Size = new Size(93, 19);
        cb_UI_IsInCombat.TabIndex = 22;
        cb_UI_IsInCombat.Text = "Is In Combat";
        cb_UI_IsInCombat.UseVisualStyleBackColor = true;
        // 
        // tb_UI_FOV
        // 
        tb_UI_FOV.Location = new Point(119, 97);
        tb_UI_FOV.Name = "tb_UI_FOV";
        tb_UI_FOV.Size = new Size(377, 23);
        tb_UI_FOV.TabIndex = 6;
        tb_UI_FOV.Text = "0.873";
        // 
        // cb_UI_IsCompetitiveMode
        // 
        cb_UI_IsCompetitiveMode.AutoSize = true;
        cb_UI_IsCompetitiveMode.Location = new Point(162, 47);
        cb_UI_IsCompetitiveMode.Name = "cb_UI_IsCompetitiveMode";
        cb_UI_IsCompetitiveMode.Size = new Size(136, 19);
        cb_UI_IsCompetitiveMode.TabIndex = 21;
        cb_UI_IsCompetitiveMode.Text = "Is Competitive Mode";
        cb_UI_IsCompetitiveMode.UseVisualStyleBackColor = true;
        // 
        // cb_UI_DoesAnyInputHaveFocus
        // 
        cb_UI_DoesAnyInputHaveFocus.AutoSize = true;
        cb_UI_DoesAnyInputHaveFocus.Location = new Point(304, 47);
        cb_UI_DoesAnyInputHaveFocus.Name = "cb_UI_DoesAnyInputHaveFocus";
        cb_UI_DoesAnyInputHaveFocus.Size = new Size(171, 19);
        cb_UI_DoesAnyInputHaveFocus.TabIndex = 20;
        cb_UI_DoesAnyInputHaveFocus.Text = "Does Any Input Have Focus";
        cb_UI_DoesAnyInputHaveFocus.UseVisualStyleBackColor = true;
        // 
        // cb_UI_DoesGameHaveFocus
        // 
        cb_UI_DoesGameHaveFocus.AutoSize = true;
        cb_UI_DoesGameHaveFocus.Location = new Point(6, 47);
        cb_UI_DoesGameHaveFocus.Name = "cb_UI_DoesGameHaveFocus";
        cb_UI_DoesGameHaveFocus.Size = new Size(150, 19);
        cb_UI_DoesGameHaveFocus.TabIndex = 19;
        cb_UI_DoesGameHaveFocus.Text = "Does Game Have Focus";
        cb_UI_DoesGameHaveFocus.UseVisualStyleBackColor = true;
        // 
        // cb_UI_IsCompassTopRight
        // 
        cb_UI_IsCompassTopRight.AutoSize = true;
        cb_UI_IsCompassTopRight.Location = new Point(105, 22);
        cb_UI_IsCompassTopRight.Name = "cb_UI_IsCompassTopRight";
        cb_UI_IsCompassTopRight.Size = new Size(139, 19);
        cb_UI_IsCompassTopRight.TabIndex = 18;
        cb_UI_IsCompassTopRight.Text = "Is Compass Top Right";
        cb_UI_IsCompassTopRight.UseVisualStyleBackColor = true;
        // 
        // cb_UI_IsCompassRotationEnabled
        // 
        cb_UI_IsCompassRotationEnabled.AutoSize = true;
        cb_UI_IsCompassRotationEnabled.Location = new Point(250, 22);
        cb_UI_IsCompassRotationEnabled.Name = "cb_UI_IsCompassRotationEnabled";
        cb_UI_IsCompassRotationEnabled.Size = new Size(179, 19);
        cb_UI_IsCompassRotationEnabled.TabIndex = 17;
        cb_UI_IsCompassRotationEnabled.Text = "Is Compass Rotation Enabled";
        cb_UI_IsCompassRotationEnabled.UseVisualStyleBackColor = true;
        cb_UI_IsCompassRotationEnabled.CheckedChanged += this.cb_UI_IsCompassRotationEnabled_CheckedChanged;
        // 
        // cb_UI_IsMapOpen
        // 
        cb_UI_IsMapOpen.AutoSize = true;
        cb_UI_IsMapOpen.Location = new Point(6, 22);
        cb_UI_IsMapOpen.Name = "cb_UI_IsMapOpen";
        cb_UI_IsMapOpen.Size = new Size(93, 19);
        cb_UI_IsMapOpen.TabIndex = 16;
        cb_UI_IsMapOpen.Text = "Is Map Open";
        cb_UI_IsMapOpen.UseVisualStyleBackColor = true;
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1034, 731);
        this.Controls.Add(gb_UI);
        this.Controls.Add(gb_Game);
        this.Controls.Add(gb_MapAndWorld);
        this.Controls.Add(gb_Status);
        this.Controls.Add(gb_Identity);
        this.Controls.Add(gb_CameraFront);
        this.Controls.Add(gb_CameraPosition);
        this.Controls.Add(gb_AvatarFront);
        this.Controls.Add(gb_AvatarPosition);
        this.MinimumSize = new Size(1050, 489);
        this.Name = "MainForm";
        this.Text = "MumbleMock";
        gb_AvatarPosition.ResumeLayout(false);
        gb_AvatarPosition.PerformLayout();
        gb_AvatarFront.ResumeLayout(false);
        gb_AvatarFront.PerformLayout();
        gb_CameraFront.ResumeLayout(false);
        gb_CameraFront.PerformLayout();
        gb_CameraPosition.ResumeLayout(false);
        gb_CameraPosition.PerformLayout();
        gb_Identity.ResumeLayout(false);
        gb_Identity.PerformLayout();
        gb_Status.ResumeLayout(false);
        gb_Status.PerformLayout();
        gb_MapAndWorld.ResumeLayout(false);
        gb_MapAndWorld.PerformLayout();
        gb_Game.ResumeLayout(false);
        gb_Game.PerformLayout();
        gb_UI.ResumeLayout(false);
        gb_UI.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Timer MumbleUpdate_timer;
    private GroupBox gb_AvatarPosition;
    private TextBox tb_AvatarPosition_X;
    private Label lbl_AvatarPosition_X;
    private Label lbl_AvatarPosition_Z;
    private TextBox tb_AvatarPosition_Z;
    private Label lbl_AvatarPosition_Y;
    private TextBox tb_AvatarPosition_Y;
    private GroupBox gb_AvatarFront;
    private Label lbl_AvatarFront_Z;
    private TextBox tb_AvatarFront_Z;
    private Label lbl_AvatarFront_Y;
    private TextBox tb_AvatarFront_Y;
    private Label lbl_AvatarFront_X;
    private TextBox tb_AvatarFront_X;
    private GroupBox gb_Identity;
    private TextBox tb_UI_FOV;
    private Label lbl_World_Id;
    private TextBox tb_Map_PlayerX;
    private Label lbl_Identity_Name;
    private TextBox tb_Identity_Name;
    private GroupBox gb_CameraFront;
    private Label lbl_CameraFront_Z;
    private TextBox tb_CameraFront_Z;
    private Label lbl_CameraFront_Y;
    private TextBox tb_CameraFront_Y;
    private Label lbl_CameraFront_X;
    private TextBox tb_CameraFront_X;
    private GroupBox gb_CameraPosition;
    private Label lbl_CameraPosition_Z;
    private TextBox tb_CameraPosition_Z;
    private Label lbl_CameraPosition_Y;
    private TextBox tb_CameraPosition_Y;
    private Label lbl_CameraPosition_X;
    private TextBox tb_CameraPosition_X;
    private GroupBox gb_Status;
    private RichTextBox rtb_Log;
    private CheckBox cb_Log_LogMumbleUpdated;
    private ComboBox cb_Identity_Race;
    private Label lbl_Identity_Spec;
    private Label lbl_Identity_Profession;
    private Label lbl_Identity_Race;
    private ComboBox cb_Identity_Spec;
    private ComboBox cb_Identity_Profession;
    private Button btn_Start;
    private Button btn_Stop;
    private GroupBox gb_MapAndWorld;
    private ComboBox cb_Map_Type;
    private Label lbl_Map_Type;
    private Label lbl_Map_ID;
    private ComboBox cb_Map_ID;
    private ComboBox cb_World_ID;
    private GroupBox gb_Game;
    private Button btn_Game_SelectProcess;
    private Label lbl_Game_ProcessId_Value;
    private TextBox tb_Game_BuildId;
    private Label lbl_Game_ProcessId;
    private Label lbl_Game_BuildId;
    private ComboBox cb_Identity_Mount;
    private Label lbl_Identity_Mount;
    private GroupBox gb_UI;
    private CheckBox cb_UI_IsMapOpen;
    private CheckBox cb_UI_IsCompassTopRight;
    private CheckBox cb_UI_IsCompassRotationEnabled;
    private CheckBox cb_UI_DoesGameHaveFocus;
    private CheckBox cb_UI_IsCompetitiveMode;
    private CheckBox cb_UI_DoesAnyInputHaveFocus;
    private CheckBox cb_UI_IsInCombat;
    private CheckBox cb_Identity_IsCommander;
    private Label lbl_UI_FOV;
    private ComboBox cb_UI_Scale;
    private Label lbl_UI_Scale;
    private Label lbl_Map_PlayerY;
    private TextBox tb_Map_PlayerY;
    private Label lbl_Map_PlayerX;
    private Label lbl_Map_CenterY;
    private TextBox tb_Map_CenterY;
    private Label lbl_Map_CenterX;
    private TextBox tb_Map_CenterX;
    private Label lbl_Map_Scale;
    private TextBox tb_Map_Scale;
    private Label lbl_UI_CompassRotation;
    private TextBox tb_UI_CompassRotation;
    private Label lbl_UI_CompassHeight;
    private TextBox tb_UI_CompassHeight;
    private Label lbl_UI_CompassWidth;
    private TextBox tb_UI_CompassWidth;
}
