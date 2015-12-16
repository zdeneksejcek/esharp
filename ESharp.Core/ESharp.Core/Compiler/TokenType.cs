using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESharp.Core.Compiler
{
    internal enum TokenType
    {
        Punctation,
        Number,
        String,
        SinglyQuotedString,
        Keyword,
        Identifier,
        Operator
    }
}