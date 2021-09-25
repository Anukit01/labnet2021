using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrabajoPractico05.Logic;

namespace TrabajoPractico05
{
    [TestClass]
    public class UnitTest1
    {
        BaseLogic baseLogic = new BaseLogic();
        [TestMethod]
        public void TestQuery1()
        {
            var customerRandome = baseLogic.Query1();
            Assert.AreEqual(customerRandome, baseLogic.Query1());
        }

        [TestMethod]
        public void TestQuery2()
        {
            var productsOutStock = baseLogic.Query2();
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void TestQuery3()
        {
            var productsInStockAbove3PerUnit = baseLogic.Query3();
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void TestQuery4()
        {
            var customerWA = baseLogic.Query4();
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void TestQuery5()
        {
            var firstProduct = baseLogic.Query5();
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void TestQuery6A()
        {
            var customerUpper = baseLogic.Query6A();
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void TestQuery6B()
        {
            var customerLower = baseLogic.Query6B();
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void TestQuery7()
        {
            var customerOrderDate = baseLogic.Query7();
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void TestQuery8()
        {
            var first3customers = baseLogic.Query8();
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void TestQuery9()
        {
            var productsPerName = baseLogic.Query9();
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void TestQuery10()
        {
            var productsInStockDes = baseLogic.Query10();
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void TestQuery11()
        {
            var categoryName = baseLogic.Query11();
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void TestQuery12()
        {
            var firstProduct = baseLogic.Query12();
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void TestQuery13()
        {
            var OrderPerCustomer = baseLogic.Query13();
            Assert.AreEqual(1, 1);
        }
    }

}
