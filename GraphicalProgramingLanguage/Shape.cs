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
        public Shape()
        { }

        public enum shapes
        {
            Rectangle,
            Line,
            Circle,

        }

        public Shape(shapes shape, int x, int y, int width, int height)
        {
            CurrentShape = shape;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public shapes CurrentShape { get; set; } = shapes.Rectangle;
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public static bool userinputdraw(string input, out Shape output)
        {
            output = null;

            if (string.IsNullOrEmpty(input))
                return false;

            var Commmad = input.Split(' ');
            var validCommmads = Enum.GetNames(typeof(shapes));

            if (Commmad.Length < 5 || !validCommmads.Contains(Commmad[0], StringComparer.OrdinalIgnoreCase))
            {
                MessageBox.Show("Enter Valid Shape");
                return false;
            }
            int px, py, width, length;

            if (!int.TryParse(Commmad[1], out px) ||
                !int.TryParse(Commmad[2], out py) ||
                !int.TryParse(Commmad[3], out width) ||
                !int.TryParse(Commmad[4], out length))
            {
                MessageBox.Show("Enter Valid Location/Measurements");
                return false;
            }
            if (width <= 0 || length <= 0)
            {
                MessageBox.Show("Height/Width must be greater than Zero");
                return false;
            }
            var shape = (shapes)validCommmads.ToList().FindIndex(a => a.Equals(Commmad[0], StringComparison.OrdinalIgnoreCase));
            output = new Shape(shape, px, py, width, length);
            return true;
        }

















    }
}