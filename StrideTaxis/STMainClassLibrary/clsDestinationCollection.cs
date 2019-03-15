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
        private Int32 mRecordCount;
        //create a private list data member to store the data from the database
        private List<clsDestination> mDestinationList = new List<clsDestination>();
        //private data member to connect to the database
        private clsDataConnection myDB = new clsDataConnection();

        //public property returning the count of records
        public Int32 Count
        {
            //getter for the property
            get
            {
                //return record count
                return mRecordCount;
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

    }
}