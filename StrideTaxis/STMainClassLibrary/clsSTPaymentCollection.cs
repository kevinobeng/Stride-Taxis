using System;
using System.Collections.Generic;

namespace STMainClassLibrary
{
    public class clsSTPaymentCollection
    {

        //Private data member for the list
        List<clsSTPayment> mPaymentList = new List<clsSTPayment>();
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
        public clsSTPayment ThisPayment { get; set; }

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
    }
}