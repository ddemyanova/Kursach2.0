using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GoodVision
{

    abstract class Object
    {
        private string FileName;
        private Tuple<double, double> size;
        private Image ShowImage;
        public Object()
        {
            this.FileName = "...";//Тут должен будет быт путь к базовому изображения
            this.size = new Tuple<double, double>(2.33333333, 2.33333333);//размер изображения в милиметрах для 6(базовой строки)
            this.ShowImage = Image.FromFile(this.FileName);
        }
        public Object(Object Obj)
        {
            this.FileName = Obj.FileName;
            ShowImage = Image.FromFile(this.FileName);
            this.size = Obj.size;
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
        ~Object()
        {
            //хз че в деструкторе писать
        }
    };
}


