using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STMainClassLibrary;

namespace TestProjects.DamanTests
{
    [TestClass]
    public class tstPayment
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Payment Instance Test Code
        [TestMethod]
        public void PaymentInstanceOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Test to see if that class exists
            Assert.IsNotNull(APayment);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Primary Key Payment ID Test Code
        [TestMethod]
        public void PaymentIDPropertyOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            string SomePaymentID = "1";
            //Assign the data to the property
            APayment.PaymentID = SomePaymentID;
            //Test to see that the two values are the same
            Assert.AreEqual(APayment.PaymentID, SomePaymentID);
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Invoice No Test Codes

        [TestMethod]
        public void InvoiceNoPropertyOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            string SomeInvoiceNo = "123456789123456";
            //Assign the data to the property
            APayment.InvoiceNo = SomeInvoiceNo;
            //Test to see that the two values are the same
            Assert.AreEqual(APayment.InvoiceNo, SomeInvoiceNo);
        }

        [TestMethod]
        public void InvoiceValidPaymentOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeInvoiceNo = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomeInvoiceNo);
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
            string SomeInvoiceNo = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomeInvoiceNo);
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
            string SomeInvoiceNo = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomeInvoiceNo);
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
            string SomeInvoiceNo = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomeInvoiceNo);
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
            string SomeInvoiceNo = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomeInvoiceNo);
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
            string SomeInvoiceNo = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomeInvoiceNo);
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
            string SomeInvoiceNo = "123456789123456";
            //Invoke the method
            Error = APayment.InvoiceValid(SomeInvoiceNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Payment Type Test Codes

        [TestMethod]
        public void PaymentTypePropertyOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            string SomePaymentType = "12345678912345678912";
            //Assign the data to the property
            APayment.PaymentType = SomePaymentType;
            //Test to see that the two values are the same
            Assert.AreEqual(APayment.PaymentType, SomePaymentType);
        }

        [TestMethod]
        public void PaymentTypeValidPaymentOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomePaymentType = "12345678912345678912";
            //Invoke the method
            Error = APayment.PaymentTypeValid(SomePaymentType);
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
            string SomePaymentType = "12345678912345678912";
            //Invoke the method
            Error = APayment.PaymentTypeValid(SomePaymentType);
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
            string SomePaymentType = "12345678912345678912";
            //Invoke the method
            Error = APayment.PaymentTypeValid(SomePaymentType);
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
            string SomePaymentType = "12345678912345678912";
            //Invoke the method
            Error = APayment.PaymentTypeValid(SomePaymentType);
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
            string SomePaymentType = "12345678912345678912";
            //Invoke the method
            Error = APayment.PaymentTypeValid(SomePaymentType);
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
            string SomePaymentType = "12345678912345678912";
            //Invoke the method
            Error = APayment.PaymentTypeValid(SomePaymentType);
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
            string SomePaymentType = "12345678912345678912";
            //Invoke the method
            Error = APayment.PaymentTypeValid(SomePaymentType);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Price Test Codes

        //[TestMethod]
        //public void PricePropertyOK()
        //{
        //    //Create an instance of the clsPayment
        //    clsPayment APayment = new clsPayment();
        //    //Create some test data to assign to the property
        //    Decimal SomePrice = 2m;
        //    //Assign the data to the property
        //    APayment.Price = SomePrice;
        //    //Test to see that the two values are the same
        //    Assert.AreEqual(APayment.Price, SomePrice);
        //}

        //[TestMethod]
        //public void PriceValidPaymentOK()
        //{
        //    //Create an instance of the clsPayment
        //    clsPayment APayment = new clsPayment();
        //    //Create a string variable to store the result of the validation
        //    string Error = "";
        //    //Create some test data to the method
        //    string PricePaymentNo = "123456789123456";
        //    //Invoke the method
        //    Error = APayment.PriceValid(PricePaymentNo);
        //    //Test to see that the result is OK, i.e. there was error messages returned
        //    Assert.AreEqual(Error, "");
        //}

        ////[TestMethod]
        ////public void PriceMinLessOne()
        ////{
        ////    //Create an instance of the clsPayment
        ////    clsPayment APayment = new clsPayment();
        ////    //Create a string variable to store the result of the validation
        ////    string Error = "";
        ////    //Create some test data to the method
        ////    string SomePayment = "123456789123456";
        ////    //Invoke the method
        ////    Error = APayment.PriceValid(SomePayment);
        ////    //Test to see that the result is OK, i.e. there was error messages returned
        ////    Assert.AreEqual(Error, "");
        ////}

        ////[TestMethod]
        ////public void PriceMinBoundary()
        ////{
        ////    //Create an instance of the clsPayment
        ////    clsPayment APayment = new clsPayment();
        ////    //Create a string variable to store the result of the validation
        ////    string Error = "";
        ////    //Create some test data to the method
        ////    string SomePayment = "123456789123456";
        ////    //Invoke the method
        ////    Error = APayment.PriceValid(SomePayment);
        ////    //Test to see that the result is OK, i.e. there was error messages returned
        ////    Assert.AreEqual(Error, "");
        ////}

        ////[TestMethod]
        ////public void PriceMinPlusOne()
        ////{
        ////    //Create an instance of the clsPayment
        ////    clsPayment APayment = new clsPayment();
        ////    //Create a string variable to store the result of the validation
        ////    string Error = "";
        ////    //Create some test data to the method
        ////    string SomePayment = "123456789123456";
        ////    //Invoke the method
        ////    Error = APayment.PriceValid(SomePayment);
        ////    //Test to see that the result is OK, i.e. there was error messages returned
        ////    Assert.AreEqual(Error, "");
        ////}

        ////[TestMethod]
        ////public void PriceMaxLessOne()
        ////{
        ////    //Create an instance of the clsPayment
        ////    clsPayment APayment = new clsPayment();
        ////    //Create a string variable to store the result of the validation
        ////    string Error = "";
        ////    //Create some test data to the method
        ////    string SomePayment = "123456789123456";
        ////    //Invoke the method
        ////    Error = APayment.PriceValid(SomePayment);
        ////    //Test to see that the result is OK, i.e. there was error messages returned
        ////    Assert.AreEqual(Error, "");
        ////}

        ////[TestMethod]
        ////public void PriceMaxBoundary()
        ////{
        ////    //Create an instance of the clsPayment
        ////    clsPayment APayment = new clsPayment();
        ////    //Create a string variable to store the result of the validation
        ////    string Error = "";
        ////    //Create some test data to the method
        ////    string SomePayment = "123456789123456";
        ////    //Invoke the method
        ////    Error = APayment.PriceValid(SomePayment);
        ////    //Test to see that the result is OK, i.e. there was error messages returned
        ////    Assert.AreEqual(Error, "");
        ////}

        ////[TestMethod]
        ////public void PriceMaxPlusOne()
        ////{
        ////    //Create an instance of the clsPayment
        ////    clsPayment APayment = new clsPayment();
        ////    //Create a string variable to store the result of the validation
        ////    string Error = "";
        ////    //Create some test data to the method
        ////    string SomePayment = "123456789123456";
        ////    //Invoke the method
        ////    Error = APayment.PriceValid(SomePayment);
        ////    //Test to see that the result is OK, i.e. there was error messages returned
        ////    Assert.AreEqual(Error, "");
        ////}

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Payment Date Test Codes

        [TestMethod]
        public void PaymentDatePropertyOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            DateTime SomePaymentDate = Convert.ToDateTime("05/05/2006");
            //Assign the data to the property
            APayment.PaymentDate = SomePaymentDate;
            //Test to see that the two values are the same
            Assert.AreEqual(APayment.PaymentDate, SomePaymentDate);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Payment Time Test Codes

        [TestMethod]
        public void PaymentTimePropertyOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            DateTime SomePaymentTime = Convert.ToDateTime("00:00");
            //Assign the data to the property
            APayment.PaymentTime = SomePaymentTime;
            //Test to see that the two values are the same
            Assert.AreEqual(APayment.PaymentTime, SomePaymentTime);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Card Number Test Codes

        [TestMethod]
        public void CardNumberPropertyOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            string SomeCardNumber = "1234567891234567";
            //Assign the data to the property
            APayment.CardNumber = SomeCardNumber;
            //Test to see that the two values are the same
            Assert.AreEqual(APayment.CardNumber, SomeCardNumber);
        }

        [TestMethod]
        public void CardNumberValidPaymentOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCardNumber = "1234567891234567";
            //Invoke the method
            Error = APayment.CardNumberValid(SomeCardNumber);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardNumberMinLessOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCardNumber = "1234567891234567";
            //Invoke the method
            Error = APayment.CardNumberValid(SomeCardNumber);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardNumberMinBoundary()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCardNumber = "1234567891234567";
            //Invoke the method
            Error = APayment.CardNumberValid(SomeCardNumber);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardNumberMinPlusOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCardNumber = "1234567891234567";
            //Invoke the method
            Error = APayment.CardNumberValid(SomeCardNumber);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardNumberMaxLessOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCardNumber = "1234567891234567";
            //Invoke the method
            Error = APayment.CardNumberValid(SomeCardNumber);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardNumberMaxBoundary()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCardNumber = "1234567891234567";
            //Invoke the method
            Error = APayment.CardNumberValid(SomeCardNumber);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardNumberMaxPlusOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCardNumber = "1234567891234567";
            //Invoke the method
            Error = APayment.CardNumberValid(SomeCardNumber);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Account Number Test Codes
        [TestMethod]
        public void AccountNumberPropertyOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            string SomeAccountNumber = "123456789";
            //Assign the data to the property
            APayment.AccountNumber = SomeAccountNumber;
            //Test to see that the two values are the same
            Assert.AreEqual(APayment.AccountNumber, SomeAccountNumber);
        }

        [TestMethod]
        public void AccountValidPaymentOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeAccountNumber = "123456789";
            //Invoke the method
            Error = APayment.AccountNumberValid(SomeAccountNumber);
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
            string SomeAccountNumber = "123456789";
            //Invoke the method
            Error = APayment.AccountNumberValid(SomeAccountNumber);
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
            string SomeAccountNumber = "123456789";
            //Invoke the method
            Error = APayment.AccountNumberValid(SomeAccountNumber);
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
            string SomeAccountNumber = "123456789";
            //Invoke the method
            Error = APayment.AccountNumberValid(SomeAccountNumber);
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
            string SomeAccountNumber = "123456789";
            //Invoke the method
            Error = APayment.AccountNumberValid(SomeAccountNumber);
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
            string SomeAccountNumber = "123456789";
            //Invoke the method
            Error = APayment.AccountNumberValid(SomeAccountNumber);
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
            string SomeAccountNumber = "123456789";
            //Invoke the method
            Error = APayment.AccountNumberValid(SomeAccountNumber);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Sort Code Test Codes

        [TestMethod]
        public void SortCodePropertyOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            string SomeSortCode = "123456";
            //Assign the data to the property
            APayment.SortCode = SomeSortCode;
            //Test to see that the two values are the same
            Assert.AreEqual(APayment.SortCode, SomeSortCode);
        }

        [TestMethod]
        public void SortCodeValidPaymentOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeSortCode = "123456";
            //Invoke the method
            Error = APayment.SortCodeValid(SomeSortCode);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SortCodeMinLessOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeSortCode = "123456";
            //Invoke the method
            Error = APayment.SortCodeValid(SomeSortCode);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SortCodeMinBoundary()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeSortCode = "123456";
            //Invoke the method
            Error = APayment.SortCodeValid(SomeSortCode);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SortCodeMinPlusOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeSortCode = "123456";
            //Invoke the method
            Error = APayment.SortCodeValid(SomeSortCode);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SortCodeMaxLessOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeSortCode = "123456";
            //Invoke the method
            Error = APayment.SortCodeValid(SomeSortCode);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SortCodeMaxBoundary()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeSortCode = "123456";
            //Invoke the method
            Error = APayment.SortCodeValid(SomeSortCode);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SortCodeMaxPlusOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeSortCode = "123456";
            //Invoke the method
            Error = APayment.SortCodeValid(SomeSortCode);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Expiry Date Test Code
        [TestMethod]
        public void ExpiryDatePropertyOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            DateTime SomeExpiryDate = Convert.ToDateTime("01/12/98");
            //Assign the data to the property
            APayment.ExpiryDate = SomeExpiryDate;
            //Test to see that the two values are the same
            Assert.AreEqual(APayment.ExpiryDate, SomeExpiryDate);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Expiry Date Test Code
        [TestMethod]
        public void ValidFromPropertyOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            DateTime SomeValidFrom = Convert.ToDateTime("01/11/98");
            //Assign the data to the property
            APayment.ValidFrom = SomeValidFrom;
            //Test to see that the two values are the same
            Assert.AreEqual(APayment.ValidFrom, SomeValidFrom);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Card Holder Name Test Codes

        [TestMethod]
        public void CardHolderNamePropertyOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            string SomeCardHolderName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLM";
            //Assign the data to the property
            APayment.CardHolderName = SomeCardHolderName;
            //Test to see that the two values are the same
            Assert.AreEqual(APayment.CardHolderName, SomeCardHolderName);
        }

        [TestMethod]
        public void CardHolderNameValidPaymentOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCardHolderName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMN";
            //Invoke the method
            Error = APayment.CardHolderNameValid(SomeCardHolderName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardHolderNameMinLessOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCardHolderName = "A";
            //Invoke the method
            Error = APayment.CardHolderNameValid(SomeCardHolderName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardHolderNameMinBoundary()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCardHolderName = "A";
            //Invoke the method
            Error = APayment.CardHolderNameValid(SomeCardHolderName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardHolderNameMinPlusOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCardHolderName = "AB";
            //Invoke the method
            Error = APayment.CardHolderNameValid(SomeCardHolderName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardHolderNameMaxLessOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCardHolderName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLM";
            //Invoke the method
            Error = APayment.CardHolderNameValid(SomeCardHolderName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardHolderNameMaxBoundary()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCardHolderName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMN";
            //Invoke the method
            Error = APayment.CardHolderNameValid(SomeCardHolderName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardHolderNameMaxPlusOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCardHolderName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMN";
            //Invoke the method
            Error = APayment.CardHolderNameValid(SomeCardHolderName);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////CVC Test Codes

        [TestMethod]
        public void CVCPropertyOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            string SomeCVC = "123";
            //Assign the data to the property
            APayment.CVC = SomeCVC;
            //Test to see that the two values are the same
            Assert.AreEqual(APayment.CVC, SomeCVC);
        }

        [TestMethod]
        public void CVCValidPaymentOK()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCVC = "123";
            //Invoke the method
            Error = APayment.CVCValid(SomeCVC);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CVCMinLessOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCVC = "123";
            //Invoke the method
            Error = APayment.CVCValid(SomeCVC);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CVCMinBoundary()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCVC = "123";
            //Invoke the method
            Error = APayment.CVCValid(SomeCVC);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CVCMinPlusOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCVC = "123";
            //Invoke the method
            Error = APayment.CVCValid(SomeCVC);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CVCMaxLessOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCVC = "123";
            //Invoke the method
            Error = APayment.CVCValid(SomeCVC);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CVCMaxBoundary()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCVC = "123";
            //Invoke the method
            Error = APayment.CVCValid(SomeCVC);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CVCMaxPlusOne()
        {
            //Create an instance of the clsPayment
            clsPayment APayment = new clsPayment();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCVC = "123";
            //Invoke the method
            Error = APayment.CVCValid(SomeCVC);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
    }
}
