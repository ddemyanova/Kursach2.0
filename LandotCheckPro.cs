using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodVision
{
    public partial class LandotCheckPro : Form
    {
        public LandotCheckPro()
        {
            InitializeComponent();
        }
        int i = 5, temp;

        private void GoLandotButton_Click(object sender, EventArgs e) // Запуск тестирования Сюда первую картинку надо
        {
            LandotTimer.Value = 0;
            LTimer.Enabled = true;
            temp = i;
        }

        private void BackToVisionCheckButton_Click(object sender, EventArgs e)// возврат на предыдущую страницу
        {
            VisionCheck Vch = new VisionCheck();
            Vch.Show();
            this.Hide();
        }

        private void LTimer_Tick_1(object sender, EventArgs e)
        {

            
            temp--;
            LandotTimer.Text = Convert.ToString(temp);    
            LandotTimer.PerformStep();
            if (temp != 0)
                LTimer.Enabled = true;

            else
                LTimer.Enabled = false;
        }



        private void UpLandotButton_Click(object sender, EventArgs e) //здесь можно добавить смену картики и считывание ответа
        {
            LandotTimer.Value = 0;
            LTimer.Enabled = true;
            temp = i;
        }

        private void LeftLandotButton_Click(object sender, EventArgs e)
        {
            LandotTimer.Value = 0;
            LTimer.Enabled = true;
            temp = i;
        }


        private void DownLandotButton_Click(object sender, EventArgs e)
        {
            LandotTimer.Value = 0;
            LTimer.Enabled = true;
            temp = i;
        }

        private void BackToVisionCheckButton_Click_1(object sender, EventArgs e)
        {
            VisionCheck Vch = new VisionCheck();
            Vch.Show();
            this.Hide();
        }

      

        private void RightLandotButton_Click(object sender, EventArgs e)
        {
            LandotTimer.Value = 0;
            LTimer.Enabled = true;
            temp = i;
        }



    }
}
