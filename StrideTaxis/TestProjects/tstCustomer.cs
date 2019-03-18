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
            string SomeFirstName = "Hanna";
            //Invoke the method
            Error = ACustomer.FirstNameValid(SomeFirstName);
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

        [TestMethod]
        public void LastNameValidOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //Craete a string variable to store results
            string Error = "";
            //create some test data for the method
            string SomeLastName = "Burrows";
            //Invoke the method
            Error = ACustomer.LastNameValid(SomeLastName);
            //test to see result
            Assert.AreEqual(Error, "");
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

        [TestMethod]
        public void HouseNumberValidOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //Craete a string variable to store results
            string Error = "";
            //create some test data for the method
            string SomeHouseNumber = "1";
            //Invoke the method
            Error = ACustomer.HouseNumberValid(SomeHouseNumber);
            //test to see result
            Assert.AreEqual(Error, "");
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

        [TestMethod]
        public void TownValidOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //Craete a string variable to store results
            string Error = "";
            //create some test data for the method
            string SomeTown = "Leicestershire";
            //Invoke the method
            Error = ACustomer.TownValid(SomeTown);
            //test to see result
            Assert.AreEqual(Error, "");
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

        [TestMethod]
        public void StreetValidOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //Craete a string variable to store results
            string Error = "";
            //create some test data for the method
            string SomeStreet = "The Pastures";
            //Invoke the method
            Error = ACustomer.StreetValid(SomeStreet);
            //test to see result
            Assert.AreEqual(Error, "");
        }

        ///////////////////////////////////////////////////////////////PostCode

        [TestMethod]
        public void PostCodeOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a test for the data
            String SomePostCode = "LE14 3DU";
            //asign the data to the property
            ACustomer.PostCode = SomePostCode;
            //test to see that it exists
            Assert.AreEqual(ACustomer.PostCode, SomePostCode);
        }

        [TestMethod]
        public void PostCodeValidOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //Craete a string variable to store results
            string Error = "";
            //create some test data for the method
            string SomePostCode = "LE14 3DU";
            //Invoke the method
            Error = ACustomer.PostCodeValid(SomePostCode);
            //test to see result
            Assert.AreEqual(Error, "");
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

        [TestMethod]
        public void EmailValidOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //Craete a string variable to store results
            string Error = "";
            //create some test data for the method
            string SomeEmail = "abc@abc.co.uk";
            //Invoke the method
            Error = ACustomer.EmailValid(SomeEmail);
            //test to see result
            Assert.AreEqual(Error, "");
        }

        ///////////////////////////////////////////////////////////////TelephoneNumber

        [TestMethod]
        public void TelephoneNumberOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a test for the data
            Int32 SomeTelephoneNumber = 1;
            //asign the data to the property
            ACustomer.TelephoneNumber = SomeTelephoneNumber;
            //test to see that it exists
            Assert.AreEqual(ACustomer.TelephoneNumber, SomeTelephoneNumber);
        }

        [TestMethod]
        public void TelephoneNumberValidOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //Craete a string variable to store results
            string Error = "";
            //create some test data for the method
            string SomeTelephoneNumber = "1";
            //Invoke the method
            Error = ACustomer.TelephoneNumberValid(SomeTelephoneNumber);
            //test to see result
            Assert.AreEqual(Error, "");
        }
    }
}
