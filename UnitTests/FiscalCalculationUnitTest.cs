using FiscalYearCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class FiscalCalculationUnitTest
    {
        [TestMethod]
        public void TestGetFiscal_null()
        {
            var fiscal = GetFiscal("1/54/3333");
            Assert.IsNull(fiscal);
        }


        [TestMethod]
        public void TestGetFiscal_Test1()
        {
            var fiscal = GetFiscal("12/19/2020");
            Assert.AreEqual(2020, fiscal.Year);
            Assert.AreEqual(356, fiscal.Day);
            Assert.AreEqual(51, fiscal.Woy);
            Assert.AreEqual(13, fiscal.Poy);
            Assert.AreEqual("12/14/2020", fiscal.Wini.ToShortDateString());

        }

        [TestMethod]
        public void TestGetFiscal_Test2()
        {
            var fiscal = GetFiscal("12/20/2020");
            Assert.AreEqual(2020, fiscal.Year);
            Assert.AreEqual(357, fiscal.Day);
            Assert.AreEqual(51, fiscal.Woy);
            Assert.AreEqual(13, fiscal.Poy);
            Assert.AreEqual("12/14/2020", fiscal.Wini.ToShortDateString());

        }

        [TestMethod]
        public void TestGetFiscal_Test3()
        {
            var fiscal = GetFiscal("12/21/2020");
            Assert.AreEqual(2020, fiscal.Year);
            Assert.AreEqual(358, fiscal.Day);
            Assert.AreEqual(52, fiscal.Woy);
            Assert.AreEqual(13, fiscal.Poy);
            Assert.AreEqual("12/21/2020", fiscal.Wini.ToShortDateString());
        }


        [TestMethod]
        public void TestGetFiscal_Test4()
        {
            var fiscal = GetFiscal("12/27/2020");
            Assert.AreEqual(2020, fiscal.Year);
            Assert.AreEqual(364, fiscal.Day);
            Assert.AreEqual(52, fiscal.Woy);
            Assert.AreEqual(13, fiscal.Poy);
            Assert.AreEqual("12/21/2020", fiscal.Wini.ToShortDateString());
        }

        [TestMethod]
        public void TestGetFiscal_Test5()
        {
            var fiscal = GetFiscal("12/28/2020");
            Assert.AreEqual(2021, fiscal.Year);
            Assert.AreEqual(1, fiscal.Day);
            Assert.AreEqual(1, fiscal.Woy);
            Assert.AreEqual(1, fiscal.Poy);
            Assert.AreEqual("12/28/2020", fiscal.Wini.ToShortDateString());
        }

        [TestMethod]
        public void TestGetFiscal_Test6()
        {
            var fiscal = GetFiscal("12/29/2020");
            Assert.AreEqual(2021, fiscal.Year);
            Assert.AreEqual(2, fiscal.Day);
            Assert.AreEqual(1, fiscal.Woy);
            Assert.AreEqual(1, fiscal.Poy);
            Assert.AreEqual("12/28/2020", fiscal.Wini.ToShortDateString());
        }

        [TestMethod]
        public void TestGetFiscal_Test7()
        {
            var fiscal = GetFiscal("12/30/2020");
            Assert.AreEqual(2021, fiscal.Year);
            Assert.AreEqual(3, fiscal.Day);
            Assert.AreEqual(1, fiscal.Woy);
            Assert.AreEqual(1, fiscal.Poy);
            Assert.AreEqual("12/28/2020", fiscal.Wini.ToShortDateString());
        }


        [TestMethod]
        public void TestGetFiscal_Test8()
        {
            var fiscal = GetFiscal("12/31/2020");
            Assert.AreEqual(2021, fiscal.Year);
            Assert.AreEqual(4, fiscal.Day);
            Assert.AreEqual(1, fiscal.Woy);
            Assert.AreEqual(1, fiscal.Poy);
            Assert.AreEqual("12/28/2020", fiscal.Wini.ToShortDateString());
        }

        [TestMethod]
        public void TestGetFiscal_Test9()
        {
            var fiscal = GetFiscal("1/1/2021");
            Assert.AreEqual(2021, fiscal.Year);
            Assert.AreEqual(5, fiscal.Day);
            Assert.AreEqual(1, fiscal.Woy);
            Assert.AreEqual(1, fiscal.Poy);
            Assert.AreEqual("12/28/2020", fiscal.Wini.ToShortDateString());
        }

        [TestMethod]
        public void TestGetFiscal_Test10()
        {
            var fiscal = GetFiscal("1/2/2021");
            Assert.AreEqual(2021, fiscal.Year);
            Assert.AreEqual(6, fiscal.Day);
            Assert.AreEqual(1, fiscal.Woy);
            Assert.AreEqual(1, fiscal.Poy);
            Assert.AreEqual("12/28/2020", fiscal.Wini.ToShortDateString());
        }

        [TestMethod]
        public void TestGetFiscal_Test11()
        {
            var fiscal = GetFiscal("1/3/2021");
            Assert.AreEqual(2021, fiscal.Year);
            Assert.AreEqual(7, fiscal.Day);
            Assert.AreEqual(1, fiscal.Woy);
            Assert.AreEqual(1, fiscal.Poy);
            Assert.AreEqual("12/28/2020", fiscal.Wini.ToShortDateString());
        }

        [TestMethod]
        public void TestGetFiscal_Test12()
        {
            var fiscal = GetFiscal("1/4/2021");
            Assert.AreEqual(2021, fiscal.Year);
            Assert.AreEqual(8, fiscal.Day);
            Assert.AreEqual(2, fiscal.Woy);
            Assert.AreEqual(1, fiscal.Poy);
            Assert.AreEqual("1/4/2021", fiscal.Wini.ToShortDateString());
        }

        [TestMethod]
        public void TestGetFiscal_Test13()
        {
            var fiscal = GetFiscal("1/5/2021");
            Assert.AreEqual(2021, fiscal.Year);
            Assert.AreEqual(9, fiscal.Day);
            Assert.AreEqual(2, fiscal.Woy);
            Assert.AreEqual(1, fiscal.Poy);
            Assert.AreEqual("1/4/2021", fiscal.Wini.ToShortDateString());
        }


        private Fiscal GetFiscal(string date)
        {
            FiscalCalculation calc = new FiscalCalculation();
            return calc.GetFiscal(date);
        }
    }
}
