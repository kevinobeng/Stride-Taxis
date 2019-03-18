using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMainClassLibrary
{
    public class clsDestinationCollection
    {
        //private data member that stores the count of records found
        private Int32 mCount;
        //create a private list data member to store the data from the database
        private List<clsDestination> mDestinationList = new List<clsDestination>();
        //private data member to connect to the database
        private clsDataConnection DB = new clsDataConnection();
        //public property returning the count of records
        public Int32 Count
        {
            //getter for the property
            get
            {
                //return record count
                return mDestinationList.Count;
            }
            set
            {

            }
        }
        //public List of destinations
        public List<clsDestination> DestinationList
        {
            get
            {
                //return private dat
                return mDestinationList;
            }
            set
            {
                //set the private data
                mDestinationList = value;
            }
        }
        public clsDestination ThisDestination { get; set; }

        //constructor for the class
        public clsDestinationCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;
            //create an instance of the data connection
            DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblDestination_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //While there are record are records to process
            while (Index < RecordCount)
            {
                //create a blank Destination
                clsDestination AnDestination = new clsDestination();
                //read in the fields from the current record
                AnDestination.DestinationID = Convert.ToInt32(DB.DataTable.Rows[0]["DestinationID"]);
                //private Int32 PickupTime;
                AnDestination.PickupTime = Convert.ToDateTime(DB.DataTable.Rows[0]["PickupTime"]);
                //private Int32 EndPointHouseNo;
                AnDestination.EndPointHouseNo = Convert.ToInt32(DB.DataTable.Rows[0]["EndPointHouseNo"]);
                //private string EndPointPostCode;
                AnDestination.EndPointPostCode = Convert.ToString(DB.DataTable.Rows[0]["EndPointPostCode"]);
                //private string EndPointStreet;
                AnDestination.EndPointStreet = Convert.ToString(DB.DataTable.Rows[0]["EndPointStreet"]);
                //private string EndPointTown;
                AnDestination.EndPointTown = Convert.ToString(DB.DataTable.Rows[0]["EndPointTown"]);
                //private string DropoffTime;
                AnDestination.DropoffTime = Convert.ToDateTime(DB.DataTable.Rows[0]["DropoffTime"]);
                //add the record to the private data member
                mDestinationList.Add(AnDestination);
                //point at the next record
                Index++;
            }
        }
    }
}