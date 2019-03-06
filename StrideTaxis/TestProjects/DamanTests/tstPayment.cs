using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STMainClassLibrary;

namespace TestProjects.DamanTests
{
    [TestClass]
    public class tstPayment
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Invoice Number Test Codes
        [TestMethod]
        public void PaymentInstanceOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Test to see if that class exists
            Assert.IsNotNull(APayment);
        }

        [TestMethod]
        public void InvoiceNumberPropertyOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            string SomePayment = "InvoiceNumber";
            //Assign the data to the property
            APayment.Payment = SomePayment;
            //Test to see that the two values are the same
            Assert.AreEqual(APayment.Payment, SomePayment);
        }

        [TestMethod]
        public void InvoicePaymentNoOK()
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
        public void InvoiceValidPaymentOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InvoiceNumberMinLessOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InvoiceNumberMinBoundary()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InvoiceNumberMinPlusOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InvoiceNumberMaxLessOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InvoiceNumberMaxBoundary()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InvoiceNumberMaxPlusOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Payment Type Test Codes

        [TestMethod]
        public void PaymentTypePropertyOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            string SomePayment = "InvoiceNumber";
            //Assign the data to the property
            APayment.Payment = SomePayment;
            //Test to see that the two values are the same
            Assert.AreEqual(APayment.Payment, SomePayment);
        }

        [TestMethod]
        public void PaymentTypeNoOK()
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
        public void PaymentTypeValidPaymentOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "12345678912345678912";
            //Invoke the method
            Error = APayment.PaymentTypeValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentTypeMinLessOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "12345678912345678912";
            //Invoke the method
            Error = APayment.PaymentTypeValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentTypeMinBoundary()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "12345678912345678912";
            //Invoke the method
            Error = APayment.PaymentTypeValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentTypeMinPlusOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "12345678912345678912";
            //Invoke the method
            Error = APayment.PaymentTypeValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentTypeMaxLessOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "12345678912345678912";
            //Invoke the method
            Error = APayment.PaymentTypeValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentTypeMaxBoundary()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "12345678912345678912";
            //Invoke the method
            Error = APayment.PaymentTypeValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentTypeMaxPlusOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "12345678912345678912";
            //Invoke the method
            Error = APayment.PaymentTypeValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Price Test Codes

        [TestMethod]
        public void PricePropertyOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            string SomePayment = "InvoiceNumber";
            //Assign the data to the property
            APayment.Payment = SomePayment;
            //Test to see that the two values are the same
            Assert.AreEqual(APayment.Payment, SomePayment);
        }

        [TestMethod]
        public void PricePaymentNoOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            Double PricePaymentNo = 23.20;
            //Assign the data to the property
            APayment.PricePaymentNo = PricePaymentNo;
            //Test to see that the two values are the same
            Assert.AreEqual(APayment.PaymentNo, PricePaymentNo);
        }

        [TestMethod]
        public void InvoiceValidPaymentOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InvoiceNumberMinLessOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InvoiceNumberMinBoundary()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InvoiceNumberMinPlusOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InvoiceNumberMaxLessOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InvoiceNumberMaxBoundary()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InvoiceNumberMaxPlusOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Account Number Test Codes

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
        public void AccountValidPaymentOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePayment = "12345678";
            //Invoke the method
            Error = APayment.AccountNumberValid(SomePayment);
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
            string SomePayment = "12345678";
            //Invoke the method
            Error = APayment.AccountNumberValid(SomePayment);
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
            string SomePayment = "12345678";
            //Invoke the method
            Error = APayment.AccountNumberValid(SomePayment);
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
            string SomePayment = "12345678";
            //Invoke the method
            Error = APayment.AccountNumberValid(SomePayment);
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
            Error = APayment.AccountNumberValid(SomePayment);
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
            string SomePayment = "12345678";
            //Invoke the method
            Error = APayment.AccountNumberValid(SomePayment);
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
            string SomePayment = "12345678";
            //Invoke the method
            Error = APayment.AccountNumberValid(SomePayment);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
    }
}
