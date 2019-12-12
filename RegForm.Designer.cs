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
            this.WellcLabel = new System.Windows.Forms.Label();
            this.WellcomePanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RegButton = new ButtonRoundedCorners.RoundedCorners();
            this.RegistTextBox = new System.Windows.Forms.TextBox();
            this.RegPanel = new System.Windows.Forms.Panel();
            this.WellcomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegButton)).BeginInit();
            this.RegPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WellcLabel
            // 
            this.WellcLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WellcLabel.AutoSize = true;
            this.WellcLabel.Font = new System.Drawing.Font("a_AvanteInt", 20.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.WellcLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.WellcLabel.Location = new System.Drawing.Point(250, 29);
            this.WellcLabel.Name = "WellcLabel";
            this.WellcLabel.Size = new System.Drawing.Size(832, 110);
            this.WellcLabel.TabIndex = 0;
            this.WellcLabel.Text = "Ласкаво просимо";
            // 
            // WellcomePanel
            // 
            this.WellcomePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WellcomePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WellcomePanel.BackColor = System.Drawing.Color.Transparent;
            this.WellcomePanel.BackgroundImage = global::GoodVision.Properties.Resources.подложка;
            this.WellcomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WellcomePanel.Controls.Add(this.WellcLabel);
            this.WellcomePanel.Location = new System.Drawing.Point(12, 12);
            this.WellcomePanel.Name = "WellcomePanel";
            this.WellcomePanel.Size = new System.Drawing.Size(1116, 172);
            this.WellcomePanel.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logo.Image = global::GoodVision.Properties.Resources.iconSmall1;
            this.logo.Location = new System.Drawing.Point(2, 509);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(91, 91);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("a_AvanteInt", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.NameLabel.Location = new System.Drawing.Point(23, 55);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(299, 45);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "введiть своє ім\'я";
            // 
            // RegButton
            // 
            this.RegButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegButton.BackColor = System.Drawing.SystemColors.Control;
            this.RegButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RegButton.Image = global::GoodVision.Properties.Resources.війти;
            this.RegButton.ImageHover = global::GoodVision.Properties.Resources.війтиHover;
            this.RegButton.ImageNormal = global::GoodVision.Properties.Resources.війти;
            this.RegButton.Location = new System.Drawing.Point(19, 188);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(680, 97);



        }

        #endregion

       // private RoundButtonTwo.MyRoundButton ButtonReg;
        private System.Windows.Forms.Panel panelForGreet;
        private System.Windows.Forms.Label WellcomeLabel;
        private System.Windows.Forms.Label EnterNameMess;
        private System.Windows.Forms.TextBox RegTextBox;
        private System.Windows.Forms.Panel EnterNamePanel;
        private System.Windows.Forms.Label WellcLabel;
        private System.Windows.Forms.Panel WellcomePanel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label NameLabel;
        private ButtonRoundedCorners.RoundedCorners RegButton;
        public System.Windows.Forms.TextBox RegistTextBox;
        private System.Windows.Forms.Panel RegPanel;
        // private RoundButtonTwo.MyRoundButton RegButton;
    }
}

