using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgramingLanguage
{
    /// <summary>
    /// Class to handle user variables and LOOPS
    /// </summary>
   public class UserVariables
    {

       
        public int LoopinNum;
        public List<int> VarIntList = new List<int>();
        public List<string> VarNameList = new List<string>();
        public List<string> Loopin = new List<string>();        

    /// <summary>
    /// Gets the Variable name and Value from the user input and adds them to lists 
    /// </summary>
    /// <param name="VarName"></param>
    /// <param name="VarInt"></param>
    public void CreateVar(string VarName, int VarInt)
        {
            VarIntList.Add(VarInt);
            VarNameList.Add(VarName);

        }
     
        /// <summary>
        /// Checks the variables list to see if the entered variable exists 
        /// </summary>
        /// <param name="VarName"></param>
        /// <returns></returns>
    public int GetVar(string VarName)
        {
            for (int i = 0; i < VarIntList.Count;)
            {
                foreach (string name in VarNameList) //itterates through the list
                {

                    if (name.Equals(VarName))
                    { //checks the inputted name agianst the list 
                        return VarIntList[i];

                    }
                    i++;
                }
            }

            throw new Exception ("No Variable found");//throws expetion 
        }

        /// <summary>
        /// Adds a line to the loop list 
        /// </summary>
        /// <param name="line"></param>
        public void creatloopline(string line) 
        {
            Loopin.Add(line);
         

        }
        /// <summary>
        /// holds the values for how many times the loop will be performed
        /// </summary>
        /// <param name="looptime"></param>
        public void createloop(int looptime)
        {
            LoopinNum = looptime;
        }
        
        public int getloopnum()
        {
            return LoopinNum;
        }

        public string[] getloop()
        {
            string[] loops = new string[Loopin.Count()];
            int index = 0;
            foreach (string Line in Loopin)
            {
                loops[index] = Loopin[index];
                index++;
            }
            return loops;
        }
        /// <summary>
        /// Clears the current Loop
        /// </summary>
        public void ClearLoops()
        {
            Loopin.Clear();
        }
        
        public void createifloop()
        {

        }




   }
}

