﻿namespace GoodVision
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.LightPanel = new System.Windows.Forms.Panel();
            this.HelloLab = new System.Windows.Forms.Label();
            this.DarkPanel = new System.Windows.Forms.Panel();
            this.VisionCheckButton = new ButtonRoundedCorners.RoundedCorners();
            this.StatisticButton = new ButtonRoundedCorners.RoundedCorners();
            this.HelpButton = new rbutton.CustRoundButton();
            this.EyePictureBox = new System.Windows.Forms.PictureBox();
            this.ChangeUser = new TetraCustomButton.ImageTetraButton();
            this.LightPanel.SuspendLayout();
            this.DarkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisionCheckButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeUser)).BeginInit();
            this.SuspendLayout();
            // 
            // LightPanel
            // 
            this.LightPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LightPanel.BackColor = System.Drawing.Color.Transparent;
            this.LightPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LightPanel.BackgroundImage")));
            this.LightPanel.Controls.Add(this.HelloLab);
            this.LightPanel.Location = new System.Drawing.Point(182, 41);
            this.LightPanel.Name = "LightPanel";
            this.LightPanel.Size = new System.Drawing.Size(772, 134);
            this.LightPanel.TabIndex = 1;
            // 
            // HelloLab
            // 
            this.HelloLab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HelloLab.AutoSize = true;
            this.HelloLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 45.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelloLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.HelloLab.Location = new System.Drawing.Point(16, 22);
            this.HelloLab.Name = "HelloLab";
            this.HelloLab.Size = new System.Drawing.Size(341, 87);
            this.HelloLab.TabIndex = 0;
            this.HelloLab.Text = "Вітаємо,";
            // 
            // DarkPanel
            // 
            this.DarkPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DarkPanel.BackColor = System.Drawing.Color.Transparent;
            this.DarkPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DarkPanel.BackgroundImage")));
            this.DarkPanel.Controls.Add(this.VisionCheckButton);
            this.DarkPanel.Controls.Add(this.StatisticButton);
            this.DarkPanel.Location = new System.Drawing.Point(182, 250);
            this.DarkPanel.Name = "DarkPanel";
            this.DarkPanel.Size = new System.Drawing.Size(772, 323);
            this.DarkPanel.TabIndex = 2;
            // 
            // VisionCheckButton
            // 
            this.VisionCheckButton.BackColor = System.Drawing.Color.Coral;
            this.VisionCheckButton.BackgroundImage = global::GoodVision.Properties.Resources.початиТест;
            this.VisionCheckButton.Image = global::GoodVision.Properties.Resources.початиТест;
            this.VisionCheckButton.ImageHover = global::GoodVision.Properties.Resources.почТестHover;
            this.VisionCheckButton.ImageNormal = global::GoodVision.Properties.Resources.початиТест;
            this.VisionCheckButton.Location = new System.Drawing.Point(65, 187);
            this.VisionCheckButton.Name = "VisionCheckButton";
            this.VisionCheckButton.Size = new System.Drawing.Size(668, 93);
            this.VisionCheckButton.TabIndex = 3;
            this.VisionCheckButton.TabStop = false;
            this.VisionCheckButton.Click += new System.EventHandler(this.VisionCheckButton_Click);
            // 
            // StatisticButton
            // 
            this.StatisticButton.BackColor = System.Drawing.Color.Coral;
            this.StatisticButton.BackgroundImage = global::GoodVision.Properties.Resources.statistic;
            this.StatisticButton.ImageHover = global::GoodVision.Properties.Resources.стат;
            this.StatisticButton.ImageNormal = null;
            this.StatisticButton.Location = new System.Drawing.Point(65, 47);
            this.StatisticButton.Name = "StatisticButton";
            this.StatisticButton.Size = new System.Drawing.Size(668, 93);
            this.StatisticButton.TabIndex = 2;
            this.StatisticButton.TabStop = false;
            this.StatisticButton.Click += new System.EventHandler(this.StatisticButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HelpButton.Image = global::GoodVision.Properties.Resources.NewHelp;
            this.HelpButton.ImageHover = global::GoodVision.Properties.Resources.NewHelpHover;
            this.HelpButton.ImageNormal = global::GoodVision.Properties.Resources.NewHelp;
            this.HelpButton.Location = new System.Drawing.Point(1006, 462);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(122, 111);
            this.HelpButton.TabIndex = 3;
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // EyePictureBox
            // 
            this.EyePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EyePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.EyePictureBox.Image = global::GoodVision.Properties.Resources.eye1;
            this.EyePictureBox.Location = new System.Drawing.Point(25, 63);
            this.EyePictureBox.Name = "EyePictureBox";
            this.EyePictureBox.Size = new System.Drawing.Size(131, 89);
            this.EyePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EyePictureBox.TabIndex = 4;
            this.EyePictureBox.TabStop = false;
            this.EyePictureBox.MouseEnter += new System.EventHandler(this.EyePictureBox_MouseEnter);
            this.EyePictureBox.MouseLeave += new System.EventHandler(this.EyePictureBox_MouseLeave);
            // 
            // ChangeUser
            // 
            this.ChangeUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangeUser.Image = global::GoodVision.Properties.Resources.ChangeUser;
            this.ChangeUser.ImageHover = global::GoodVision.Properties.Resources.ChangeUserHover;
            this.ChangeUser.ImageNormal = global::GoodVision.Properties.Resources.ChangeUser;
            this.ChangeUser.Location = new System.Drawing.Point(971, 60);
            this.ChangeUser.Name = "ChangeUser";
            this.ChangeUser.Size = new System.Drawing.Size(157, 92);
            this.ChangeUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ChangeUser.TabIndex = 5;
            this.ChangeUser.TabStop = false;
            this.ChangeUser.Click += new System.EventHandler(this.ChangeUser_Click);
            // 
            // MainMenu
            // 
            this.BackgroundImage = global::GoodVision.Properties.Resources.Регистр2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 638);
            this.Controls.Add(this.ChangeUser);
            this.Controls.Add(this.EyePictureBox);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.DarkPanel);
            this.Controls.Add(this.LightPanel);
            this.DoubleBuffered = true;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головне меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.LightPanel.ResumeLayout(false);
            this.LightPanel.PerformLayout();
            this.DarkPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VisionCheckButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        //    private RoundButtonTwo.MyRoundButton CheckVisionButton;
        // private rbutton.CustRoundButton HelpButton;
        //     private RoundButtonTwo.MyRoundButton StatisticButton;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Panel LightPanel;
        private System.Windows.Forms.Panel DarkPanel;
        //  private rbutton.CustRoundButton MainMenuHellpButton;
        public System.Windows.Forms.Label HelloLab;

        private rbutton.CustRoundButton HelpButton;
        private ButtonRoundedCorners.RoundedCorners VisionCheckButton;
        private ButtonRoundedCorners.RoundedCorners StatisticButton;
        private System.Windows.Forms.PictureBox EyePictureBox;
        private TetraCustomButton.ImageTetraButton ChangeUser;
        //
    }
}