using System.Collections.Generic;

namespace STMainClassLibrary
{
    public class clsDestinationCollection
    {
        //private data nember for the list
        List<clsDestination> mDestinationList = new List<clsDestination>();
        public List<clsDestination> DestinationList
        {
            get
            {
                //return the private data
                return mDestinationList;
            }
            set
            {
                //set the private data 
                mDestinationList = value;
            }
        }
        public clsDestination ThisDestination { get; set; }
        public int Count { get; set; }
    }
}