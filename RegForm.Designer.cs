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
            this.label2 = new System.Windows.Forms.Label();
            this.RegButton = new RoundButtonTwo.MyRoundButton();
            this.WellcomePanel.SuspendLayout();
            this.RegPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegButton)).BeginInit();
            this.SuspendLayout();
            // 
            // WellcomePanel
            // 
            this.WellcomePanel.Controls.Add(this.WellcLabel);
            this.WellcomePanel.Location = new System.Drawing.Point(164, 52);
            this.WellcomePanel.Name = "WellcomePanel";
            this.WellcomePanel.Size = new System.Drawing.Size(835, 119);
            this.WellcomePanel.TabIndex = 0;
            // 
            // WellcLabel
            // 
            this.WellcLabel.AutoSize = true;
            this.WellcLabel.Font = new System.Drawing.Font("Modern No. 20", 55.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WellcLabel.Location = new System.Drawing.Point(201, 13);
            this.WellcLabel.Name = "WellcLabel";
            this.WellcLabel.Size = new System.Drawing.Size(412, 95);
            this.WellcLabel.TabIndex = 0;
            this.WellcLabel.Text = "Wellcome";
            // 
            // RegPanel
            // 
            this.RegPanel.Controls.Add(this.RegistTextBox);
            this.RegPanel.Location = new System.Drawing.Point(164, 261);
            this.RegPanel.Name = "RegPanel";
            this.RegPanel.Size = new System.Drawing.Size(835, 132);
            this.RegPanel.TabIndex = 1;
            // 
            // RegistTextBox
            // 
            this.RegistTextBox.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistTextBox.Location = new System.Drawing.Point(126, 49);
            this.RegistTextBox.Name = "RegistTextBox";
            this.RegistTextBox.Size = new System.Drawing.Size(625, 36);
            this.RegistTextBox.TabIndex = 0;
            this.RegistTextBox.TextChanged += new System.EventHandler(this.RegistTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your name";
            // 
            // RegButton
            // 
            this.RegButton.Image = ((System.Drawing.Image)(resources.GetObject("RegButton.Image")));
            this.RegButton.ImageHover = null;
            this.RegButton.ImageNormal = global::GoodVision.Properties.Resources.desktop_3246124__340;
            this.RegButton.Location = new System.Drawing.Point(328, 423);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(518, 85);
            this.RegButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RegButton.TabIndex = 3;
            this.RegButton.TabStop = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // RegForm
            // 
            this.ClientSize = new System.Drawing.Size(1131, 543);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegPanel);
            this.Controls.Add(this.WellcomePanel);
            this.Name = "RegForm";
            this.WellcomePanel.ResumeLayout(false);
            this.WellcomePanel.PerformLayout();
            this.RegPanel.ResumeLayout(false);
            this.RegPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButtonTwo.MyRoundButton ButtonReg;
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
        private RoundButtonTwo.MyRoundButton RegButton;
    }
}

