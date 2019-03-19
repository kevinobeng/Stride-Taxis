using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace STMainClassLibrary
{
    public class clsSTPayment
    {
        //Public string for the primary key - payment id
        private Int32 mPaymentID;
        //Public string for the Invoice No
        private string mInvoiceNo;
        //Public string for the Payment Type
        private string mPaymentType;
        //Public decimal for the Price
        private decimal mPrice;
        //Public DateTime for the Payment Date
        private DateTime mPaymentDate;
        //Public DateTime for the Payment Time
        private DateTime mPaymentTime;
        //Public string for the Card Number
        private string mCardNumber;
        //Public string for the Account Number
        private string mAccountNumber;
        //Public string for the Sort Code
        private string mSortCode;
        //Public DateTime for the ExpiryDate
        private DateTime mExpiryDate;
        //Public DateTime for the ValidFrom
        private DateTime mValidFrom;
        //Public string for the Card Holder Name
        private string mCardHolderName;
        //Public string for the CVC
        private string mCVC;

        //Public property for the Payment ID
        public int PaymentID
        {
            get
            {
                //Return the private data
                return mPaymentID;
            }
            set
            {
                //set the private data
                mPaymentID = value;
            }
        }

        //Public property for the InvoiceNo
        public string InvoiceNo
        {
            get
            {
                //Return the private data
                return mInvoiceNo;
            }
            set
            {
                //set the private data
                mInvoiceNo = value;
            }
        }

        //Public property for the PaymentType
        public string PaymentType
        {
            get
            {
                //Return the private data
                return mPaymentType;
            }
            set
            {
                //set the private data
                mPaymentType = value;
            }
        }

        //Public property for the Price
        public decimal Price
        {
            get
            {
                //Return the private data
                return mPrice;
            }
            set
            {
                //set the private data
                mPrice = value;
            }
        }

        //Public property for the PaymentDate
        public DateTime PaymentDate
        {
            get
            {
                //Return the private data
                return mPaymentDate;
            }
            set
            {
                //set the private data
                mPaymentDate = value;
            }
        }

        //Public property for the PaymentTime
        public DateTime PaymentTime
        {
            get
            {
                //Return the private data
                return mPaymentTime;
            }
            set
            {
                //set the private data
                mPaymentTime = value;
            }
        }

        //Public property for the Card Number
        public string CardNumber
        {
            get
            {
                //Return the private data
                return mCardNumber;
            }
            set
            {
                //set the private data
                mCardNumber = value;
            }
        }

        //Public property for the Account Number
        public string AccountNumber
        {
            get
            {
                //Return the private data
                return mAccountNumber;
            }
            set
            {
                //set the private data
                mAccountNumber = value;
            }
        }

        //Public property for the Sort Code
        public string SortCode
        {
            get
            {
                //Return the private data
                return mSortCode;
            }
            set
            {
                //set the private data
                mSortCode = value;
            }
        }

        //Public property for the Expiry Date
        public DateTime ExpiryDate
        {
            get
            {
                //Return the private data
                return mExpiryDate;
            }
            set
            {
                //set the private data
                mExpiryDate = value;
            }
        }

        //Public property for the Valid From
        public DateTime ValidFrom
        {
            get
            {
                //Return the private data
                return mValidFrom;
            }
            set
            {
                //set the private data
                mValidFrom = value;
            }
        }

        //Public property for the Card Holder Name
        public string CardHolderName
        {
            get
            {
                //Return the private data
                return mCardHolderName;
            }
            set
            {
                //set the private data
                mCardHolderName = value;
            }
        }

        //Public property for the CVC
        public string CVC
        {
            get
            {
                //Return the private data
                return mCVC;
            }
            set
            {
                //set the private data
                mCVC = value;
            }
        }



        public bool Find(int PaymentID)
        {
            //Create an instance of the data connection
            clsDataConnection STDB = new clsDataConnection();
            //Add the parameter for the Payment ID to search for
            STDB.AddParameter("@PaymentID", PaymentID);
            //Execute the tored procedure
            STDB.Execute("sproc_tblPayment_FilterByPaymentID");
            //If one record is found (there should be either one or zero!)
            if (STDB.Count == 1)
            {
                //Copy the data from the database to the private data members
                mPaymentID = Convert.ToInt32(STDB.DataTable.Rows[0]["PaymentID"]);
                mInvoiceNo = Convert.ToString(STDB.DataTable.Rows[0]["InvoiceNo"]);
                mPaymentType = Convert.ToString(STDB.DataTable.Rows[0]["PaymentType"]);
                mPrice = Convert.ToDecimal(STDB.DataTable.Rows[0]["Price"]);
                mPaymentDate = Convert.ToDateTime(STDB.DataTable.Rows[0]["PaymentDate"]);
                mPaymentTime = Convert.ToDateTime(STDB.DataTable.Rows[0]["PaymentTime"]);
                mCardNumber = Convert.ToString(STDB.DataTable.Rows[0]["CardNumber"]);
                mAccountNumber = Convert.ToString(STDB.DataTable.Rows[0]["AccountNumber"]);
                mSortCode = Convert.ToString(STDB.DataTable.Rows[0]["SortCode"]);
                mExpiryDate = Convert.ToDateTime(STDB.DataTable.Rows[0]["ExpiryDate"]);
                mValidFrom = Convert.ToDateTime(STDB.DataTable.Rows[0]["ValidFrom"]);
                mCardHolderName = Convert.ToString(STDB.DataTable.Rows[0]["CardHolderName"]);
                mCVC = Convert.ToString(STDB.DataTable.Rows[0]["CVC"]);
                //Return that everything worked ok
                return true;
            }
            //If no record was found
            else
            {
                //Return false indicating a problem
                return false;

            }
        }

        public string Valid(string invoiceNo, string paymentType, string price, string paymentDate, string paymentTime, string cardNumber, string accountNumber, 
            string sortCode, string expiryDate, string validFrom, string cardHolderName, string cVC)
        {
            //string variable to store the error message
            string Error = "";
            //DateTime variable for the Payment Date
            DateTime PaymentDateTemp;
            //If the invoice number is more than 15 characters
            if (invoiceNo.Length > 15)
            {
                //Return an error message
                Error = "The invoice number cannot exceed 15 characters";
            }

            //If the invoice number is less than 15
            if (invoiceNo.Length < 15)
            {
                //Return an error message
                Error = "The invoice number cannot be less than 15 characters";
            }

            //If the invoice number is left blank
            if (invoiceNo.Length == 0)
            {
                //Return an error message
                Error = "The invoice number cannot be left blank";
            }
            //If the payment type is more than 20 characters
            if (paymentType.Length > 20)
            {
                //Return an error message
                Error = "The payment type cannot exceed 20 characters";
            }

            //If the payment type is less than 1 character 
            if (paymentType.Length < 1)
            {
                //Return an error message
                Error = "The invoice number cannot be less than 1 characters";
            }

            //If the payment type is left blank
            if (paymentType.Length == 0)
            {
                //Return an error message
                Error = "The payment type cannot be left blank";
            }
            try
            {
                //Copy the Payment Date Added to the PaymentDateTemp Variable
                PaymentDateTemp = Convert.ToDateTime(paymentDate);
                if (PaymentDateTemp < DateTime.Now.Date)
                {
                    //Record the error
                    Error = Error + "The date cannot be in the past : ";
                }

                //if (PaymentDateTemp > DateTime.Now.Date)
                //{
                //    //Record the error
                //    Error = Error + "The date cannot be in the future : ";
                //}
            }
            catch
            {
                //Record the error
                Error = Error + "The date was not a valid date : ";
            }

            //If the card number is more than 16 characters
            if (cardNumber.Length > 16)
            {
                //Return an error message
                Error = "The card number cannot exceed 16 characters";
            }

            //If the card number is less than 16
            if (cardNumber.Length < 16)
            {
                //Return an error message
                Error = "The card number cannot be less than 16 characters";
            }

            //If the card number is left blank
            if (cardNumber.Length == 0)
            {
                //Return an error message
                Error = "The card number cannot be left blank";
            }

            //If the account number is more than 8 characters
            if (accountNumber.Length > 8)
            {
                //Return an error message
                Error = "The account number cannot exceed 8 characters";
            }

            //If the account number is less than 8
            if (accountNumber.Length < 8)
            {
                //Return an error message
                Error = "The account number cannot be less than 8 characters";
            }

            //If the account number is left blank
            if (accountNumber.Length == 0)
            {
                //Return an error message
                Error = "The account number cannot be left blank";
            }

            //If the sort code is more than 6 characters
            if (sortCode.Length > 6)
            {
                //Return an error message
                Error = "The sort code cannot exceed 6 characters";
            }

            //If the sort code is less than 6
            if (sortCode.Length < 6)
            {
                //Return an error message
                Error = "The sort code cannot be less than 6 characters";
            }

            //If the sort code is left blank
            if (sortCode.Length == 0)
            {
                //Return an error message
                Error = "The sort code cannot be left blank";
            }

            //If the card holder's name is more than 40 characters
            if (cardHolderName.Length > 40)
            {
                //Return an error message
                Error = "The card holder's name cannot exceed 40 characters";
            }

            //If the card holder's name is less than 1
            if (cardHolderName.Length < 1)
            {
                //Return an error message
                Error = "The card holder's name cannot be less than 1 characters";
            }

            //If the card holder's name is left blank
            if (cardHolderName.Length == 0)
            {
                //Return an error message
                Error = "The card holder's name cannot be left blank";
            }

            //If the CVC is more than 3 characters
            if (cVC.Length > 3)
            {
                //Return an error message
                Error = "The CVC cannot exceed 3 characters";
            }

            //If the CVC is less than 3
            if (cVC.Length < 3)
            {
                //Return an error message
                Error = "The sort code cannot be less than 3 characters";
            }

            //If the CVC is left blank
            if (cVC.Length == 0)
            {
                //Return an error message
                Error = "The CVC cannot be left blank";
            }
            return Error;
        }
    }
}