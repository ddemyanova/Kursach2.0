namespace GoodVision
{
    partial class VisionCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisionCheck));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VisionCheckLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BackToMenuButton = new rbutton.CustRoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.SivtsevModeButton = new TetraCustomButton.ImageTetraButton();
            this.LandoltModeButton = new TetraCustomButton.ImageTetraButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SivtsevModeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LandoltModeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VisionCheckLabel);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 69);
            this.panel1.TabIndex = 0;
            // 
            // VisionCheckLabel
            // 
            this.VisionCheckLabel.AutoSize = true;
            this.VisionCheckLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisionCheckLabel.Location = new System.Drawing.Point(447, 11);
            this.VisionCheckLabel.Name = "VisionCheckLabel";
            this.VisionCheckLabel.Size = new System.Drawing.Size(214, 50);
            this.VisionCheckLabel.TabIndex = 0;
            this.VisionCheckLabel.Text = "Lets Start";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SivtsevModeButton);
            this.panel2.Controls.Add(this.LandoltModeButton);
            this.panel2.Controls.Add(this.BackToMenuButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.InstructionLabel);
            this.panel2.Location = new System.Drawing.Point(8, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1116, 479);
            this.panel2.TabIndex = 1;
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.ImageHover = null;
            this.BackToMenuButton.ImageNormal = null;
            this.BackToMenuButton.Location = new System.Drawing.Point(0, 336);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(209, 140);
            this.BackToMenuButton.TabIndex = 2;
            this.BackToMenuButton.Text = "custRoundButton1";
            this.BackToMenuButton.UseVisualStyleBackColor = true;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ONE MORE INSTRUCTION";
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel.Location = new System.Drawing.Point(23, 22);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(124, 21);
            this.InstructionLabel.TabIndex = 0;
            this.InstructionLabel.Text = "INSTRUCTION";
            // 
            // SivtsevModeButton
            // 
            this.SivtsevModeButton.Image = ((System.Drawing.Image)(resources.GetObject("SivtsevModeButton.Image")));
            this.SivtsevModeButton.ImageHover = null;
            this.SivtsevModeButton.ImageNormal = global::GoodVision.Properties.Resources.depositphotos_186382688_stock_illustration_eye_test_chart_vector_rings;
            this.SivtsevModeButton.Location = new System.Drawing.Point(495, 130);
            this.SivtsevModeButton.Name = "SivtsevModeButton";
            this.SivtsevModeButton.Size = new System.Drawing.Size(287, 200);
            this.SivtsevModeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SivtsevModeButton.TabIndex = 4;
            this.SivtsevModeButton.TabStop = false;
            this.SivtsevModeButton.Click += new System.EventHandler(this.SivtsevModeButton_Click);
            // 
            // LandoltModeButton
            // 
            this.LandoltModeButton.Image = ((System.Drawing.Image)(resources.GetObject("LandoltModeButton.Image")));
            this.LandoltModeButton.ImageHover = null;
            this.LandoltModeButton.ImageNormal = ((System.Drawing.Image)(resources.GetObject("LandoltModeButton.ImageNormal")));
            this.LandoltModeButton.Location = new System.Drawing.Point(205, 132);
            this.LandoltModeButton.Name = "LandoltModeButton";
            this.LandoltModeButton.Size = new System.Drawing.Size(284, 198);
            this.LandoltModeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LandoltModeButton.TabIndex = 3;
            this.LandoltModeButton.TabStop = false;
            this.LandoltModeButton.Click += new System.EventHandler(this.LandoltModeButton_Click_1);
            // 
            // VisionCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VisionCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisionCheck";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SivtsevModeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LandoltModeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VisionCheckLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label InstructionLabel;
     //   private ImageTetraButton.ImageCustomButton SivtsevModeButton;
       // private ImageTetraButton.ImageCustomButton LandoltModeButton;
    //    private rbutton.CustRoundButton BackFromVChButton;
        private System.Windows.Forms.Label label1;
        private rbutton.CustRoundButton BackToMenuButton;
        private TetraCustomButton.ImageTetraButton LandoltModeButton;
        private TetraCustomButton.ImageTetraButton SivtsevModeButton;
    }
}