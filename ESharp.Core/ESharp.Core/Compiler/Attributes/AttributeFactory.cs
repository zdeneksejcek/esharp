using ESharp.Core.Compiler.Lexing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESharp.Core.Compiler.Attributes
{
    internal class AttributeFactory
    {
        internal static Attribute Create(Lexer lexer)
        {
            var token = lexer.Next(); // get rid of "-"
            Validate(token);

            while ((token = lexer.Next()) != null)
            {
                var attName = new Atom(token.Value);

                var att = CreateAttributeByName(attName, lexer);

                if (token.Value == ".")
                    return new Attributes.Custom(attName, lexer);
            }

            throw new SyntaxException();
        }

        private static void Validate(Token token)
        {
            if (token == null || token.Value != "-")
                throw new SystemException();
        }

        private static Attribute CreateAttributeByName(Atom name, Lexer lexer)
        {
            switch (name.Value)
            {
                case "module":
                    return new Module();

                case "export":
                    return new Export();

                case "record":
                    return new Record();

                default:
                    return new Custom(name, lexer);
            }
        }
    }
}