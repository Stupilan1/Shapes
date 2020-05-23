using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgramingLanguage
{
   public class UserVariables
    {

       
        public int LoopinNum;
        public List<int> VarIntList = new List<int>();
        public List<string> VarNameList = new List<string>();
        public List<string> Loopin = new List<string>();        

    public void CreateVar(string VarName, int VarInt)
        {
            VarIntList.Add(VarInt);
            VarNameList.Add(VarName);

        }
     

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

        public void creatloopline(string line) 
        {
            Loopin.Add(line);
         

        }
  
        public void createloop(int looptime)
        {
            LoopinNum = looptime;
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

        public void ClearLoops()
        {
            Loopin.Clear();
        }
        
        public void createifloop()
        {

        }




   }
}

