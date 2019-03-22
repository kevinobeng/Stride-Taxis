using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STMainClassLibrary;

namespace TestProjects
{
    [TestClass]
    public class tstDriver
    {
        public object LicenseNo { get; private set; }
        public object FirstName { get; private set; }
        public object LastName { get; private set; }
        public object Email { get; private set; }
        public object TelephoneNo { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsDriver AnDriver = new clsDriver();
            //test to see that it exists 
            Assert.IsNotNull(AnDriver);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsDriver AnDriver = new clsDriver();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnDriver.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnDriver.Active, TestData);
        }
        [TestMethod]
        public void LicenseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsDriver AnDriver = new clsDriver();
            //create some test data to assign to the property
            Int32 TestData = 1098789;
            //Assign the data to the property
            AnDriver.LicenseNo = TestData;
            //test to see that it exists 
            Assert.AreEqual(AnDriver.LicenseNo, TestData);
        }
        [TestMethod]
        public void LicenseNoMinLessOne()
        {
            //Create an instance of the clsPayment
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeLicenseNo = "123456789123456";
            //Invoke the method
            Error = ADriver.LicenseNoValid(SomeLicenseNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LicenseNoMinBoundary()
        {
            //Create an instance of the clsPayment
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeLicenseNo = "123456789123456";
            //Invoke the method
            Error = ADriver.LicenseNoValid(SomeLicenseNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LicenseNoMinPlusOne()
        {
            //Create an instance of the clsPayment
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeLicenseNo = "123456789123456";
            //Invoke the method
            Error = ADriver.LicenseNoValid(SomeLicenseNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LicenseNoMid()
        {
            //Create an instance of the clsPayment
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeLicenseNo = "123456789123456";
            //Invoke the method
            Error = ADriver.LicenseNoValid(SomeLicenseNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LicenseNoMaxLessOne()
        {
            //Create an instance of the clsPayment
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeLicenseNo = "123456789123456";
            //Invoke the method
            Error = ADriver.LicenseNoValid(SomeLicenseNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LicenseNoMaxBoundary()
        {
            //Create an instance of the clsPayment
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeLicenseNo = "123456789123456";
            //Invoke the method
            Error = ADriver.LicenseNoValid(SomeLicenseNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LicenseNoMaxPlusOne()
        {
            //Create an instance of the clsPayment
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeLicenseNo = "123456789123456";
            //Invoke the method
            Error = ADriver.LicenseNoValid(SomeLicenseNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LicenseNoExtremeMax()
        {
            //Create an instance of the clsPayment
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeLicenseNo = "123456789123456";
            //Invoke the method
            Error = ADriver.LicenseNoValid(SomeLicenseNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsDriver AnDriver = new clsDriver();
            //create some test data to assign to the property
            String TestData = "Test Email";
            //Assign the data to the property
            AnDriver.Email = TestData;
            //test to see that it exists 
            Assert.AreEqual(AnDriver.Email, TestData);
        }
        [TestMethod]
        public void EmailValidPaymentOK()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeEmail = "hammadghouri0@gmail.com";
            //Invoke the method
            Error = ADriver.EmailValid(SomeEmail);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeEmail = "A";
            //Invoke the method
            Error = ADriver.EmailValid(SomeEmail);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinBoundary()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeEmail = "A";
            //Invoke the method
            Error = ADriver.EmailValid(SomeEmail);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeEmail = "A";
            //Invoke the method
            Error = ADriver.EmailValid(SomeEmail);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeEmail = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //Invoke the method
            Error = ADriver.EmailValid(SomeEmail);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeEmail = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLM";
            //Invoke the method
            Error = ADriver.EmailValid(SomeEmail);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxBoundary()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeEmail = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMN";
            //Invoke the method
            Error = ADriver.EmailValid(SomeEmail);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeEmail = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMN";
            //Invoke the method
            Error = ADriver.EmailValid(SomeEmail);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeEmail = "";
            //Pad the string with characters
            SomeEmail = SomeEmail.PadRight(500, 'a');
            //Invoke the method
            Error = ADriver.EmailValid(SomeEmail);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsDriver AnDriver = new clsDriver();
            //create some test data to assign to the property
            String TestData = "Test FirstName";
            //Assign the data to the property
            AnDriver.FirstName = TestData;
            //test to see that it exists 
            Assert.AreEqual(AnDriver.FirstName, TestData);
        }

        [TestMethod]
        public void FirstNameValidPropertyOK()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeFirstName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMN";
            //Invoke the method
            Error = ADriver.FirstNameValid(SomeFirstName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeFirstName = "A";
            //Invoke the method
            Error = ADriver.FirstNameValid(SomeFirstName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinBoundary()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeFirstName = "A";
            //Invoke the method
            Error = ADriver.FirstNameValid(SomeFirstName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeFirstName = "A";
            //Invoke the method
            Error = ADriver.FirstNameValid(SomeFirstName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeFirstName = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //Invoke the method
            Error = ADriver.FirstNameValid(SomeFirstName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeFirstName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLM";
            //Invoke the method
            Error = ADriver.FirstNameValid(SomeFirstName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxBoundary()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeFirstName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMN";
            //Invoke the method
            Error = ADriver.FirstNameValid(SomeFirstName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeFirstName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMN";
            //Invoke the method
            Error = ADriver.FirstNameValid(SomeFirstName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeFirstName = "";
            //Pad the string with characters
            SomeFirstName = SomeFirstName.PadRight(500, 'a');
            //Invoke the method
            Error = ADriver.FirstNameValid(SomeFirstName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsDriver AnDriver = new clsDriver();
            //create some test data to assign to the property
            String TestData = "Test FirstName";
            //Assign the data to the property
            AnDriver.LastName = TestData;
            //test to see that it exists 
            Assert.AreEqual(AnDriver.LastName, TestData);
        }
        [TestMethod]
        public void LastNameValidPropertyOK()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeLastName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMN";
            //Invoke the method
            Error = ADriver.LastNameValid(SomeLastName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeLastName = "A";
            //Invoke the method
            Error = ADriver.LastNameValid(SomeLastName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinBoundary()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeLastName = "A";
            //Invoke the method
            Error = ADriver.LastNameValid(SomeLastName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeLastName = "A";
            //Invoke the method
            Error = ADriver.LastNameValid(SomeLastName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeLastName = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //Invoke the method
            Error = ADriver.LastNameValid(SomeLastName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeLastName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLM";
            //Invoke the method
            Error = ADriver.LastNameValid(SomeLastName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxBoundary()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeLastName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMN";
            //Invoke the method
            Error = ADriver.LastNameValid(SomeLastName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeLastName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMN";
            //Invoke the method
            Error = ADriver.LastNameValid(SomeLastName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //Create an instance of the clsDriver
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeLastName = "";
            //Pad the string with characters
            SomeLastName = SomeLastName.PadRight(500, 'a');
            //Invoke the method
            Error = ADriver.LastNameValid(SomeLastName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TelephoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsDriver AnDriver = new clsDriver();
            //create some test data to assign to the property
            Int32 TestData = 10258794;
            //Assign the data to the property
            AnDriver.TelephoneNo = TestData;
            //test to see that it exists 
            Assert.AreEqual(AnDriver.TelephoneNo, TestData);
        }
        [TestMethod]
        public void TelephoneNoMinLessOne()
        {
            //Create an instance of the clsPayment
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeTelephoneNo = "123456789123456";
            //Invoke the method
            Error = ADriver.TelephoneNoValid(SomeTelephoneNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TelephoneNoMinBoundary()
        {
            //Create an instance of the clsPayment
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeTelephoneNo = "123456789123456";
            //Invoke the method
            Error = ADriver.TelephoneNoValid(SomeTelephoneNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TelephoneNoMinPlusOne()
        {
            //Create an instance of the clsPayment
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeTelephoneNo = "123456789123456";
            //Invoke the method
            Error = ADriver.TelephoneNoValid(SomeTelephoneNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNoMid()
        {
            //Create an instance of the clsPayment
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeTelephoneNo = "123456789123456";
            //Invoke the method
            Error = ADriver.TelephoneNoValid(SomeTelephoneNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNoMaxLessOne()
        {
            //Create an instance of the clsPayment
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeTelephoneNo = "123456789123456";
            //Invoke the method
            Error = ADriver.TelephoneNoValid(SomeTelephoneNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNoMaxBoundary()
        {
            //Create an instance of the clsPayment
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeTelephoneNo = "123456789123456";
            //Invoke the method
            Error = ADriver.TelephoneNoValid(SomeTelephoneNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNoMaxPlusOne()
        {
            //Create an instance of the clsPayment
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeTelephoneNo = "123456789123456";
            //Invoke the method
            Error = ADriver.TelephoneNoValid(SomeTelephoneNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNoExtremeMax()
        {
            //Create an instance of the clsPayment
            clsDriver ADriver = new clsDriver();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeTelephoneNo = "123456789123456";
            //Invoke the method
            Error = ADriver.TelephoneNoValid(SomeTelephoneNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsDriver AnDriver = new clsDriver();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 LicenseNo = 1098789;
            //invoke the method
            Found = AnDriver.Find(LicenseNo);
            //test to see that the result is correct 
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestLicenseNoFound()
        {
            //create an instance of the class we want to create
            clsDriver AnDriver = new clsDriver();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LicenseNo = 1;
            //invoke the method
            Found = AnDriver.Find(LicenseNo);
            //check the License no
            if (AnDriver.LicenseNo != 1098789)
            {
                OK = true;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsDriver AnDriver = new clsDriver();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LicenseNo = 1;
            //invoke the method
            Found = AnDriver.Find(LicenseNo);
            //check the Email
            if (AnDriver.Email != "Test Email")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsDriver AnDriver = new clsDriver();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LicenseNo = 1;
            //invoke the method
            Found = AnDriver.Find(LicenseNo);
            //check the First Name
            if (AnDriver.FirstName != "Test FirstName")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsDriver AnDriver = new clsDriver();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LicenseNo = 1;
            //invoke the method
            Found = AnDriver.Find(LicenseNo);
            //check the Last Name
            if (AnDriver.LastName != "Test LastName")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTelephoneNoFound()
        {
            //create an instance of the class we want to create
            clsDriver AnDriver = new clsDriver();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LicenseNo = 1;
            //invoke the method
            Found = AnDriver.Find(LicenseNo);
            //check the Telephone no
            if (AnDriver.TelephoneNo != 10258794)
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
            clsDriver AnDriver = new clsDriver();
            //string variable to store any error message 
            String Error = "";
            //invoke the method
            Error = AnDriver.Valid(LicenseNo, FirstName, LastName, Email, TelephoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}
