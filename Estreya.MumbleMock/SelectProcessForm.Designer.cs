namespace Estreya.MumbleMock;

partial class SelectProcessForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lv_Processes = new ListView();
        name = new ColumnHeader();
        id = new ColumnHeader();
        description = new ColumnHeader();
        btn_OK = new Button();
        btn_Cancel = new Button();
        this.SuspendLayout();
        // 
        // lv_Processes
        // 
        lv_Processes.Columns.AddRange(new ColumnHeader[] { name, id, description });
        lv_Processes.Dock = DockStyle.Top;
        lv_Processes.Location = new Point(0, 0);
        lv_Processes.MultiSelect = false;
        lv_Processes.Name = "lv_Processes";
        lv_Processes.Size = new Size(800, 409);
        lv_Processes.TabIndex = 0;
        lv_Processes.UseCompatibleStateImageBehavior = false;
        lv_Processes.View = View.Details;
        // 
        // name
        // 
        name.Text = "Name";
        // 
        // id
        // 
        id.Text = "ID";
        // 
        // description
        // 
        description.Text = "Description";
        // 
        // btn_OK
        // 
        btn_OK.Location = new Point(713, 415);
        btn_OK.Name = "btn_OK";
        btn_OK.Size = new Size(75, 23);
        btn_OK.TabIndex = 1;
        btn_OK.Text = "OK";
        btn_OK.UseVisualStyleBackColor = true;
        btn_OK.Click += this.btn_OK_Click;
        // 
        // btn_Cancel
        // 
        btn_Cancel.Location = new Point(632, 415);
        btn_Cancel.Name = "btn_Cancel";
        btn_Cancel.Size = new Size(75, 23);
        btn_Cancel.TabIndex = 2;
        btn_Cancel.Text = "Cancel";
        btn_Cancel.UseVisualStyleBackColor = true;
        btn_Cancel.Click += this.btn_Cancel_Click;
        // 
        // SelectProcessForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(btn_Cancel);
        this.Controls.Add(btn_OK);
        this.Controls.Add(lv_Processes);
        this.Name = "SelectProcessForm";
        this.Text = "Select process...";
        this.ResumeLayout(false);
    }

    #endregion

    private ListView lv_Processes;
    private ColumnHeader name;
    private ColumnHeader id;
    private Button btn_OK;
    private Button btn_Cancel;
    private ColumnHeader description;
}