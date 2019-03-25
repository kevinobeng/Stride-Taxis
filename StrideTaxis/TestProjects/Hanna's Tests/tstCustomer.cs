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
        
        //////////////////////////////////////////////////////////////Findtest

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result
            Boolean Found = false;
            //create some test data to use
            Int32 UserNumber = 1;
            //invoked the method
            Found = ACustomer.Find(UserNumber);
            //test to see it works
            Assert.IsTrue(Found);
        }
          
        //////////////////////////////////////////////////////////////UserNumber

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
        public void TestUserNumberFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use
            Int32 UserNumber = 21;
            //invoked the method
            Found = ACustomer.Find(UserNumber);
            //check the user number
            if (ACustomer.UserNumber != 21)
            {
                OK = false;
            }
            //test to see that the result is found
            Assert.IsNotNull(ACustomer);
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
        public void TestFirstNameFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use
            Int32 UserNumber = 21;
            //invoked the method
            Found = ACustomer.Find(UserNumber);
            //check the user number
            if (ACustomer.FirstName != "Test First Name")
            {
                OK = false;
            }
            //test to see that the result is found
            Assert.IsNotNull(ACustomer);
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
        public void TestLastNameFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use
            Int32 UserNumber = 21;
            //invoked the method
            Found = ACustomer.Find(UserNumber);
            //check the user number
            if (ACustomer.LastName != "Test Last Name")
            {
                OK = false;
            }
            //test to see that the result is found
            Assert.IsNotNull(ACustomer);
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
        public void TestHouseNumberFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use
            Int32 UserNumber = 21;
            //invoked the method
            Found = ACustomer.Find(UserNumber);
            //check the user number
            if (ACustomer.HouseNumber != 60)
            {
                OK = false;
            }
            //test to see that the result is found
            Assert.IsNotNull(ACustomer);
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
        public void TestTownFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use
            Int32 UserNumber = 21;
            //invoked the method
            Found = ACustomer.Find(UserNumber);
            //check the user number
            if (ACustomer.Town != "Test Town")
            {
                OK = false;
            }
            //test to see that the result is found
            Assert.IsNotNull(ACustomer);
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
        public void TestStreetFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use
            Int32 UserNumber = 21;
            //invoked the method
            Found = ACustomer.Find(UserNumber);
            //check the user number
            if (ACustomer.Street != "Test Street")
            {
                OK = false;
            }
            //test to see that the result is found
            Assert.IsNotNull(ACustomer);
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
        public void TestPostCodeFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use
            Int32 UserNumber = 21;
            //invoked the method
            Found = ACustomer.Find(UserNumber);
            //check the user number
            if (ACustomer.PostCode != "XXXX XXX")
            {
                OK = false;
            }
            //test to see that the result is found
            Assert.IsNotNull(ACustomer);
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
        public void TestEmailFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use
            Int32 UserNumber = 21;
            //invoked the method
            Found = ACustomer.Find(UserNumber);
            //check the user number
            if (ACustomer.Email != "Test Email")
            {
                OK = false;
            }
            //test to see that the result is found
            Assert.IsNotNull(ACustomer);
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
        public void TestTelephoneNumberFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use
            Int32 UserNumber = 21;
            //invoked the method
            Found = ACustomer.Find(UserNumber);
            //check the user number
            if (ACustomer.TelephoneNumber != 0116)
            {
                OK = false;
            }
            //test to see that the result is found
            Assert.IsNotNull(ACustomer);
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
