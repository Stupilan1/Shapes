using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalProgramingLanguage
{
    class Rectangle : Shape
    {
        public Rectangle(Shapes shape, int x, int y, int width, int height) : base(shape, x, y)
        {
            Width = width;
            Height = height;
        }

        public Rectangle() { }
        public int Width { get; set; }
        public int Height { get; set; }

        public static bool userinputdraw(string input, out Rectangle result)
        {
            result = null;

            if (string.IsNullOrEmpty(input))
                return false;

            var cmd = input.Split(' ');
            var validCmds = Enum.GetNames(typeof(Shapes));

            if (cmd.Length < 5 || !validCmds.Contains(cmd[0], StringComparer.OrdinalIgnoreCase))
            {
                MessageBox.Show("Enter Valid Shape");
                return false;
            }
                

            int x, y, w, h;

            if (!int.TryParse(cmd[1], out x) ||
                !int.TryParse(cmd[2], out y) ||
                !int.TryParse(cmd[3], out w) ||
                !int.TryParse(cmd[4], out h))
            {
                MessageBox.Show("Enter Valid Location/Measurements");
                return false;
            }
            if (w <= 0 || h <= 0)
            {
                MessageBox.Show("Height/Width must be greater than Zero");
                return false;
            }
            var shape = (Shapes)validCmds.ToList().FindIndex(a => a.Equals(cmd[0], StringComparison.OrdinalIgnoreCase));

            result = new Rectangle(shape, x, y, w, h);
            return true;
        }

    }
}
