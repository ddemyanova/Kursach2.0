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
		void Create_account(string Nickname)
		{
			string filePath = Nickname + ".xml";//можно прописать тут полный адрес
			if (File.Exists(filePath))
			{
				//вывести свой месседж бокс с "да-нет",сказать, что уже существует такой юзер
				//если это вы - Enter Account();
				//если нет - запросить снова
				//хз что здесь возвращать
			}
			else
			{
				fileStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
				//создать файл с именем;
				
			}

			
		}
		void Enter_account(string Nickname)
		{
			string filePath = Nickname + ".xml";//можно прописать тут полный адрес
			if (File.Exists(filePath))
			{
			fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
			}
			//открыть файл ;
			else
			{
				//если такого нет - вывести месседж бокс с ответом "ок", что нет такого пользователя и предложить создать нового
				//Create_account();
				Create_account(Nickname);
			}
			
		}
		
	}
}
