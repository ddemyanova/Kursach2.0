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
            this.panel3 = new System.Windows.Forms.Panel();
            this.HelloLab = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.VisionCheckButton = new RoundButtonTwo.MyRoundButton();
            this.StaticticButton = new RoundButtonTwo.MyRoundButton();
            this.MainMenuHellpButton = new rbutton.CustRoundButton();
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
            this.HelloLab.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLab.Location = new System.Drawing.Point(203, 47);
            this.HelloLab.Name = "HelloLab";
            this.HelloLab.Size = new System.Drawing.Size(98, 34);
            this.HelloLab.TabIndex = 0;
            this.HelloLab.Text = "Hello,";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.VisionCheckButton);
            this.panel4.Controls.Add(this.StaticticButton);
            this.panel4.Location = new System.Drawing.Point(161, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(772, 323);
            this.panel4.TabIndex = 2;
            // 
            // VisionCheckButton
            // 
            this.VisionCheckButton.ImageHover = null;
            this.VisionCheckButton.ImageNormal = null;
            this.VisionCheckButton.Location = new System.Drawing.Point(53, 56);
            this.VisionCheckButton.Name = "VisionCheckButton";
            this.VisionCheckButton.Size = new System.Drawing.Size(685, 76);
            this.VisionCheckButton.TabIndex = 0;
            this.VisionCheckButton.TabStop = false;
            this.VisionCheckButton.Click += new System.EventHandler(this.VisionCheckButton_Click);
            // 
            // StaticticButton
            // 
            this.StaticticButton.ImageHover = null;
            this.StaticticButton.ImageNormal = null;
            this.StaticticButton.Location = new System.Drawing.Point(53, 167);
            this.StaticticButton.Name = "StaticticButton";
            this.StaticticButton.Size = new System.Drawing.Size(685, 76);
            this.StaticticButton.TabIndex = 0;
            this.StaticticButton.TabStop = false;
            this.StaticticButton.Click += new System.EventHandler(this.StaticticButton_Click);
            // 
            // MainMenuHellpButton
            // 
            this.MainMenuHellpButton.ImageHover = null;
            this.MainMenuHellpButton.ImageNormal = null;
            this.MainMenuHellpButton.Location = new System.Drawing.Point(939, 349);
            this.MainMenuHellpButton.Name = "MainMenuHellpButton";
            this.MainMenuHellpButton.Size = new System.Drawing.Size(165, 156);
            this.MainMenuHellpButton.TabIndex = 3;
            this.MainMenuHellpButton.Text = "custRoundButton1";
            this.MainMenuHellpButton.UseVisualStyleBackColor = true;
            this.MainMenuHellpButton.Click += new System.EventHandler(this.MainMenuHellpButton_Click);
            // 
            // MainMenu
            // 
            this.ClientSize = new System.Drawing.Size(1126, 560);
            this.Controls.Add(this.MainMenuHellpButton);
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
        private RoundButtonTwo.MyRoundButton CheckVisionButton;
        private rbutton.CustRoundButton HelpButton;
        private RoundButtonTwo.MyRoundButton StatisticButton;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private RoundButtonTwo.MyRoundButton VisionCheckButton;
        private RoundButtonTwo.MyRoundButton StaticticButton;
        private rbutton.CustRoundButton MainMenuHellpButton;
        public System.Windows.Forms.Label HelloLab;
    }
}