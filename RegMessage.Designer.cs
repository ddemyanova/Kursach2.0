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
            this.label1 = new System.Windows.Forms.Label();
            this.NoButton = new ButtonRoundedCorners.RoundedCorners();
            this.YesButton = new ButtonRoundedCorners.RoundedCorners();
            ((System.ComponentModel.ISupportInitialize)(this.NoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YesButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::GoodVision.Properties.Resources.подложка;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account *UserName* is already \r\nexist.\r\n Is it your account?";
            // 
            // NoButton
            // 
            this.NoButton.Image = global::GoodVision.Properties.Resources.hrest;
            this.NoButton.ImageHover = null;
            this.NoButton.ImageNormal = null;
            this.NoButton.Location = new System.Drawing.Point(305, 171);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(110, 54);
            this.NoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NoButton.TabIndex = 2;
            this.NoButton.TabStop = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.Image = global::GoodVision.Properties.Resources._66936;
            this.YesButton.ImageHover = null;
            this.YesButton.ImageNormal = null;
            this.YesButton.Location = new System.Drawing.Point(99, 174);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(114, 51);
            this.YesButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YesButton.TabIndex = 1;
            this.YesButton.TabStop = false;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // RegMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::GoodVision.Properties.Resources.подложка2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 255);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegMessage";
            this.Text = "RegMessage";
            ((System.ComponentModel.ISupportInitialize)(this.NoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YesButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ButtonRoundedCorners.RoundedCorners YesButton;
        private ButtonRoundedCorners.RoundedCorners NoButton;
        //  private RoundedButton.MyRoundButton YesButton;
        //   private RoundButtonTwo.MyRoundButton NoButton;
    }
}