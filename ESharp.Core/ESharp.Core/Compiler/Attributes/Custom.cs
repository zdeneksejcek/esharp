using ESharp.Core.Compiler.Lexing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESharp.Core.Compiler.Attributes
{
    internal class Custom : Attribute
    {
        private Atom Name { get; set; }

        public Custom(Atom name, Lexer lexer)
        {
            this.Name = name;
        }
    }
}