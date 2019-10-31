﻿using System;
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
        enum Shapes
        {
            Ellipse,
            Rectangle,
            Line
        }

        int x, y, w, h;
        Shapes shape;


        public Form1()
        {
            InitializeComponent();
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            var cmd = txtB.Text.Split(',');
            var validCmds = Enum.GetNames(typeof(Shapes));

            if (cmd.Length < 5 || !validCmds.Contains(cmd[0], StringComparer.OrdinalIgnoreCase))
            {
                MessageBox.Show("Enter a valid command.");
                return;
            }

            if (!int.TryParse(cmd[1], out x) ||
                !int.TryParse(cmd[2], out y) ||
                !int.TryParse(cmd[3], out w) ||
                !int.TryParse(cmd[4], out h))
            {
                MessageBox.Show("Enter a valid shape");
                return;
            }
            shape = (Shapes)validCmds.ToList().FindIndex(a => a.Equals(cmd[0], StringComparison.OrdinalIgnoreCase));
            pictureBox1.Invalidate();

        }

       
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (w > 0 && h > 0)
            {
                e.Graphics.Clear(Color.White);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                using (Pen pn = new Pen(Color.Black, 5))
                {
                    switch (shape)
                    {
                        case Shapes.Ellipse:
                            e.Graphics.DrawEllipse(pn, x, y, w, h);
                            break;
                        case Shapes.Rectangle:
                            e.Graphics.DrawRectangle(pn, x, y, w, h);
                            break;
                        case Shapes.Line:
                            e.Graphics.DrawLine(pn, x, y, w, h);
                            break;
                    }
                }
            }
        }
    }
}
