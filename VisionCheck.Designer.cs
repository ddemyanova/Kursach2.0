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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisionCheck));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VisionCheckLabel = new System.Windows.Forms.Label();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sivtsevTip = new System.Windows.Forms.ToolTip(this.components);
            this.SivtsevModeButton = new TetraCustomButton.ImageTetraButton();
            this.LandoltTip = new System.Windows.Forms.ToolTip(this.components);
            this.LandoltModeButton = new TetraCustomButton.ImageTetraButton();
            this.BackToMenuButton = new rbutton.CustRoundButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SivtsevModeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LandoltModeButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GoodVision.Properties.Resources.BlueBack1;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.VisionCheckLabel);
            this.panel1.Controls.Add(this.InstructionLabel);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 416);
            this.panel1.TabIndex = 0;
            // 
            // VisionCheckLabel
            // 
            this.VisionCheckLabel.AutoSize = true;
            this.VisionCheckLabel.BackColor = System.Drawing.Color.Transparent;
            this.VisionCheckLabel.Font = new System.Drawing.Font("a_AvanteInt", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisionCheckLabel.Location = new System.Drawing.Point(442, 30);
            this.VisionCheckLabel.Name = "VisionCheckLabel";
            this.VisionCheckLabel.Size = new System.Drawing.Size(307, 69);
            this.VisionCheckLabel.TabIndex = 0;
            this.VisionCheckLabel.Text = "Почнемо!";
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.BackColor = System.Drawing.Color.Transparent;
            this.InstructionLabel.Font = new System.Drawing.Font("a_AvanteInt", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstructionLabel.Location = new System.Drawing.Point(138, 113);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(885, 35);
            this.InstructionLabel.TabIndex = 0;
            this.InstructionLabel.Text = "Для початку тестування вам необхідно обрати його формат.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1054, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sivtsevTip
            // 
            this.sivtsevTip.IsBalloon = true;
            // 
            // SivtsevModeButton
            // 
            this.SivtsevModeButton.Image = global::GoodVision.Properties.Resources.SivtsevHover;
            this.SivtsevModeButton.ImageHover = global::GoodVision.Properties.Resources.civtsev;
            this.SivtsevModeButton.ImageNormal = global::GoodVision.Properties.Resources.SivtsevHover;
            this.SivtsevModeButton.Location = new System.Drawing.Point(612, 330);
            this.SivtsevModeButton.Name = "SivtsevModeButton";
            this.SivtsevModeButton.Size = new System.Drawing.Size(346, 241);
            this.SivtsevModeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SivtsevModeButton.TabIndex = 4;
            this.SivtsevModeButton.TabStop = false;
            this.sivtsevTip.SetToolTip(this.SivtsevModeButton, "Тестування за допомоги таблиці Сивцева");
            this.SivtsevModeButton.Click += new System.EventHandler(this.SivtsevModeButton_Click);
            // 
            // LandoltTip
            // 
            this.LandoltTip.IsBalloon = true;
            // 
            // LandoltModeButton
            // 
            this.LandoltModeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LandoltModeButton.Image = ((System.Drawing.Image)(resources.GetObject("LandoltModeButton.Image")));
            this.LandoltModeButton.ImageHover = global::GoodVision.Properties.Resources.LandoltHover;
            this.LandoltModeButton.ImageNormal = ((System.Drawing.Image)(resources.GetObject("LandoltModeButton.ImageNormal")));
            this.LandoltModeButton.Location = new System.Drawing.Point(253, 330);
            this.LandoltModeButton.Name = "LandoltModeButton";
            this.LandoltModeButton.Size = new System.Drawing.Size(327, 241);
            this.LandoltModeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LandoltModeButton.TabIndex = 3;
            this.LandoltModeButton.TabStop = false;
            this.LandoltTip.SetToolTip(this.LandoltModeButton, "Тестування за допомоги кілець Ландольта");
            this.LandoltModeButton.Click += new System.EventHandler(this.LandoltModeButton_Click_1);
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackToMenuButton.ForeColor = System.Drawing.Color.Transparent;
            this.BackToMenuButton.Image = global::GoodVision.Properties.Resources._13;
            this.BackToMenuButton.ImageHover = global::GoodVision.Properties.Resources._13Hover;
            this.BackToMenuButton.ImageNormal = global::GoodVision.Properties.Resources._13;
            this.BackToMenuButton.Location = new System.Drawing.Point(12, 460);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(218, 163);
            this.BackToMenuButton.TabIndex = 2;
            this.BackToMenuButton.UseVisualStyleBackColor = true;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("a_AvanteInt", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(281, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(648, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Щоб обрати формат тестування клікніть на зображення.";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::GoodVision.Properties.Resources.подложка2;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 127);
            this.panel2.TabIndex = 2;
            // 
            // VisionCheck
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::GoodVision.Properties.Resources.Регистр2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1126, 635);
            this.Controls.Add(this.LandoltModeButton);
            this.Controls.Add(this.SivtsevModeButton);
            this.Controls.Add(this.BackToMenuButton);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "VisionCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisionCheck";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SivtsevModeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LandoltModeButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VisionCheckLabel;
        private System.Windows.Forms.Label InstructionLabel;
     //   private ImageTetraButton.ImageCustomButton SivtsevModeButton;
       // private ImageTetraButton.ImageCustomButton LandoltModeButton;
    //    private rbutton.CustRoundButton BackFromVChButton;
        private System.Windows.Forms.Label label1;
        private rbutton.CustRoundButton BackToMenuButton;
        private TetraCustomButton.ImageTetraButton LandoltModeButton;
        private TetraCustomButton.ImageTetraButton SivtsevModeButton;
        private System.Windows.Forms.ToolTip sivtsevTip;
        private System.Windows.Forms.ToolTip LandoltTip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}