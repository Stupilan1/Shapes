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
        /// <summary>
        /// Runs the commands in the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        private void Btn_Run_Line(object sender, EventArgs e) { 
            {
            string cmmds = txtB.Text.Trim();
                      
                shapes = comand.GetComands(cmmds);
                pictureBox1.Invalidate();
                
            }
        }

        /// <summary>
        /// Clears everything in the Texfields and PictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Clear(object sender, EventArgs e) // Clear
        {
            shapes.Clear();
            pictureBox1.Invalidate();
            txtB.Clear();
            RTxTB.Clear();
        }

        /// <summary>
        /// Saves the Program to a user chosen location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Save(object sender, EventArgs e) // Save
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                RTxTB.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
        }

        /// <summary>
        /// Load a program of commands from the PC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Load(object sender, EventArgs e) // Load
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                RTxTB.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
        }

        /// <summary>
        /// Run the commands in the R
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Run_Program(object sender, EventArgs e)
        {
            RTxTB.Text.Trim();
            shapes = comand.Program(RTxTB);
            pictureBox1.Invalidate();


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

        
    }
           
 }
