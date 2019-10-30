using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading;
using System.Windows.Forms;

namespace GoodVision
{
    public partial class SivtsevCheckingPro : Form
    {
        public SivtsevCheckingPro()
        {
            InitializeComponent();
          
        }
        int i = 6, temp;

        private void AnswerSivtsevButton_Click(object sender, EventArgs e)
        {
            SivtsevTimer.Value = 0;
            temp = i;
            timer1.Enabled = true;

        }

        private void AnswerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackFromSivtsevButton_Click(object sender, EventArgs e)
        {
            VisionCheck Vch = new VisionCheck();
            Vch.Show();
            this.Hide();
        }
       

        private void timer1_Tick(object sender, EventArgs e) // Здесь же можем и начинать грузить картинки
        {
                    
                temp--;
                SivtsevTimer.Text = Convert.ToString(temp);
            SivtsevTimer.PerformStep();
            if (temp != 0)
            timer1.Enabled = true;
            
            else
             timer1.Enabled = false;
            }

      
        private void BackToVisionCheckButton_Click(object sender, EventArgs e)
        {
            VisionCheck Vch = new VisionCheck();
            Vch.Show();
            this.Hide();
        }



        private void StartButton_Click(object sender, EventArgs e)
        {
            SivtsevTimer.Value = 0;
            timer1.Enabled = true;
            temp = i;
        }
    }
}
