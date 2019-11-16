using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private void StatisticTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void StatisticForm_Load(object sender, EventArgs e)
		{
			FileStream session = new FileStream("session.txt", FileMode.Open, FileAccess.Read);
			if (session != null)
			{
				StreamReader reader = new StreamReader(session);
				User.Nick = reader.ReadToEnd();
				session.Close();
			}
		}
	}
}
