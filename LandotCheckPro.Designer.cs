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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RightLandotButton = new RoundButtonTwo.MyRoundButton();
            this.UpLandotButton = new RoundButtonTwo.MyRoundButton();
            this.LeftLandotButton = new RoundButtonTwo.MyRoundButton();
            this.DownLandotButton = new RoundButtonTwo.MyRoundButton();
            this.LandotTimer = new CircularProgressBar.CircularProgressBar();
            this.LandotCirclePictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LandotInstructTextBox = new System.Windows.Forms.RichTextBox();
            this.LTimer = new System.Windows.Forms.Timer(this.components);
            this.BackToVisionCheckButton = new rbutton.CustRoundButton();
            this.GoLandotButton = new RoundButtonTwo.MyRoundButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightLandotButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpLandotButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftLandotButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownLandotButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LandotCirclePictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoLandotButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RightLandotButton);
            this.panel1.Controls.Add(this.UpLandotButton);
            this.panel1.Controls.Add(this.LeftLandotButton);
            this.panel1.Controls.Add(this.DownLandotButton);
            this.panel1.Controls.Add(this.LandotTimer);
            this.panel1.Controls.Add(this.LandotCirclePictureBox);
            this.panel1.Location = new System.Drawing.Point(408, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 552);
            this.panel1.TabIndex = 0;
            // 
            // RightLandotButton
            // 
            this.RightLandotButton.ImageHover = null;
            this.RightLandotButton.ImageNormal = null;
            this.RightLandotButton.Location = new System.Drawing.Point(506, 173);
            this.RightLandotButton.Name = "RightLandotButton";
            this.RightLandotButton.Size = new System.Drawing.Size(135, 212);
            this.RightLandotButton.TabIndex = 6;
            this.RightLandotButton.TabStop = false;
            this.RightLandotButton.Click += new System.EventHandler(this.RightLandotButton_Click);
            // 
            // UpLandotButton
            // 
            this.UpLandotButton.ImageHover = null;
            this.UpLandotButton.ImageNormal = null;
            this.UpLandotButton.Location = new System.Drawing.Point(261, 23);
            this.UpLandotButton.Name = "UpLandotButton";
            this.UpLandotButton.Size = new System.Drawing.Size(224, 117);
            this.UpLandotButton.TabIndex = 5;
            this.UpLandotButton.TabStop = false;
            this.UpLandotButton.Click += new System.EventHandler(this.UpLandotButton_Click);
            // 
            // LeftLandotButton
            // 
            this.LeftLandotButton.ImageHover = null;
            this.LeftLandotButton.ImageNormal = null;
            this.LeftLandotButton.Location = new System.Drawing.Point(92, 173);
            this.LeftLandotButton.Name = "LeftLandotButton";
            this.LeftLandotButton.Size = new System.Drawing.Size(139, 212);
            this.LeftLandotButton.TabIndex = 4;
            this.LeftLandotButton.TabStop = false;
            this.LeftLandotButton.Click += new System.EventHandler(this.LeftLandotButton_Click);
            // 
            // DownLandotButton
            // 
            this.DownLandotButton.Image = ((System.Drawing.Image)(resources.GetObject("DownLandotButton.Image")));
            this.DownLandotButton.ImageHover = null;
            this.DownLandotButton.ImageNormal = null;
            this.DownLandotButton.Location = new System.Drawing.Point(260, 401);
            this.DownLandotButton.Name = "DownLandotButton";
            this.DownLandotButton.Size = new System.Drawing.Size(235, 116);
            this.DownLandotButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DownLandotButton.TabIndex = 3;
            this.DownLandotButton.TabStop = false;
            this.DownLandotButton.Click += new System.EventHandler(this.DownLandotButton_Click);
            // 
            // LandotTimer
            // 
            this.LandotTimer.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("LandotTimer.AnimationFunction")));
            this.LandotTimer.AnimationSpeed = 500;
            this.LandotTimer.BackColor = System.Drawing.Color.White;
            this.LandotTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.LandotTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LandotTimer.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LandotTimer.InnerMargin = 2;
            this.LandotTimer.InnerWidth = -1;
            this.LandotTimer.Location = new System.Drawing.Point(27, 12);
            this.LandotTimer.MarqueeAnimationSpeed = 2000;
            this.LandotTimer.Maximum = 50;
            this.LandotTimer.Name = "LandotTimer";
            this.LandotTimer.OuterColor = System.Drawing.Color.Gray;
            this.LandotTimer.OuterMargin = -20;
            this.LandotTimer.OuterWidth = 20;
            this.LandotTimer.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            this.LandotTimer.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LandotTimer.Value = 50;
            // 
            // LandotCirclePictureBox
            // 
            this.LandotCirclePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LandotCirclePictureBox.Image")));
            this.LandotCirclePictureBox.Location = new System.Drawing.Point(260, 173);
            this.LandotCirclePictureBox.Name = "LandotCirclePictureBox";
            this.LandotCirclePictureBox.Size = new System.Drawing.Size(225, 212);
            this.LandotCirclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LandotCirclePictureBox.TabIndex = 0;
            this.LandotCirclePictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LandotInstructTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 375);
            this.panel2.TabIndex = 3;
            // 
            // LandotInstructTextBox
            // 
            this.LandotInstructTextBox.Location = new System.Drawing.Point(18, 23);
            this.LandotInstructTextBox.Name = "LandotInstructTextBox";
            this.LandotInstructTextBox.Size = new System.Drawing.Size(340, 330);
            this.LandotInstructTextBox.TabIndex = 0;
            this.LandotInstructTextBox.Text = "Instuction";
            // 
            // LTimer
            // 
            this.LTimer.Interval = 1000;
            this.LTimer.Tick += new System.EventHandler(this.LTimer_Tick_1);
            // 
            // BackToVisionCheckButton
            // 
            this.BackToVisionCheckButton.ImageHover = null;
            this.BackToVisionCheckButton.ImageNormal = null;
            this.BackToVisionCheckButton.Location = new System.Drawing.Point(29, 413);
            this.BackToVisionCheckButton.Name = "BackToVisionCheckButton";
            this.BackToVisionCheckButton.Size = new System.Drawing.Size(149, 134);
            this.BackToVisionCheckButton.TabIndex = 4;
            this.BackToVisionCheckButton.Text = "custRoundButton1";
            this.BackToVisionCheckButton.UseVisualStyleBackColor = true;
            this.BackToVisionCheckButton.Click += new System.EventHandler(this.BackToVisionCheckButton_Click_1);
            // 
            // GoLandotButton
            // 
            this.GoLandotButton.Image = ((System.Drawing.Image)(resources.GetObject("GoLandotButton.Image")));
            this.GoLandotButton.ImageHover = null;
            this.GoLandotButton.ImageNormal = null;
            this.GoLandotButton.Location = new System.Drawing.Point(221, 413);
            this.GoLandotButton.Name = "GoLandotButton";
            this.GoLandotButton.Size = new System.Drawing.Size(149, 134);
            this.GoLandotButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GoLandotButton.TabIndex = 5;
            this.GoLandotButton.TabStop = false;
            this.GoLandotButton.Click += new System.EventHandler(this.GoLandotButton_Click);
            // 
            // LandotCheckPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 576);
            this.Controls.Add(this.GoLandotButton);
            this.Controls.Add(this.BackToVisionCheckButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LandotCheckPro";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RightLandotButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpLandotButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftLandotButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownLandotButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LandotCirclePictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GoLandotButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
       // private rbutton.CustRoundButton BackToVisionCheckButton;
        private System.Windows.Forms.PictureBox LandotCirclePictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox LandotInstructTextBox;
        private CircularProgressBar.CircularProgressBar LandotTimer;
        private System.Windows.Forms.Timer LTimer;
        private rbutton.CustRoundButton BackToVisionCheckButton;
        private RoundButtonTwo.MyRoundButton RightLandotButton;
        private RoundButtonTwo.MyRoundButton UpLandotButton;
        private RoundButtonTwo.MyRoundButton LeftLandotButton;
        private RoundButtonTwo.MyRoundButton DownLandotButton;
        private RoundButtonTwo.MyRoundButton GoLandotButton;
    }
}