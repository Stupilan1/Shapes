using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GraphicalProgramingLanguage
{
    public abstract class Shape
    {

        protected int x, y;
        

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
                    }

        public abstract void Draw(Graphics g);

        public override string ToString()
        {
            return base.ToString() + "    " + this.x + "," + this.y + " : ";
        }


    }
}
















