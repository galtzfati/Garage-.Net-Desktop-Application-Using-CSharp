using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GarageDesktopApplication.Proxies
{
    public class RegexTextBox : TextBox
    {
        private Regex m_Regex = null;
        public string RegexPattern
        {
            get 
            { 
                return m_Regex?.ToString(); 
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    m_Regex = null;
                }
                else
                {
                    m_Regex = new Regex(value);
                }
            }
        }
        public RegexTextBox()
        {
            KeyPress += validate;
        }

        private void validate(object sender, KeyPressEventArgs e)
        {
            if (m_Regex != null)
            {
                if (!m_Regex.IsMatch(Text + e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
