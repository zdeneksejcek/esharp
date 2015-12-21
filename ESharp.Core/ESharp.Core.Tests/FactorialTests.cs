using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ESharp.Core.Tests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void Factorial_Test()
        {
            var res = ResourceParser.LoadModule("ESharp.Core.Tests.Simple.factorial.erl");

        }
    }
}