namespace Estreya.MumbleMock;
using System;
using System.Windows.Forms;
//using Windows.Management.Deployment;

public partial class SelectWindowsAppFrom : Form
{
    public SelectWindowsAppFrom()
    {
        this.InitializeComponent();
        this.Load += this.SelectWindowsAppFrom_Load;
    }

    private void SelectWindowsAppFrom_Load(object? sender, EventArgs e)
    {
        //var packages = new PackageManager().FindPackages();
        //foreach (var package in packages)
        //{
        //    this.lb_Apps.Items.Add(package);
        //}
    }

    private void btn_OK_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void btn_Cancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}
