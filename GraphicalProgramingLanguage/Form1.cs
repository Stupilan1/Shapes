using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalProgramingLanguage
{
    public partial class Form1 : Form
    {

        Pen myPen = new Pen(Color.Black);
        ArrayList shapes = new ArrayList();

        public int MoveX = 0;
        public int MoveY = 0;
        int index = 0;
        string[] Cmmds = new string[30];
        int x = 0;
        int y = 0;
        

        public PictureBox MyPictureBox
        {
            get
            {
                return pictureBox1;
            }
        }

        public static string passingtext;
        public Form1()
        {
            InitializeComponent();
                        
        }
       private void btn1_Click_1(object sender, EventArgs e)
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
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            pictureBox1.Invalidate();
            txtB.Clear();
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(@"D:\Commands.txt", Cmmds, Encoding.UTF8); //saves the list of commands to a specifed location
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < shapes.Count; i++)
            {
                Shape s;
                s = (Shape)shapes[i];
                s.Draw(g);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            List<string> data = File.ReadAllLines(@"D:\File.txt").ToList();
            foreach (string d in data)
            {
                string[] items = d.Split(new char[] { ',' },
                       StringSplitOptions.RemoveEmptyEntries);
                Lview1.Items.Add(new ListViewItem(items));
            }
        }
    }


    
 }
