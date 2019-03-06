using System;

namespace STMainClassLibrary
{
    public class clsPayment
    {
        public string Payment { get; set; }
        public int PaymentNo { get; set; }

        public string AccountNumberValid(string somePayment)
        {
            //string variable to store the error message
            string Error = "";
            //If the account number is more than 8 characters
            if (somePayment.Length > 8)
            {
                //Return an error message
                Error = "The account number cannot exceed 8 characters";
            }

            //If the account number is less than 8
            if (somePayment.Length < 8)
            {
                //Return an error message
                Error = "The account number cannot be less than 8 characters";
            }

            //If the account number is left blank
            if (somePayment.Length == 0)
            {
                //Return an error message
                Error = "The account number cannot be left blank";
            }
            return Error;
        }

        public string InvoiceValid(string somePayment)
        {
            //string variable to store the error message
            string Error = "";
            //If the invoice number is more than 15 characters
            if (somePayment.Length > 15)
            {
                //Return an error message
                Error = "The invoice number cannot exceed 15 characters";
            }

            //If the invoice number is less than 15
            if (somePayment.Length < 15)
            {
                //Return an error message
                Error = "The invoice number cannot be less than 15 characters";
            }

            //If the invoice number is left blank
            if (somePayment.Length == 0)
            {
                //Return an error message
                Error = "The invoice number cannot be left blank";
            }
            return Error;
        }

        public string PaymentTypeValid(string somePayment)
        {
            //string variable to store the error message
            string Error = "";
            //If the payment type is more than 20 characters
            if (somePayment.Length > 20)
            {
                //Return an error message
                Error = "The payment type cannot exceed 20 characters";
            }

            //If the payment type is less than 20
            if (somePayment.Length < 20)
            {
                //Return an error message
                Error = "The invoice number cannot be less than 20 characters";
            }

            //If the payment type is left blank
            if (somePayment.Length == 0)
            {
                //Return an error message
                Error = "The payment type cannot be left blank";
            }
            return Error;
        }
    }
}