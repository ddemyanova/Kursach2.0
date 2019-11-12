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
		UserClass User;
		GoodVisionClass MyVision;
		

		private void StaticticButton_Click(object sender, EventArgs e)  // просмотр статистики
        {
            StatisticForm statForm = new StatisticForm();
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
            HellpMessage help = new HellpMessage();
            help.Show();
        }

		private void MainMenu_Load(object sender, EventArgs e)
		{
			//считать данные из файла данной сессии (имя)
			//открыть файл по имени пользователья с его данными
			HelloLab.Text = "Hello, " + User.Nick;
		}
	}
}
