namespace Estreya.MumbleMock;

partial class SelectWindowsAppFrom
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
        lb_Apps = new ListBox();
        btn_Cancel = new Button();
        btn_OK = new Button();
        this.SuspendLayout();
        // 
        // lb_Apps
        // 
        lb_Apps.Dock = DockStyle.Top;
        lb_Apps.FormattingEnabled = true;
        lb_Apps.ItemHeight = 15;
        lb_Apps.Location = new Point(0, 0);
        lb_Apps.Name = "lb_Apps";
        lb_Apps.Size = new Size(800, 409);
        lb_Apps.TabIndex = 0;
        // 
        // btn_Cancel
        // 
        btn_Cancel.Location = new Point(632, 415);
        btn_Cancel.Name = "btn_Cancel";
        btn_Cancel.Size = new Size(75, 23);
        btn_Cancel.TabIndex = 4;
        btn_Cancel.Text = "Cancel";
        btn_Cancel.UseVisualStyleBackColor = true;
        btn_Cancel.Click += this.btn_Cancel_Click;
        // 
        // btn_OK
        // 
        btn_OK.Location = new Point(713, 415);
        btn_OK.Name = "btn_OK";
        btn_OK.Size = new Size(75, 23);
        btn_OK.TabIndex = 3;
        btn_OK.Text = "OK";
        btn_OK.UseVisualStyleBackColor = true;
        btn_OK.Click += this.btn_OK_Click;
        // 
        // SelectWindowsAppFrom
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(btn_Cancel);
        this.Controls.Add(btn_OK);
        this.Controls.Add(lb_Apps);
        this.Name = "SelectWindowsAppFrom";
        this.Text = "SelectWindowsApp";
        this.ResumeLayout(false);
    }

    #endregion

    private ListBox lb_Apps;
    private Button btn_Cancel;
    private Button btn_OK;
}