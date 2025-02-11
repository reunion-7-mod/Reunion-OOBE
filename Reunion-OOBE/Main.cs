using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Reunion_OOBE
{
    public partial class Main : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        private const int GWL_STYLE = -16;
        private const int WS_SYSMENU = 0x80000;

        private Panel contentPanel;

        public Main()
        {
            InitializeComponent();

            backButton.MouseEnter += BackButton_MouseEnter;
            backButton.MouseLeave += BackButton_MouseLeave;
            backButton.MouseDown += BackButton_MouseDown;
            backButton.MouseUp += BackButton_MouseUp;

            contentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = System.Drawing.Color.White
            };
            this.Controls.Add(contentPanel);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            int style = GetWindowLong(this.Handle, GWL_STYLE);
            SetWindowLong(this.Handle, GWL_STYLE, style & ~WS_SYSMENU);
            LoadForm(this, new Start(this));
        }

        public void LoadForm(Form currentForm, Form nextForm)
        {
            contentPanel.Controls.Clear();

            nextForm.TopLevel = false;
            nextForm.FormBorderStyle = FormBorderStyle.None;
            nextForm.Dock = DockStyle.Fill;

            contentPanel.Controls.Add(nextForm);
            nextForm.Show();
        }


        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            if (backButton.Image == Properties.Resources.backdisabled) return;

            backButton.Image = Properties.Resources.backhover; // Hover image
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            if (backButton.Image == Properties.Resources.backdisabled) return;

            backButton.Image = Properties.Resources.backdefault; // Default image
        }

        private void BackButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (backButton.Image == Properties.Resources.backdisabled) return;

            backButton.Image = Properties.Resources.backclick; // Clicked image
        }

        private void BackButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (backButton.Image == Properties.Resources.backdisabled) return;

            backButton.Image = Properties.Resources.backhover; // Hover image
        }

        public void SetBackButtonState(bool enabled)
        {
            if (enabled)
            {
                backButton.Image = Properties.Resources.backdefault;
            }
            else
            {
                backButton.Image = Properties.Resources.backdisabled;
            }
        }
    }
}
