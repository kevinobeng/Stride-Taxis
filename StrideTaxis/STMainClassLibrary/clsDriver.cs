using System;

namespace STMainClassLibrary
{
    public class clsDriver
    {
        
            //private data member for the LicenseNo property
            private Int32 mLicenseNo;
            //private data member for Email
            private string mEmail;
            //private data member for First Name
            private string mFirstName;
            //private data member for Last Name
            private string mLastName;
            //private data member for Telephone No
            private Int32 mTelephoneNo;
            //private data member for active
            private bool mActive;

            //public property for License No
            public int LicenseNo
            {
                get
                {
                    //return the private data
                    return mLicenseNo;
                }
                set
                {
                    //set the private data
                    mLicenseNo = value;
                }
            }
            //public property for Email
            public string Email
            {
                get
                {
                    //return the private data
                    return mEmail;
                }
                set
                {
                    //set the private data
                    mEmail = value;
                }
            }
            //public property for First Name
            public string FirstName
            {
                get
                {
                    //return the private data
                    return mFirstName;
                }
                set
                {
                    //set the private data
                    mFirstName = value;
                }
            }
            //public property for Last Name
            public string LastName
            {
                get
                {
                    //return the private data
                    return mLastName;
                }
                set
                {
                    //set the private data
                    mLastName = value;
                }
            }
            //public property for Telephone No
            public int TelephoneNo
            {
                get
                {
                    //return the private data
                    return mTelephoneNo;
                }
                set
                {
                    //set the private data
                    mTelephoneNo = value;
                }
            }
            //public property for active

            public bool Active
            {
                get
                {
                    //return the private 
                    return mActive;
                }
                set
                {
                    //set the private data 
                    mActive = value;
                }
            }
            public bool Find(int LicenseNo)
            {
                //create an instance of the data connection
                clsDataConnection DB = new clsDataConnection();
                //add the parameter for the License no to search for
                DB.AddParameter("@LicenseNo", LicenseNo);
                //execute the stored procedure
                DB.Execute("sproc_tblDriver_FilterByLicenseNo");
                //if one record is found (there should be either one or zero!)
                if (DB.Count == 1)
                {


                    //copy the data from the database to private data members
                    mLicenseNo = Convert.ToInt32(DB.DataTable.Rows[0]["LicenseNo"]);
                    mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                    mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                    mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                    mTelephoneNo = Convert.ToInt32(DB.DataTable.Rows[0]["TelephoneNo"]);
                    //return that everything worked OK
                    return true;
                }
                //if no record was found 
                else
                {
                    //return false indicating a problem
                    return false;
                }

            }
            public string Valid(object LicenseNo, object FirstName, object LastName, object Email, object TelephoneNo)
            {
                return "";
            }

            public string LicenseNoValid(string someLicenseNo)
            {
                return "";
            }

            public string EmailValid(string someEmail)
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

            public string TelephoneNoValid(string someTelephoneNo)
            {
                return "";
            }
            public bool Find(string LicenseNo)
            {
                return true;
            }

        }
    }


