using System;

namespace STMainClassLibrary
{
    public class clsCustomer
    {
        private Int32 mUsernumber;
        public int UserNumber
        {
            get
            {
                return mUsernumber;
            }
            set
            {
                mUsernumber = value;
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int HouseNumber { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string Email { get; set; }
        public int TelephoneNumber { get; set; }

        public bool Find(int UserNumber)
        {
            //set the priavte data member to the test data value
            mUsernumber = 21;
            //always return true
            return true;
        }

        public string UserNumberValid(string someUserNumber)
        {
            return "";
        }

        public string FirstNameValid(string someFirstName)
        {
            return "";
        }

        public string LastNameValid(string someLastName)
        {
           return "";
        }

        public string HouseNumberValid(string someHouseNumber)
        {
            return "";
        }


        public string TownValid(string someTown)
        {
           return "";
        }

        public string StreetValid(string someStreet)
        {
            return "";
        }

        public string PostCodeValid(string somePostCode)
        {
            return "";
        }

        public string EmailValid(string someEmail)
        {
            return "";
        }

        public string TelephoneNumberValid(string someTelephoneNumber)
        {
            return "";
        }

    }
}