using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESharp.Core.Compiler
{
    [DebuggerDisplay("{Value} {Type}")]
    internal class Token
    {
        public TokenType Type { get; private set; }
        public string Value {get; private set;}

        public int Line { get; private set; }
        public int Column { get; private set; }

        public Token(TokenType type, string value, int line = 0, int column = 0)
        {
            this.Type = type;
            this.Value = value;
            this.Line = line;
            this.Column = column;
        }
    }
}