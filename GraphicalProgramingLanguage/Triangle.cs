using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicalProgramingLanguage
{
    class Triangle : Shape
    {
        //Point[] pnt = new Point[3];
        int width, height;
        public Triangle(int x, int y, string height, string width) : base(x, y)
        {

            if (Int32.TryParse(height, out this.height) &&
                Int32.TryParse(width, out this.width))
            {

            }

        }

        public override void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            Point P1 = new Point(x, y);
            Point P2 = new Point(x + width, y);
            Point P3 = new Point(x, y + height);
            Point[] Triangle = new Point[] { new Point(x, y), new Point(x + width, y), new Point(x, y + height) };
            g.DrawPolygon(p, Triangle);
        }

        public override string ToString()
        {
            return base.ToString() + "  " + this.height + "  " + this.width;
        }
    }
}