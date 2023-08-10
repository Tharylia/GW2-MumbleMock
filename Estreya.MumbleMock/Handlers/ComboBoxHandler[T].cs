namespace Estreya.MumbleMock.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ComboBoxHandler<T> where T : class
{
    public ComboBoxHandler(ComboBox comboBox)
    {
        this.ComboBox = comboBox;
    }

    public ComboBox ComboBox { get; }

    public T? GetValue(T? defaultValue = default)
    {
        var selectedValue = this.ComboBox.SelectedItem as T;
        return selectedValue ?? defaultValue;
    }

    public string? GetValueAsText(string? defaultValue = default)
    {
        var value = this.GetValue();
        var textValue = value is not null and not default(T) ? value.ToString() : this.ComboBox.Text;
        return (!string.IsNullOrWhiteSpace(textValue) ? textValue : null) ?? defaultValue;
    }

    public void SetValue(T? value)
    {
        if (this.ComboBox.Items.Count > 0)
        {
            this.ComboBox.SelectedValue = value;
        }
        else
        {
            this.ComboBox.Text = value?.ToString();
        }
    }
}
