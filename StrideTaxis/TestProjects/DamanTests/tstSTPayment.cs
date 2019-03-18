using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STMainClassLibrary;

namespace TestProjects.DamanTests
{
    [TestClass]
    public class tstSTPayment
    {
        //Good test data
        //Create some test data to pass to the method
        string InvoiceNo = "123456789123456";
        string PaymentType = "Card";
        string Price = Convert.ToString("40");
        string PaymentDate = DateTime.Now.Date.ToString();
        string PaymentTime = DateTime.Now.TimeOfDay.ToString();
        string CardNumber = "1234567891234567";
        string AccountNumber = "12345678";
        string SortCode = "123456";
        string ExpiryDate = DateTime.Now.Date.ToString();
        string ValidFrom = DateTime.Now.Date.ToString();
        string CardHolderName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLM";
        string CVC = "123";

        [TestMethod]
        public void InstanceSTOkay()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Test to see if that class exists
            Assert.IsNotNull(STPayment);
        }

        [TestMethod]
        public void PaymentIDPropertyOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Create some test data to assign to the property
            Int32 SomePaymentID = 1;
            //Assign the data to the property
            STPayment.PaymentID = SomePaymentID;
            //Test to see that the two values are the same
            Assert.AreEqual(STPayment.PaymentID, SomePaymentID);
        }

        [TestMethod]
        public void InvoiceNoPropertyOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Create some test data to assign to the property
            string SomeInvoiceNo = "123456789123456";
            //Assign the data to the property
            STPayment.InvoiceNo = SomeInvoiceNo;
            //Test to see that the two values are the same
            Assert.AreEqual(STPayment.InvoiceNo, SomeInvoiceNo);
        }

        [TestMethod]
        public void PaymentTypePropertyOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Create some test data to assign to the property
            string SomePaymentType = "Card";
            //Assign the data to the property
            STPayment.PaymentType = SomePaymentType;
            //Test to see that the two values are the same
            Assert.AreEqual(STPayment.PaymentType, SomePaymentType);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Create some test data to assign to the property
            Decimal SomePrice = Convert.ToDecimal(40.0);
            //Assign the data to the property
            STPayment.Price = SomePrice;
            //Test to see that the two values are the same
            Assert.AreEqual(STPayment.Price, SomePrice);
        }

        [TestMethod]
        public void PaymentDatePropertyOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Create some test data to assign to the property
            DateTime SomePaymentDate = DateTime.Now.Date;
            //Assign the data to the property
            STPayment.PaymentDate = SomePaymentDate;
            //Test to see that the two values are the same
            Assert.AreEqual(STPayment.PaymentDate, SomePaymentDate);
        }

        [TestMethod]
        public void PaymentTimePropertyOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Create some test data to assign to the property
            DateTime SomePaymentTime = DateTime.Now.Date;
            //Assign the data to the property
            STPayment.PaymentTime = SomePaymentTime;
            //Test to see that the two values are the same
            Assert.AreEqual(STPayment.PaymentTime, SomePaymentTime);
        }

        [TestMethod]
        public void CardNumberPropertyOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Create some test data to assign to the property
            string SomeCardNumber = "1234567891234567";
            //Assign the data to the property
            STPayment.CardNumber = SomeCardNumber;
            //Test to see that the two values are the same
            Assert.AreEqual(STPayment.CardNumber, SomeCardNumber);
        }

        [TestMethod]
        public void AccountNumberPropertyOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Create some test data to assign to the property
            string SomeAccountNumber = "123456789";
            //Assign the data to the property
            STPayment.AccountNumber = SomeAccountNumber;
            //Test to see that the two values are the same
            Assert.AreEqual(STPayment.AccountNumber, SomeAccountNumber);
        }

        [TestMethod]
        public void SortCodePropertyOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Create some test data to assign to the property
            string SomeSortCode = "123456";
            //Assign the data to the property
            STPayment.SortCode = SomeSortCode;
            //Test to see that the two values are the same
            Assert.AreEqual(STPayment.SortCode, SomeSortCode);
        }

        [TestMethod]
        public void ExpiryDatePropertyOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Create some test data to assign to the property
            DateTime SomeExpiryDate = DateTime.Now.Date;
            //Assign the data to the property
            STPayment.ExpiryDate = SomeExpiryDate;
            //Test to see that the two values are the same
            Assert.AreEqual(STPayment.ExpiryDate, SomeExpiryDate);
        }

        [TestMethod]
        public void ValidFromPropertyOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Create some test data to assign to the property
            DateTime SomeValidFrom = DateTime.Now.Date;
            //Assign the data to the property
            STPayment.ValidFrom = SomeValidFrom;
            //Test to see that the two values are the same
            Assert.AreEqual(STPayment.ValidFrom, SomeValidFrom);
        }

        [TestMethod]
        public void CardHolderNamePropertyOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Create some test data to assign to the property
            string SomeCardHolderName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLM";
            //Assign the data to the property
            STPayment.CardHolderName = SomeCardHolderName;
            //Test to see that the two values are the same
            Assert.AreEqual(STPayment.CardHolderName, SomeCardHolderName);
        }

        [TestMethod]
        public void CVCPropertyOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Create some test data to assign to the property
            string SomeCVC = "123";
            //Assign the data to the property
            STPayment.CVC = SomeCVC;
            //Test to see that the two values are the same
            Assert.AreEqual(STPayment.CVC, SomeCVC);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 PaymentID = 1;
            //Invoke the method
            Found = STPayment.Find(PaymentID);
            //Test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void PaymentIDFound()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to recrd if the data is ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 PaymentID = 1;
            //Invoke the method
            Found = STPayment.Find(PaymentID);
            //Check the property
            if (STPayment.PaymentID != 1)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void InvoiceNoFound()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to recrd if the data is ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 PaymentID = 1;
            //Invoke the method
            Found = STPayment.Find(PaymentID);
            //Check the property
            if (STPayment.InvoiceNo != "123456789123456")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void PaymentTypeFound()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to recrd if the data is ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 PaymentID = 1;
            //Invoke the method
            Found = STPayment.Find(PaymentID);
            //Check the property
            if (STPayment.PaymentType != "Card")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void PriceFound()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to recrd if the data is ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 PaymentID = 1;
            //Invoke the method
            Found = STPayment.Find(PaymentID);
            //Check the property
            if (STPayment.Price != Convert.ToDecimal(40.0))
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void PaymentDateFound()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to recrd if the data is ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 PaymentID = 1;
            //Invoke the method
            Found = STPayment.Find(PaymentID);
            //Check the property
            if (STPayment.PaymentDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void PaymentTimeFound()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to recrd if the data is ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 PaymentID = 1;
            //Invoke the method
            Found = STPayment.Find(PaymentID);
            //Check the property
            if (STPayment.PaymentTime != Convert.ToDateTime("13/03/2019 00:00"))
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CardNumberFound()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to recrd if the data is ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 PaymentID = 1;
            //Invoke the method
            Found = STPayment.Find(PaymentID);
            //Check the property
            if (STPayment.CardNumber != "1234567891234567")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void AccountNumberFound()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to recrd if the data is ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 PaymentID = 1;
            //Invoke the method
            Found = STPayment.Find(PaymentID);
            //Check the property
            if (STPayment.AccountNumber != "12345678")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void SortCodeNumberFound()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to recrd if the data is ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 PaymentID = 1;
            //Invoke the method
            Found = STPayment.Find(PaymentID);
            //Check the property
            if (STPayment.SortCode != "123456")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ExpiryDateFound()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to recrd if the data is ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 PaymentID = 1;
            //Invoke the method
            Found = STPayment.Find(PaymentID);
            //Check the property
            if (STPayment.ExpiryDate != Convert.ToDateTime("18/08/2015"))
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidFromFound()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to recrd if the data is ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 PaymentID = 1;
            //Invoke the method
            Found = STPayment.Find(PaymentID);
            //Check the property
            if (STPayment.ValidFrom != Convert.ToDateTime("18/08/2018"))
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CardHolderNameNumberFound()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to recrd if the data is ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 PaymentID = 1;
            //Invoke the method
            Found = STPayment.Find(PaymentID);
            //Check the property
            if (STPayment.CardHolderName != "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLM")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CVCFound()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to recrd if the data is ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 PaymentID = 1;
            //Invoke the method
            Found = STPayment.Find(PaymentID);
            //Check the property
            if (STPayment.CVC != "123")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //String a variable to store any error message
            String Error = "";
            //Invoke the method
            Error = STPayment.Valid(InvoiceNo, PaymentType, Price, PaymentDate, PaymentTime, CardNumber, AccountNumber, SortCode, ExpiryDate, ValidFrom, CardHolderName, CVC);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InvoiceNoMinimumOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //String a variable to store my error message
            string Error = "";
            //Create some test data to pass to the method
            string InvoiceNo = "123456789123456";
            //Invoke the method
            Error = STPayment.Valid(InvoiceNo, PaymentType, Price, PaymentDate, PaymentTime, CardNumber, AccountNumber, SortCode, ExpiryDate, ValidFrom, CardHolderName, CVC);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InvoiceNoMaximumOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //String a variable to store my error message
            string Error = "";
            //Create some test data to pass to the method
            string InvoiceNo = "123456789123456";
            //Invoke the method
            Error = STPayment.Valid(InvoiceNo, PaymentType, Price, PaymentDate, PaymentTime, CardNumber, AccountNumber, SortCode, ExpiryDate, ValidFrom, CardHolderName, CVC);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentTypeMinimumOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //String a variable to store my error message
            string Error = "";
            //Create some test data to pass to the method
            string PaymentType = "Card";
            //Invoke the method
            Error = STPayment.Valid(InvoiceNo, PaymentType, Price, PaymentDate, PaymentTime, CardNumber, AccountNumber, SortCode, ExpiryDate, ValidFrom, CardHolderName, CVC);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentTypeMaximumOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //String a variable to store my error message
            string Error = "";
            //Create some test data to pass to the method
            string PaymentType = "Card";
            //Invoke the method
            Error = STPayment.Valid(InvoiceNo, PaymentType, Price, PaymentDate, PaymentTime, CardNumber, AccountNumber, SortCode, ExpiryDate, ValidFrom, CardHolderName, CVC);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardNumberMinimumOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //String a variable to store my error message
            string Error = "";
            //Create some test data to pass to the method
            string CardNumber = "1234567891234567";
            //Invoke the method
            Error = STPayment.Valid(InvoiceNo, PaymentType, Price, PaymentDate, PaymentTime, CardNumber, AccountNumber, SortCode, ExpiryDate, ValidFrom, CardHolderName, CVC);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardNumberMaximumOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //String a variable to store my error message
            string Error = "";
            //Create some test data to pass to the method
            string CardNumber = "1234567891234567";
            //Invoke the method
            Error = STPayment.Valid(InvoiceNo, PaymentType, Price, PaymentDate, PaymentTime, CardNumber, AccountNumber, SortCode, ExpiryDate, ValidFrom, CardHolderName, CVC);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountNumberMinimumOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //String a variable to store my error message
            string Error = "";
            //Create some test data to pass to the method
            string AccountNumber = "12345678";
            //Invoke the method
            Error = STPayment.Valid(InvoiceNo, PaymentType, Price, PaymentDate, PaymentTime, CardNumber, AccountNumber, SortCode, ExpiryDate, ValidFrom, CardHolderName, CVC);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountNumberMaximumOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //String a variable to store my error message
            string Error = "";
            //Create some test data to pass to the method
            string AccountNumber = "12345678";
            //Invoke the method
            Error = STPayment.Valid(InvoiceNo, PaymentType, Price, PaymentDate, PaymentTime, CardNumber, AccountNumber, SortCode, ExpiryDate, ValidFrom, CardHolderName, CVC);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SortCodeMinimumOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //String a variable to store my error message
            string Error = "";
            //Create some test data to pass to the method
            string SortCode = "123456";
            //Invoke the method
            Error = STPayment.Valid(InvoiceNo, PaymentType, Price, PaymentDate, PaymentTime, CardNumber, AccountNumber, SortCode, ExpiryDate, ValidFrom, CardHolderName, CVC);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SortCodeMaximumOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //String a variable to store my error message
            string Error = "";
            //Create some test data to pass to the method
            string SortCode = "123456";
            //Invoke the method
            Error = STPayment.Valid(InvoiceNo, PaymentType, Price, PaymentDate, PaymentTime, CardNumber, AccountNumber, SortCode, ExpiryDate, ValidFrom, CardHolderName, CVC);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardHolderNameMinimumOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //String a variable to store my error message
            string Error = "";
            //Create some test data to pass to the method
            string CardHolderName = "123456";
            //Invoke the method
            Error = STPayment.Valid(InvoiceNo, PaymentType, Price, PaymentDate, PaymentTime, CardNumber, AccountNumber, SortCode, ExpiryDate, ValidFrom, CardHolderName, CVC);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardHolderNameMaximumOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //String a variable to store my error message
            string Error = "";
            //Create some test data to pass to the method
            string CardHolderName = "123456";
            //Invoke the method
            Error = STPayment.Valid(InvoiceNo, PaymentType, Price, PaymentDate, PaymentTime, CardNumber, AccountNumber, SortCode, ExpiryDate, ValidFrom, CardHolderName, CVC);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CVCMinimumOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //String a variable to store my error message
            string Error = "";
            //Create some test data to pass to the method
            string CVC = "123";
            //Invoke the method
            Error = STPayment.Valid(InvoiceNo, PaymentType, Price, PaymentDate, PaymentTime, CardNumber, AccountNumber, SortCode, ExpiryDate, ValidFrom, CardHolderName, CVC);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CVCMaximumOK()
        {
            //Create an instance of the clsSTPayment
            clsSTPayment STPayment = new clsSTPayment();
            //String a variable to store my error message
            string Error = "";
            //Create some test data to pass to the method
            string CVC = "123";
            //Invoke the method
            Error = STPayment.Valid(InvoiceNo, PaymentType, Price, PaymentDate, PaymentTime, CardNumber, AccountNumber, SortCode, ExpiryDate, ValidFrom, CardHolderName, CVC);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
