using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalProgramingLanguage
{/// <summary>
/// The class is used to draw the shapes with commaneds 
/// from the text/richtext box
/// </summary>
    public class Comand
    {
        ArrayList shapes = new ArrayList();

        public int MoveX = 0;
        public int MoveY = 0;
        UserVariables userVariables = new UserVariables();
        string[] Cmmds = new string[30];
        int x = 0;
        int y = 0;

        /// <summary>
        /// Sorts through commands to draw shapes
        /// </summary>
        /// <param name="cmmds">Command line passed by user</param>
        /// <returns>ArrrayList Containing shapes</returns>
        public ArrayList GetComands(String cmmds)
        {
            
            string[] cmds = cmmds.Trim().Split(' ');
            
            int Vcmds = cmds.GetLength(0);
            switch (true)
            {
                case bool v when cmds[0].Equals("Rectangle", StringComparison.OrdinalIgnoreCase):
                    if (Vcmds > 3)
                    {
                        throw new ShapesException("Rectangle too manyy Parameters");
                    }
                    else if (Vcmds < 3)
                    {
                        throw new ShapesException("Not Enough prameteres in Rectanlge ");
                    }
                     
                    if(Int32.TryParse(cmds[1], out int width) &&
                                     Int32.TryParse(cmds[2], out int height))
                        {
                        shapes.Add(new Rectangle(x, y, width, height));                    
                        }
                   else
                    {
                        shapes.Add(new Rectangle(x, y, userVariables.GetVar(cmds[1]), userVariables.GetVar(cmds[2])));
                    }
                    break;

                case bool v when cmds[0].Equals("circle", StringComparison.OrdinalIgnoreCase):
                    if (Vcmds > 2)
                    {
                        throw new ShapesException("Length Error");
                    }
                    if (Int32.TryParse(cmds[1], out int radius))
                    {
                        shapes.Add(new Circle(x, y, radius));  
                    }
                    else
                    {

                        shapes.Add(new Circle(x, y, userVariables.GetVar(cmds[1])));
                    }
                    break;
                case bool v when cmds[0].Equals("Triangle", StringComparison.OrdinalIgnoreCase):
                    if (Vcmds > 3)
                    {

                        throw new ShapesException("Syntax Error");
                    }
                    if (Int32.TryParse(cmds[1], out int length) &&
                                     Int32.TryParse(cmds[2], out int Base))
                    {
                        shapes.Add(new Triangle(x, y, length, Base));
                    }
                                              
                    else
                    {
                       shapes.Add(new Triangle(x, y, userVariables.GetVar(cmds[1]), userVariables.GetVar(cmds[2])));
                    }

                    break;

                case bool v when cmds[0].Equals("drawLine", StringComparison.OrdinalIgnoreCase):
                    if (Vcmds > 3)
                    {
                        throw new ShapesException("Syntax Error");
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
                        shapes.Add(new Line(x, y, userVariables.GetVar(cmds[1]), userVariables.GetVar(cmds[2])));
                    }
                    break;

                case bool v when cmds[0].Equals("moveTo", StringComparison.OrdinalIgnoreCase):

                    if (Vcmds > 3)
                    {
                        throw new ShapesException("Syntax Error");
                    }
                    if (Int32.TryParse(cmds[1], out int MoveX) &&
                            Int32.TryParse(cmds[2], out int MoveY))
                    {
                        x +=  MoveX;
                        y += MoveY;
                    
                    }
                    else
                    {
                        x = userVariables.GetVar(cmds[1]);
                        y = userVariables.GetVar(cmds[2]);
                    }
                    break;

               

                case bool v when cmds[0].Equals("reset", StringComparison.InvariantCultureIgnoreCase):
                    if (Vcmds > 1)
                    {
                        throw new ShapesException("Syntax Error");
                    }
                    else
                    {
                        x = 0;
                        y = 0;
                    }
                    break;

                case bool v when cmds[0].Equals("var", StringComparison.InvariantCultureIgnoreCase):
                    if (!Int32.TryParse(cmds[2], out int VarInt))
                    {
                        throw new ShapesException("wasnt able to parse varable into an integer ");
                    }
                    ;

                    userVariables.CreateVar(cmds[1], VarInt);
                    break;

                default:
                    throw new ShapesException("invalid command");
            }

            
            return shapes;


        }
       
        

        public ArrayList Program(RichTextBox RTxTB)
        {
            
            String[] Separators = { "\r\n", "\n", "\r" };
            String[] Commands = RTxTB.Text.Trim().Split(Separators, StringSplitOptions.RemoveEmptyEntries);
            MultiCommand(Commands);
            
            
            return shapes;

          
        }
        public void MultiCommand(string[] Cmds)
        {
            bool flag = false;
            foreach (String line in Cmds)
            {


                string[] cmds = line.Split(' ');
                int Vcmds = cmds.GetLength(0);
                if (flag == true)
                {
                    if (cmds[0].Equals("Endloop", StringComparison.InvariantCultureIgnoreCase))
                    {
                        flag = false;
                        MultiCommand(userVariables.getloop());
                    }
                    else
                    {
                        userVariables.creatloopline(line);
                    }
                }
                switch (true)
                {

                    case bool v when cmds[0].Equals("Loop", StringComparison.InvariantCultureIgnoreCase):
                        flag = true;
                        Int32.TryParse(cmds[1], out int lp);
                        userVariables.createloop(lp);
                        break;
                    case bool v when cmds[0].Equals("EndLoop", StringComparison.InvariantCultureIgnoreCase):
                        break;

                    case bool v when cmds[0].Equals("ClearLoop", StringComparison.InvariantCultureIgnoreCase):
                        userVariables.ClearLoops();
                        break;

                    case bool v when cmds[0].Equals("if", StringComparison.InvariantCultureIgnoreCase):
                       
                        break;
                    default:
                        GetComands(line);
                        break;
                }
            }
        }



    }

}
