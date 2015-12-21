using ESharp.Core.Compiler.Lexing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESharp.Core.Compiler
{
    internal class Parser
    {
        private Lexer lexer;
        private Token[] tokens;

        public Parser(Lexer lexer)
        {
            this.lexer = lexer;
        }

        public Module ParseModule()
        {
            var sentences = new List<Sentence>();

            Token token;
            while ((token = lexer.Peek()) != null)
            {
                var sentence = SentenceFactory.Create(lexer);

                if (sentence == null)
                    break;

                sentences.Add(sentence);
            }

            return new Module();
        }

        private Token[] GetAllTokens()
        {
            var list = new List<Token>();

            Token token;
            while ((token = lexer.Next()) != null)
                list.Add(token);

            return list.ToArray();
        }
    }
}
