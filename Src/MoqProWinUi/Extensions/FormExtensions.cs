namespace MoqProWinUi.Extensions;

public static class FormExtensions
{
    public static void SetDarkModee(this Form form, bool active)
    {
        if (active)
        {
            // Dark Mode
            form.BackColor = Color.FromArgb(30, 30, 30);
            form.ForeColor = Color.White;
            ApplyThemeToControls(form.Controls, Color.FromArgb(30, 30, 30), Color.White);
        }
        else
        {
            // Light Mode
            form.BackColor = SystemColors.Control;
            form.ForeColor = SystemColors.ControlText;
            ApplyThemeToControls(form.Controls, SystemColors.Control, SystemColors.ControlText);
        }
    }


    private static void ApplyThemeToControls(Control.ControlCollection controls, Color backColor, Color foreColor)
    {
        foreach (Control ctrl in controls)
        {
            if (ctrl is TextBox || ctrl is RichTextBox)
            {
                ctrl.BackColor = (backColor == SystemColors.Control) ? Color.White : Color.FromArgb(50, 50, 50);
                ctrl.ForeColor = foreColor;
            }
            else if (ctrl is DataGridView dgv)
            {
                dgv.BackgroundColor = backColor;
                dgv.DefaultCellStyle.BackColor = (backColor == SystemColors.Control) ? Color.White : Color.FromArgb(50, 50, 50);
                dgv.DefaultCellStyle.ForeColor = foreColor;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = backColor;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = foreColor;
            }
            else if (ctrl is TabControl tabControl)
            {
                tabControl.BackColor = backColor;
                tabControl.ForeColor = foreColor;

                foreach (TabPage page in tabControl.TabPages)
                {
                    page.BackColor = backColor;
                    page.ForeColor = foreColor;
                    ApplyThemeToControls(page.Controls, backColor, foreColor);
                }
            }
            else
            {
                ctrl.BackColor = backColor;
                ctrl.ForeColor = foreColor;
            }

            if (ctrl.HasChildren)
                ApplyThemeToControls(ctrl.Controls, backColor, foreColor);
        }
    }


}




