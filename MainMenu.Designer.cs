namespace GoodVision
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.HelloLab = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.custRoundButton1 = new rbutton.CustRoundButton();
            this.HelpButton = new rbutton.CustRoundButton();
            this.VisionCheckButton = new ButtonRoundedCorners.RoundedCorners();
            this.StaticticButton = new ButtonRoundedCorners.RoundedCorners();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisionCheckButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaticticButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.HelloLab);
            this.panel3.Location = new System.Drawing.Point(105, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 134);
            this.panel3.TabIndex = 1;
            // 
            // HelloLab
            // 
            this.HelloLab.AutoSize = true;
            this.HelloLab.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLab.Location = new System.Drawing.Point(237, 22);
            this.HelloLab.Name = "HelloLab";
            this.HelloLab.Size = new System.Drawing.Size(390, 83);
            this.HelloLab.TabIndex = 0;
            this.HelloLab.Text = "Hello, user";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.VisionCheckButton);
            this.panel4.Controls.Add(this.StaticticButton);
            this.panel4.Controls.Add(this.custRoundButton1);
            this.panel4.Location = new System.Drawing.Point(161, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(772, 323);
            this.panel4.TabIndex = 2;
            // 
            // custRoundButton1
            // 
            this.custRoundButton1.ImageHover = null;
            this.custRoundButton1.ImageNormal = null;
            this.custRoundButton1.Location = new System.Drawing.Point(766, 251);
            this.custRoundButton1.Name = "custRoundButton1";
            this.custRoundButton1.Size = new System.Drawing.Size(134, 122);
            this.custRoundButton1.TabIndex = 1;
            this.custRoundButton1.Text = "custRoundButton1";
            this.custRoundButton1.UseVisualStyleBackColor = true;
            // 
            // HelpButton
            // 
            this.HelpButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpButton.Image")));
            this.HelpButton.ImageHover = null;
            this.HelpButton.ImageNormal = null;
            this.HelpButton.Location = new System.Drawing.Point(939, 404);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(145, 144);
            this.HelpButton.TabIndex = 3;
            this.HelpButton.Text = "custRoundButton2";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // VisionCheckButton
            // 
            this.VisionCheckButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.VisionCheckButton.ImageHover = null;
            this.VisionCheckButton.ImageNormal = null;
            this.VisionCheckButton.Location = new System.Drawing.Point(65, 187);
            this.VisionCheckButton.Name = "VisionCheckButton";
            this.VisionCheckButton.Size = new System.Drawing.Size(663, 110);
            this.VisionCheckButton.TabIndex = 3;
            this.VisionCheckButton.TabStop = false;
            this.VisionCheckButton.Click += new System.EventHandler(this.VisionCheckButton_Click);
            // 
            // StaticticButton
            // 
            this.StaticticButton.BackColor = System.Drawing.Color.Coral;
            this.StaticticButton.ImageHover = null;
            this.StaticticButton.ImageNormal = null;
            this.StaticticButton.Location = new System.Drawing.Point(65, 47);
            this.StaticticButton.Name = "StaticticButton";
            this.StaticticButton.Size = new System.Drawing.Size(668, 93);
            this.StaticticButton.TabIndex = 2;
            this.StaticticButton.TabStop = false;
            this.StaticticButton.Click += new System.EventHandler(this.StaticticButton_Click);
            // 
            // MainMenu
            // 
            this.ClientSize = new System.Drawing.Size(1126, 560);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "MainMenu";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VisionCheckButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaticticButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    //    private RoundButtonTwo.MyRoundButton CheckVisionButton;
       // private rbutton.CustRoundButton HelpButton;
   //     private RoundButtonTwo.MyRoundButton StatisticButton;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
      //  private rbutton.CustRoundButton MainMenuHellpButton;
        public System.Windows.Forms.Label HelloLab;
        private rbutton.CustRoundButton custRoundButton1;
        private rbutton.CustRoundButton HelpButton;
        private ButtonRoundedCorners.RoundedCorners VisionCheckButton;
        private ButtonRoundedCorners.RoundedCorners StaticticButton;
        //
    }
}