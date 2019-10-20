namespace GoodVision
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StatisticButton = new RoundButtonTwo.MyRoundButton();
            this.CheckVisionButton = new RoundButtonTwo.MyRoundButton();
            this.HelpButton = new rbutton.CustRoundButton();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckVisionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HelloLabel);
            this.panel1.Location = new System.Drawing.Point(171, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 106);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.StatisticButton);
            this.panel2.Controls.Add(this.CheckVisionButton);
            this.panel2.Location = new System.Drawing.Point(335, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 239);
            this.panel2.TabIndex = 1;
            // 
            // StatisticButton
            // 
            this.StatisticButton.ImageHover = null;
            this.StatisticButton.ImageNormal = null;
            this.StatisticButton.Location = new System.Drawing.Point(41, 23);
            this.StatisticButton.Name = "StatisticButton";
            this.StatisticButton.Size = new System.Drawing.Size(542, 82);
            this.StatisticButton.TabIndex = 0;
            this.StatisticButton.TabStop = false;
            this.StatisticButton.Click += new System.EventHandler(this.StatisticButton_Click);
            // 
            // CheckVisionButton
            // 
            this.CheckVisionButton.ImageHover = null;
            this.CheckVisionButton.ImageNormal = null;
            this.CheckVisionButton.Location = new System.Drawing.Point(41, 128);
            this.CheckVisionButton.Name = "CheckVisionButton";
            this.CheckVisionButton.Size = new System.Drawing.Size(542, 82);
            this.CheckVisionButton.TabIndex = 0;
            this.CheckVisionButton.TabStop = false;
            this.CheckVisionButton.Click += new System.EventHandler(this.CheckVisionButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpButton.Image")));
            this.HelpButton.ImageHover = null;
            this.HelpButton.ImageNormal = null;
            this.HelpButton.Location = new System.Drawing.Point(1022, 409);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(112, 119);
            this.HelpButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HelpButton.TabIndex = 2;
            this.HelpButton.TabStop = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLabel.Location = new System.Drawing.Point(30, 11);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(237, 83);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "Hello,";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 571);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StatisticButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckVisionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RoundButtonTwo.MyRoundButton CheckVisionButton;
        private rbutton.CustRoundButton HelpButton;
        private RoundButtonTwo.MyRoundButton StatisticButton;
        private System.Windows.Forms.Label HelloLabel;
    }
}