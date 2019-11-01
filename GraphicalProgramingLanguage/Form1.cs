using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalProgramingLanguage
{
    public partial class Form1 : Form
    {

        Shape shape;


        public Form1()
        {
            InitializeComponent();
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shape = null;
            if (!Shape.Helper(txtB.Text, out shape))
            {
                return;
            }
            pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shape = null;
            pictureBox1.Invalidate();
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
                        case Shape.shapes.Ellipse:
                            e.Graphics.DrawEllipse(MyPen, shape.X, shape.Y, shape.Width, shape.Height);
                            break;
                        case Shape.shapes.Rectangle:
                            e.Graphics.DrawRectangle(MyPen, shape.X, shape.Y, shape.Width, shape.Height);
                            break;
                        case Shape.shapes.Line:
                            e.Graphics.DrawLine(MyPen, shape.X, shape.Y, shape.Width, shape.Height);
                            break;
                    }
                }
            }
        }
    }


    
 }
