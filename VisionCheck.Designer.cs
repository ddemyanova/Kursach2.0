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
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.LandoltModeButton = new CustomButton.ImageCustomButton();
            this.SivtsevModeButton = new CustomButton.ImageCustomButton();
            this.BackFromVChButton = new rbutton.CustRoundButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LandoltModeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SivtsevModeButton)).BeginInit();
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
            this.VisionCheckLabel.Size = new System.Drawing.Size(209, 48);
            this.VisionCheckLabel.TabIndex = 0;
            this.VisionCheckLabel.Text = "Lets Start";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BackFromVChButton);
            this.panel2.Controls.Add(this.SivtsevModeButton);
            this.panel2.Controls.Add(this.LandoltModeButton);
            this.panel2.Controls.Add(this.InstructionLabel);
            this.panel2.Location = new System.Drawing.Point(8, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1116, 479);
            this.panel2.TabIndex = 1;
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel.Location = new System.Drawing.Point(31, 25);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(124, 21);
            this.InstructionLabel.TabIndex = 0;
            this.InstructionLabel.Text = "INSTRUCTION";
            // 
            // LandoltModeButton
            // 
            this.LandoltModeButton.ImageHover = ((System.Drawing.Image)(resources.GetObject("LandoltModeButton.ImageHover")));
            this.LandoltModeButton.ImageNormal = ((System.Drawing.Image)(resources.GetObject("LandoltModeButton.ImageNormal")));
            this.LandoltModeButton.Location = new System.Drawing.Point(417, 175);
            this.LandoltModeButton.Name = "LandoltModeButton";
            this.LandoltModeButton.Size = new System.Drawing.Size(530, 175);
            this.LandoltModeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LandoltModeButton.TabIndex = 1;
            this.LandoltModeButton.TabStop = false;
            // 
            // SivtsevModeButton
            // 
            this.SivtsevModeButton.ImageHover = ((System.Drawing.Image)(resources.GetObject("SivtsevModeButton.ImageHover")));
            this.SivtsevModeButton.ImageNormal = ((System.Drawing.Image)(resources.GetObject("SivtsevModeButton.ImageNormal")));
            this.SivtsevModeButton.Location = new System.Drawing.Point(182, 175);
            this.SivtsevModeButton.Name = "SivtsevModeButton";
            this.SivtsevModeButton.Size = new System.Drawing.Size(403, 175);
            this.SivtsevModeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SivtsevModeButton.TabIndex = 1;
            this.SivtsevModeButton.TabStop = false;
            // 
            // BackFromVChButton
            // 
            this.BackFromVChButton.ImageHover = null;
            this.BackFromVChButton.ImageNormal = null;
            this.BackFromVChButton.Location = new System.Drawing.Point(445, 385);
            this.BackFromVChButton.Name = "BackFromVChButton";
            this.BackFromVChButton.Size = new System.Drawing.Size(283, 72);
            this.BackFromVChButton.TabIndex = 2;
            this.BackFromVChButton.Text = "custRoundButton1";
            this.BackFromVChButton.UseVisualStyleBackColor = true;
            this.BackFromVChButton.Click += new System.EventHandler(this.BackFromVChButton_Click);
            // 
            // VisionCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VisionCheck";
            this.Text = "VisionCheck";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LandoltModeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SivtsevModeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VisionCheckLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label InstructionLabel;
        private CustomButton.ImageCustomButton SivtsevModeButton;
        private CustomButton.ImageCustomButton LandoltModeButton;
        private rbutton.CustRoundButton BackFromVChButton;
    }
}