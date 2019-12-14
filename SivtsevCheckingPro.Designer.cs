namespace GoodVision
{
    partial class SivtsevCheckingPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SivtsevCheckingPro));
            this.BackPanel = new System.Windows.Forms.Panel();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.WhitePanel = new System.Windows.Forms.Panel();
            this.LetterPictureBox = new System.Windows.Forms.PictureBox();
            this.LightPanel = new System.Windows.Forms.Panel();
            this.AnswerSivtsevButton = new ButtonRoundedCorners.RoundedCorners();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.SivtsevTimer = new CircularProgressBar.CircularProgressBar();
            this.EyeTestPanel = new System.Windows.Forms.Panel();
            this.EyeTextLabel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.InstrPanel = new System.Windows.Forms.Panel();
            this.SivtsevInstrTextBox = new System.Windows.Forms.RichTextBox();
            this.BackToVisionCheckButton = new rbutton.CustRoundButton();
            this.StartButton = new ButtonRoundedCorners.RoundedCorners();
            this.BackPanel.SuspendLayout();
            this.WhitePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LetterPictureBox)).BeginInit();
            this.LightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerSivtsevButton)).BeginInit();
            this.EyeTestPanel.SuspendLayout();
            this.InstrPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartButton)).BeginInit();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackPanel.BackColor = System.Drawing.Color.Transparent;
            this.BackPanel.BackgroundImage = global::GoodVision.Properties.Resources.подложка;
            this.BackPanel.Controls.Add(this.MessagePanel);
            this.BackPanel.Controls.Add(this.WhitePanel);
            this.BackPanel.Controls.Add(this.LightPanel);
            this.BackPanel.Controls.Add(this.SivtsevTimer);
            this.BackPanel.Location = new System.Drawing.Point(434, 12);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(693, 577);
            this.BackPanel.TabIndex = 0;
            // 
            // MessagePanel
            // 
            this.MessagePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MessagePanel.BackgroundImage = global::GoodVision.Properties.Resources.enterMessage;
            this.MessagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MessagePanel.Location = new System.Drawing.Point(245, 85);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(301, 291);
            this.MessagePanel.TabIndex = 1;
            this.MessagePanel.Visible = false;
            // 
            // WhitePanel
            // 
            this.WhitePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WhitePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WhitePanel.Controls.Add(this.LetterPictureBox);
            this.WhitePanel.Location = new System.Drawing.Point(269, 146);
            this.WhitePanel.Name = "WhitePanel";
            this.WhitePanel.Size = new System.Drawing.Size(246, 214);
            this.WhitePanel.TabIndex = 3;
            // 
            // LetterPictureBox
            // 
            this.LetterPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LetterPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LetterPictureBox.Image")));
            this.LetterPictureBox.Location = new System.Drawing.Point(107, 94);
            this.LetterPictureBox.Name = "LetterPictureBox";
            this.LetterPictureBox.Size = new System.Drawing.Size(33, 28);
            this.LetterPictureBox.TabIndex = 0;
            this.LetterPictureBox.TabStop = false;
            // 
            // LightPanel
            // 
            this.LightPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LightPanel.BackgroundImage = global::GoodVision.Properties.Resources.подложка2;
            this.LightPanel.Controls.Add(this.AnswerSivtsevButton);
            this.LightPanel.Controls.Add(this.AnswerTextBox);
            this.LightPanel.Location = new System.Drawing.Point(175, 396);
            this.LightPanel.Name = "LightPanel";
            this.LightPanel.Size = new System.Drawing.Size(413, 116);
            this.LightPanel.TabIndex = 2;
            // 
            // AnswerSivtsevButton
            // 
            this.AnswerSivtsevButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AnswerSivtsevButton.BackColor = System.Drawing.Color.Coral;
            this.AnswerSivtsevButton.Enabled = false;
            this.AnswerSivtsevButton.Image = global::GoodVision.Properties.Resources.ok;
            this.AnswerSivtsevButton.ImageHover = global::GoodVision.Properties.Resources.ok;
            this.AnswerSivtsevButton.ImageNormal = global::GoodVision.Properties.Resources.ok;
            this.AnswerSivtsevButton.Location = new System.Drawing.Point(227, 32);
            this.AnswerSivtsevButton.Name = "AnswerSivtsevButton";
            this.AnswerSivtsevButton.Size = new System.Drawing.Size(149, 58);
            this.AnswerSivtsevButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AnswerSivtsevButton.TabIndex = 1;
            this.AnswerSivtsevButton.TabStop = false;
            this.AnswerSivtsevButton.Click += new System.EventHandler(this.AnswerSivtsevButton_Click);
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AnswerTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerTextBox.Location = new System.Drawing.Point(41, 35);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(158, 46);
            this.AnswerTextBox.TabIndex = 0;
            this.AnswerTextBox.TextChanged += new System.EventHandler(this.AnswerTextBox_TextChanged);
            this.AnswerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AnswerTextBox_KeyPress);
            // 
            // SivtsevTimer
            // 
            this.SivtsevTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SivtsevTimer.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("SivtsevTimer.AnimationFunction")));
            this.SivtsevTimer.AnimationSpeed = 500;
            this.SivtsevTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.SivtsevTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 55.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SivtsevTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SivtsevTimer.InnerColor = System.Drawing.Color.Transparent;
            this.SivtsevTimer.InnerMargin = 2;
            this.SivtsevTimer.InnerWidth = -1;
            this.SivtsevTimer.Location = new System.Drawing.Point(15, 3);
            this.SivtsevTimer.MarqueeAnimationSpeed = 2000;
            this.SivtsevTimer.Maximum = 50;
            this.SivtsevTimer.Name = "SivtsevTimer";
            this.SivtsevTimer.OuterColor = System.Drawing.Color.DimGray;
            this.SivtsevTimer.OuterMargin = -10;
            this.SivtsevTimer.OuterWidth = 10;
            this.SivtsevTimer.ProgressColor = System.Drawing.Color.Coral;
            this.SivtsevTimer.ProgressWidth = 20;
            this.SivtsevTimer.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.SivtsevTimer.Size = new System.Drawing.Size(135, 128);
            this.SivtsevTimer.StartAngle = 270;
            this.SivtsevTimer.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.SivtsevTimer.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.SivtsevTimer.SubscriptText = "";
            this.SivtsevTimer.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.SivtsevTimer.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.SivtsevTimer.SuperscriptText = "";
            this.SivtsevTimer.TabIndex = 1;
            this.SivtsevTimer.TextMargin = new System.Windows.Forms.Padding(7, 7, 0, 0);
            this.SivtsevTimer.Value = 50;
            // 
            // EyeTestPanel
            // 
            this.EyeTestPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EyeTestPanel.BackColor = System.Drawing.Color.Transparent;
            this.EyeTestPanel.BackgroundImage = global::GoodVision.Properties.Resources.gjlkj_rf2;
            this.EyeTestPanel.Controls.Add(this.EyeTextLabel);
            this.EyeTestPanel.ForeColor = System.Drawing.Color.Cornsilk;
            this.EyeTestPanel.Location = new System.Drawing.Point(437, 12);
            this.EyeTestPanel.Name = "EyeTestPanel";
            this.EyeTestPanel.Size = new System.Drawing.Size(694, 583);
            this.EyeTestPanel.TabIndex = 2;
            // 
            // EyeTextLabel
            // 
            this.EyeTextLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EyeTextLabel.AutoSize = true;
            this.EyeTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EyeTextLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EyeTextLabel.Location = new System.Drawing.Point(85, 199);
            this.EyeTextLabel.Name = "EyeTextLabel";
            this.EyeTextLabel.Size = new System.Drawing.Size(517, 126);
            this.EyeTextLabel.TabIndex = 0;
            this.EyeTextLabel.Text = "Тестуємо ліве око. \r\nБудь ласка, закрийте праве \r\nта нажміть \"старт\".";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // InstrPanel
            // 
            this.InstrPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InstrPanel.BackColor = System.Drawing.Color.Transparent;
            this.InstrPanel.Controls.Add(this.SivtsevInstrTextBox);
            this.InstrPanel.Location = new System.Drawing.Point(12, 12);
            this.InstrPanel.Name = "InstrPanel";
            this.InstrPanel.Size = new System.Drawing.Size(423, 363);
            this.InstrPanel.TabIndex = 5;
            // 
            // SivtsevInstrTextBox
            // 
            this.SivtsevInstrTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SivtsevInstrTextBox.BackColor = System.Drawing.Color.Lavender;
            this.SivtsevInstrTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SivtsevInstrTextBox.Location = new System.Drawing.Point(0, 3);
            this.SivtsevInstrTextBox.Name = "SivtsevInstrTextBox";
            this.SivtsevInstrTextBox.ReadOnly = true;
            this.SivtsevInstrTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.SivtsevInstrTextBox.ShowSelectionMargin = true;
            this.SivtsevInstrTextBox.Size = new System.Drawing.Size(423, 357);
            this.SivtsevInstrTextBox.TabIndex = 1;
            this.SivtsevInstrTextBox.Text = resources.GetString("SivtsevInstrTextBox.Text");
            this.SivtsevInstrTextBox.TextChanged += new System.EventHandler(this.SivtsevInstrTextBox_TextChanged);
            // 
            // BackToVisionCheckButton
            // 
            this.BackToVisionCheckButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackToVisionCheckButton.BackColor = System.Drawing.Color.Transparent;
            this.BackToVisionCheckButton.Image = global::GoodVision.Properties.Resources._13;
            this.BackToVisionCheckButton.ImageHover = global::GoodVision.Properties.Resources._13Hover;
            this.BackToVisionCheckButton.ImageNormal = global::GoodVision.Properties.Resources._13;
            this.BackToVisionCheckButton.Location = new System.Drawing.Point(5, 408);
            this.BackToVisionCheckButton.Name = "BackToVisionCheckButton";
            this.BackToVisionCheckButton.Size = new System.Drawing.Size(218, 163);
            this.BackToVisionCheckButton.TabIndex = 6;
            this.BackToVisionCheckButton.UseVisualStyleBackColor = false;
            this.BackToVisionCheckButton.Click += new System.EventHandler(this.BackToVisionCheckButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartButton.BackgroundImage")));
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartButton.Image = global::GoodVision.Properties.Resources.ИнвСтарт;
            this.StartButton.ImageHover = global::GoodVision.Properties.Resources.ИнвСтарт;
            this.StartButton.ImageNormal = global::GoodVision.Properties.Resources.ИнвСтарт;
            this.StartButton.Location = new System.Drawing.Point(229, 381);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(199, 199);
            this.StartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartButton.TabIndex = 7;
            this.StartButton.TabStop = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SivtsevCheckingPro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::GoodVision.Properties.Resources.Регистр2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1140, 601);
            this.Controls.Add(this.EyeTestPanel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.BackToVisionCheckButton);
            this.Controls.Add(this.BackPanel);
            this.Controls.Add(this.InstrPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "SivtsevCheckingPro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перевірка таблицею Сивцева";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SivtsevCheckingPro_FormClosing);
            this.Load += new System.EventHandler(this.SivtsevCheckingPro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SivtsevCheckingPro_KeyDown);
            this.BackPanel.ResumeLayout(false);
            this.WhitePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LetterPictureBox)).EndInit();
            this.LightPanel.ResumeLayout(false);
            this.LightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerSivtsevButton)).EndInit();
            this.EyeTestPanel.ResumeLayout(false);
            this.EyeTestPanel.PerformLayout();
            this.InstrPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StartButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.PictureBox LetterPictureBox;
        private CircularProgressBar.CircularProgressBar SivtsevTimer;
        private System.Windows.Forms.Panel LightPanel;
        private System.Windows.Forms.TextBox AnswerTextBox;
      //  private rbutton.CustRoundButton BackFromSivtsevButton;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel InstrPanel;
      //  private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox SivtsevInstrTextBox;
        private rbutton.CustRoundButton BackToVisionCheckButton;
        private ButtonRoundedCorners.RoundedCorners AnswerSivtsevButton;
        private ButtonRoundedCorners.RoundedCorners StartButton;
        private System.Windows.Forms.Panel EyeTestPanel;
        private System.Windows.Forms.Label EyeTextLabel;
        private System.Windows.Forms.Panel WhitePanel;
        private System.Windows.Forms.Panel MessagePanel;
        //   private RoundButtonTwo.MyRoundButton AnswerSivtsevButton;
        //private RoundButtonTwo.MyRoundButton StartButton;
    }
}