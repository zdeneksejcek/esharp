using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ESharp
{
    internal class ResourceReader
    {
        public static string ReadExample1()
        {
            //var names = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ESharp.example.erl");
            
            using (var sr = new StreamReader(stream))
                return sr.ReadToEnd();
        }
    }
}