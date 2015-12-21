using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESharp.Core.Compiler.Lexing
{
    internal class Keywords
    {
        private static readonly HashSet<string> keywords = new HashSet<string>
        {
            "after",
            "and",
            "andalso",
            "band",
            "begin",
            "bnot",
            "bor",
            "bsl",
            "bsr",
            "bxor",
            "case",
            "catch",
            "cond",
            "div",
            "end",
            "fun", "if", "let", "not", "of", "or", "orelse", "query", "receive", "rem", "try", "when", "xor"
        };

        public static bool IsKeyword(string keyword)
        {
            return keywords.Contains(keyword);
        }
    }
}