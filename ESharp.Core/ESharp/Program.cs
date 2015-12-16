using ESharp.Core.Compiler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = ResourceReader.ReadExample1();
            var sr = new StringReader(res);
            var lexer = new Lexer(sr);
            var parser = new Parser(lexer);

            var module = parser.ParseModule();
        }
    }
}