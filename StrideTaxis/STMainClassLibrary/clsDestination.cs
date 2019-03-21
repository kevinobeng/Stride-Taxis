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
        private string mEndPointHouseNo;
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

        public string EndPointHouseNo
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
                mEndPointHouseNo = Convert.ToString(DB.DataTable.Rows[0]["EndPointHouseNo"]);
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
        public string Valid(string endPointHouseNo, string endPointPostCode, string endPointStreet, string endPointTown, string pickupTime)
        {
            //create a string variable to store the error
            String Error = "";
            DateTime DateTemp;
            //if the EndPointHouseNo is blank
            if (endPointHouseNo.Length == 0)
            {
                //record the error
                Error = Error + "The House No May Not Be Blank : ";
            }
            //if the house no is greater than 6
            if (endPointHouseNo.Length > 6)
            {
                //record the error
                Error = Error + "The House No Must Not Be More Than 6 Characters : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(pickupTime);
                if (DateTemp < DateTime.Now.Date)
                {
                    //recorded the error
                    Error = Error + "The Date Can Not Be In The Past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The Date Cannot Be In The Future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The Date Was Not A Valid Date : ";
            }
            if (endPointPostCode.Length == 0)
            {
                //record the error
                Error = Error + "The Post Code May Not Be Blank : ";
            }
            //if the house no is greater than 10
            if (endPointPostCode.Length > 10)
            {
                //record the error
                Error = Error + "The Post Code Must Not Be More Than 10 Characters : ";
            }
            if (endPointStreet.Length == 0)
            {
                //record the error
                Error = Error + "The Street May Not Be Blank : ";
            }
            //if the house no is greater than 50
            if (endPointStreet.Length > 50)
            {
                //record the error
                Error = Error + "The Street Must Not Be More Than 50 Characters : ";
            }
            if (endPointTown.Length == 0)
            {
                //record the error
                Error = Error + "The Town May Not Be Blank : ";
            }
            //if the house no is greater than 50
            if (endPointTown.Length > 50)
            {
                //record the error
                Error = Error + "The Town Must Not Be More Than 50 Characters : ";
            }
            //return any error messages 
            return Error;
        }
    }
}


