using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STMainClassLibrary;

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
        //create a test for 'Find' method first 
        // first create the test to ensure the existance of the method

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 DestinationID = 4;
            //invoke the method
            Found = AnDestination.Find(DestinationID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        //create test for found method for: Destination no  
        [TestMethod]
        public void TestDestinationNoFound()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DestinationID = 4;
            //invoke the method
            Found = AnDestination.Find(DestinationID);
            //check the Destination ID
            if (AnDestination.DestinationID != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //create test for found method for: EndPointHouseNo   
        [TestMethod]
        public void TestEndPointHouseNoFound()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DestinationID = 4;
            //invoke the method
            Found = AnDestination.Find(DestinationID);
            //check the EndPointHouseNo property
            if (AnDestination.EndPointHouseNo != 123)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //create test for found method for: EndPointPostCode   
        [TestMethod]
        public void TestEndPointPostCodeFound()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DestinationID = 4;
            //invoke the method
            Found = AnDestination.Find(DestinationID);
            //check the EndPointPostCode property 
            if (AnDestination.EndPointPostCode != "LE1 3AS")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //create test for found method for: EndPointStreet  
        [TestMethod]
        public void TestEndPointStreetFound()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DestinationID = 4;
            //invoke the method
            Found = AnDestination.Find(DestinationID);
            //check the EndPointStreet property 
            if (AnDestination.EndPointStreet != "Global Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //create test for found method for: EndPointTown  
        [TestMethod]
        public void TestEndPointTownFound()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DestinationID = 4;
            //invoke the method
            Found = AnDestination.Find(DestinationID);
            //check the EndPointTown property 
            if (AnDestination.EndPointTown != "Leicester")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //create test for found method for: PickupTime  
        [TestMethod]
        public void TestPickupTimeFound()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DestinationID = 4;
            //invoke the method
            Found = AnDestination.Find(DestinationID);
            //check the PickupTime property 
            if (AnDestination.PickupTime !=Convert.ToDateTime("28/02/2019 19:50:00"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //create test for found method for: DropoffTime  
        [TestMethod]
        public void TestDropoffTimeFound()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DestinationID = 4;
            //invoke the method
            Found = AnDestination.Find(DestinationID);
            //check the DropoffTime property 
            if (AnDestination.DropoffTime != Convert.ToDateTime("28/02/2019 20:40:00"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
