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
		Letter NewLetter= new Letter();
		int rightAnswer = 0;
		int tests = 0;
		int left = 1;
		int right = 12;

		UserClass User = new UserClass() ;
		GoodVisionClass MyVision= new GoodVisionClass();

		Tuple<double, double> LetterSize =new Tuple<double, double>(0,0);

        private void AnswerSivtsevButton_Click(object sender, EventArgs e)
        {
			if (left < right)
			{
				if (AnswerTextBox.Text == NewLetter.Get_Letter())
				{
					rightAnswer++;
				}

				i++;

				if (tests < 3)
				{
					NewLetter.Set_Letter();
					LetterPictureBox.Image = NewLetter.ShowImage;
				}
				else if (rightAnswer >= 2)
				{
					left = NewLetter.ObjectRow;
					NewLetter.ObjectRow = (left + right) / 2;
					tests = 0;
					NewLetter.Set_Letter();
					
					LetterPictureBox.Image = NewLetter.ShowImage;
				}
				else
				{
					right= NewLetter.ObjectRow;
					NewLetter.ObjectRow = (left + right) / 2;
					//задать размер
					LetterPictureBox.Image = NewLetter.ShowImage;
					tests = 0;
				}



				SivtsevTimer.Value = 0;
				temp = i;
				timer1.Enabled = true;
			}
			else
			{
				//if
				//r/l
			}
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            SivtsevTimer.Value = 0;
            EyeTestPanel.Visible = false;             // предупреждение про проверку правого глаза уходит
            System.Threading.Thread.Sleep(100);
            timer1.Enabled = true;
            temp = i;
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

		private void SivtsevCheckingPro_Load(object sender, EventArgs e)
		{
			
		}

		private void BackToVisionCheckButton_Click(object sender, EventArgs e)
        {
            VisionCheck Vch = new VisionCheck();
            Vch.Show();
            this.Hide();
        }



    
    }
}
