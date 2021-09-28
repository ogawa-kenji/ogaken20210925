﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestStdOut()
        {
            Console.WriteLine("stdout {0} {1}", 1, "text");
        }

        [TestMethod]
        public void Roundのテスト()
        {
            var calc = new OGA.Calc();
            Assert.AreEqual(calc.Round(0.5m, 0), 1m);
            Assert.AreEqual(calc.Round(0.4m, 0), 0m);
            Assert.AreEqual(calc.Round(0m, 0), 0m);
            Assert.AreEqual(calc.Round(0m, 1), 0m);
            Assert.AreEqual(calc.Round(1.54m, 1), 1.5m);
            Assert.AreEqual(calc.Round(1.54m, 2), 1.54m);
            Assert.AreEqual(calc.Round(-1.54m, 0), -2m);
            Assert.AreEqual(calc.Round(123.45m, 0), 123m);
            Assert.AreEqual(calc.Round(-123.45m, 0), -123m);
            Assert.AreEqual(calc.Round(123.55m, 0), 124m);
            Assert.AreEqual(calc.Round(-123.55m, 0), -124m);
            Assert.AreEqual(calc.Round(0.1m, 0), 0m);
            Assert.AreEqual(calc.Round(0.2m, 0), 0m);
            Assert.AreEqual(calc.Round(0.3m, 0), 0m);
            Assert.AreEqual(calc.Round(0.4m, 0), 0m);
            Assert.AreEqual(calc.Round(0.5m, 0), 1m);
            Assert.AreEqual(calc.Round(0.6m, 0), 1m);
            Assert.AreEqual(calc.Round(0.7m, 0), 1m);
            Assert.AreEqual(calc.Round(0.8m, 0), 1m);
            Assert.AreEqual(calc.Round(0.9m, 0), 1m);
            Assert.AreEqual(calc.Round(1.0m, 0), 1m);
            Assert.AreEqual(calc.Round(1.1m, 0), 1m);




        }
    }
}