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
        [TestMethod]
        public void DestinationIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnDestination.DestinationID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDestination.DestinationID, TestData);
        }
        [TestMethod]
        public void DropoffTimePropertyOK()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnDestination.DropoffTime = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDestination.DropoffTime, TestData);
        }
        [TestMethod]
        public void EndPointHouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //create some test data to assign to the property
            Int32 TestData = 16;
            //assign the data to the property
            AnDestination.EndPointHouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDestination.EndPointHouseNo, TestData);
        }
        [TestMethod]
        public void EndPointPostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //create some test data to assign to the property
            String TestData = "LE11 2WJ";
            //assign the data to the property
            AnDestination.EndPointPostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDestination.EndPointPostCode, TestData);
        }
        [TestMethod]
        public void EndPointStreetPropertyOK()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //create some test data to assign to the property
            String TestData = "Leicester Road";
            //assign the data to the property
            AnDestination.EndPointStreet = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDestination.EndPointStreet, TestData);
        }
        [TestMethod]
        public void EndPointTownPropertyOK()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //create some test data to assign to the property
            String TestData = "Leicester";
            //assign the data to the property
            AnDestination.EndPointTown = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDestination.EndPointTown, TestData);
        }

        [TestMethod]
        public void PickupTimePropertyOK()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnDestination.PickupTime = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDestination.PickupTime, TestData);
        }
    }
}
