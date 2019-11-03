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

        Rectangle shape;
        int index = 0;
        string[] Cmmds = new string[30];
        

        public static string passingtext;
        public Form1()
        {
            InitializeComponent();
                        
        }
       private void btn1_Click_1(object sender, EventArgs e)
            {
           
            if (index < Cmmds.Length)
            {
                Cmmds[index] = txtB.Text;
                Lview1.Items.Add(Cmmds[index++]);
            }

              shape = null;
              if (!Rectangle.userinputdraw(txtB.Text, out shape))
              {
                return;
              }
             pictureBox1.Invalidate();
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            shape = null;
            pictureBox1.Invalidate();
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(@"D:\Commands.txt", Cmmds, Encoding.UTF8);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.Clear(Color.White);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (shape != null)
            {


                using (Pen MyPen = new Pen(Color.Black, 3))
                {
                    switch (shape.CurrentShape)
                    {
                        case Rectangle.Shapes.Circle:
                            e.Graphics.DrawEllipse(MyPen, shape.X, shape.Y, shape.Width * 2, shape.Height * 2);
                            break;
                        case Shape.Shapes.Rectangle:
                            e.Graphics.DrawRectangle(MyPen, shape.X, shape.Y, shape.Width, shape.Height);
                            break;
                        case Shape.Shapes.Line:
                            e.Graphics.DrawLine(MyPen, shape.X, shape.Y, shape.Width, shape.Height);
                            break;
                    }
                }
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
