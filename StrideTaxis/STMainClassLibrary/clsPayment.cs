using System;

namespace STMainClassLibrary
{
    public class clsPayment
    {
        public string Payment { get; set; }
        public int PaymentNo { get; set; }

        public string Valid(string somePayment)
        {
            //string variable to store the error message
            string Error = "";
            //If the account number is more than 9 characters
            if (somePayment.Length > 8)
            {
                //Return an error message
                Error = "The account number cannot exceed 8 characters";
            }

            //If the account number is less than 1
            if (somePayment.Length < 1)
            {
                //Return an error message
                Error = "The account number cannot be less than 1 character";
            }

            //If the account number is left blank
            if (somePayment.Length == 0)
            {
                //Return an error message
                Error = "The account number cannot be left blank";
            }
            return Error;
        }
    }
}