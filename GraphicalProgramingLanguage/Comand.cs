﻿using System;
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
        int index = 0;
        string[] Cmmds = new string[30];
        int x = 0;
        int y = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="txtB"></param>
        /// <param name="RTxTX"></param>
        /// <returns></returns>
        public ArrayList GetComands(TextBox txtB, RichTextBox RTxTX)
        {
            string cmmds = txtB.Text.Trim();
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
                        //pictureBox1.Invalidate();
                        if (index < Cmmds.Length)
                        {
                            Cmmds[index] = txtB.Text;
                            RTxTX.AppendText(Cmmds[index]);// saves the commands to the list box 
                            RTxTX.AppendText(Environment.NewLine);
                        }
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
                        //pictureBox1.Invalidate();
                        if (index < Cmmds.Length)
                        {
                            Cmmds[index] = txtB.Text;
                            RTxTX.AppendText(Cmmds[index]); // saves the commands to the list box 
                            RTxTX.AppendText(Environment.NewLine);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Snydetax Error");
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
                        if (index < Cmmds.Length)
                        {
                            Cmmds[index] = txtB.Text;
                            RTxTX.AppendText(Cmmds[index]); // saves the commands to the list box 
                            RTxTX.AppendText(Environment.NewLine);
                        }

                        //pictureBox1.Invalidate();
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
                        if (index < Cmmds.Length)
                        {
                            Cmmds[index] = txtB.Text;
                            RTxTX.AppendText(Cmmds[index]); // saves the commands to the list box 
                            RTxTX.AppendText(Environment.NewLine);
                        }
                    }
                    break;

             /*   case bool v when cmds[0].Equals("Triangle", StringComparison.OrdinalIgnoreCase):
                    if (Vcmds < 5)
                    {
                        MessageBox.Show("Syntax Error");
                    }
                    if (Int32.TryParse(cmds[1], out int x) &&
                            Int32.TryParse(cmds[2], out int y) &&
                            Int32.TryParse(cmds[3], out int x3) &&
                            Int32.TryParse(cmds[4], out int y3))
                    {
                        shapes.Add(new Triangle(x, y, x2, y2, x3, y3));
                        //pictureBox1.Invalidate();
                        if (index < Cmmds.Length)
                        {
                            Cmmds[index] = txtB.Text;
                            RTxTX.AppendText(Cmmds[index]); // saves the commands to the list box 
                            RTxTX.AppendText(Environment.NewLine);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a triangle");
                    }
                    break;*/

                case bool v when cmds[0].Equals("reset", StringComparison.InvariantCultureIgnoreCase):
                    if (Vcmds < 1)
                    {
                        MessageBox.Show("Syntax Error");
                    }
                    else{
                        x = 0;
                        y = 0;
                        if (index < Cmmds.Length)
                        {
                            Cmmds[index] = txtB.Text;
                            RTxTX.AppendText(Cmmds[index]); // saves the commands to the list box 
                            RTxTX.AppendText(Environment.NewLine);
                        }
                    }
                    break;

                        

                    
            }
            return shapes;






        }
    }
}
