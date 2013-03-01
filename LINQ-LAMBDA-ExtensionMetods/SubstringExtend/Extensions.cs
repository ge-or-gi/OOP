using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement an extension method Substring(int index, int length)
//for the class StringBuilder that returns new StringBuilder and
//has the same functionality as Substring in the class String.

namespace SubstringExtend
{
    public static class Extensions
    {

        public static StringBuilder SubstringExtend(this StringBuilder str, int index, int length)
        {
            StringBuilder mySubstring = new StringBuilder();

            for (int i = index; i < length; i++)
            {

                mySubstring.Append(str[i]);

            }

            return mySubstring;
        
        }


    }
}
