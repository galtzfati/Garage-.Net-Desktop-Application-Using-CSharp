using System.Windows.Forms;

namespace GarageDesktopApplication.Extensions
{
    internal static class ValidationExtensions
    {
        public static bool AllTextBoxesAreFilled(this Control i_Control)
        {
            bool allTextBoxesAreFilled = true;

            foreach (Control control in i_Control.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                {
                    allTextBoxesAreFilled = false;
                    break;
                }

                if (control.HasChildren)
                {
                    if (!control.AllTextBoxesAreFilled())
                    {
                        allTextBoxesAreFilled = false;
                        break;
                    }
                }
            }

            return allTextBoxesAreFilled;
        }
    }
}
