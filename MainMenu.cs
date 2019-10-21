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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
           
        }
      static  string UserName;
     
        public string Exchange // передаем имя пользователя в эту форму
        {
            get {return UserName; }
            set
            {
                if (value != null)
                {
                    UserName = value;
                    HelloLab.Text = "Hello, " + value;
                }
                else HelloLab.Text= "Hello, " + UserName;
            }
        }

        private void StaticticButton_Click(object sender, EventArgs e)
        {
            StatisticForm statForm = new StatisticForm();
            statForm.StatistExchange = Exchange;
            statForm.Show();
            this.Hide();
            
        }

        private void VisionCheckButton_Click(object sender, EventArgs e)
        {
            VisionCheck VChForm = new VisionCheck();
            VChForm.Show();
            this.Hide();
        }

        private void MainMenuHellpButton_Click(object sender, EventArgs e) // вызываем хелп для главного меню
        {
            HellpMessage hellpForm = new HellpMessage();
         
            hellpForm.Show();
            
        }
    }
}
