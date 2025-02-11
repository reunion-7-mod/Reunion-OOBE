using System;
using System.Windows.Forms;

namespace Reunion_OOBE
{
    public partial class Password : Form
    {
        private Main mainForm;

        public Password(Main main)
        {
            InitializeComponent();
            mainForm = main;
            mainForm.SetBackButtonState(true);
        }
    }
}
