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

         //////////////////////////////////////////////////////////////UserName
        
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
        public void UserNumberValidOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //Craete a string variable to store results
            string Error = "";
            //create some test data for the method
            string SomeUserNumber = "1";
            //Invoke the method
            Error = ACustomer.UserNumberValid(SomeUserNumber);
            //test to see result
            Assert.AreEqual(Error, "");
        }
        //////////////////////////////////////////////////////////////FirstName

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
        public void FirstNameValidOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //Craete a string variable to store results
            string Error = "";
            //create some test data for the method
            string SomeUserNumber = "1";
            //Invoke the method
            Error = ACustomer.UserNumberValid(SomeUserNumber);
            //test to see result
            Assert.AreEqual(Error, "");
        }

        //////////////////////////////////////////////////////////////LastName

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

        ///////////////////////////////////////////////////////////////HouseNumber

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

        ///////////////////////////////////////////////////////////////Town

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

        ///////////////////////////////////////////////////////////////Street

        [TestMethod]
        public void StreetOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a test for the data
            String SomeStreet = "The Pastures";
            //asign the data to the property
            ACustomer.Street = SomeStreet;
            //test to see that it exists
            Assert.AreEqual(ACustomer.Street, SomeStreet);
        }

        ///////////////////////////////////////////////////////////////PostCode

        [TestMethod]
        public void PostCodeOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a test for the data
            String SomePostCode = "LE19 3DU";
            //asign the data to the property
            ACustomer.PostCode = SomePostCode;
            //test to see that it exists
            Assert.AreEqual(ACustomer.PostCode, SomePostCode);
        }

        ///////////////////////////////////////////////////////////////Email

        [TestMethod]
        public void EmailOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a test for the data
            String SomeEmail = "abc@abc.co.uk";
            //asign the data to the property
            ACustomer.Email = SomeEmail;
            //test to see that it exists
            Assert.AreEqual(ACustomer.Email, SomeEmail);
        }

        ///////////////////////////////////////////////////////////////TelephoneNumber

        [TestMethod]
        public void TelephoneNumberOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a test for the data
            Int32 SomeTelephoneNumber = 0;
            //asign the data to the property
            ACustomer.TelephoneNumber = SomeTelephoneNumber;
            //test to see that it exists
            Assert.AreEqual(ACustomer.TelephoneNumber, SomeTelephoneNumber);
        }
    }
}
