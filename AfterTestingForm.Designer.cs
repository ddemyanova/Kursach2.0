﻿namespace GoodVision
{
    partial class AfterTestingForm
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
            this.LightPanelMain = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.DarkPanel = new System.Windows.Forms.Panel();
            this.VisionCheckButton = new ButtonRoundedCorners.RoundedCorners();
            this.StatistButton = new ButtonRoundedCorners.RoundedCorners();
            this.BackToMenuButton = new rbutton.CustRoundButton();
            this.PanelRight = new System.Windows.Forms.Panel();
            this.RightEyeRes = new System.Windows.Forms.Label();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.LeftEyeRes = new System.Windows.Forms.Label();
            this.RightEyeLabel = new System.Windows.Forms.Label();
            this.LeftEyeLabel = new System.Windows.Forms.Label();
            this.LightPanelMain.SuspendLayout();
            this.DarkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisionCheckButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatistButton)).BeginInit();
            this.PanelRight.SuspendLayout();
            this.PanelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // LightPanelMain
            // 
            this.LightPanelMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LightPanelMain.BackColor = System.Drawing.Color.Transparent;
            this.LightPanelMain.BackgroundImage = global::GoodVision.Properties.Resources.подложка;
            this.LightPanelMain.Controls.Add(this.Title);
            this.LightPanelMain.Location = new System.Drawing.Point(100, 22);
            this.LightPanelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LightPanelMain.Name = "LightPanelMain";
            this.LightPanelMain.Size = new System.Drawing.Size(1006, 89);
            this.LightPanelMain.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(325, 17);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(283, 44);
            this.Title.TabIndex = 0;
            this.Title.Text = "Ваш результат";
            // 
            // DarkPanel
            // 
            this.DarkPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DarkPanel.BackColor = System.Drawing.Color.Transparent;
            this.DarkPanel.BackgroundImage = global::GoodVision.Properties.Resources.gjlkj_rf2;
            this.DarkPanel.Controls.Add(this.VisionCheckButton);
            this.DarkPanel.Controls.Add(this.StatistButton);
            this.DarkPanel.Location = new System.Drawing.Point(241, 286);
            this.DarkPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DarkPanel.Name = "DarkPanel";
            this.DarkPanel.Size = new System.Drawing.Size(691, 279);
            this.DarkPanel.TabIndex = 1;
            // 
            // VisionCheckButton
            // 
            this.VisionCheckButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VisionCheckButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.VisionCheckButton.Image = global::GoodVision.Properties.Resources.початиТест;
            this.VisionCheckButton.ImageHover = global::GoodVision.Properties.Resources.почТестHover;
            this.VisionCheckButton.ImageNormal = global::GoodVision.Properties.Resources.початиТест;
            this.VisionCheckButton.Location = new System.Drawing.Point(45, 146);
            this.VisionCheckButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisionCheckButton.Name = "VisionCheckButton";
            this.VisionCheckButton.Size = new System.Drawing.Size(595, 95);
            this.VisionCheckButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.VisionCheckButton.TabIndex = 3;
            this.VisionCheckButton.TabStop = false;
            this.VisionCheckButton.Click += new System.EventHandler(this.VisionCheckButton_Click);
            // 
            // StatistButton
            // 
            this.StatistButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StatistButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StatistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StatistButton.Image = global::GoodVision.Properties.Resources.статист;
            this.StatistButton.ImageHover = global::GoodVision.Properties.Resources.стат;
            this.StatistButton.ImageNormal = global::GoodVision.Properties.Resources.статист;
            this.StatistButton.Location = new System.Drawing.Point(45, 30);
            this.StatistButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatistButton.Name = "StatistButton";
            this.StatistButton.Size = new System.Drawing.Size(595, 92);
            this.StatistButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.StatistButton.TabIndex = 2;
            this.StatistButton.TabStop = false;
            this.StatistButton.Click += new System.EventHandler(this.StatistButton_Click);
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackToMenuButton.Image = global::GoodVision.Properties.Resources._13;
            this.BackToMenuButton.ImageHover = global::GoodVision.Properties.Resources._13Hover;
            this.BackToMenuButton.ImageNormal = global::GoodVision.Properties.Resources._13;
            this.BackToMenuButton.Location = new System.Drawing.Point(17, 411);
            this.BackToMenuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(219, 162);
            this.BackToMenuButton.TabIndex = 0;
            this.BackToMenuButton.TabStop = false;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // PanelRight
            // 
            this.PanelRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelRight.BackColor = System.Drawing.Color.Transparent;
            this.PanelRight.BackgroundImage = global::GoodVision.Properties.Resources.подложка;
            this.PanelRight.Controls.Add(this.RightEyeRes);
            this.PanelRight.Location = new System.Drawing.Point(686, 195);
            this.PanelRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(195, 50);
            this.PanelRight.TabIndex = 1;
            // 
            // RightEyeRes
            // 
            this.RightEyeRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RightEyeRes.AutoSize = true;
            this.RightEyeRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightEyeRes.Location = new System.Drawing.Point(58, 10);
            this.RightEyeRes.Name = "RightEyeRes";
            this.RightEyeRes.Size = new System.Drawing.Size(70, 26);
            this.RightEyeRes.TabIndex = 0;
            this.RightEyeRes.Text = "label1";
            // 
            // PanelLeft
            // 
            this.PanelLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelLeft.BackColor = System.Drawing.Color.Transparent;
            this.PanelLeft.BackgroundImage = global::GoodVision.Properties.Resources.подложка;
            this.PanelLeft.Controls.Add(this.LeftEyeRes);
            this.PanelLeft.Location = new System.Drawing.Point(286, 195);
            this.PanelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(195, 50);
            this.PanelLeft.TabIndex = 1;
            // 
            // LeftEyeRes
            // 
            this.LeftEyeRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeftEyeRes.AutoSize = true;
            this.LeftEyeRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftEyeRes.Location = new System.Drawing.Point(45, 10);
            this.LeftEyeRes.Name = "LeftEyeRes";
            this.LeftEyeRes.Size = new System.Drawing.Size(70, 26);
            this.LeftEyeRes.TabIndex = 0;
            this.LeftEyeRes.Text = "label1";
            // 
            // RightEyeLabel
            // 
            this.RightEyeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RightEyeLabel.AutoSize = true;
            this.RightEyeLabel.BackColor = System.Drawing.Color.Transparent;
            this.RightEyeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightEyeLabel.Location = new System.Drawing.Point(712, 151);
            this.RightEyeLabel.Name = "RightEyeLabel";
            this.RightEyeLabel.Size = new System.Drawing.Size(117, 26);
            this.RightEyeLabel.TabIndex = 0;
            this.RightEyeLabel.Text = "Праве око";
            // 
            // LeftEyeLabel
            // 
            this.LeftEyeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeftEyeLabel.AutoSize = true;
            this.LeftEyeLabel.BackColor = System.Drawing.Color.Transparent;
            this.LeftEyeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftEyeLabel.Location = new System.Drawing.Point(320, 151);
            this.LeftEyeLabel.Name = "LeftEyeLabel";
            this.LeftEyeLabel.Size = new System.Drawing.Size(98, 26);
            this.LeftEyeLabel.TabIndex = 0;
            this.LeftEyeLabel.Text = "Ліве око";
            // 
            // AfterTestingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::GoodVision.Properties.Resources.Регистр2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 601);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.DarkPanel);
            this.Controls.Add(this.PanelRight);
            this.Controls.Add(this.LeftEyeLabel);
            this.Controls.Add(this.LightPanelMain);
            this.Controls.Add(this.BackToMenuButton);
            this.Controls.Add(this.RightEyeLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AfterTestingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результат";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AfterTestingForm_FormClosing);
            this.Load += new System.EventHandler(this.AfterTestingForm_Load);
            this.LightPanelMain.ResumeLayout(false);
            this.LightPanelMain.PerformLayout();
            this.DarkPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VisionCheckButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatistButton)).EndInit();
            this.PanelRight.ResumeLayout(false);
            this.PanelRight.PerformLayout();
            this.PanelLeft.ResumeLayout(false);
            this.PanelLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LightPanelMain;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel DarkPanel;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Label RightEyeLabel;
        private System.Windows.Forms.Label LeftEyeLabel;
        private System.Windows.Forms.Panel PanelRight;
        private System.Windows.Forms.Label RightEyeRes;
        private System.Windows.Forms.Label LeftEyeRes;
  //      private RoundButtonTwo.MyRoundButton StatisticButton;
  //      private RoundButtonTwo.MyRoundButton VisionCheckButton;
        private rbutton.CustRoundButton BackToMenuButton;
        private ButtonRoundedCorners.RoundedCorners StatistButton;
        private ButtonRoundedCorners.RoundedCorners VisionCheckButton;
        //  private rbutton.CustRoundButton BackToMenuButton;
    }
}