using System;
using System.Drawing;
using System.Windows.Forms;

namespace Reunion_OOBE
{
    public partial class CustomPanel : Panel
    {
        // Property to set the border color
        public Color BorderColor { get; set; } = Color.Black;

        // Property to set the border thickness
        public int BorderThickness { get; set; } = 1;

        public CustomPanel()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(240, 240, 240); // Default background color
        }

        // Override the OnPaint method to draw the custom border
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                // Adjust for border thickness
                e.Graphics.DrawRectangle(
                    pen,
                    BorderThickness / 2,
                    BorderThickness / 2,
                    this.Width - BorderThickness,
                    this.Height - BorderThickness
                );
            }
        }
    }
}
