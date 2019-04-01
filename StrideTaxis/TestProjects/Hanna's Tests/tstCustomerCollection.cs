using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjects.Hanna_s_Tests
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }
    }
}
