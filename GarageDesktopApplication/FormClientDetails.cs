using GarageDesktopApplication.Extensions;
using GarageDesktopApplication.Proxies;
using GarageLogic;
using System;
using System.Windows.Forms;

namespace GarageDesktopApplication
{
    public partial class FormClientDetails : Form
    {
        public Client Client { get; set; }
        public RegexTextBox RegexTextBoxName
        {
            get
            {
                return regexTextBoxName;
            }
        }
        public RegexTextBox RegexTextBoxId
        {
            get
            {
                return regexTextBoxId;
            }
        }
        public RegexTextBox RegexTextBoxPhoneNumber
        {
            get
            {
                return regexTextBoxPhoneNumber;
            }
        }
        public FormClientDetails()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (this.AllTextBoxesAreFilled())
            {
                Client = new Client()
                {
                    Name = regexTextBoxName.Text,
                    Id = regexTextBoxId.Text,
                    PhoneNumber = regexTextBoxPhoneNumber.Text,
                };
                Close();
            }
            else
            {
                MessageBox.Show("All fields must be filled!", "Some Fields Are Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
