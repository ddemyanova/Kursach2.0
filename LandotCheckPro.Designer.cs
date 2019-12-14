namespace GoodVision
{
    partial class LandotCheckPro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandotCheckPro));
            this.EyeTestingPanel = new System.Windows.Forms.Panel();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.WhitePanel = new System.Windows.Forms.Panel();
            this.LandotCirclePictureBox = new System.Windows.Forms.PictureBox();
            this.UpLandotButton = new ButtonRoundedCorners.RoundedCorners();
            this.LandotTimer = new CircularProgressBar.CircularProgressBar();
            this.RightLandotButton = new ButtonRoundedCorners.RoundedCorners();
            this.DownLandotButton = new ButtonRoundedCorners.RoundedCorners();
            this.LeftLandotButton = new ButtonRoundedCorners.RoundedCorners();
            this.InstructPanel = new System.Windows.Forms.Panel();
            this.LandotInstructTextBox = new System.Windows.Forms.RichTextBox();
            this.EyeTestPanel = new System.Windows.Forms.Panel();
            this.EyeTextLabel = new System.Windows.Forms.Label();
            this.LTimer = new System.Windows.Forms.Timer(this.components);
            this.BackToVisionCheckButton = new rbutton.CustRoundButton();
            this.GoLandotButton = new ButtonRoundedCorners.RoundedCorners();
            this.EyeTestingPanel.SuspendLayout();
            this.WhitePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LandotCirclePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpLandotButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightLandotButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownLandotButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftLandotButton)).BeginInit();
            this.InstructPanel.SuspendLayout();
            this.EyeTestPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoLandotButton)).BeginInit();
            this.SuspendLayout();
            // 
            // EyeTestingPanel
            // 
            this.EyeTestingPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EyeTestingPanel.BackColor = System.Drawing.Color.Transparent;
            this.EyeTestingPanel.BackgroundImage = global::GoodVision.Properties.Resources.подложка;
            this.EyeTestingPanel.Controls.Add(this.MessagePanel);
            this.EyeTestingPanel.Controls.Add(this.WhitePanel);
            this.EyeTestingPanel.Controls.Add(this.UpLandotButton);
            this.EyeTestingPanel.Controls.Add(this.LandotTimer);
            this.EyeTestingPanel.Controls.Add(this.RightLandotButton);
            this.EyeTestingPanel.Controls.Add(this.DownLandotButton);
            this.EyeTestingPanel.Controls.Add(this.LeftLandotButton);
            this.EyeTestingPanel.Location = new System.Drawing.Point(429, 9);
            this.EyeTestingPanel.Name = "EyeTestingPanel";
            this.EyeTestingPanel.Size = new System.Drawing.Size(694, 574);
            this.EyeTestingPanel.TabIndex = 0;
            // 
            // MessagePanel
            // 
            this.MessagePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MessagePanel.BackColor = System.Drawing.Color.Transparent;
            this.MessagePanel.BackgroundImage = global::GoodVision.Properties.Resources.enterMessageLand;
            this.MessagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MessagePanel.Location = new System.Drawing.Point(234, 160);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(269, 244);
            this.MessagePanel.TabIndex = 8;
            this.MessagePanel.Visible = false;
            // 
            // WhitePanel
            // 
            this.WhitePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WhitePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WhitePanel.Controls.Add(this.LandotCirclePictureBox);
            this.WhitePanel.Location = new System.Drawing.Point(243, 181);
            this.WhitePanel.Name = "WhitePanel";
            this.WhitePanel.Size = new System.Drawing.Size(246, 214);
            this.WhitePanel.TabIndex = 7;
            // 
            // LandotCirclePictureBox
            // 
            this.LandotCirclePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LandotCirclePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LandotCirclePictureBox.Image")));
            this.LandotCirclePictureBox.Location = new System.Drawing.Point(107, 94);
            this.LandotCirclePictureBox.Name = "LandotCirclePictureBox";
            this.LandotCirclePictureBox.Size = new System.Drawing.Size(33, 28);
            this.LandotCirclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LandotCirclePictureBox.TabIndex = 0;
            this.LandotCirclePictureBox.TabStop = false;
            // 
            // UpLandotButton
            // 
            this.UpLandotButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpLandotButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.UpLandotButton.Image = global::GoodVision.Properties.Resources.Up;
            this.UpLandotButton.ImageHover = global::GoodVision.Properties.Resources.UpHover;
            this.UpLandotButton.ImageNormal = global::GoodVision.Properties.Resources.Up;
            this.UpLandotButton.Location = new System.Drawing.Point(253, 40);
            this.UpLandotButton.Name = "UpLandotButton";
            this.UpLandotButton.Size = new System.Drawing.Size(225, 109);
            this.UpLandotButton.TabIndex = 5;
            this.UpLandotButton.TabStop = false;
            this.UpLandotButton.Click += new System.EventHandler(this.UpLandotButton_Click);
            // 
            // LandotTimer
            // 
            this.LandotTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LandotTimer.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("LandotTimer.AnimationFunction")));
            this.LandotTimer.AnimationSpeed = 500;
            this.LandotTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.LandotTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 55.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LandotTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LandotTimer.InnerColor = System.Drawing.Color.Transparent;
            this.LandotTimer.InnerMargin = 2;
            this.LandotTimer.InnerWidth = -1;
            this.LandotTimer.Location = new System.Drawing.Point(12, 3);
            this.LandotTimer.MarqueeAnimationSpeed = 2000;
            this.LandotTimer.Maximum = 50;
            this.LandotTimer.Name = "LandotTimer";
            this.LandotTimer.OuterColor = System.Drawing.Color.Gray;
            this.LandotTimer.OuterMargin = -10;
            this.LandotTimer.OuterWidth = 10;
            this.LandotTimer.ProgressColor = System.Drawing.Color.Coral;
            this.LandotTimer.ProgressWidth = 20;
            this.LandotTimer.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.LandotTimer.Size = new System.Drawing.Size(155, 146);
            this.LandotTimer.StartAngle = 270;
            this.LandotTimer.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.LandotTimer.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.LandotTimer.SubscriptText = "";
            this.LandotTimer.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.LandotTimer.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.LandotTimer.SuperscriptText = "";
            this.LandotTimer.TabIndex = 2;
            this.LandotTimer.TextMargin = new System.Windows.Forms.Padding(4, 8, 0, 0);
            this.LandotTimer.Value = 50;
            // 
            // RightLandotButton
            // 
            this.RightLandotButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RightLandotButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RightLandotButton.Image = global::GoodVision.Properties.Resources.Right;
            this.RightLandotButton.ImageHover = global::GoodVision.Properties.Resources.RightHover;
            this.RightLandotButton.ImageNormal = global::GoodVision.Properties.Resources.Right;
            this.RightLandotButton.Location = new System.Drawing.Point(509, 174);
            this.RightLandotButton.Name = "RightLandotButton";
            this.RightLandotButton.Size = new System.Drawing.Size(109, 211);
            this.RightLandotButton.TabIndex = 6;
            this.RightLandotButton.TabStop = false;
            this.RightLandotButton.Click += new System.EventHandler(this.RightLandotButton_Click);
            // 
            // DownLandotButton
            // 
            this.DownLandotButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DownLandotButton.BackColor = System.Drawing.Color.DimGray;
            this.DownLandotButton.Image = global::GoodVision.Properties.Resources.down;
            this.DownLandotButton.ImageHover = global::GoodVision.Properties.Resources.downHower;
            this.DownLandotButton.ImageNormal = global::GoodVision.Properties.Resources.down;
            this.DownLandotButton.Location = new System.Drawing.Point(260, 410);
            this.DownLandotButton.Name = "DownLandotButton";
            this.DownLandotButton.Size = new System.Drawing.Size(225, 109);
            this.DownLandotButton.TabIndex = 4;
            this.DownLandotButton.TabStop = false;
            this.DownLandotButton.Click += new System.EventHandler(this.DownLandotButton_Click);
            // 
            // LeftLandotButton
            // 
            this.LeftLandotButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeftLandotButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LeftLandotButton.Image = global::GoodVision.Properties.Resources.Left;
            this.LeftLandotButton.ImageHover = global::GoodVision.Properties.Resources.LeftHover;
            this.LeftLandotButton.ImageNormal = global::GoodVision.Properties.Resources.Left;
            this.LeftLandotButton.Location = new System.Drawing.Point(120, 173);
            this.LeftLandotButton.Name = "LeftLandotButton";
            this.LeftLandotButton.Size = new System.Drawing.Size(109, 212);
            this.LeftLandotButton.TabIndex = 3;
            this.LeftLandotButton.TabStop = false;
            this.LeftLandotButton.Click += new System.EventHandler(this.LeftLandotButton_Click);
            // 
            // InstructPanel
            // 
            this.InstructPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InstructPanel.BackColor = System.Drawing.Color.Transparent;
            this.InstructPanel.Controls.Add(this.LandotInstructTextBox);
            this.InstructPanel.Location = new System.Drawing.Point(12, 12);
            this.InstructPanel.Name = "InstructPanel";
            this.InstructPanel.Size = new System.Drawing.Size(423, 347);
            this.InstructPanel.TabIndex = 3;
            // 
            // LandotInstructTextBox
            // 
            this.LandotInstructTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LandotInstructTextBox.BackColor = System.Drawing.Color.Lavender;
            this.LandotInstructTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LandotInstructTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LandotInstructTextBox.Location = new System.Drawing.Point(-7, 3);
            this.LandotInstructTextBox.Name = "LandotInstructTextBox";
            this.LandotInstructTextBox.ReadOnly = true;
            this.LandotInstructTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.LandotInstructTextBox.ShowSelectionMargin = true;
            this.LandotInstructTextBox.Size = new System.Drawing.Size(421, 341);
            this.LandotInstructTextBox.TabIndex = 0;
            this.LandotInstructTextBox.Text = resources.GetString("LandotInstructTextBox.Text");
            // 
            // EyeTestPanel
            // 
            this.EyeTestPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EyeTestPanel.BackColor = System.Drawing.Color.Transparent;
            this.EyeTestPanel.BackgroundImage = global::GoodVision.Properties.Resources.gjlkj_rf2;
            this.EyeTestPanel.Controls.Add(this.EyeTextLabel);
            this.EyeTestPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EyeTestPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EyeTestPanel.Location = new System.Drawing.Point(429, 9);
            this.EyeTestPanel.Name = "EyeTestPanel";
            this.EyeTestPanel.Size = new System.Drawing.Size(694, 574);
            this.EyeTestPanel.TabIndex = 7;
            this.EyeTestPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.EyeTestPanel_Paint);
            // 
            // EyeTextLabel
            // 
            this.EyeTextLabel.AutoSize = true;
            this.EyeTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EyeTextLabel.Location = new System.Drawing.Point(89, 196);
            this.EyeTextLabel.Name = "EyeTextLabel";
            this.EyeTextLabel.Size = new System.Drawing.Size(517, 126);
            this.EyeTextLabel.TabIndex = 0;
            this.EyeTextLabel.Text = "Тестуємо ліве око. \r\nБудь ласка, закрийте праве \r\nта нажміть \"старт\".\r\n";
            // 
            // LTimer
            // 
            this.LTimer.Interval = 1000;
            this.LTimer.Tick += new System.EventHandler(this.LTimer_Tick_1);
            // 
            // BackToVisionCheckButton
            // 
            this.BackToVisionCheckButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackToVisionCheckButton.Image = global::GoodVision.Properties.Resources._13;
            this.BackToVisionCheckButton.ImageHover = global::GoodVision.Properties.Resources._13Hover;
            this.BackToVisionCheckButton.ImageNormal = global::GoodVision.Properties.Resources._13;
            this.BackToVisionCheckButton.Location = new System.Drawing.Point(5, 405);
            this.BackToVisionCheckButton.Name = "BackToVisionCheckButton";
            this.BackToVisionCheckButton.Size = new System.Drawing.Size(218, 163);
            this.BackToVisionCheckButton.TabIndex = 4;
            this.BackToVisionCheckButton.UseVisualStyleBackColor = true;
            this.BackToVisionCheckButton.Click += new System.EventHandler(this.BackToVisionCheckButton_Click);
            // 
            // GoLandotButton
            // 
            this.GoLandotButton.Image = global::GoodVision.Properties.Resources.ИнвСтарт;
            this.GoLandotButton.ImageHover = global::GoodVision.Properties.Resources.ИнвСтарт;
            this.GoLandotButton.ImageNormal = global::GoodVision.Properties.Resources.ИнвСтарт;
            this.GoLandotButton.Location = new System.Drawing.Point(226, 380);
            this.GoLandotButton.Name = "GoLandotButton";
            this.GoLandotButton.Size = new System.Drawing.Size(199, 199);
            this.GoLandotButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GoLandotButton.TabIndex = 8;
            this.GoLandotButton.TabStop = false;
            this.GoLandotButton.Click += new System.EventHandler(this.GoLandotButton_Click);
            // 
            // LandotCheckPro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::GoodVision.Properties.Resources.Регистр2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 601);
            this.Controls.Add(this.GoLandotButton);
            this.Controls.Add(this.EyeTestPanel);
            this.Controls.Add(this.BackToVisionCheckButton);
            this.Controls.Add(this.InstructPanel);
            this.Controls.Add(this.EyeTestingPanel);
            this.DoubleBuffered = true;
            this.Name = "LandotCheckPro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перевірка кільцями Ландольта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LandotCheckPro_FormClosing);
            this.Load += new System.EventHandler(this.LandotCheckPro_Load);
            this.EyeTestingPanel.ResumeLayout(false);
            this.WhitePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LandotCirclePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpLandotButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightLandotButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownLandotButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftLandotButton)).EndInit();
            this.InstructPanel.ResumeLayout(false);
            this.EyeTestPanel.ResumeLayout(false);
            this.EyeTestPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoLandotButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EyeTestingPanel;
       // private rbutton.CustRoundButton BackToVisionCheckButton;
        private System.Windows.Forms.PictureBox LandotCirclePictureBox;
        private System.Windows.Forms.Panel InstructPanel;
        private System.Windows.Forms.RichTextBox LandotInstructTextBox;
        private CircularProgressBar.CircularProgressBar LandotTimer;
        private System.Windows.Forms.Timer LTimer;
        private rbutton.CustRoundButton BackToVisionCheckButton;
        private ButtonRoundedCorners.RoundedCorners RightLandotButton;
        private ButtonRoundedCorners.RoundedCorners UpLandotButton;
        private ButtonRoundedCorners.RoundedCorners DownLandotButton;
        private ButtonRoundedCorners.RoundedCorners LeftLandotButton;
        private System.Windows.Forms.Panel EyeTestPanel;
        private System.Windows.Forms.Label EyeTextLabel;
        private System.Windows.Forms.Panel WhitePanel;
        private System.Windows.Forms.Panel MessagePanel;
        private ButtonRoundedCorners.RoundedCorners GoLandotButton;
    }
}