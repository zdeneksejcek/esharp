using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESharp.Core.Compiler
{
    public class Punctations
    {
        private const string PUNCTATIONS = ",:;(){}[].<>";

        public static bool IsPunctation(Char ch)
        {
            return PUNCTATIONS.Contains(ch);
        }
    }
}