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

        public enum shapes
        {
            Rectangle,
            Line,
            Ellipse
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

        public static bool Helper(string input, out Shape output)
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
            int x, y, w, h;

            if (!int.TryParse(Commmad[1], out x) ||
                !int.TryParse(Commmad[2], out y) ||
                !int.TryParse(Commmad[3], out w) ||
                !int.TryParse(Commmad[4], out h))
            {
                MessageBox.Show("Enter Valid Location/Measurements");
                return false;
            }
            if (w <= 0 || h <= 0)
            {
                MessageBox.Show("Height/Width must be greater than Zero");
                return false;
            }
            var shape = (shapes)validCommmads.ToList().FindIndex(a => a.Equals(Commmad[0], StringComparison.OrdinalIgnoreCase));
            output = new Shape(shape, x, y, w, h);
            return true;
        }

















    }
}