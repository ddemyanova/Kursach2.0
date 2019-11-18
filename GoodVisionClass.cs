using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace GoodVision
{
	class GoodVisionClass: GoodVisionInterface
	{ bool regMess;
		public GoodVisionClass() { }
		public void Add_to_file(ref UserClass User)
		{
			//добавление в файл пользователя данных
		}

		public void Clear_account(ref UserClass User)
		{
			try {
				File.Delete(User.Nick + ".xml");
			}
			catch (FileNotFoundException)
			{

			}

		}
		
	


		public void Get_Stats(ref UserClass User)
		{
			//показать статистику
		}
		public void Test_vision_with_circles(ref UserClass User)
		{
			throw new NotImplementedException();
		}

		public void Test_vision_with_letters(ref UserClass User)
		{

		}

		public void Create_account(ref UserClass User)
		{
			string filePath = User.Nick + ".xml";//можно прописать тут полный адрес
						
			try
			{
					User.File = new FileStream(filePath, FileMode.Create);
					//создать файл с именем;
			}
			catch (FileNotFoundException)
			{

			}

			
		}
        public bool ExchangeRegMessage
        {
            get { return regMess;  }
            set {regMess = value; }
        }

        public bool Enter_account( UserClass User)
		{
			string filePath = User.Nick + ".xml";
			try
			{
				FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);


                if (fileStream != null)
            { RegMessage reg = new RegMessage();
                reg.Show();
                //вывести месседж бокс "да/нет"  "это ваш аккаунт?"
                if (ExchangeRegMessage == true)
                    {
                        fileStream.Flush();
                        fileStream.Close();
                        return true; // войти в аккаунт
                       
                    } 
            //если да 

            //если нет -
            else {
                        MessageBox.Show("Користувач з таким логіном вже існує. Будьласка, змініть логін");
                        fileStream.Flush();
                        fileStream.Close();
                        return false;
                            
            }
				}
                else { return false; }
			}
			catch (FileNotFoundException)
			{
				
				//Create_account();
				Create_account(ref User);
                return false;
			}
			
		}
	}
}
