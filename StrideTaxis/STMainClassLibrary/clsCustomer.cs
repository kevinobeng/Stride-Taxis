using System;

namespace STMainClassLibrary
{
    public class clsCustomer
    {
        public int UserNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int HouseNumber { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string Email { get; set; }
        public int TelephoneNumber { get; set; }

        public string UserNumberValid(string someUserNumber)
        {
            return "";
        }
    }
}