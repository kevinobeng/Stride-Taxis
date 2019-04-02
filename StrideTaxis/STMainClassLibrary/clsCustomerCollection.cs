using System;
using System.Collections.Generic;

namespace STMainClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

        //Constructor for this class
        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connecton
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.UserNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["UserNumber"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.HouseNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["HouseNumber"]);
                ACustomer.Town = Convert.ToString(DB.DataTable.Rows[Index]["Town"]);
                ACustomer.Street = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                ACustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.TelephoneNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["TelephoneNumber"]);
                //add record to private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data                               
                return mCustomerList;
            }
            set
            {
                //set private data
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                //do later
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@HouseNumber", mThisCustomer.HouseNumber);
            DB.AddParameter("@Town", mThisCustomer.Town);
            DB.AddParameter("@Street", mThisCustomer.Street);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@TelephoneNumber", mThisCustomer.TelephoneNumber);
            //execute the query
            return DB.Execute("sproc_tblCustomer_Insert");
        }
        public void Delete()
        {
            //deletes the record pointed to by thiscustomer
            //conect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@UserNumber", mThisCustomer.UserNumber);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thiscustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@UserNumber", mThisCustomer.UserNumber);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@HouseNumber", mThisCustomer.HouseNumber);
            DB.AddParameter("@Town", mThisCustomer.Town);
            DB.AddParameter("@Street", mThisCustomer.Street);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@TelephoneNumber", mThisCustomer.TelephoneNumber);
            //execute the query
            DB.Execute("sproc_tblCustomer_Insert");
        }

        public void ReportByPostCode(string PostCode)
        {
            //filter the records based on a full or partical postcode
        }
    }
}