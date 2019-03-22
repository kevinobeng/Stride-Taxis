using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace STMainClassLibrary
{
    public class clsCar
    {
        //private data member for the Car ID property
        private Int32 mCarID;
        //private data memeber for Car Colour
        private string mCarColour;
        //private data member for Car Make
        private string mCarMake;
        //private data member for Car Model
        private string mCarModel;
        //private data member for RegistrationNo
        private string mRegistrationNo;
        //private data member for active
        private bool mActive;

        //public property for the Car ID
        public int CarID
        {
            get
            {
                //return the private data
                return mCarID;
            }
            set
            {


                //set the value of the private data member 
                mCarID = value;
            }

        }

        //public property for Car Colour
        public clsCar ThisCar;

        //private data member for the list
        List<clsCar> mCarList = new List<clsCar>();
        //public property for the Car List
        public List<clsCar> CarList
        {
            get
            {
                //return the private data
                return mCarList;
            }
            set
            {
                //set the private data
                mCarList = value;
            }
        }
        public string CarColour
        {
            get
            {
                //return the private
                return mCarColour;
            }
            set
            {
                //set the private data
                mCarColour = value;
            }
        }
        //public property for Car Make
        public string CarMake
        {
            get
            {
                //return the private
                return mCarMake;
            }
            set
            {
                //set the private data
                mCarMake = value;
            }
        }
        //public property for Car Colour
        public string CarModel
        {
            get
            {
                //return the private
                return mCarModel;
            }
            set
            {
                //set the private data
                mCarModel = value;
            }
        }
        //public property for RegistrationNo
        public string RegistrationNo
        {
            get
            {
                //return the private
                return mRegistrationNo;
            }
            set
            {
                //set the private data
                mRegistrationNo = value;
            }
        }
        //public property for active
        public bool Active
        {
            get
            {
                //return the private
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }

        public bool Find(int carID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Car ID to search for
            DB.AddParameter("@CarID", CarID);
            //execute the store procedure
            DB.Execute("sproc_tblCar_FilterByCarID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data the datBse to the private data members
                mCarID = Convert.ToInt32(DB.DataTable.Rows[0]["CarID"]);
                mCarColour = Convert.ToString(DB.DataTable.Rows[0]["CarColour"]);
                mCarMake = Convert.ToString(DB.DataTable.Rows[0]["CarModel"]);
                mCarModel = Convert.ToString(DB.DataTable.Rows[0]["CarMake"]);
                mRegistrationNo = Convert.ToString(DB.DataTable.Rows[0]["RegistrationNo"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string carID, string carColour, string carMake, string carModel, string registrationNo, string active)
        {
            return "";
        }

        public string CarIDValid(string someCarID)
        {
            return "";
        }
        public string CarColourValid(string someCarColour)
        {
            return "";
        }
        public string CarMakeValid(string someCarMake)
        {
            return "";
        }
        public string CarModelValid(string someCarModel)
        {
            return "";
        }
        public string RegistrationNoValid(string someRegistrationNo)
        {
            return "";
        }

        public bool Find(string carID)
        {
            return true;
        }

        public static implicit operator int(clsCar v)
        {
            return 0;
        }
    }

}
