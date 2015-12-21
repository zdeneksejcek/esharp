using ESharp.Core.Compiler.Lexing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESharp.Core.Compiler
{
    internal class Function : Sentence
    {
        public string FunctionName { get; private set; }

        public Clause[] Clauses { get; private set; }

        internal Function(Lexer lexer)
        {

        }
    }
}