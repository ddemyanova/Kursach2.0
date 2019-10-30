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
            this.label1 = new System.Windows.Forms.Label();
            this.YesButton = new RoundButtonTwo.MyRoundButton();
            this.NoButton = new RoundButtonTwo.MyRoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.YesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account *UserName* is already exist.\r\n Is it your account?";
            // 
            // YesButton
            // 
            this.YesButton.Image = global::GoodVision.Properties.Resources._66936;
            this.YesButton.ImageHover = null;
            this.YesButton.ImageNormal = null;
            this.YesButton.Location = new System.Drawing.Point(135, 137);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(114, 71);
            this.YesButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YesButton.TabIndex = 1;
            this.YesButton.TabStop = false;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.Image = ((System.Drawing.Image)(resources.GetObject("NoButton.Image")));
            this.NoButton.ImageHover = null;
            this.NoButton.ImageNormal = null;
            this.NoButton.Location = new System.Drawing.Point(307, 137);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(107, 69);
            this.NoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NoButton.TabIndex = 2;
            this.NoButton.TabStop = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // RegMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 286);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegMessage";
            this.Text = "RegMessage";
            ((System.ComponentModel.ISupportInitialize)(this.YesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RoundButtonTwo.MyRoundButton YesButton;
        private RoundButtonTwo.MyRoundButton NoButton;
    }
}