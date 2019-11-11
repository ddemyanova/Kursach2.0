using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodVision
{
   class Letter : Object
    {
       public enum Letters : int//список букв в таблице Сивцева
        {
            Ш = 1,
            Б,
            М,
            Н,
            К,
            Ы,
            И
        };
        private Letters Letter_to_show;//Буква которая будет для каждого объекта класса 
        public int Get_Random()//случайная генерация числа 1-7
        {
            Random rnd = new Random();
            int Random_Letter = rnd.Next(1,7);
            return Random_Letter;
        }
        public Letter()//конструктор в котором буква для каждого объекта будет по умолчанию выбрана случайно
        {
			this.Set_Letter();
        }
        public void Set_Letter()//метод для установки значения буквы 
        {
			this.Letter_to_show = (Letters)Get_Random();
			switch (Letter_to_show)
			{
				case Letters.Ш:
					{
						this.FileName = "Ш.xml";
						break;
					}
				case Letters.Б:
					{
						this.FileName = "Б.xml";
						break;
					}
				case Letters.М:
					{
						this.FileName = "М.xml";
						break;
					}
				case Letters.Н:
					{
						this.FileName = "Н.xml";
						break;
					}
				case Letters.К:
					{
						this.FileName = "К.xml";
						break;
					}
				case Letters.Ы:
					{
						this.FileName = "Ы.xml";
						break;
					}
				case Letters.И:
					{
						this.FileName = "И.xml";
						break;
					}
			}
		}
		public string Get_Letter()//метод для установки значения буквы вручную
		{
			string name = this.FileName;
			name.Remove(1,4);
			return name;
		}
		public double CalcSize()
		{
			double size=0;
			//формула
			return size;
		}
        ~Letter() { }
    }
}
