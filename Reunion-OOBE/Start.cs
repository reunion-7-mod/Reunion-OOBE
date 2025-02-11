using System;
using System.Drawing;
using System.Windows.Forms;

namespace Reunion_OOBE
{
    public partial class Start : Form
    {
        private Main mainForm;

        public Start(Main main)
        {
            InitializeComponent();
            mainForm = main;
        } 

        private void Start_Load(object sender, EventArgs e)
        {
            computerNameBox.MaxLength = 15;
            usernameBox.MaxLength = 127;
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            if (usernameBox.Text.Length > 0)
            {
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
            }

            string username = usernameBox.Text.Replace(" ", string.Empty);
            string computerName = username + "-PC";

            if (computerName.Length > 15)
            {
                username = username.Substring(0, 15 - "-PC".Length);
                computerName = username + "-PC";
            }

            if (username.Length == 0)
            {
                computerName = "PC";
            }

            computerNameBox.Text = computerName;
        }

        private void nextButton_Click_1(object sender, EventArgs e)
        {
            Password pwForm = new Password(mainForm);
            mainForm.LoadForm(this, pwForm);
        }
    }
}
