using System;

namespace TestProjects
{
    internal class clsDestination
    {
        public clsDestination()
        {
        }

        public DateTime DropoffTime { get; internal set; }
        public int EndPointHouseNo { get; internal set; }
        public string EndPointPostCode { get; internal set; }
        public string EndPointStreet { get; internal set; }
        public string EndPointTown { get; internal set; }
        public DateTime PickupTime { get; internal set; }
    }
}