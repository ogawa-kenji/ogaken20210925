using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGA
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void TestStdOut()
        {
            Console.WriteLine("stdout {0} {1}", 1, "text");
        }
    }
}
