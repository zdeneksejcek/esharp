using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESharp.Core.Compiler
{
    internal class Lexer
    {
        CharReader reader;

        public Lexer(TextReader reader)
        {
            this.reader = new CharReader(reader);
        }

        public Token Peek()
        {
            return null;
        }

        public Token Next()
        {
            ReadWhile(Char.IsWhiteSpace);
            if (reader.IsEOF()) return null;
            if (SkipComment())
                return Next();

            var ch = reader.PeekChar();

            if (ch == '"')
                return ReadString(TokenType.String, '"');

            if (ch == '\'')
                return ReadString(TokenType.SinglyQuotedString, '\'');

            if (Char.IsDigit(ch))
                return ReadNumber();

            if (Identificators.IsIdentificatorStart(ch))
                return ReadIdentificator();

            if (Punctations.IsPunctation(ch))
            {
                reader.ReadChar();
                return new Token(TokenType.Punctation, ch.ToString());
            }

            if (Operators.IsOperator(ch))
            {
                reader.ReadChar();
                return new Token(TokenType.Operator, ch.ToString());
            }

            //var end = reader.ReadToEnd();

            return null;
        }

        private Token ReadIdentificator()
        {
            var str = ReadWhile(Identificators.IsIdentificator);

            if (Keywords.IsKeyword(str))
                return new Token(TokenType.Keyword, str);

            return new Token(TokenType.Identifier, str);
        }

        private Token ReadNumber()
        {
            var str = ReadWhile(Char.IsDigit);

            return new Token(TokenType.Number, str);
        }

        private Token ReadString(TokenType type, char endCharacter)
        {
            var sb = new StringBuilder();
            reader.ReadChar();

            while (!reader.IsEOF())
            {
                var ch = reader.ReadChar();

                if (ch == endCharacter)
                    break;
                else
                    sb.Append(ch);
            }

            return new Token(type, sb.ToString());
        }

        private string ReadWhile(Func<char,bool> predicate)
        {
            var str = string.Empty;
            while (!reader.IsEOF() && predicate(reader.PeekChar()))
                str += reader.ReadChar();

            return str;
        }

        private bool SkipComment()
        {
            var ch = reader.PeekChar();
            if (ch == '%')
            {
                ReadWhile(c => c != '\r');
                reader.ReadChar();
                reader.ReadChar();

                return true;
            }

            return false;
        }
    }
}