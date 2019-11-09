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
		UserClass User;
		GoodVisionClass MyVision;
		//создали объекты, которые будем передавать между формами!
		public RegForm()
        {
            InitializeComponent();
        }
                 
        
        private void RegistTextBox_TextChanged(object sender, EventArgs e) //Имя пользователя 
        {
      
            
        }
       
        
        private void RegButton_Click(object sender, EventArgs e) // переход на нову форму

        {

            MainMenu mMForm = new MainMenu();
			User.Nick = RegistTextBox.Text;
			MyVision.Enter_account(ref User);
			mMForm.Exchange = User; // отправили имя пользователя через свойство
            mMForm.Show();
            this.Hide();
        }
    }
}
