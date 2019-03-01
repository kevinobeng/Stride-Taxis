using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMainClassLibrary
{
    public class clsDestination
    {
        private Int32 mDestinationID;
        private DateTime mPickupTime;
        private Int32 mEndPointHouseNo;
        private string mEndPointPostCode;
        private string mEndPointStreet;
        private string mEndPointTown;
        private DateTime mDropoffTime;
        //private data members for the class
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
    }
}
