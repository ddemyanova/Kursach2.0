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
        private Image Image_to_show = Image.FromFile("Ssss.jpg");//рандомное имя файла
        
            public Tuple<double,double> Get_size(Image Image_to_show)
        {
            var size = new Tuple<double, double>((double)Image_to_show.Height * 0.265, (double)Image_to_show.Width * 0.265);
            return size;
        }

      //  public void Set_size(Image Image_to_show)
    }
}
