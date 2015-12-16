using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESharp.Core.Compiler
{
    internal class Identificators
    {
        public static bool IsIdentificatorStart(Char ch)
        {
            return Char.IsLetter(ch) || ch == '_';
        }

        public static bool IsIdentificator(Char ch)
        {
            return IsIdentificatorStart(ch) || Char.IsLetterOrDigit(ch);
        }
    }
}