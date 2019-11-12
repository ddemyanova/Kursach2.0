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

    public partial class RegForm : Form
    {
		
		public RegForm()
        {
            InitializeComponent();
        }
                 
        
        private void RegistTextBox_TextChanged(object sender, EventArgs e) //Имя пользователя 
        {
      
            
        }

		UserClass User=new UserClass();
		GoodVisionClass MyVision= new GoodVisionClass();
		private void RegButton_Click(object sender, EventArgs e) // переход на нову форму

        {
            if (RegistTextBox.Text != string.Empty)
            {
                MainMenu mMForm = new MainMenu();
                User.Nick = RegistTextBox.Text;
                MyVision.Enter_account(User); //входим в аккаунт
                                              //добавить открытие файла сессии и запись имени пользователя в него
                mMForm.Show();
                this.Hide();
            }
        }
    }
}
