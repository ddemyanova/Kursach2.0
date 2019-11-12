using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GoodVision
{
	class GoodVisionClass: GoodVisionInterface
	{
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

		public void Enter_account( UserClass User)
		{
			string filePath = User.Nick + ".xml";
			try
			{
				FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
			}
			catch (FileNotFoundException)
			{
				//если такого нет - вывести месседж бокс с ответом "ок", 
				//что нет такого пользователя и предложить создать нового
				//Create_account();
				Create_account(ref User);
			}
			
		}
	}
}
