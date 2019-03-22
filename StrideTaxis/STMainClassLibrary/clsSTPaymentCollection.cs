using System;
using System.Collections.Generic;

namespace STMainClassLibrary
{
    public class clsSTPaymentCollection
    {

        //Private data member for the list
        List<clsSTPayment> mPaymentList = new List<clsSTPayment>();
        //Private data member ThisPayment
        clsSTPayment mThisPayment = new clsSTPayment();
        public List<clsSTPayment> PaymentList
        {
            get
            {
                //Return the private data
                return mPaymentList;
            }
            set
            {
                //Set the private data
                mPaymentList = value;
            }
        }
        public int Count
        {
            get
            {
                //Return the count of the list
                return mPaymentList.Count;
            }
            set
            {
                //We shall worry about this later
            }
        }
        public clsSTPayment ThisPayment
        {
            get
            {
                //return the private data
                return mThisPayment;
            }
            set
            {
                //set the private data
                mThisPayment = value;
            }
        }

        //Constructor for this class
        public clsSTPaymentCollection()
        {
            //Var for the index
            Int32 Index = 0;
            //Var to store the record count
            Int32 RecordPaymentCount = 0;
            //Objcet for the data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure for select all
            DB.Execute("sproc_tblPayment_SelectAll");
            //Get the count of payment records
            RecordPaymentCount = DB.Count;
            //While there are records to process
            while (Index < RecordPaymentCount)
            {
                //Create a blank payment record
                clsSTPayment APayment = new clsSTPayment();
                //Read in the fields from the current record
                APayment.PaymentID = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentID"]);
                APayment.CardNumber = Convert.ToString(DB.DataTable.Rows[Index]["CardNumber"]);
                APayment.AccountNumber = Convert.ToString(DB.DataTable.Rows[Index]["AccountNumber"]);
                APayment.SortCode = Convert.ToString(DB.DataTable.Rows[Index]["SortCode"]);
                APayment.ExpiryDate = Convert.ToString(DB.DataTable.Rows[Index]["ExpiryDate"]);
                APayment.ValidFrom = Convert.ToString(DB.DataTable.Rows[Index]["ValidFrom"]);
                APayment.CardHolderName = Convert.ToString(DB.DataTable.Rows[Index]["CardHolderName"]);
                APayment.CVC = Convert.ToString(DB.DataTable.Rows[Index]["CVC"]);
                //Add the record to the private data member
                mPaymentList.Add(APayment);
                //Point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //Adds a new record to the database based on the values of ThisPayment
            //Connect to the database
            clsDataConnection STDB = new clsDataConnection();
            //Set the parameters for the stored procedures
            STDB.AddParameter("@CardNumber", mThisPayment.CardNumber);
            STDB.AddParameter("@AccountNumber", mThisPayment.AccountNumber);
            STDB.AddParameter("@SortCode", mThisPayment.SortCode);
            STDB.AddParameter("@ExpiryDate", mThisPayment.ExpiryDate);
            STDB.AddParameter("@ValidFrom", mThisPayment.ValidFrom);
            STDB.AddParameter("@CardHolderName", mThisPayment.CardHolderName);
            STDB.AddParameter("@CVC", mThisPayment.CVC);
            //Execute the query
            return STDB.Execute("sproc_tblPayment_Insert");
        }

        public int Update()
        {
            //Adds a new record to the database based on the values of ThisPayment
            //Connect to the database
            clsDataConnection STDB = new clsDataConnection();
            //Set the parameters for the stored procedures
            STDB.AddParameter("@PaymentID", mThisPayment.PaymentID);
            STDB.AddParameter("@CardNumber", mThisPayment.CardNumber);
            STDB.AddParameter("@AccountNumber", mThisPayment.AccountNumber);
            STDB.AddParameter("@SortCode", mThisPayment.SortCode);
            STDB.AddParameter("@ExpiryDate", mThisPayment.ExpiryDate);
            STDB.AddParameter("@ValidFrom", mThisPayment.ValidFrom);
            STDB.AddParameter("@CardHolderName", mThisPayment.CardHolderName);
            STDB.AddParameter("@CVC", mThisPayment.CVC);
            //Execute the query
            return STDB.Execute("sproc_tblPayment_Update");
        }

        public void Delete()
        {
            //Deletes the record pointed to by ThisPayment
            //Connect to the database
            clsDataConnection STDB = new clsDataConnection();
            //Set the parameters for the stored procedure
            STDB.AddParameter("@PaymentID", mThisPayment.PaymentID);
            //Excute the stored procedure
            STDB.Execute("sproc_tblPayment_Delete");
        }
    }
}