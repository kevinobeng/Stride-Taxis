using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STMainClassLibrary;

namespace TestProjects
{
    [TestClass]
    public class tstDestination
    {
        //Good Test data
        //create some test data to pass to the method
        string EndPointHouseNo = "43";
        string EndPointPostCode = "LE2 2BT";
        string EndPointStreet = "Carterhatch Street";
        string EndPointTown = "Leicester";
        string PickupTime = DateTime.Now.Date.ToString();
        string DropoffTime = DateTime.Now.Date.ToString();

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
            if (AnDestination.PickupTime != Convert.ToDateTime("28/02/2019 19:50:00"))
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

        // create test to test the Validation 
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //create a test for the first parameter: EndPointHouseNo

        [TestMethod]
        public void EndPointHouseNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string EndPointHouseNo = ""; //this part should trigger the error
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EndPointHouseNoMin()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string EndPointHouseNo = "a"; //this should be ok
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointHouseNoPlusOne()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string EndPointHouseNo = "aa"; //this should be ok
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointHouseNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string EndPointHouseNo = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointHouseNoMax()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string EndPointHouseNo = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointHouseNoMid()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string EndPointHouseNo = "aaa"; //this should be ok
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointHouseNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string EndPointHouseNo = "";
            EndPointHouseNo = EndPointHouseNo.PadRight(500, 'a');
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //create a test for the parameter: EndPointPostCode

        [TestMethod]
        public void EndPointPostCodeLessOne()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            // this should fail
            string EndPointPostCode = "";
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointPostCodeMin()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            // this should fail
            string EndPointPostCode = "a";
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointPostCodePlusOne()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            // this should fail
            string EndPointPostCode = "aa";
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointPostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            // this should fail
            string EndPointPostCode = "aaaaaaaaa";
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointPostCodeMax()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            // this should fail
            string EndPointPostCode = "aaaaaaaaaa";
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointPostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            // this should fail
            string EndPointPostCode = "aaaaaaaaaaa";
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointPostCodeMid()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            // this should fail
            string EndPointPostCode = "aaaaa";
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //create a test for the parameter: EndPointStreet

        [TestMethod]
        public void EndPointStreetLessOne()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            // this should fail
            string EndPointStreet = "";
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointStreetMin()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            // this should fail
            string EndPointStreet = "a";
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointStreetPlusOne()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            // this should fail
            string EndPointStreet = "aa";
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointStreetMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            // this should fail
            string EndPointStreet = "";
            EndPointStreet = EndPointStreet.PadRight(49, 'a');
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointStreetMax()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            // this should fail
            string EndPointStreet = "";
            EndPointStreet = EndPointStreet.PadRight(50, 'a');
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointStreetMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            // this should fail
            string EndPointStreet = "";
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointStreetMid()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            // this should fail
            string EndPointStreet = "";
            EndPointStreet = EndPointStreet.PadRight(25, 'a');
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //create a test for the parameter: EndPointTown

        [TestMethod]
        public void EndPointTownLessOn()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string EndPointTown = "";
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointTownMin()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string EndPointTown = "a";
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointTownMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string EndPointTown = "aa";
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointTownMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string EndPointTown = "";
            EndPointTown = EndPointTown.PadRight(49, 'a');
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointTownMax()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string EndPointTown = "";
            EndPointTown = EndPointTown.PadRight(50, 'a');
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointTownMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string EndPointTown = "";
            EndPointTown = EndPointTown.PadRight(51, 'a');
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EndPointTownMid()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string EndPointTown = "";
            EndPointTown = EndPointTown.PadRight(25, 'a');
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //create a test for the parameter: PickupTime

        [TestMethod]
        public void PickupTimeExtremeMin()
        {
            //create an instance of the class we want to create
            clsDestination AnDestination = new clsDestination();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 year
            TestDate = TestDate.AddYears(-100);
            //convert the data variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnDestination.Valid(EndPointHouseNo, EndPointPostCode, EndPointStreet, EndPointTown, PickupTime, DropoffTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
