using System;
using System.Collections.Generic;
namespace STMainClassLibrary
{
    public class clsDriverCollection
    {
        //private data member for the list
        List<clsDriver> mDriverList = new List<clsDriver>();
        //public data member thisDriver
        clsDriver mThisDriver = new clsDriver();
        //public property for ThisDriver
        public clsDriver ThisDriver
        {
            get
            {
                //return the private data 
                return mThisDriver;
            }
            set
            {
                //set the private data 
                mThisDriver = value;
            }
        }
        public int Add()
        {
            //adds a new record to the database based on the values mThisDriver
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@LicenseNo", mThisDriver.LicenseNo);
            DB.AddParameter("@FirstName", mThisDriver.FirstName);
            DB.AddParameter("@LastName", mThisDriver.LastName);
            DB.AddParameter("@Email", mThisDriver.Email);
            DB.AddParameter("@TelephoneNo", mThisDriver.TelephoneNo);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblDriver_Insert");
        }
        public void Update()
        {
            //adds a new record to the database based on the values mThisDriver
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@LicenseNo", mThisDriver.LicenseNo);
            DB.AddParameter("@FirstName", mThisDriver.FirstName);
            DB.AddParameter("@LastName", mThisDriver.LastName);
            DB.AddParameter("@Email", mThisDriver.Email);
            DB.AddParameter("@TelephoneNo", mThisDriver.TelephoneNo);
            //execute the stored procedure
            DB.Execute("sproc_tblDriver_Update");
        }
        public void Delete()
        {
            //deletes the record pointed to by thisDriver
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@LicenseNo", mThisDriver.LicenseNo);
            //execute the stored procedure
            DB.Execute("sproc_tblDriver_Delete");
        }
        public List<clsDriver> DriverList
        {
            get
            {
                //return the private data
                return mDriverList;
            }
            set
            {
                //set the private data 
                mDriverList = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mDriverList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        

        //constructor for the class
        public clsDriverCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblDriver_FilterByLicenseNo");
            //get the count of records
            RecordCount = DB.Count;
            //While there are record are records to process
            while (Index < RecordCount)
            {
                //create a blank Destination
                clsDriver AnDriver = new clsDriver();
                //read in the fields from the current record
                AnDriver.LicenseNo = Convert.ToInt32(DB.DataTable.Rows[0]["LicenseNo"]);
                //private string FirstName;
                AnDriver.FirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                //private string LastName;
                AnDriver.LastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                //private string Email;
                AnDriver.Email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                //private string TelephoneNo;
                AnDriver.TelephoneNo = Convert.ToInt32(DB.DataTable.Rows[0]["TelephoneNo"]);

                //point at the next record
                Index++;
            }
            
        }

        public void ReportByLicenseNo(string LicenseNo)
        {
            //filters the records based on a full or partial post code
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the LicenseNo parameter to the database 
            DB.AddParameter("@LicenseNo", LicenseNo);
            //execute the stored procedure
            DB.Execute("sproc_tblDriver_FilterByLicenseNo");
        }

    }
}