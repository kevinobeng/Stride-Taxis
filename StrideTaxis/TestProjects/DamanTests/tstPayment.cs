using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STMainClassLibrary;

namespace TestProjects.DamanTests
{
    [TestClass]
    public class tstPayment
    {
        [TestMethod]
        public void PaymentInstanceOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Test to see if that class exists
            Assert.IsNotNull(APayment);
        }

        [TestMethod]
        public void AccountNumberPropertyOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            string SomePayment = "AccountNumber";
            //Assign the data to the property
            APayment.Payment = SomePayment;
            //Test to see that the two values are the same
            Assert.AreEqual(APayment.Payment, SomePayment);
        }

        [TestMethod]
        public void PaymentNoOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            Int32 PaymentNo = 1;
            //Assign the data to the property
            APayment.PaymentNo = PaymentNo;
            //Test to see that the two values are the same
            Assert.AreEqual(APayment.PaymentNo, PaymentNo);
        }

        [TestMethod]
        public void ValidPaymentOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "AccountNumber";
            //Invoke the method
            Error = APayment.Valid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountNumberMinLessOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "";
            //Invoke the method
            Error = APayment.Valid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountNumberMinBoundary()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "1";
            //Invoke the method
            Error = APayment.Valid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountNumberMinPlusOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "12";
            //Invoke the method
            Error = APayment.Valid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountNumberMaxLessOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "12345678";
            //Invoke the method
            Error = APayment.Valid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountNumberMaxBoundary()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "123456789";
            //Invoke the method
            Error = APayment.Valid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountNumberMaxPlusOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "1234567899";
            //Invoke the method
            Error = APayment.Valid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
    }
}
