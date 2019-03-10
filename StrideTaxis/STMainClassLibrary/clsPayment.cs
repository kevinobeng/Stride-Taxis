using System;

namespace STMainClassLibrary
{
    public class clsPayment
    {
        //Public string for the primary key - payment id
        public string PaymentID { get; set; }
        //Public string for the Invoice No
        public string InvoiceNo { get; set; }
        //Public string for the Payment Type
        public string PaymentType { get; set; }
        //Public string for the Price
        public decimal Price { get; set; }
        //Public string for the Payment Date
        public DateTime PaymentDate { get; set; }
        //Public string for the Payment Time
        public DateTime PaymentTime { get; set; }
        //Public string for the Card Number
        public string CardNumber { get; set; }
        //Public string for the Account Number
        public string AccountNumber { get; set; }
        //Public string for the Sort Code
        public string SortCode { get; set; }
        //Public string for the Expiry Date
        public DateTime ExpiryDate { get; set; }
        //Public string for the Valid From
        public DateTime ValidFrom { get; set; }
        //Public string for the Card Holder Name
        public string CardHolderName { get; set; }
        //Public string for the CVC
        public string CVC { get; set; }

        public string InvoiceValid(string someInvoiceNo)
        {
            //string variable to store the error message
            string Error = "";
            //If the invoice number is more than 15 characters
            if (someInvoiceNo.Length > 15)
            {
                //Return an error message
                Error = "The invoice number cannot exceed 15 characters";
            }

            //If the invoice number is less than 15
            if (someInvoiceNo.Length < 15)
            {
                //Return an error message
                Error = "The invoice number cannot be less than 15 characters";
            }

            //If the invoice number is left blank
            if (someInvoiceNo.Length == 0)
            {
                //Return an error message
                Error = "The invoice number cannot be left blank";
            }
            return Error;
        }

        public string PaymentTypeValid(string SomePaymentType)
        {
            //string variable to store the error message
            string Error = "";
            //If the payment type is more than 20 characters
            if (SomePaymentType.Length > 20)
            {
                //Return an error message
                Error = "The payment type cannot exceed 20 characters";
            }

            //If the payment type is less than 1 character 
            if (SomePaymentType.Length < 20)
            {
                //Return an error message
                Error = "The invoice number cannot be less than 1 characters";
            }

            //If the payment type is left blank
            if (SomePaymentType.Length == 0)
            {
                //Return an error message
                Error = "The payment type cannot be left blank";
            }
            return Error;
        }

        public string PriceValid(decimal SomePrice)
        {
            //string variable to store the error message
            string Error = "";
            //If the price is more than 5 characters
            if (SomePrice > 5)
            {
                //Return an error message
                Error = "The price cannot exceed 5 characters";
            }

            //If the price is less than 1
            if (SomePrice < 1)
            {
                //Return an error message
                Error = "The price cannot be less than 1 character";
            }

            //If the price is left blank
            if (SomePrice == 0)
            {
                //Return an error message
                Error = "The price cannot be left blank";
            }
            return Error;
        }

        public string CardNumberValid(string someCardNumber)
        {
            //string variable to store the error message
            string Error = "";
            //If the card number is more than 16 characters
            if (someCardNumber.Length > 16)
            {
                //Return an error message
                Error = "The card number cannot exceed 20 characters";
            }

            //If the card number is less than 16
            if (someCardNumber.Length < 16)
            {
                //Return an error message
                Error = "The card number cannot be less than 16 characters";
            }

            //If the card number is left blank
            if (someCardNumber.Length == 0)
            {
                //Return an error message
                Error = "The card number cannot be left blank";
            }
            return Error;
        }

        public string AccountNumberValid(string someAccountNumber)
        {
            //string variable to store the error message
            string Error = "";
            //If the account number is more than 9 characters
            if (someAccountNumber.Length > 9)
            {
                //Return an error message
                Error = "The account number cannot exceed 9 characters";
            }

            //If the account number is less than 9
            if (someAccountNumber.Length < 9)
            {
                //Return an error message
                Error = "The account number cannot be less than 9 characters";
            }

            //If the account number is left blank
            if (someAccountNumber.Length == 0)
            {
                //Return an error message
                Error = "The account number cannot be left blank";
            }
            return Error;
        }

        public string SortCodeValid(string someSortCode)
        {
            //string variable to store the error message
            string Error = "";
            //If the sort code is more than 6 characters
            if (someSortCode.Length > 6)
            {
                //Return an error message
                Error = "The sort code cannot exceed 6 characters";
            }

            //If the sort code is less than 6
            if (someSortCode.Length < 6)
            {
                //Return an error message
                Error = "The sort code cannot be less than 6 characters";
            }

            //If the sort code is left blank
            if (someSortCode.Length == 0)
            {
                //Return an error message
                Error = "The sort code cannot be left blank";
            }
            return Error;
        }

        public string CardHolderNameValid(string someCardHolderName)
        {
            //string variable to store the error message
            string Error = "";
            //If the card holder's name is more than 40 characters
            if (someCardHolderName.Length > 40)
            {
                //Return an error message
                Error = "The card holder's name cannot exceed 40 characters";
            }

            //If the card holder's name is less than 1
            if (someCardHolderName.Length < 1)
            {
                //Return an error message
                Error = "The card holder's name cannot be less than 1 characters";
            }

            //If the card holder's name is left blank
            if (someCardHolderName.Length == 0)
            {
                //Return an error message
                Error = "The card holder's name cannot be left blank";
            }
            return Error;
        }

        public string CVCValid(string someCVC)
        {
            //string variable to store the error message
            string Error = "";
            //If the CVC is more than 3 characters
            if (someCVC.Length > 3)
            {
                //Return an error message
                Error = "The CVC cannot exceed 3 characters";
            }

            //If the CVC is less than 3
            if (someCVC.Length < 3)
            {
                //Return an error message
                Error = "The sort code cannot be less than 3 characters";
            }

            //If the CVC is left blank
            if (someCVC.Length == 0)
            {
                //Return an error message
                Error = "The CVC cannot be left blank";
            }
            return Error;
        }
    }
}