using ESharp.Core.Compiler.Attributes;
using ESharp.Core.Compiler.Lexing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESharp.Core.Compiler
{
    internal class SentenceFactory
    {
        internal static Sentence Create(Lexer lexer)
        {
            var token = lexer.Peek();

            if (token == null)
                throw new SyntaxException();

            if (token.Value == "-")
                return AttributeFactory.Create(lexer);

            else if (Atom.IsAtom(token.Value))
                return new Function(lexer);

            else
                throw new SyntaxException();
        }
    }
}