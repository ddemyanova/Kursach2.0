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
		private FileStream fileStream;

		public void Add_to_file(ref UserClass User)
		{
			throw new NotImplementedException();
		}

		public void Change_form()
		{
			throw new NotImplementedException();
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
		void GoodVisionInterface.Clear_account(ref UserClass User)
		{
			throw new NotImplementedException();
		}

		public void Get_help()
		{
			throw new NotImplementedException();
		}

		public void Get_Stats(ref UserClass User)
		{
			throw new NotImplementedException();
		}

		public void Test_vision_with_circles(ref UserClass User)
		{
			throw new NotImplementedException();
		}

		public void Test_vision_with_letters(ref UserClass User)
		{
			throw new NotImplementedException();
		}

		public void Create_account(ref UserClass User)
		{
			string filePath = User.Nick + ".xml";//можно прописать тут полный адрес
			if (File.Exists(filePath))
			{
				//вывести свой месседж бокс с "да-нет",сказать, что уже существует такой юзер
				//если это вы - Enter Account();
				//если нет - запросить снова
				//хз что здесь возвращать
			}
			else
			
			try
			{
					User.File = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
					//создать файл с именем;
				
				
			}
			catch (FileNotFoundException)
			{

			}

			
		}

		void GoodVisionInterface.Create_account(ref UserClass User)
		{
			throw new NotImplementedException();
		}

		public void Enter_account(ref UserClass User)
		{
			string filePath = User.Nick + ".xml";//можно прописать тут полный адрес
			try
			{
				fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
			}
			catch (FileNotFoundException)
			{
				//если такого нет - вывести месседж бокс с ответом "ок", 
				//что нет такого пользователя и предложить создать нового
				//Create_account();
				Create_account(ref User);
			}
			
		}

		void GoodVisionInterface.Enter_account(ref UserClass User)
		{
			throw new NotImplementedException();
		}
	}
}
