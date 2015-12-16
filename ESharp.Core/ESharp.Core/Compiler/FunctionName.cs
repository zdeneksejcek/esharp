using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESharp.Core.Compiler
{
    internal class FunctionName
    {
        public string Name { get; private set; }

        public int Arity { get; private set; }

        public FunctionName(string name, int arity)
        {
            Name = name;
            Arity = arity;
        }
    }
}