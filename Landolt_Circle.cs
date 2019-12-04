using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GoodVision
{
	class Landolt_Circle : Object
	{
		public enum Direction : int//класс перечисление для выбора направление кольца Ландольта
		{
			Upwards = 1,
			Downwards,
			Leftwards,
			Rightwards
		}
		private Direction Circle_Direction;
		public int Get_Random()//случайная генерация числа 1-4
		{
			Random rnd = new Random();
			int Random_Direction = rnd.Next(1, 4);
			return Random_Direction;
		}
		public void Set_Circle()
		{
			this.Circle_Direction = (Direction)Get_Random();
		}
		public Landolt_Circle()//конструктор со случайным выбором направления для кольца
		{
		//	this.FileName = "Circle.png";
			this.Set_Circle();
		//	this.ShowImage = Image.FromFile(this.FileName);
		}
		public int Directions//Метод который возвращает направление кольца
        {
			set
			{
				this.Circle_Direction = (Direction)value;

			}

			get
			{
				return (int)this.Circle_Direction;
			}

        }
        ~Landolt_Circle() { }//деструктор
        
    }
}
