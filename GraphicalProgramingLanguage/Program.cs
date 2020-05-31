using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GraphicalProgramingLanguage
{
    class Program
    {
        [STAThread]
        static void Main()
        {
           
           
            try
            {
                Application.Run(new Form1());
            }

            catch (ShapesException error )
            {
                MessageBox.Show(error.Message);
                Application.Run(new Form1());
            }
        }
    }
}
