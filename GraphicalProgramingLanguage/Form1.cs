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

        Comand comand = new Comand();

 
        string[] Cmmds = new string[30];
       

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
       private void btn1_Click_1(object sender, EventArgs e) { 
            {
            string cmmds = txtB.Text.Trim();
                      
                shapes = comand.GetComands(cmmds);
                pictureBox1.Invalidate();
                
            }
        }
        private void btn2_Click(object sender, EventArgs e) // Clear
        {
            shapes.Clear();
            pictureBox1.Invalidate();
            txtB.Clear();
        }
        private void btn3_Click(object sender, EventArgs e) // Save
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                RTxTB.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
        }

        private void btn4_Click(object sender, EventArgs e) // Load
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                RTxTB.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
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


        private void btn5_Click(object sender, EventArgs e)
        {

            shapes = comand.Program(RTxTB);
            pictureBox1.Invalidate();


        }
    }


    
 }
