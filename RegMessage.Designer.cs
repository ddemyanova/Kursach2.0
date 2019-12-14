namespace GoodVision
{
    partial class RegMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegMessage));
            this.MessageLabel = new System.Windows.Forms.Label();
            this.NoButton = new ButtonRoundedCorners.RoundedCorners();
            this.YesButton = new ButtonRoundedCorners.RoundedCorners();
            this.LightPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.NoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YesButton)).BeginInit();
            this.LightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageLabel.Image = global::GoodVision.Properties.Resources.подложка;
            this.MessageLabel.Location = new System.Drawing.Point(12, 12);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(307, 93);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "Акаунт з таким логіном\r\n вже створено. \r\nЦе ваш акаунт?";
            // 
            // NoButton
            // 
            this.NoButton.Image = ((System.Drawing.Image)(resources.GetObject("NoButton.Image")));
            this.NoButton.ImageHover = global::GoodVision.Properties.Resources.NoHover;
            this.NoButton.ImageNormal = ((System.Drawing.Image)(resources.GetObject("NoButton.ImageNormal")));
            this.NoButton.Location = new System.Drawing.Point(287, 170);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(114, 51);
            this.NoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.NoButton.TabIndex = 2;
            this.NoButton.TabStop = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.Image = global::GoodVision.Properties.Resources.Yes;
            this.YesButton.ImageHover = global::GoodVision.Properties.Resources.YesHover;
            this.YesButton.ImageNormal = global::GoodVision.Properties.Resources.Yes;
            this.YesButton.Location = new System.Drawing.Point(109, 170);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(114, 51);
            this.YesButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.YesButton.TabIndex = 1;
            this.YesButton.TabStop = false;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // LightPanel
            // 
            this.LightPanel.Controls.Add(this.MessageLabel);
            this.LightPanel.Location = new System.Drawing.Point(12, 9);
            this.LightPanel.Name = "LightPanel";
            this.LightPanel.Size = new System.Drawing.Size(499, 147);
            this.LightPanel.TabIndex = 3;
            // 
            // RegMessage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::GoodVision.Properties.Resources.подложка2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 255);
            this.Controls.Add(this.LightPanel);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegMessage";
            ((System.ComponentModel.ISupportInitialize)(this.NoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YesButton)).EndInit();
            this.LightPanel.ResumeLayout(false);
            this.LightPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private ButtonRoundedCorners.RoundedCorners YesButton;
        private ButtonRoundedCorners.RoundedCorners NoButton;
        private System.Windows.Forms.Panel LightPanel;
        //  private RoundedButton.MyRoundButton YesButton;
        //   private RoundButtonTwo.MyRoundButton NoButton;
    }
}