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
            int x2, x3, y2, y3;
            public Triangle(int x, int y, int x2, int y2, int x3, int y3) : base(x, y)
            {
                this.x2 = x2;
                this.x3 = x3;
                this.y2 = y2;
                this.y3 = y3;

               /* pnt[0].X = x;
                pnt[0].Y = y;

                pnt[1].X = x2;
                pnt[1].Y = y2;

                pnt[2].X = x3;
                pnt[2].Y = y3;*/
            }

            public override void Draw(Graphics g)
            {
                Pen p = new Pen(Color.Black, 2);
                g.DrawLine(p, x, y, x2, y2);
                g.DrawLine(p, x2, y2, x3, y3);
                g.DrawLine(p, x3, y3, x, y);
        }

            public override string ToString()
            {
                return base.ToString() + "  " + this.x2 + "  " + this.y2 + "  " + this.x3 + "  " + this.y3;
            }
        }
}


