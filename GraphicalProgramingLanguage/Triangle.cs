using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicalProgramingLanguage
{
    class Triangle : Shape
    {
        //Point[] pnt = new Point[3];
        int Base, height;
        public Triangle(int x, int y, string height, string Base) : base(x, y)
        {
          

                if (Int32.TryParse(height, out this.height) &&
                    Int32.TryParse(Base, out this.Base))
                {
                    
                }
            
            else
            {
                MessageBox.Show("Syntax Error");
            }

        }

        public override void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            Point[] Triangle = new Point[] { new Point(x, y), new Point(x + height, y + Base    ), new Point(x, y + Base) };
            g.DrawPolygon(p, Triangle);
        }

        public override string ToString()
        {
            return base.ToString() + "  " + this.height + "  " + this.Base;
        }
    }
}