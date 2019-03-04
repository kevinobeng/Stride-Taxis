using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMainClassLibrary
{
    public class clsDestination
    {
        //private data members for the class
        private Int32 mDestinationID;
        private DateTime mPickupTime;
        private Int32 mEndPointHouseNo;
        private string mEndPointPostCode;
        private string mEndPointStreet;
        private string mEndPointTown;
        private DateTime mDropoffTime;
        
        //public data members for the class
        public Int32 DestinationID
        {
            get
            {
                return mDestinationID;
            }
            set
            {
                mDestinationID = value;
            }
        }
        public DateTime PickupTime
        {
            get
            {
                return mPickupTime;
            }
            set
            {
                mPickupTime = value;
            }
        }

        public Int32 EndPointHouseNo
        {
            get
            {
                return mEndPointHouseNo;
            }
            set
            {
                mEndPointHouseNo = value;
            }
        }

        public string EndPointPostCode
        {
            get
            {
                return mEndPointPostCode;
            }
            set
            {
                mEndPointPostCode = value;
            }
        }

        public string EndPointStreet
        {
            get
            {
                return mEndPointStreet;
            }
            set
            {
                mEndPointStreet = value;
            }
        }

        public string EndPointTown
        {
            get
            {
                return mEndPointTown;
            }
            set
            {
                mEndPointTown = value;
            }
        }

        public DateTime DropoffTime
        {
            get
            {
                return mDropoffTime;
            }
            set
            {
                mDropoffTime = value;
            }
        }

        ///public find method
        public bool Find(int DestinationID)
        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@DestinationID", DestinationID);
            //execute the stored procedure
            DB.Execute("sproc_tblDestination_FilterByDestinationID");
            //if one record is found  (either one or 0)
            if (DB.Count == 1)
            {
                //set the private data members with the data from the database
                //private Int32 DestinationID;
                mDestinationID = Convert.ToInt32(DB.DataTable.Rows[0]["DestinationID"]);
                //private Int32 PickupTime;
                mPickupTime = Convert.ToDateTime(DB.DataTable.Rows[0]["PickupTime"]);
                //private Int32 EndPointHouseNo;
                mEndPointHouseNo = Convert.ToInt32(DB.DataTable.Rows[0]["EndPointHouseNo"]);
                //private string EndPointPostCode;
                mEndPointPostCode = Convert.ToString(DB.DataTable.Rows[0]["EndPointPostCode"]);
                //private string EndPointStreet;
                mEndPointStreet = Convert.ToString(DB.DataTable.Rows[0]["EndPointStreet"]);
                //private string EndPointTown;
                mEndPointTown = Convert.ToString(DB.DataTable.Rows[0]["EndPointTown"]);
                //private string DropoffTime;
                mDropoffTime = Convert.ToDateTime(DB.DataTable.Rows[0]["DropoffTime"]);
                //return success
                return true;
            }
            else //user no was invalid
            {
                //return that there was a problem
                return false;
            }
        }

        public string Valid(string endPointHouseNo, string endPointPostCode, string endPointStreet, string endPointTown, string pickupTime, string dropoffTime)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary varible to store date value
            DateTime DateTemp;
            //if the EndPointHouseNo is blank
            if (endPointHouseNo.Length == 0)
            {
                //record the error
                Error = Error + "The House No May Be Blank : ";
            }
            //if the house no is greater than 6
            if (endPointHouseNo.Length > 6)
            {
                //record the error
                Error = Error + "The House No Must Be Less Than 6 Characters : ";
            }
            //copy the dateAdded value to the DateTemp variable
            DateTemp = Convert.ToDateTime(pickupTime);
            if (DateTemp < DateTime.Now.Date)
            {
                //recorded the error
                Error = Error + "The Date Can Not Be In The Past : ";
            }
            //return any error messages 
            return Error;
        }
    }
}
