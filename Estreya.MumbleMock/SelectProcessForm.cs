using System.Diagnostics;

namespace Estreya.MumbleMock;
public partial class SelectProcessForm : Form
{
    public Process? SelectedProcess { get; private set; }

    public SelectProcessForm()
    {
        this.InitializeComponent();
        this.Load += this.SelectProcessForm_Load;
        this.lv_Processes.Sorting = SortOrder.Ascending;
        this.lv_Processes.FullRowSelect = true;
    }

    private void SelectProcessForm_Load(object? sender, EventArgs e)
    {
        foreach (Process process in Process.GetProcesses())
        {
            ListViewItem item = new ListViewItem(process.ProcessName);
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, process.Id.ToString()));
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, this.GetProcessDescription(process)));
            this.lv_Processes.Items.Add(item);
        }

        this.lv_Processes.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        this.lv_Processes.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
        this.lv_Processes.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
    }

    private string? GetProcessDescription(Process process)
    {
        try
        {
            return process.MainModule?.FileVersionInfo.FileDescription;
        }
        catch (Exception)
        {
            return null;
        }
    }

    private void btn_OK_Click(object sender, EventArgs e)
    {
        this.SetProcess();
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void btn_Cancel_Click(object sender, EventArgs e)
    {
        this.SetProcess();
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void SetProcess()
    {
        this.SelectedProcess = this.lv_Processes.SelectedIndices.Count == 0 ? null : Process.GetProcessById(Convert.ToInt32(this.lv_Processes.SelectedItems[0].SubItems[1].Text));
    }
}
