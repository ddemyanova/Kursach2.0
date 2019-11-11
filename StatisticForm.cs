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
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();

           
        }

        public string StatistExchange // передаем имя пользователя в эту форму
        {
            get { return StatisticLabel.Text; }
            set {StatisticLabel.Text = value; }
        }

  

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu mMForm = new MainMenu();
            mMForm.Show();
            this.Hide();
        }
    }
}
