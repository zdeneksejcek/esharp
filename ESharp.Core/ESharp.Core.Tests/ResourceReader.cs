using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ESharp.Core.Tests
{
    internal class ResourceReader
    {
        public static string Read(string path)
        {
            //var list = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path);
            
            using (var sr = new StreamReader(stream))
                return sr.ReadToEnd();
        }
    }
}