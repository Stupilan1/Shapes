using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicalProgramingLanguage
{
    public class Circle : Shape
    {
        int radius;
 
        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;
        }

        public override void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawEllipse(p, x, y, radius * 2, radius * 2);
        }

        public override string ToString()
        {
            return base.ToString() + "  " + this.radius;
        }


    }
}
