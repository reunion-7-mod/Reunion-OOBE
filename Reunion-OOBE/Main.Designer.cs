using System.Drawing;

namespace Reunion_OOBE
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.iconPicture = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.titleBarLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.topPanel.Controls.Add(this.iconPicture);
            this.topPanel.Controls.Add(this.backButton);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(593, 32);
            this.topPanel.TabIndex = 0;
            // 
            // iconPicture
            // 
            this.iconPicture.Image = global::Reunion_OOBE.Properties.Resources.oobe_logo;
            this.iconPicture.Location = new System.Drawing.Point(37, 7);
            this.iconPicture.Name = "iconPicture";
            this.iconPicture.Size = new System.Drawing.Size(16, 16);
            this.iconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPicture.TabIndex = 1;
            this.iconPicture.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.Image = global::Reunion_OOBE.Properties.Resources.backdisabled;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(31, 31);
            this.backButton.TabIndex = 0;
            this.backButton.TabStop = false;
            // 
            // titleBarLabel
            // 
            this.titleBarLabel.AutoSize = true;
            this.titleBarLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.titleBarLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBarLabel.Location = new System.Drawing.Point(57, 7);
            this.titleBarLabel.Name = "titleBarLabel";
            this.titleBarLabel.Size = new System.Drawing.Size(93, 15);
            this.titleBarLabel.TabIndex = 2;
            this.titleBarLabel.Text = "Set Up Windows";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 466);
            this.Controls.Add(this.titleBarLabel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        public System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.PictureBox iconPicture;
        private System.Windows.Forms.Label titleBarLabel;
    }
}

