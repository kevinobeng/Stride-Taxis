using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STMainClassLibrary;

namespace TestProjects
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void UserNumberOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a test for the data
            Int32 SomeUserNumber = 1;
            //asign the data to the property
            ACustomer.UserNumber = SomeUserNumber;
                    //test to see that it exists
            Assert.AreEqual(ACustomer.UserNumber, SomeUserNumber);
        }

        [TestMethod]
        public void FirstNameOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a test for the data
            String SomeFirstName = "Hanna";
            //asign the data to the property
            ACustomer.FirstName = SomeFirstName;
            //test to see that it exists
            Assert.AreEqual(ACustomer.FirstName, SomeFirstName);
        }

        [TestMethod]
        public void LastNameOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a test for the data
            String SomeLastName = "Burrows";
            //asign the data to the property
            ACustomer.LastName = SomeLastName;
            //test to see that it exists
            Assert.AreEqual(ACustomer.LastName, SomeLastName);
        }

        [TestMethod]
        public void HouseNumberOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a test for the data
            Int32 SomeHouseNumber = 1;
            //asign the data to the property
            ACustomer.HouseNumber = SomeHouseNumber;
            //test to see that it exists
            Assert.AreEqual(ACustomer.HouseNumber, SomeHouseNumber);
        }

        [TestMethod]
        public void TownOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a test for the data
            String SomeTown = "Leicestershire";
            //asign the data to the property
            ACustomer.Town = SomeTown;
            //test to see that it exists
            Assert.AreEqual(ACustomer.Town, SomeTown);
        }

        [TestMethod]
        public void StreetOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a test for the data
            Int32 SomeUserNumber = 1;
            //asign the data to the property
            ACustomer.UserNumber = SomeUserNumber;
            //test to see that it exists
            Assert.AreEqual(ACustomer.UserNumber, SomeUserNumber);
        }

        [TestMethod]
        public void PostCodeOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a test for the data
            Int32 SomeUserNumber = 1;
            //asign the data to the property
            ACustomer.UserNumber = SomeUserNumber;
            //test to see that it exists
            Assert.AreEqual(ACustomer.UserNumber, SomeUserNumber);
        }

        [TestMethod]
        public void EmailOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a test for the data
            Int32 SomeUserNumber = 1;
            //asign the data to the property
            ACustomer.UserNumber = SomeUserNumber;
            //test to see that it exists
            Assert.AreEqual(ACustomer.UserNumber, SomeUserNumber);
        }

        [TestMethod]
        public void TelephoneNumberOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a test for the data
            Int32 SomeUserNumber = 1;
            //asign the data to the property
            ACustomer.UserNumber = SomeUserNumber;
            //test to see that it exists
            Assert.AreEqual(ACustomer.UserNumber, SomeUserNumber);
        }
    }
}
