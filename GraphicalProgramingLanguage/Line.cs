using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicalProgramingLanguage
{
    class Line :Shape
    {
        int x2, y2;
        public Line(int x, int y, int x2, int y2) : base(x, y)
        {
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawLine(p, x, y, x2, y2);

        }

        public override string ToString()
        {
            return base.ToString() + "    " + this.x2 + "," + this.y2 + " : ";
        }
    }
}
