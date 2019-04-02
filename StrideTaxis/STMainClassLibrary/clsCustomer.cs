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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the user number to search for
            DB.AddParameter("@UserNumber", UserNumber);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByUserNumber");
            //if one record is found
            if (DB.Count == 1)
            {
                mUsernumber = Convert.ToInt32(DB.DataTable.Rows[0]["UserNumber"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mHouseNumber = Convert.ToInt32(DB.DataTable.Rows[0]["HouseNumber"]);
                mTown = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
                mStreet = Convert.ToString(DB.DataTable.Rows[0]["Street"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mTelephoneNumber = Convert.ToInt32(DB.DataTable.Rows[0]["TelephoneNumber"]);
                //always return true
                return true;
            }
            //if no record was found
            else
            {
                //return false for indicating a problem
                return false;
            }
        }

        public string Valid(string FirstName, string LastName, string HouseNumber, string Town, string Street, string PostCode, string Email, string TelephoneNumber)
        {
            //create a string variable to store the error
            String Error = "";            
            //if the firstname is blank
            if (FirstName.Length == 0)
            {
                //record the error
                Error = Error + "The First Name field cannot be blank : ";
            }
            //if the firstname is greater than 20 characters
            if (FirstName.Length > 20)
            {
                Error = Error + "Your First name must be less than 20 characters : ";
            }
            //if last name is blank
            if (LastName.Length == 0)
            {
                //record the error
                Error = Error + "The Last Name field cannot be blank : ";
            }
            //if the last name is greater than 20 characters
            if (LastName.Length > 20)
            {
                Error = Error + "Your Last name must be less than 20 characters : ";
            }
            //is the house number is blank
            if (HouseNumber.Length == 0)
            {
                //record the error
                Error = Error + "The House Number field cannot be blank : ";
            }
            //if the house number is greater than 6 characters
            if (HouseNumber.Length > 6)
            {
                Error = Error + "Your House Number must be less than 6 characters : ";
            }
            //if the town is blank
            if (Town.Length == 0)
            {
                //record the error
                Error = Error + "The Town field cannot be blank : ";
            }
            //if the Town is greater than 20 characters
            if (Town.Length > 20)
            {
                Error = Error + "Your Town must be less than 20 characters : ";
            }
            //if the Street is blank
            if (Street.Length == 0)
            {
                //record the error
                Error = Error + "The Street field cannot be blank : ";
            }
            //if the Street is greater than 30 characters
            if (Street.Length > 30)
            {
                Error = Error + "Your Street must be less than 30 characters : ";
            }
            //if the PostCode is blank
            if (PostCode.Length == 0)
            {
                //record the error
                Error = Error + "The PostCode field cannot be blank : ";
            }
            //if the PostCode is greater than 8 characters
            if (PostCode.Length > 8)
            {
                Error = Error + "Your PostCode must be less than 8 characters : ";
            }
            //if the Email is blank
            if (Email.Length == 0)
            {
                //record the error
                Error = Error + "The Email field cannot be blank : ";
            }
            //if the Email is greater than 70 characters
            if (Email.Length > 70)
            {
                Error = Error + "Your Email must be less than 20 characters : ";
            }
            //if the Telephone is blank
            if (TelephoneNumber.Length == 0)
            {
                //record the error
                Error = Error + "The Telephone Number field cannot be blank : ";
            }
            //if the Telephone is greater than 11 characters
            if (TelephoneNumber.Length > 11)
            {
                Error = Error + "Your Telephone must be less than 11 characters : ";
            }
            //return any error messages
            return Error;
        }

        public void Find(object primaryKey)
        {
            throw new NotImplementedException();
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