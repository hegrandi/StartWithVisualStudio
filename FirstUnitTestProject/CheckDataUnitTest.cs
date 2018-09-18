using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StartWithVisualStudio.ViewModels;

namespace FirstUnitTestProject
{
    [TestClass]
    public class CheckDataUnitTest
    {
        [TestMethod]
        public void CheckDataTestMethod()
        {
            var OrderVM = new OrderViewModel();
            //OrderVM.Orders.Clear();
            Assert.IsNotNull(OrderVM.Orders);
            Assert.AreNotEqual(0, OrderVM.Orders.Count);
        }
    }
}
