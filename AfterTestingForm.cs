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

        private void StatisticButton_Click(object sender, EventArgs e)
        {
            StatisticForm stat = new StatisticForm();
            stat.Show();
            this.Hide();
        }

        private void VisionCheckButton_Click(object sender, EventArgs e)
        {
            VisionCheck Vch = new VisionCheck();
            Vch.Show();
            this.Hide();

        }



        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu mMen = new MainMenu();
            mMen.Show();
            mMen.Hide();
        }

       
    }
}
