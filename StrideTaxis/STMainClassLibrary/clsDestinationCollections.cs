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
        //private data member thisDestination
        clsDestination mThisDestination = new clsDestination();
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
        public clsDestination ThisDestination
        {
            get
            {
                //return the private data
                return mThisDestination;
            }
            set
            {
                //set the private data
                mThisDestination = value;
            }
        }

        //constructor for the class
        public clsDestinationCollection()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblDestination_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        public void FindAllDestinations()
        {
            //re-set the connection
            DB = new clsDataConnection();
            //var to store the index
            Int32 Index = 0;
            //var to store the Destination number of the current record
            Int32 DestinationID;
            //var to flag that user was found
            Boolean DestinationFound;
            //execute the stored procedure
            DB.Execute("sproc_tblDestination_SelectAll");
            //get the count of records
            mCount = DB.Count;
            //while there are still records to process
            while (Index < DB.Count)
            {
                //create an instance of the destination class
                clsDestination NewDestination = new clsDestination();
                //get the destination number from the database
                DestinationID = Convert.ToInt32(DB.DataTable.Rows[Index]["DestinationID"]);
                //find the user by invoking the find method
                DestinationFound = NewDestination.Find(DestinationID);
                if (DestinationFound == true)
                {
                    //add the user to the list
                    mDestinationList.Add(NewDestination);
                }
                //increment the index
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database base on the values of mThisDestination
            //connect to the DataBase
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EndPointHouseNo", mThisDestination.EndPointHouseNo);
            DB.AddParameter("@EndPointPostCode", mThisDestination.EndPointPostCode);
            DB.AddParameter("@EndPointStreet", mThisDestination.EndPointStreet);
            DB.AddParameter("@EndPointTown", mThisDestination.@EndPointTown);
            DB.AddParameter("@PickupTime", mThisDestination.PickupTime);
            DB.AddParameter("@DropoffTime", mThisDestination.DropoffTime);
            //Execute the query returning the primary key value
            return DB.Execute("sproc_tblDestination_Insert");
        }

        public void Delete()
        {
            //delete the record pointed to by thisdestination
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@DestinationID", mThisDestination.DestinationID);
            //execute the stored procedure
            DB.Execute("sproc_tblDestination_Delete");
        }

        public void Update()
        {
            //adds a new record to the database base on the values of mThisDestination
            //connect to the DataBase
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@DestinationID", mThisDestination.DestinationID);
            DB.AddParameter("@EndPointHouseNo", mThisDestination.EndPointHouseNo);
            DB.AddParameter("@EndPointPostCode", mThisDestination.EndPointPostCode);
            DB.AddParameter("@EndPointStreet", mThisDestination.EndPointStreet);
            DB.AddParameter("@EndPointTown", mThisDestination.@EndPointTown);
            DB.AddParameter("@PickupTime", mThisDestination.PickupTime);
            DB.AddParameter("@DropoffTime", mThisDestination.DropoffTime);
            //Execute the query returning the primary key value
            DB.Execute("sproc_tblDestination_Update");
        }

        public void ReportByTown(string EndPointTown)
        {
            //filtered the records based on a full or partial Town
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Town parameter to the database
            DB.AddParameter("@EndPointTown", EndPointTown);
            //execute the stored procedure
            DB.Execute("sproc_tblDestination_FilterByTown");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;           
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mDestinationList = new List<clsDestination>();
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
                AnDestination.EndPointHouseNo = Convert.ToString(DB.DataTable.Rows[0]["EndPointHouseNo"]);
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