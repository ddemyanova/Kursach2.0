namespace GoodVision
{
    partial class StatisticForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatisticTable = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftEyeAcuity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightEyeAcuity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatisticLabel = new System.Windows.Forms.Label();
            this.BackToMainButton = new rbutton.CustRoundButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BackToMainButton);
            this.panel1.Controls.Add(this.StatisticLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 146);
            this.panel1.TabIndex = 0;
            // 
            // StatisticTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.StatisticTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StatisticTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StatisticTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatisticTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Date,
            this.LeftEyeAcuity,
            this.RightEyeAcuity});
            this.StatisticTable.Location = new System.Drawing.Point(180, 152);
            this.StatisticTable.Name = "StatisticTable";
            this.StatisticTable.RowTemplate.Height = 24;
            this.StatisticTable.Size = new System.Drawing.Size(782, 405);
            this.StatisticTable.TabIndex = 1;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // LeftEyeAcuity
            // 
            this.LeftEyeAcuity.HeaderText = "Left Eye Acuti";
            this.LeftEyeAcuity.Name = "LeftEyeAcuity";
            // 
            // RightEyeAcuity
            // 
            this.RightEyeAcuity.HeaderText = "Right Eye Acuity";
            this.RightEyeAcuity.Name = "RightEyeAcuity";
            // 
            // StatisticLabel
            // 
            this.StatisticLabel.AutoSize = true;
            this.StatisticLabel.Location = new System.Drawing.Point(149, 38);
            this.StatisticLabel.Name = "StatisticLabel";
            this.StatisticLabel.Size = new System.Drawing.Size(46, 17);
            this.StatisticLabel.TabIndex = 1;
            this.StatisticLabel.Text = "label1";
            // 
            // BackToMainButton
            // 
            this.BackToMainButton.ImageHover = null;
            this.BackToMainButton.ImageNormal = null;
            this.BackToMainButton.Location = new System.Drawing.Point(908, 29);
            this.BackToMainButton.Name = "BackToMainButton";
            this.BackToMainButton.Size = new System.Drawing.Size(206, 88);
            this.BackToMainButton.TabIndex = 2;
            this.BackToMainButton.Text = "custRoundButton1";
            this.BackToMainButton.UseVisualStyleBackColor = true;
            this.BackToMainButton.Click += new System.EventHandler(this.BackToMainButton_Click);
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 596);
            this.Controls.Add(this.StatisticTable);
            this.Controls.Add(this.panel1);
            this.Name = "StatisticForm";
            this.Text = "StatisticForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView StatisticTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftEyeAcuity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightEyeAcuity;
        private System.Windows.Forms.Label StatisticLabel;
        private rbutton.CustRoundButton BackToMainButton;
    }
}