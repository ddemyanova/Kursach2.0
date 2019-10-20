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
        public virtual int Get_Random()//случайная генерация числа 1-7
        {
            Random rnd = new Random();
            int Random_Letter = rnd.Next(1,7);
            return Random_Letter;
        }
        public Letter()//конструктор в котором буква для каждого объекта будет по умолчанию выбрана случайно
        {
            this.Letter_to_show = (Letters)Get_Random();
            switch (Letter_to_show)
            {
                case Letters.Ш:
                    {
                        this.FileName = "Сюда надо путь к файлу для буквы Ш";
                        break;
                    }
                case Letters.Б:
                    {
                        this.FileName = "Сюда надо путь к файлу для буквы Б";
                        break;
                    }
                case Letters.М:
                    {
                        this.FileName = "Сюда надо путь к файлу для буквы М";
                        break;
                    }
                case Letters.Н:
                    {
                        this.FileName = "Сюда надо путь к файлу для буквы Н";
                        break;
                    }
                case Letters.К:
                    {
                        this.FileName = "Сюда надо путь к файлу для буквы К";
                        break;
                    }
                case Letters.Ы:
                    {
                        this.FileName = "Сюда надо путь к файлу для буквы Ы";
                        break;
                    }
                case Letters.И:
                    {
                        this.FileName = "Сюда надо путь к файлу для буквы И";
                        break;
                    }
            }
        }
        public void Set_Letter(int letter)//метод для установки значения буквы вручную
        {
            this.Letter_to_show = (Letters)letter;
        }
        //а здесь должен быть метод чтобы узнать букву объекта, но шось его пока нет
        public Letters Get_Letter()
        {
            return this.Letter_to_show;//возвращает текующую букву дял объекта класса
        }
    }
}
