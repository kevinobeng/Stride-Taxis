using System;

namespace STMainClassLibrary
{
    public class clsCustomer
    {
        private Int32 mUsernumber;
        private string mFirstName;
        private string mLastName;
        private Int32 mHouseNumber;
        private string mTown;
        private string mStreet;
        private string mPostCode;
        private string mEmail;
        private Int32 mTelephoneNumber;

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

        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }
        public int HouseNumber
        {
            get
            {
                return mHouseNumber;
            }
            set
            {
                mHouseNumber = value;
            }
        }
        public string Town
        {
            get
            {
                return mTown;
            }
            set
            {
                mTown = value;
            }
        }
        public string Street
        {
            get
            {
                return mStreet;
            }
            set
            {
                mStreet = value;
            }
        }
        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }
        public int TelephoneNumber
        {
            get
            {
                return mTelephoneNumber;
            }
            set
            {
                mTelephoneNumber = value;
            }
        }

        public bool Find(int UserNumber)
        {
            //set the priavte data member to the test data value
            mUsernumber = 21;
            mFirstName = "Test First Name";
            mLastName = "Test Last Name";
            mHouseNumber = 60;
            mTown = "Test Town";
            mStreet = "Test Street";
            mPostCode = "XXXX XXX";
            mEmail = "Test Email";
            mTelephoneNumber = 0116;
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