namespace Reunion_OOBE
{
    partial class Start
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
            this.accountLabel = new System.Windows.Forms.Label();
            this.usernameTip = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.computerNameBox = new System.Windows.Forms.TextBox();
            this.computerNameTip = new System.Windows.Forms.Label();
            this.eoaPicture = new System.Windows.Forms.PictureBox();
            this.windowsLogo = new System.Windows.Forms.PictureBox();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.buttonPanel = new Reunion_OOBE.CustomPanel();
            this.nextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eoaPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsLogo)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.Location = new System.Drawing.Point(35, 168);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(514, 15);
            this.accountLabel.TabIndex = 1;
            this.accountLabel.Text = "Choose a user name for your account and name your computer to distinguish it on t" +
    "he network.";
            // 
            // usernameTip
            // 
            this.usernameTip.AutoSize = true;
            this.usernameTip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTip.Location = new System.Drawing.Point(167, 203);
            this.usernameTip.Name = "usernameTip";
            this.usernameTip.Size = new System.Drawing.Size(206, 15);
            this.usernameTip.TabIndex = 2;
            this.usernameTip.Text = "Type a user name (for example, John):";
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(168, 218);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(240, 23);
            this.usernameBox.TabIndex = 3;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // computerNameBox
            // 
            this.computerNameBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerNameBox.Location = new System.Drawing.Point(168, 261);
            this.computerNameBox.Name = "computerNameBox";
            this.computerNameBox.Size = new System.Drawing.Size(240, 21);
            this.computerNameBox.TabIndex = 5;
            this.computerNameBox.Text = "PC";
            this.computerNameBox.AutoSize = true;
            // 
            // computerNameTip
            // 
            this.computerNameTip.AutoSize = true;
            this.computerNameTip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerNameTip.Location = new System.Drawing.Point(165, 242);
            this.computerNameTip.Name = "computerNameTip";
            this.computerNameTip.Size = new System.Drawing.Size(132, 15);
            this.computerNameTip.TabIndex = 4;
            this.computerNameTip.Text = "Type a computer name:";
            // 
            // eoaPicture
            // 
            this.eoaPicture.Image = global::Reunion_OOBE.Properties.Resources.eoa_logo_small;
            this.eoaPicture.Location = new System.Drawing.Point(11, 397);
            this.eoaPicture.Name = "eoaPicture";
            this.eoaPicture.Size = new System.Drawing.Size(24, 24);
            this.eoaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.eoaPicture.TabIndex = 6;
            this.eoaPicture.TabStop = false;
            // 
            // windowsLogo
            // 
            this.windowsLogo.Image = global::Reunion_OOBE.Properties.Resources.logo;
            this.windowsLogo.Location = new System.Drawing.Point(66, 91);
            this.windowsLogo.Name = "windowsLogo";
            this.windowsLogo.Size = new System.Drawing.Size(458, 72);
            this.windowsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.windowsLogo.TabIndex = 0;
            this.windowsLogo.TabStop = false;
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLabel.Location = new System.Drawing.Point(262, 408);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(325, 15);
            this.copyrightLabel.TabIndex = 7;
            this.copyrightLabel.Text = "Copyright © 2009 Microsoft Corporation. All rights reserved.";
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.buttonPanel.BorderThickness = 1;
            this.buttonPanel.Controls.Add(this.nextButton);
            this.buttonPanel.Location = new System.Drawing.Point(-1, 425);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(595, 42);
            this.buttonPanel.TabIndex = 8;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(516, 9);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(69, 23);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click_1);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 466);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.eoaPicture);
            this.Controls.Add(this.computerNameBox);
            this.Controls.Add(this.computerNameTip);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.usernameTip);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.windowsLogo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eoaPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsLogo)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox windowsLogo;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Label usernameTip;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox computerNameBox;
        private System.Windows.Forms.Label computerNameTip;
        private System.Windows.Forms.PictureBox eoaPicture;
        private System.Windows.Forms.Label copyrightLabel;
        private CustomPanel buttonPanel;
        private System.Windows.Forms.Button nextButton;
    }
}