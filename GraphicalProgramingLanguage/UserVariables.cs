using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgramingLanguage
{
   public class UserVariables
    {


        public List<int> VarIntList = new List<int>();
        public List<string> VarNameList = new List<string>();

        

    public void CreateVar(string VarName, int VarInt)
        {
            VarIntList.Add(VarInt);
            VarNameList.Add(VarName);

        }
     

    public int GetVar(string VarName)
        {
           for (int i = 0;i<VarIntList.Count;) 
            foreach (string name in VarNameList) //itterates through the list
            {
                
                if (name.Equals(VarName)){ //checks the inputted name agianst the list 
                    return VarIntList[i];
                    
                }
                
            }


            throw new Exception ("No Variable found");//throw expetion 
        }

        public void ifloop(string name) { 
        
        
        
        }






    }
}
