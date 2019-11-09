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
        UserClass User;
		public MainMenu()
        {
            InitializeComponent();
           
        }
		
		
		
        public UserClass UserExchange // передаем имя пользователя в эту форму
        {
            get {return User; }
            set
            {
                if (value != null)
                {
                    User.Nick = value;
                    HelloLab.Text = "Hello, " + value;
                }
                else HelloLab.Text= "Hello, " + User.Nick;
            }
        }
		GoodVisionClass MyVision;
		public GoodVisionClass GVExchange // передаем имя пользователя в эту форму
		{
			get { return MyVision; }
			set
			{
				
			}
		}

		private void StaticticButton_Click(object sender, EventArgs e)  // просмотр статистики
        {
            StatisticForm statForm = new StatisticForm();
            statForm.StatistExchange = Exchange;
            statForm.Show();
            this.Hide();

        }

        private void VisionCheckButton_Click(object sender, EventArgs e) // переход к форме тестирования
        {
            VisionCheck VChForm = new VisionCheck();
            VChForm.Show();
            this.Hide();
        }


        // вызываем помощь для главного меню
        private void HelpButton_Click(object sender, EventArgs e) 
        {
            HellpMessage hellpForm = new HellpMessage();

            hellpForm.Show();
        }
    }
}
