using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalProgramingLanguage
{
    class Comand
    {
        ArrayList shapes = new ArrayList();

        public int MoveX = 0;
        public int MoveY = 0;
        string[] Cmmds = new string[30];
        int x = 0;
        int y = 0;

        public ArrayList GetComands(String cmmds)
        {
           
            string[] cmds = cmmds.Split(' ');

            int Vcmds = cmds.GetLength(0);
            switch (true)
            {
                case bool v when cmds[0].Equals("Rectangle", StringComparison.OrdinalIgnoreCase):
                    if (Vcmds < 3)
                    {
                        MessageBox.Show("Syntax Error");
                    }
                     
                   if (Int32.TryParse(cmds[1], out int width) &&
                       Int32.TryParse(cmds[2], out int height))
                    {
                        shapes.Add(new Rectangle(x, y, width, height));
                        
                      
                        }
                   else
                    {
                        MessageBox.Show("Syntax Error");
                    }
                    break;

                case bool v when cmds[0].Equals("circle", StringComparison.OrdinalIgnoreCase):
                    if (Vcmds < 2)
                    {
                        MessageBox.Show("Syntax Error");
                    }
                    if (Int32.TryParse(cmds[1], out int radius))
                    {
                        shapes.Add(new Circle(x, y, radius));  
                    }
                    else
                    {
                        MessageBox.Show("Syntax Error");
                    }
                    break;

                case bool v when cmds[0].Equals("drawLine", StringComparison.OrdinalIgnoreCase):
                    if (Vcmds < 3)
                    {
                        MessageBox.Show("Syntax Error");
                    }
                    if (Int32.TryParse(cmds[1], out int x2) &&
                             Int32.TryParse(cmds[2], out int y2))
                    {
                        shapes.Add(new Line(x, y, x2, y2));
                        x = x2;
                        y = y2;                              
                    }
                    else
                    {
                        MessageBox.Show("Syntax Error");
                    }
                    break;

                case bool v when cmds[0].Equals("moveTo", StringComparison.OrdinalIgnoreCase):

                    if (Vcmds < 3)
                    {
                        MessageBox.Show("Syntax Error");
                    }
                    if (Int32.TryParse(cmds[1], out int MoveX) &&
                            Int32.TryParse(cmds[2], out int MoveY))
                    {
                        x = MoveX;
                        y = MoveY;
                    
                    }
                    else
                    {
                        MessageBox.Show("Syntax Error");
                    }
                    break;

                case bool v when cmds[0].Equals("Triangle", StringComparison.OrdinalIgnoreCase):
                    if (Vcmds < 3)
                    {
                        MessageBox.Show("Syntax Error");
                    }
                    {
                        shapes.Add(new Triangle(x, y, cmds[1], cmds[2]));
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
                    }
                    break;
                default:
                    MessageBox.Show("Please Enter valid Command");
                    break;
            }
            return shapes;




        }

        public ArrayList Program(RichTextBox RTxTB)
        {
            String[] Separators = { "\r\n", "\n", "\r" };
            String[] Commands = RTxTB.Text.Split(Separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (String line in Commands)
                GetComands(line);
            return shapes;


        }

    }

}
