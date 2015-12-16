using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESharp.Core.Compiler
{
    internal class Function
    {
        public string FunctionName { get; private set; }

        public Clause[] Clauses { get; private set; }
    }
}