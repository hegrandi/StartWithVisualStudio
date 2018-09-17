using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StartWithVisualStudio.ViewModels;

namespace FirstUnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var OrderVM = new OrderViewModel();
            //OrderVM.Orders.Clear();
            Assert.IsNotNull(OrderVM.Orders);
            Assert.AreNotEqual(0, OrderVM.Orders.Count);
        }
    }
}
