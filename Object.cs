using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GoodVision
{

    abstract public class Object
    {
        protected string FileName = @"C:\Users\Daniel\source\repos\Ap0ll0n\Kursach\Resources\";
        protected Tuple<double, double> size;
        public Image ShowImage;
		protected int Row;
        protected double[] Coefficients = new double[12];
        public Object()
        {
           // this.FileName = "...";//Тут должен будет быт путь к базовому изображения
            this.size = new Tuple<double, double>(2.33333333, 2.33333333);//размер изображения в милиметрах для 6(базовой строки)
           // this.ShowImage = Image.FromFile(this.FileName);
		   for(int i = 1; i < 11; i++)
			{
				Coefficients[i - 1] = i * 0.1;
			}
			Coefficients[10] = 1.5;
			Coefficients[11] = 2.0;
        }
        public Object(Object Obj)
        {
           // this.FileName = Obj.FileName;
           // ShowImage = Image.FromFile(this.FileName);
            this.size = Obj.size;
        }
		public double Get_result(int i)
		{
			return Coefficients[i];
		}
        virtual public Tuple<double, double> Get_size(Image Image_to_show)
        {
            this.size = new Tuple<double, double>((double)Image_to_show.Height * 0.265, (double)Image_to_show.Width * 0.265);
            return size;
        }

        virtual public void Set_size(Tuple<double, double> Size)
        {
            this.size = Size;
        }

        public void CalcSize()
        {
            double Size = 7 / Coefficients[Row - 1] / 5;
			this.size = new Tuple<double, double>( Size, Size);
        }

        public int ObjectRow
		{
			get
			{
				return Row;
			}
			set
			{
				Row = value;
			}
		}
        ~Object(){}
    };
}


