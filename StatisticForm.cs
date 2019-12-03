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
        UserClass User = new UserClass();

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
            //Десериализатор Get_Stats здесь не используется (написал на всякий случай), вместо этого просто считываю файл 
            FileStream session = new FileStream("session.txt", FileMode.Open, FileAccess.Read);
            if (session != null)
            {
                StreamReader reader = new StreamReader(session);
                User.Nick = reader.ReadToEnd();
                session.Close();
            }
            DataSet ds = new DataSet();
            ds.ReadXml(@"C:\Users\Daniel\source\repos\XMLTOGRID\XMLTOGRID\XMLFile1.xml");
            StatisticTable.DataSource = ds.Tables[0];
            //read from .txt
            string fileName = @"C:\Users\Daniel\source\repos\Ap0ll0n\Kursach\bin\Debug\session.txt"; //"условное" название, по идее .txt должен создаться после регистрации там же, где и User.xml
            string textLine = "";
            //string userName = "";
            System.IO.StreamReader objReader;
            objReader = new System.IO.StreamReader(fileName);
            textLine = objReader.ReadLine();

            StatisticTable.Columns[0].HeaderText = textLine;
            //StatisticTable.Columns[1].HeaderText = "Дата";
            
        }
	}
}
