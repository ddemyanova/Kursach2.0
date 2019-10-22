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
            this.panel2 = new System.Windows.Forms.Panel();
            this.LetterPictureBox = new System.Windows.Forms.PictureBox();
            this.SivtsevTimer = new CircularProgressBar.CircularProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AnswerSivtsevButton = new RoundButtonTwo.MyRoundButton();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.BackFromSivtsevButton = new rbutton.CustRoundButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new RoundButtonTwo.MyRoundButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SivtsevInstrTextBox = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LetterPictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerSivtsevButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartButton)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LetterPictureBox);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.SivtsevTimer);
            this.panel2.Location = new System.Drawing.Point(434, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 577);
            this.panel2.TabIndex = 0;
            // 
            // LetterPictureBox
            // 
            this.LetterPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LetterPictureBox.Image")));
            this.LetterPictureBox.Location = new System.Drawing.Point(256, 120);
            this.LetterPictureBox.Name = "LetterPictureBox";
            this.LetterPictureBox.Size = new System.Drawing.Size(287, 248);
            this.LetterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LetterPictureBox.TabIndex = 0;
            this.LetterPictureBox.TabStop = false;
            // 
            // SivtsevTimer
            // 
            this.SivtsevTimer.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("SivtsevTimer.AnimationFunction")));
            this.SivtsevTimer.AnimationSpeed = 500;
            this.SivtsevTimer.BackColor = System.Drawing.Color.White;
            this.SivtsevTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.SivtsevTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SivtsevTimer.InnerColor = System.Drawing.Color.White;
            this.SivtsevTimer.InnerMargin = 2;
            this.SivtsevTimer.InnerWidth = -1;
            this.SivtsevTimer.Location = new System.Drawing.Point(88, 41);
            this.SivtsevTimer.MarqueeAnimationSpeed = 2000;
            this.SivtsevTimer.Maximum = 50;
            this.SivtsevTimer.Name = "SivtsevTimer";
            this.SivtsevTimer.OuterColor = System.Drawing.Color.Gray;
            this.SivtsevTimer.OuterMargin = -20;
            this.SivtsevTimer.OuterWidth = 20;
            this.SivtsevTimer.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SivtsevTimer.ProgressWidth = 20;
            this.SivtsevTimer.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.SivtsevTimer.Size = new System.Drawing.Size(135, 128);
            this.SivtsevTimer.StartAngle = 270;
            this.SivtsevTimer.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.SivtsevTimer.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.SivtsevTimer.SubscriptText = "";
            this.SivtsevTimer.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.SivtsevTimer.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.SivtsevTimer.SuperscriptText = "";
            this.SivtsevTimer.TabIndex = 1;
            this.SivtsevTimer.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.SivtsevTimer.Value = 50;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AnswerSivtsevButton);
            this.panel3.Controls.Add(this.AnswerTextBox);
            this.panel3.Location = new System.Drawing.Point(100, 405);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 116);
            this.panel3.TabIndex = 2;
            // 
            // AnswerSivtsevButton
            // 
            this.AnswerSivtsevButton.ImageHover = null;
            this.AnswerSivtsevButton.ImageNormal = null;
            this.AnswerSivtsevButton.Location = new System.Drawing.Point(320, 19);
            this.AnswerSivtsevButton.Name = "AnswerSivtsevButton";
            this.AnswerSivtsevButton.Size = new System.Drawing.Size(173, 79);
            this.AnswerSivtsevButton.TabIndex = 1;
            this.AnswerSivtsevButton.TabStop = false;
            this.AnswerSivtsevButton.Click += new System.EventHandler(this.AnswerSivtsevButton_Click);
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Font = new System.Drawing.Font("Berlin Sans FB", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerTextBox.Location = new System.Drawing.Point(90, 33);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(158, 55);
            this.AnswerTextBox.TabIndex = 0;
            this.AnswerTextBox.TextChanged += new System.EventHandler(this.AnswerTextBox_TextChanged);
            // 
            // BackFromSivtsevButton
            // 
            this.BackFromSivtsevButton.ImageHover = null;
            this.BackFromSivtsevButton.ImageNormal = null;
            this.BackFromSivtsevButton.Location = new System.Drawing.Point(29, 468);
            this.BackFromSivtsevButton.Name = "BackFromSivtsevButton";
            this.BackFromSivtsevButton.Size = new System.Drawing.Size(151, 93);
            this.BackFromSivtsevButton.TabIndex = 3;
            this.BackFromSivtsevButton.Text = "custRoundButton1";
            this.BackFromSivtsevButton.UseVisualStyleBackColor = true;
            this.BackFromSivtsevButton.Click += new System.EventHandler(this.BackFromSivtsevButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartButton
            // 
            this.StartButton.Image = ((System.Drawing.Image)(resources.GetObject("StartButton.Image")));
            this.StartButton.ImageHover = null;
            this.StartButton.ImageNormal = null;
            this.StartButton.Location = new System.Drawing.Point(232, 426);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(135, 135);
            this.StartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartButton.TabIndex = 4;
            this.StartButton.TabStop = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SivtsevInstrTextBox);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 366);
            this.panel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // SivtsevInstrTextBox
            // 
            this.SivtsevInstrTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SivtsevInstrTextBox.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SivtsevInstrTextBox.Location = new System.Drawing.Point(17, 28);
            this.SivtsevInstrTextBox.Name = "SivtsevInstrTextBox";
            this.SivtsevInstrTextBox.Size = new System.Drawing.Size(380, 290);
            this.SivtsevInstrTextBox.TabIndex = 1;
            this.SivtsevInstrTextBox.Text = "Инструкция\nС другой стороны реализация намеченных плановых заданий представляет с" +
    "обой интересный эксперимент проверки соответствующий условий активизации. ";
            // 
            // SivtsevCheckingPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 601);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.BackFromSivtsevButton);
            this.Controls.Add(this.panel2);
            this.Name = "SivtsevCheckingPro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LetterPictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerSivtsevButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartButton)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox LetterPictureBox;
        private CircularProgressBar.CircularProgressBar SivtsevTimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private RoundButtonTwo.MyRoundButton AnswerSivtsevButton;
        private rbutton.CustRoundButton BackFromSivtsevButton;
        private System.Windows.Forms.Timer timer1;
        private RoundButtonTwo.MyRoundButton StartButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox SivtsevInstrTextBox;
    }
}