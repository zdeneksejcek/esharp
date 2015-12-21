using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESharp.Core.Compiler.Lexing
{
    public class Operators
    {
        private const string OPERATORS = "+-*/%=&|<>!";

        public static bool IsOperator(Char ch)
        {
            return OPERATORS.Contains(ch);
        }
    }
}