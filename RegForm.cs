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

    public partial class RegForm : Form
    {
		public RegMessage regMess;
        public string userNick;
        UserClass User = new UserClass();
        GoodVisionClass MyVision = new GoodVisionClass();

        public RegForm()
        {
            InitializeComponent();
            regMess = new RegMessage(this);

        }
       

        private void RegistTextBox_TextChanged(object sender, EventArgs e) //Имя пользователя 
        {
      
            
        }


	
        private void RegButton_Click(object sender, EventArgs e) // переход на нову форму

        {
            if (RegistTextBox.Text != string.Empty)
            {
              
                userNick = RegistTextBox.Text;

                string filePath = userNick + ".xml";
                try
                {
                    // проверка, существует ли данный аккаунт

                    if (File.Exists(filePath)) { 
               

                        regMess.userNick = userNick;
                        regMess.Tag = this;
                        this.Enabled = false;
                        regMess.Show();
                        regMess.Focus();

                        
                   }
   
                     else
                    {
                        User.Nick = userNick;


                        MyVision.Create_account(ref User);
                        
                        Enter_account(userNick);


                    }
                }

                catch (Exception)
                {
                    
                   

                }
            }
        }


              public void Enter_account(string user)
                {
                    User.Nick = user;
                    FileStream session = new FileStream("session.txt", FileMode.Create, FileAccess.Write);
                    if (session != null)
                    {
                        StreamWriter writer = new StreamWriter(session);
                        writer.Write(User.Nick);
                        writer.Flush();
                        session.Close();
                    }//открытие файла сессии и запись имени пользователя в него //
                      MainMenu mMForm = new MainMenu();
           
            mMForm.Show();

                    this.Hide();
                }

        private void RegistTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (( e.KeyChar>96&& e.KeyChar < 123)||(e.KeyChar > 1071 && e.KeyChar < 1103)||(e.KeyChar == 1110)||(e.KeyChar == 1111)|| (e.KeyChar > 47 && e.KeyChar < 58)||(e.KeyChar==8))
            {
                e.Handled = false;
            }
        }
    }
        }
    
