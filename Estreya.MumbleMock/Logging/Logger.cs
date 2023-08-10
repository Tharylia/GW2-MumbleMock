namespace Estreya.MumbleMock.Logging;
public class Logger
{
    private readonly RichTextBox _richTextBox;

    public Logger(RichTextBox richTextBox)
    {
        this._richTextBox = richTextBox;
    }

    private string GetTimestamp()
    {
        return DateTime.Now.ToLongTimeString();
    }

    private void Log(string message)
    {
        string timestamp = this.GetTimestamp();

        if (this._richTextBox.TextLength > 0)
        {
            this._richTextBox.AppendText(Environment.NewLine);
        }

        this._richTextBox.AppendText($"{timestamp}: {message}");

        if (this._richTextBox.SelectionStart == this._richTextBox.TextLength)
        {
            this._richTextBox.ScrollToCaret();
        }
    }

    public void Info(string message)
    {
        this.Log($"[INFO] {message}");
    }
    public void Error(string message)
    {
        this.Log($"[ERROR] {message}");
    }
    public void Warn(string message)
    {
        this.Log($"[WARN] {message}");
    }
}
