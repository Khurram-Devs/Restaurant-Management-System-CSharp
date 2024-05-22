using System;
using System.Windows.Forms;

public static class PlaceholderHelper
{
    public static void SetPlaceholder(TextBox textBox, string placeholderText)
    {
        textBox.Text = placeholderText;
        textBox.Tag = placeholderText;
        textBox.ForeColor = System.Drawing.Color.Gray;
        textBox.Enter += TextBox_Enter;
        textBox.Leave += TextBox_Leave;
    }

    private static void TextBox_Enter(object sender, EventArgs e)
    {
        TextBox textBox = (TextBox)sender;
        if (textBox.ForeColor == System.Drawing.Color.Gray)
        {
            textBox.Text = "";
            textBox.ForeColor = System.Drawing.Color.Black;
        }
    }

    private static void TextBox_Leave(object sender, EventArgs e)
    {
        TextBox textBox = (TextBox)sender;
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            textBox.Text = textBox.Tag.ToString();
            textBox.ForeColor = System.Drawing.Color.Gray;
        }
    }
}
