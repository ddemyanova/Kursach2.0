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
            this.label1 = new System.Windows.Forms.Label();
            this.StatisticLabel = new System.Windows.Forms.Label();
            this.StatisticTable = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftEyeAcuity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightEyeAcuity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackToMenuButton = new rbutton.CustRoundButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StatisticLabel);
            this.panel1.Location = new System.Drawing.Point(43, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 108);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(896, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Here you can view your test statistic";
            // 
            // StatisticLabel
            // 
            this.StatisticLabel.AutoSize = true;
            this.StatisticLabel.Location = new System.Drawing.Point(149, 38);
            this.StatisticLabel.Name = "StatisticLabel";
            this.StatisticLabel.Size = new System.Drawing.Size(0, 17);
            this.StatisticLabel.TabIndex = 1;
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
            this.StatisticTable.Location = new System.Drawing.Point(206, 117);
            this.StatisticTable.Name = "StatisticTable";
            this.StatisticTable.RowTemplate.Height = 24;
            this.StatisticTable.Size = new System.Drawing.Size(870, 453);
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
            // BackToMenuButton
            // 
            this.BackToMenuButton.ImageHover = null;
            this.BackToMenuButton.ImageNormal = null;
            this.BackToMenuButton.Location = new System.Drawing.Point(10, 441);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(182, 128);
            this.BackToMenuButton.TabIndex = 2;
            this.BackToMenuButton.Text = "custRoundButton1";
            this.BackToMenuButton.UseVisualStyleBackColor = true;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 596);
            this.Controls.Add(this.BackToMenuButton);
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
       // private rbutton.CustRoundButton BackToMainButton;
        private System.Windows.Forms.Label label1;
        private rbutton.CustRoundButton BackToMenuButton;
    }
}