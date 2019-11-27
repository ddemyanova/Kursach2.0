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

        public static bool mode;


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
					User.File = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
					//создать файл с именем;
			}
			catch (FileNotFoundException)
			{

			}

			
		}
        public bool ExchangeRegMessage
        {
            get { return regMess; }
            set { regMess = value; }
        }
       

    }
}
