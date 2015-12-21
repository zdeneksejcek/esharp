using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESharp.Core.Compiler
{
    internal class Atom
    {
        public string Value { get; private set; }

        internal Atom(string value)
        {
            this.Value = value;
        }

        internal static bool IsAtom(string value)
        {
            return (Char.IsLower(value[0]));
        }
    }
}
