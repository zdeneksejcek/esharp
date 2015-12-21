using ESharp.Core.Compiler;
using ESharp.Core.Compiler.Lexing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESharp.Core.Tests
{
    public class ResourceParser
    {
        internal static Module LoadModule(string path)
        {
            var res = ResourceReader.Read("ESharp.Core.Tests.Simple.factorial.erl");

            var sr = new StringReader(res);
            var lexer = new Lexer(sr);
            var parser = new Parser(lexer);

            var module = parser.ParseModule();

            return module;
        }
    }
}