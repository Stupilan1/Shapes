using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalProgramingLanguage
{
    class Shape
    {
        public enum Shapes
        {
            Circle,
            Rectangle,
            Line
        }


        public Shape()
        { }

        public Shape(Shapes shape, int x, int y)
        {
            CurrentShape = shape;
            X = x;
            Y = y;

        }

        public Shapes CurrentShape { get; set; } = Shapes.Circle;
        public int X { get; set; }
        public int Y { get; set; }


    }
}
















