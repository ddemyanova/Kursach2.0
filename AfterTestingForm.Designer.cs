namespace GoodVision
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.VisionCheckButton = new ButtonRoundedCorners.RoundedCorners();
            this.StatistButton = new ButtonRoundedCorners.RoundedCorners();
            this.BackToMenuButton = new rbutton.CustRoundButton();
            this.RightEyeRes = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LeftEyeRes = new System.Windows.Forms.Label();
            this.RightEyeLabel = new System.Windows.Forms.Label();
            this.LeftEyeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisionCheckButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatistButton)).BeginInit();
            this.RightEyeRes.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GoodVision.Properties.Resources.подложка;
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(82, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 88);
            this.panel1.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Uighur", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(409, 14);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(197, 63);
            this.Title.TabIndex = 0;
            this.Title.Text = "Your Results";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::GoodVision.Properties.Resources.gjlkj_rf2;
            this.panel2.Controls.Add(this.VisionCheckButton);
            this.panel2.Controls.Add(this.StatistButton);
            this.panel2.Location = new System.Drawing.Point(241, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 279);
            this.panel2.TabIndex = 1;
            // 
            // VisionCheckButton
            // 
            this.VisionCheckButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.VisionCheckButton.ImageHover = null;
            this.VisionCheckButton.ImageNormal = null;
            this.VisionCheckButton.Location = new System.Drawing.Point(46, 146);
            this.VisionCheckButton.Name = "VisionCheckButton";
            this.VisionCheckButton.Size = new System.Drawing.Size(594, 95);
            this.VisionCheckButton.TabIndex = 3;
            this.VisionCheckButton.TabStop = false;
            this.VisionCheckButton.Click += new System.EventHandler(this.VisionCheckButton_Click);
            // 
            // StatistButton
            // 
            this.StatistButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StatistButton.BackgroundImage = global::GoodVision.Properties.Resources.стат;
            this.StatistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StatistButton.ImageHover = null;
            this.StatistButton.ImageNormal = null;
            this.StatistButton.Location = new System.Drawing.Point(46, 30);
            this.StatistButton.Name = "StatistButton";
            this.StatistButton.Size = new System.Drawing.Size(594, 92);
            this.StatistButton.TabIndex = 2;
            this.StatistButton.TabStop = false;
            this.StatistButton.Click += new System.EventHandler(this.StatistButton_Click);
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.Image = global::GoodVision.Properties.Resources._13;
            this.BackToMenuButton.ImageHover = global::GoodVision.Properties.Resources._13Hover;
            this.BackToMenuButton.ImageNormal = global::GoodVision.Properties.Resources._13;
            this.BackToMenuButton.Location = new System.Drawing.Point(17, 411);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(218, 163);
            this.BackToMenuButton.TabIndex = 0;
            // 
            // RightEyeRes
            // 
            this.RightEyeRes.Controls.Add(this.label5);
            this.RightEyeRes.Location = new System.Drawing.Point(674, 218);
            this.RightEyeRes.Name = "RightEyeRes";
            this.RightEyeRes.Size = new System.Drawing.Size(207, 51);
            this.RightEyeRes.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LeftEyeRes);
            this.panel3.Location = new System.Drawing.Point(287, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 51);
            this.panel3.TabIndex = 1;
            // 
            // LeftEyeRes
            // 
            this.LeftEyeRes.AutoSize = true;
            this.LeftEyeRes.Location = new System.Drawing.Point(14, 19);
            this.LeftEyeRes.Name = "LeftEyeRes";
            this.LeftEyeRes.Size = new System.Drawing.Size(46, 17);
            this.LeftEyeRes.TabIndex = 0;
            this.LeftEyeRes.Text = "label1";
            // 
            // RightEyeLabel
            // 
            this.RightEyeLabel.AutoSize = true;
            this.RightEyeLabel.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightEyeLabel.Location = new System.Drawing.Point(788, 165);
            this.RightEyeLabel.Name = "RightEyeLabel";
            this.RightEyeLabel.Size = new System.Drawing.Size(93, 37);
            this.RightEyeLabel.TabIndex = 0;
            this.RightEyeLabel.Text = "Right Eye";
            // 
            // LeftEyeLabel
            // 
            this.LeftEyeLabel.AutoSize = true;
            this.LeftEyeLabel.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftEyeLabel.Location = new System.Drawing.Point(281, 168);
            this.LeftEyeLabel.Name = "LeftEyeLabel";
            this.LeftEyeLabel.Size = new System.Drawing.Size(85, 34);
            this.LeftEyeLabel.TabIndex = 0;
            this.LeftEyeLabel.Text = "Left Eye";
            // 
            // AfterTestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GoodVision.Properties.Resources.Регистр2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 601);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RightEyeRes);
            this.Controls.Add(this.LeftEyeLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackToMenuButton);
            this.Controls.Add(this.RightEyeLabel);
            this.DoubleBuffered = true;
            this.Name = "AfterTestingForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VisionCheckButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatistButton)).EndInit();
            this.RightEyeRes.ResumeLayout(false);
            this.RightEyeRes.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label RightEyeLabel;
        private System.Windows.Forms.Label LeftEyeLabel;
        private System.Windows.Forms.Panel RightEyeRes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LeftEyeRes;
  //      private RoundButtonTwo.MyRoundButton StatisticButton;
  //      private RoundButtonTwo.MyRoundButton VisionCheckButton;
        private rbutton.CustRoundButton BackToMenuButton;
        private ButtonRoundedCorners.RoundedCorners StatistButton;
        private ButtonRoundedCorners.RoundedCorners VisionCheckButton;
        //  private rbutton.CustRoundButton BackToMenuButton;
    }
}