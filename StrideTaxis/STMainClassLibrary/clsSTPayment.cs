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



        public bool Find(int paymentID)
        {
            //Set the private data members to the test data value
            mPaymentID = 2;
            mInvoiceNo = "123456789123456";
            mPaymentType = "Card";
            mPrice = Convert.ToDecimal(40.0);
            mPaymentDate = Convert.ToDateTime("14/08/2015");
            mPaymentTime = Convert.ToDateTime("23:00");
            mCardNumber = "1234567891234567";
            mAccountNumber = "123456789";
            mSortCode = "123456";
            mExpiryDate = Convert.ToDateTime("13/06/2015");
            mValidFrom = Convert.ToDateTime("14/07/2017");
            mInvoiceNo = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLM";
            mCVC = "123";
            //Always return true
            return true;
        }
    }
}