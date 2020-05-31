using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgramingLanguage
{
    [Serializable]
    public class ShapesException : Exception
    {
        public ShapesException(string message) : base(message)
        {
        }
    }
}
