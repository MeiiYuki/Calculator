using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace Calculationn
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation cal;
        [TestInitialize]
        public void SetUp()
        {
            this.cal = new Calculation(10, 5);
        }
        [TestMethod]
        public void TestAddOperator()
        {
            Assert.AreEqual(cal.Execute("+"), 15);
        }
        [TestMethod]
        public void TestSubOperator()
        {
            Assert.AreEqual(cal.Execute("-"), 5);
        }
        [TestMethod]
        public void TestMulOperator()
        {
            Assert.AreEqual(cal.Execute("*"), 50);
        }
        [TestMethod]
        public void TestDivOperator()
        {
            Assert.AreEqual(cal.Execute("/"), 2);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Calculation c = new Calculation(2, 0);
            c.Execute("/");
        }
        [TestMethod]
        public void TestDivRound()
        {
            Calculation c = new Calculation(5, 3);
            Assert.AreEqual(c.Execute("/"), 2);

        }
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",@".\Data\TestData.csv","TestData#csv",DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestwithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].Tostring());
        }
      


    }
}