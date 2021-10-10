using System;
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
            
            Assert.AreEqual(OGA.Calc.Round(0.5m, 0), 1m);
            Assert.AreEqual(OGA.Calc.Round(0.4m, 0), 0m);
            Assert.AreEqual(OGA.Calc.Round(0m, 0), 0m);
            Assert.AreEqual(OGA.Calc.Round(0m, 1), 0m);
            Assert.AreEqual(OGA.Calc.Round(1.54m, 1), 1.5m);
            Assert.AreEqual(OGA.Calc.Round(1.54m, 2), 1.54m);
            Assert.AreEqual(OGA.Calc.Round(-1.54m, 0), -2m);
            Assert.AreEqual(OGA.Calc.Round(123.45m, 0), 123m);
            Assert.AreEqual(OGA.Calc.Round(-123.45m, 0), -123m);
            Assert.AreEqual(OGA.Calc.Round(123.55m, 0), 124m);
            Assert.AreEqual(OGA.Calc.Round(-123.55m, 0), -124m);
            Assert.AreEqual(OGA.Calc.Round(0.1m, 0), 0m);
            Assert.AreEqual(OGA.Calc.Round(0.2m, 0), 0m);
            Assert.AreEqual(OGA.Calc.Round(0.3m, 0), 0m);
            Assert.AreEqual(OGA.Calc.Round(0.4m, 0), 0m);
            Assert.AreEqual(OGA.Calc.Round(0.5m, 0), 1m);
            Assert.AreEqual(OGA.Calc.Round(0.6m, 0), 1m);
            Assert.AreEqual(OGA.Calc.Round(0.7m, 0), 1m);
            Assert.AreEqual(OGA.Calc.Round(0.8m, 0), 1m);
            Assert.AreEqual(OGA.Calc.Round(0.9m, 0), 1m);
            Assert.AreEqual(OGA.Calc.Round(1.0m, 0), 1m);
            Assert.AreEqual(OGA.Calc.Round(1.1m, 0), 1m);




        }

        [TestMethod]
        public void RoundUpのテスト()
        {
            Assert.AreEqual(OGA.Calc.RoundUp(0.5m, 0), 1m);
            Assert.AreEqual(OGA.Calc.RoundUp(0.4m, 0), 1m);
            Assert.AreEqual(OGA.Calc.RoundUp(0m, 0), 0m);
            Assert.AreEqual(OGA.Calc.RoundUp(0m, 1), 0m);
            Assert.AreEqual(OGA.Calc.RoundUp(1.54m, 1), 1.6m);
            Assert.AreEqual(OGA.Calc.RoundUp(1.54m, 2), 1.54m);
            Assert.AreEqual(OGA.Calc.RoundUp(-1.54m, 0), -2m);
            Assert.AreEqual(OGA.Calc.RoundUp(123.45m, 0), 124m);
            Assert.AreEqual(OGA.Calc.RoundUp(-123.45m, 0), -124m);
            Assert.AreEqual(OGA.Calc.RoundUp(123.55m, 0), 124m);
            Assert.AreEqual(OGA.Calc.RoundUp(-123.55m, 0), -124m);
            Assert.AreEqual(OGA.Calc.RoundUp(0.1m, 0), 1m);
            Assert.AreEqual(OGA.Calc.RoundUp(0.2m, 0), 1m);
            Assert.AreEqual(OGA.Calc.RoundUp(0.3m, 0), 1m);
            Assert.AreEqual(OGA.Calc.RoundUp(0.4m, 0), 1m);
            Assert.AreEqual(OGA.Calc.RoundUp(0.5m, 0), 1m);
            Assert.AreEqual(OGA.Calc.RoundUp(0.6m, 0), 1m);
            Assert.AreEqual(OGA.Calc.RoundUp(0.7m, 0), 1m);
            Assert.AreEqual(OGA.Calc.RoundUp(0.8m, 0), 1m);
            Assert.AreEqual(OGA.Calc.RoundUp(0.9m, 0), 1m);
            Assert.AreEqual(OGA.Calc.RoundUp(1.0m, 0), 1m);
            Assert.AreEqual(OGA.Calc.RoundUp(1.1m, 0), 2m);
            Assert.AreEqual(OGA.Calc.RoundUp(-123.55m, 1), -123.6m);




        }

        [TestMethod]
        public void RoundDownのテスト()
        {
            Assert.AreEqual(OGA.Calc.RoundDown(0.5m, 0), 0m);
            Assert.AreEqual(OGA.Calc.RoundDown(0.4m, 0), 0m);
            Assert.AreEqual(OGA.Calc.RoundDown(0m, 0), 0m);
            Assert.AreEqual(OGA.Calc.RoundDown(0m, 1), 0m);
            Assert.AreEqual(OGA.Calc.RoundDown(1.54m, 1), 1.5m);
            Assert.AreEqual(OGA.Calc.RoundDown(1.54m, 2), 1.54m);
            Assert.AreEqual(OGA.Calc.RoundDown(-1.54m, 0), -1m);
            Assert.AreEqual(OGA.Calc.RoundDown(123.45m, 0), 123m);
            Assert.AreEqual(OGA.Calc.RoundDown(-123.45m, 0), -123m);
            Assert.AreEqual(OGA.Calc.RoundDown(123.55m, 0), 123m);
            Assert.AreEqual(OGA.Calc.RoundDown(-123.55m, 0), -123m);
            Assert.AreEqual(OGA.Calc.RoundDown(0.1m, 0), 0m);
            Assert.AreEqual(OGA.Calc.RoundDown(0.2m, 0), 0m);
            Assert.AreEqual(OGA.Calc.RoundDown(0.3m, 0), 0m);
            Assert.AreEqual(OGA.Calc.RoundDown(0.4m, 0), 0m);
            Assert.AreEqual(OGA.Calc.RoundDown(0.5m, 0), 0m);
            Assert.AreEqual(OGA.Calc.RoundDown(0.6m, 0), 0m);
            Assert.AreEqual(OGA.Calc.RoundDown(0.7m, 0), 0m);
            Assert.AreEqual(OGA.Calc.RoundDown(0.8m, 0), 0m);
            Assert.AreEqual(OGA.Calc.RoundDown(0.9m, 0), 0m);
            Assert.AreEqual(OGA.Calc.RoundDown(1.0m, 0), 1m);
            Assert.AreEqual(OGA.Calc.RoundDown(1.1m, 0), 1m);
            Assert.AreEqual(OGA.Calc.RoundDown(-123.55m, 1), -123.5m);

        }

        [TestMethod]
        public void StartOfMonthのテスト()
        {
            Assert.AreEqual(OGA.DateUtil.StartOfMonth(new DateTime(2021, 10, 1)), new DateTime(2021, 10, 1));
            Assert.AreEqual(OGA.DateUtil.StartOfMonth(new DateTime(2021, 10, 2)), new DateTime(2021, 10, 1));
            Assert.AreEqual(OGA.DateUtil.StartOfMonth(new DateTime(2021, 10, 3)), new DateTime(2021, 10, 1));
            Assert.AreEqual(OGA.DateUtil.StartOfMonth(new DateTime(2021, 10, 4)), new DateTime(2021, 10, 1));
            Assert.AreEqual(OGA.DateUtil.StartOfMonth(new DateTime(2021, 10, 5)), new DateTime(2021, 10, 1));
            Assert.AreEqual(OGA.DateUtil.StartOfMonth(new DateTime(2021, 10, 6)), new DateTime(2021, 10, 1));
            Assert.AreEqual(OGA.DateUtil.StartOfMonth(new DateTime(2021, 10, 7)), new DateTime(2021, 10, 1));
            Assert.AreEqual(OGA.DateUtil.StartOfMonth(new DateTime(2021, 10, 8)), new DateTime(2021, 10, 1));
            Assert.AreEqual(OGA.DateUtil.StartOfMonth(new DateTime(2021, 10, 9)), new DateTime(2021, 10, 1));
            Assert.AreEqual(OGA.DateUtil.StartOfMonth(new DateTime(2021, 10, 10)), new DateTime(2021, 10, 1));

        }

        [TestMethod]
        public void EndOfMonthのテスト()
        {
            Assert.AreEqual(OGA.DateUtil.EndOfMonth(new DateTime(2021, 10, 1)), new DateTime(2021, 10, 31));
            Assert.AreEqual(OGA.DateUtil.EndOfMonth(new DateTime(2021, 11, 2)), new DateTime(2021, 11, 30));
            Assert.AreEqual(OGA.DateUtil.EndOfMonth(new DateTime(2021, 12, 3)), new DateTime(2021, 12, 31));
            Assert.AreEqual(OGA.DateUtil.EndOfMonth(new DateTime(2021, 1, 4)), new DateTime(2021, 1, 31));
            Assert.AreEqual(OGA.DateUtil.EndOfMonth(new DateTime(2021, 2, 5)), new DateTime(2021, 2, 28));
            Assert.AreEqual(OGA.DateUtil.EndOfMonth(new DateTime(2021, 3, 6)), new DateTime(2021, 3, 31));
            Assert.AreEqual(OGA.DateUtil.EndOfMonth(new DateTime(2021, 4, 7)), new DateTime(2021, 4, 30));
            Assert.AreEqual(OGA.DateUtil.EndOfMonth(new DateTime(2021, 5, 8)), new DateTime(2021, 5, 31));
            Assert.AreEqual(OGA.DateUtil.EndOfMonth(new DateTime(2021, 6, 9)), new DateTime(2021, 6, 30));
            Assert.AreEqual(OGA.DateUtil.EndOfMonth(new DateTime(2021, 7, 10)), new DateTime(2021, 7, 31));

            // うるう年
            Assert.AreEqual(OGA.DateUtil.EndOfMonth(new DateTime(2020, 2, 5)), new DateTime(2020, 2, 29));

        }

        [TestMethod]
        public void ReadCsvのテスト()
        {
           var test = OGA.CsvHelper.ReadCsv(@"G:\github\ogaken20210926\OGA\OGA\新しいテキスト ドキュメント.csv");


            Assert.AreEqual(test[0].col1, "1");

        }

    }
}
