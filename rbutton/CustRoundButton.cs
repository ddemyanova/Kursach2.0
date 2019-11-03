
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rbutton
{
    public partial class CustRoundButton : Button
    {
        public CustRoundButton()
        {
            InitializeComponent();
        }
        private Image NormalImage;
        private Image HoverImage;
        public Image ImageNormal
        {
            get { return NormalImage; }
            set { NormalImage = value; }

        }

        public Image ImageHover
        {
            get { return HoverImage; }
            set { HoverImage = value; }

        }



        private void CustRoundButton_MouseHover(object sender, EventArgs e)
        {
            this.Image = HoverImage;
        }

        private void CustRoundButton_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }

        private void CustRoundButton_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath =
new System.Drawing.Drawing2D.GraphicsPath();

            // Set a new rectangle to the same size as the button's 
            // ClientRectangle property.
            System.Drawing.Rectangle newRectangle = this.ClientRectangle;

            // Decrease the size of the rectangle.
            newRectangle.Inflate(-10, -10);

            // Draw the button's border.
            e.Graphics.DrawEllipse(System.Drawing.Pens.Transparent, newRectangle);

            // Increase the size of the rectangle to include the border.
            newRectangle.Inflate(2, 2); //1 1

            // Create a circle within the new rectangle.
            buttonPath.AddEllipse(newRectangle);

            // Set the button's Region property to the newly created 
            // circle region.
            this.Region = new System.Drawing.Region(buttonPath);
        }

       

    }
}
