using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESharp.Core.Compiler
{
    internal class Clause
    {
        public Sequence Sequence { get; private set; }

        public Clause(Sequence sequence)
        {
            this.Sequence = sequence;
        }
    }
}