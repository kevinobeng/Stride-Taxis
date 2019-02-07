using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjects
{
    [TestClass]
    public class tstDestination
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //test to see that it exists
            Assert.IsNotNull(AnDestination);
        }
    }
}
