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
            this.BackToMenuButton = new rbutton.CustRoundButton();
            this.StatisticButton = new RoundButtonTwo.MyRoundButton();
            this.VisionCheckButton = new RoundButtonTwo.MyRoundButton();
            this.RightEyeRes = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LeftEyeRes = new System.Windows.Forms.Label();
            this.RightEyeLabel = new System.Windows.Forms.Label();
            this.LeftEyeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisionCheckButton)).BeginInit();
            this.RightEyeRes.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(82, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 64);
            this.panel1.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Uighur", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(375, 1);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(197, 63);
            this.Title.TabIndex = 0;
            this.Title.Text = "Your Results";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BackToMenuButton);
            this.panel2.Controls.Add(this.StatisticButton);
            this.panel2.Controls.Add(this.VisionCheckButton);
            this.panel2.Controls.Add(this.RightEyeRes);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.RightEyeLabel);
            this.panel2.Controls.Add(this.LeftEyeLabel);
            this.panel2.Location = new System.Drawing.Point(12, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 412);
            this.panel2.TabIndex = 1;
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.ImageHover = null;
            this.BackToMenuButton.ImageNormal = null;
            this.BackToMenuButton.Location = new System.Drawing.Point(18, 261);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(146, 139);
            this.BackToMenuButton.TabIndex = 4;
            this.BackToMenuButton.Text = "custRoundButton1";
            this.BackToMenuButton.UseVisualStyleBackColor = true;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // StatisticButton
            // 
            this.StatisticButton.Image = global::GoodVision.Properties.Resources.desktop_3246124__340;
            this.StatisticButton.ImageHover = null;
            this.StatisticButton.ImageNormal = null;
            this.StatisticButton.Location = new System.Drawing.Point(243, 261);
            this.StatisticButton.Name = "StatisticButton";
            this.StatisticButton.Size = new System.Drawing.Size(599, 96);
            this.StatisticButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StatisticButton.TabIndex = 3;
            this.StatisticButton.TabStop = false;
            this.StatisticButton.Click += new System.EventHandler(this.StatisticButton_Click);
            // 
            // VisionCheckButton
            // 
            this.VisionCheckButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.VisionCheckButton.Image = global::GoodVision.Properties.Resources.desktop_3246124__340;
            this.VisionCheckButton.ImageHover = null;
            this.VisionCheckButton.ImageNormal = null;
            this.VisionCheckButton.Location = new System.Drawing.Point(243, 142);
            this.VisionCheckButton.Name = "VisionCheckButton";
            this.VisionCheckButton.Size = new System.Drawing.Size(599, 91);
            this.VisionCheckButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VisionCheckButton.TabIndex = 2;
            this.VisionCheckButton.TabStop = false;
            this.VisionCheckButton.Click += new System.EventHandler(this.VisionCheckButton_Click);
            // 
            // RightEyeRes
            // 
            this.RightEyeRes.Controls.Add(this.label5);
            this.RightEyeRes.Location = new System.Drawing.Point(616, 67);
            this.RightEyeRes.Name = "RightEyeRes";
            this.RightEyeRes.Size = new System.Drawing.Size(207, 51);
            this.RightEyeRes.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LeftEyeRes);
            this.panel3.Location = new System.Drawing.Point(301, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 51);
            this.panel3.TabIndex = 1;
            // 
            // LeftEyeRes
            // 
            this.LeftEyeRes.AutoSize = true;
            this.LeftEyeRes.Location = new System.Drawing.Point(77, 19);
            this.LeftEyeRes.Name = "LeftEyeRes";
            this.LeftEyeRes.Size = new System.Drawing.Size(46, 17);
            this.LeftEyeRes.TabIndex = 0;
            this.LeftEyeRes.Text = "label1";
            // 
            // RightEyeLabel
            // 
            this.RightEyeLabel.AutoSize = true;
            this.RightEyeLabel.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightEyeLabel.Location = new System.Drawing.Point(669, 30);
            this.RightEyeLabel.Name = "RightEyeLabel";
            this.RightEyeLabel.Size = new System.Drawing.Size(93, 37);
            this.RightEyeLabel.TabIndex = 0;
            this.RightEyeLabel.Text = "Right Eye";
            // 
            // LeftEyeLabel
            // 
            this.LeftEyeLabel.AutoSize = true;
            this.LeftEyeLabel.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftEyeLabel.Location = new System.Drawing.Point(354, 30);
            this.LeftEyeLabel.Name = "LeftEyeLabel";
            this.LeftEyeLabel.Size = new System.Drawing.Size(85, 34);
            this.LeftEyeLabel.TabIndex = 0;
            this.LeftEyeLabel.Text = "Left Eye";
            // 
            // AfterTestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AfterTestingForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisionCheckButton)).EndInit();
            this.RightEyeRes.ResumeLayout(false);
            this.RightEyeRes.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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
        private RoundButtonTwo.MyRoundButton StatisticButton;
        private RoundButtonTwo.MyRoundButton VisionCheckButton;
        private rbutton.CustRoundButton BackToMenuButton;
        //  private rbutton.CustRoundButton BackToMenuButton;
    }
}