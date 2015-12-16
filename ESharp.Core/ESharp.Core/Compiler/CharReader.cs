using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESharp.Core.Compiler
{
    internal class CharReader
    {
        private TextReader reader;

        public CharReader(TextReader reader)
        {
            this.reader = reader;
        }

        public char PeekChar()
        {
            return (char)this.reader.Peek();
        }

        public char ReadChar()
        {
            return (char)this.reader.Read();
        }

        public bool IsEOF()
        {
            return this.reader.Peek() == -1;
        }

        public string ReadToEnd()
        {
            return this.reader.ReadToEnd();
        }
    }
}