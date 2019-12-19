using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgramingLanguage
{
    class Commands
    {
        ArrayList shapes = new ArrayList();

        public void GetComands()
        {
            switch (true)
            {
                case bool v when cmds[0].Equals("Rectangle", StringComparison.OrdinalIgnoreCase):
                    if (Vcmds < 3)
                    {
                        MessageBox.Show("Syntax Error");
                    }

                    else if (Int32.TryParse(cmds[1], out int width) &&
                             Int32.TryParse(cmds[2], out int height))
                    {
                        shapes.Add(new Rectangle(x, y, width, height));
                        pictureBox1.Invalidate();
                        if (index < Cmmds.Length)
                        {
                            Cmmds[index] = txtB.Text;
                            Lview1.Items.Add(Cmmds[index++]); // saves the commands to the list box 
                        }

                    }
                    break;

                case bool v when cmds[0].Equals("circle", StringComparison.OrdinalIgnoreCase):
                    if (Vcmds < 2)
                    {
                        MessageBox.Show("Syntax Error");
                    }
                    else if (Int32.TryParse(cmds[1], out int radius))
                    {
                        shapes.Add(new Circle(x, y, radius));
                        pictureBox1.Invalidate();
                        if (index < Cmmds.Length)
                        {
                            Cmmds[index] = txtB.Text;
                            Lview1.Items.Add(Cmmds[index++]); // saves the commands to the list box 
                        }
                    }

                    break;

                case bool v when cmds[0].Equals("drawLine", StringComparison.OrdinalIgnoreCase):
                    if (Vcmds < 3)
                    {
                        MessageBox.Show("Syntax Error");
                    }
                    else if (Int32.TryParse(cmds[1], out int x2) &&
                             Int32.TryParse(cmds[2], out int y2))
                    {
                        shapes.Add(new Line(x, y, x2, y2));
                        x = x2;
                        y = y2;
                        if (index < Cmmds.Length)
                        {
                            Cmmds[index] = txtB.Text;
                            Lview1.Items.Add(Cmmds[index++]); // saves the commands to the list box 
                        }

                        pictureBox1.Invalidate();
                    }
                    break;

                case bool v when cmds[0].Equals("moveTo", StringComparison.OrdinalIgnoreCase):

                    if (Vcmds < 3)
                    {
                        MessageBox.Show("Syntax Error");
                    }
                    else if (Int32.TryParse(cmds[1], out int MoveX) &&
                            Int32.TryParse(cmds[2], out int MoveY))
                    {
                        x = MoveX;
                        y = MoveY;
                        if (index < Cmmds.Length)
                        {
                            Cmmds[index] = txtB.Text;
                            Lview1.Items.Add(Cmmds[index++]); // saves the commands to the list box 
                        }
                    }
                    break;

                case bool v when cmds[0].Equals("Triangle", StringComparison.OrdinalIgnoreCase):
                    if (Vcmds < 5)
                    {
                        MessageBox.Show("Syntax Error");
                    }
                    else if (Int32.TryParse(cmds[1], out int x2) &&
                            Int32.TryParse(cmds[2], out int y2) &&
                            Int32.TryParse(cmds[3], out int x3) &&
                            Int32.TryParse(cmds[4], out int y3))
                    {
                        shapes.Add(new Triangle(x, y, x2, y2, x3, y3));
                        pictureBox1.Invalidate();
                        if (index < Cmmds.Length)
                        {
                            Cmmds[index] = txtB.Text;
                            Lview1.Items.Add(Cmmds[index++]); // saves the commands to the list box 
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a triangle");
                    }
                    break;

                case bool v when cmds[0].Equals("reset", StringComparison.InvariantCultureIgnoreCase):
                    if (Vcmds < 1)
                    {
                        MessageBox.Show("Syntax Error");
                    }
                    else
                    {
                        x = 0;
                        y = 0;
                        if (index < Cmmds.Length)
                        {
                            Cmmds[index] = txtB.Text;
                            Lview1.Items.Add(Cmmds[index++]); // saves the commands to the list box 
                        }
                    }
                    break;



                    return shapes;
            }





        }
    }
}
