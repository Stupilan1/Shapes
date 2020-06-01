using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GraphicalProgramingLanguage
{
    /// <summary>
    /// Abstract class to be used by other shape classes 
    /// </summary>
    public abstract class Shape
    {

        protected int x, y;
        

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
                    }

        /// <summary>
        /// Any class that uses the shapes class must have this method
        /// </summary>
        /// <param name="g"></param>
        public abstract void Draw(Graphics g);

        public override string ToString()
        {
            return base.ToString() + "    " + this.x + "," + this.y + " : ";
        }


    }
}
















