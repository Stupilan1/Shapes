using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GraphicalProgramingLanguage
{
    public class Rectangle : Shape
    {
        int width, height;
        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {

            this.width = width; //the only thingthat is different from shape abstract class
            this.height = height;
        }


        public override void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawRectangle(p, x, y, width, height);
        }
    }
}
