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
    public partial class AfterTestingForm : Form
    {
        public AfterTestingForm()
        {
            InitializeComponent();
        }

                                  
        private void BackToMenuButton_Click(object sender, EventArgs e) // возврат в меню
        {
            MainMenu mMen = new MainMenu();
            mMen.Show();
            mMen.Hide();
        }


        private void VisionCheckButton_Click(object sender, EventArgs e) // переход на форма проверка зрения
        {
            VisionCheck Vch = new VisionCheck();
            Vch.Show();
            this.Hide();
        }

        private void StatistButton_Click(object sender, EventArgs e) // переход на форму статистики
        {
            StatisticForm stat = new StatisticForm();
            stat.Show();
            this.Hide();
        }
    }
}
