namespace GoodVision
{
    partial class RegForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.WellcomePanel = new System.Windows.Forms.Panel();
            this.WellcLabel = new System.Windows.Forms.Label();
            this.RegPanel = new System.Windows.Forms.Panel();
            this.RegistTextBox = new System.Windows.Forms.TextBox();
            this.RegButton = new ButtonRoundedCorners.RoundedCorners();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WellcomePanel.SuspendLayout();
            this.RegPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WellcomePanel
            // 
            this.WellcomePanel.BackColor = System.Drawing.Color.Transparent;
            this.WellcomePanel.BackgroundImage = global::GoodVision.Properties.Resources.подложка;
            this.WellcomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WellcomePanel.Controls.Add(this.WellcLabel);
            this.WellcomePanel.Location = new System.Drawing.Point(12, 12);
            this.WellcomePanel.Name = "WellcomePanel";
            this.WellcomePanel.Size = new System.Drawing.Size(1116, 172);
            this.WellcomePanel.TabIndex = 0;
            // 
            // WellcLabel
            // 
            this.WellcLabel.AutoSize = true;
            this.WellcLabel.Font = new System.Drawing.Font("Aqum", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WellcLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.WellcLabel.Location = new System.Drawing.Point(235, 50);
            this.WellcLabel.Name = "WellcLabel";
            this.WellcLabel.Size = new System.Drawing.Size(723, 70);
            this.WellcLabel.TabIndex = 0;
            this.WellcLabel.Text = "Ласкаво просимо";
            // 
            // RegPanel
            // 
            this.RegPanel.BackColor = System.Drawing.Color.Transparent;
            this.RegPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegPanel.BackgroundImage")));
            this.RegPanel.Controls.Add(this.RegistTextBox);
            this.RegPanel.Controls.Add(this.RegButton);
            this.RegPanel.Controls.Add(this.label2);
            this.RegPanel.Location = new System.Drawing.Point(247, 238);
            this.RegPanel.Name = "RegPanel";
            this.RegPanel.Size = new System.Drawing.Size(700, 315);
            this.RegPanel.TabIndex = 1;
            // 
            // RegistTextBox
            // 
            this.RegistTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.RegistTextBox.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistTextBox.Location = new System.Drawing.Point(31, 103);
            this.RegistTextBox.Name = "RegistTextBox";
            this.RegistTextBox.Size = new System.Drawing.Size(636, 36);
            this.RegistTextBox.TabIndex = 0;
            this.RegistTextBox.TextChanged += new System.EventHandler(this.RegistTextBox_TextChanged);
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.Coral;
            this.RegButton.Image = global::GoodVision.Properties.Resources.війти;
            this.RegButton.ImageHover = global::GoodVision.Properties.Resources.війтиHover;
            this.RegButton.ImageNormal = global::GoodVision.Properties.Resources.війти;
            this.RegButton.Location = new System.Drawing.Point(31, 210);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(636, 91);
            this.RegButton.TabIndex = 3;
            this.RegButton.TabStop = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("a_AvanteInt", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "введiть своє ім\'я";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoodVision.Properties.Resources.iconSmall1;
            this.pictureBox1.Location = new System.Drawing.Point(1045, 507);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // RegForm
            // 
            this.BackgroundImage = global::GoodVision.Properties.Resources.Регистр2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1140, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegPanel);
            this.Controls.Add(this.WellcomePanel);
            this.DoubleBuffered = true;
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WellcomePanel.ResumeLayout(false);
            this.WellcomePanel.PerformLayout();
            this.RegPanel.ResumeLayout(false);
            this.RegPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       // private RoundButtonTwo.MyRoundButton ButtonReg;
        private System.Windows.Forms.Panel panelForGreet;
        private System.Windows.Forms.Label WellcomeLabel;
        private System.Windows.Forms.Label EnterNameMess;
        private System.Windows.Forms.TextBox RegTextBox;
        private System.Windows.Forms.Panel EnterNamePanel;
        private System.Windows.Forms.Panel WellcomePanel;
        private System.Windows.Forms.Panel RegPanel;
        private System.Windows.Forms.Label WellcLabel;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox RegistTextBox;
        private ButtonRoundedCorners.RoundedCorners RegButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        // private RoundButtonTwo.MyRoundButton RegButton;
    }
}

