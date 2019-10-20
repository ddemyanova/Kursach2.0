using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Landolt_Circle()//конструктор со случайным выбором направления для кольца
        {
            this.Circle_Direction = (Direction)Get_Random();
        }
        public Direction Get_direction(Landolt_Circle Obj)//Метод который возвращает направление кольца
        {
            return Obj.Circle_Direction;
        }
        ~Landolt_Circle() { }//деструктор
        
    }
}
