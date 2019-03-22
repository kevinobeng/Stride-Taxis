using System;
using System.Collections.Generic;

using STMainClassLibrary;

namespace STMainClassLibrary
{
    public class clsCarCollection
    {
        //private data member for the list
        List<clsCar> mCarList = new List<clsCar>();
        //private data member ThisCar
        clsCar mThisCar = new clsCar();
        //public property for ThisCar
        public clsCar ThisCar
        {
            get
            {
                //return the private data
                return mThisCar;
            }
            set
            {
                //set the private data
                mThisCar = value;
            }
        }




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

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCarList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        //contructor for the class
        public clsCarCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored  procedure
            DB.Execute("sproc_tblCar_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCar AnCar = new clsCar();
                //read in the fields from the current record
                AnCar.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnCar.CarID = Convert.ToInt32(DB.DataTable.Rows[Index]["CarID"]);
                AnCar.CarColour = Convert.ToString(DB.DataTable.Rows[Index]["CarColour"]);
                AnCar.CarMake = Convert.ToString(DB.DataTable.Rows[Index]["CarMake"]);
                AnCar.CarModel = Convert.ToString(DB.DataTable.Rows[Index]["CarModel"]);
                AnCar.RegistrationNo = Convert.ToString(DB.DataTable.Rows[Index]["RegistrationNo"]);
                //add the record to the private data member
                mCarList.Add(AnCar);
                //point at the next record
                Index++;
            }
        }
        public int Add()
        {
            //adds a new record to the database based on the values of ThisCar
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CarID", mThisCar.CarID);
            DB.AddParameter("@CarColour", mThisCar.CarColour);
            DB.AddParameter("@CarMake", mThisCar.CarMake);
            DB.AddParameter("@CarModel", mThisCar.CarModel);
            DB.AddParameter("@RegistrationNo", mThisCar.RegistrationNo);
            DB.AddParameter("@Active", mThisCar.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCar_Insert");
        }
        public void Delete()
        {
            //deletes the record pointed to by thisCar
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CarID", mThisCar.CarID);
            //execute the stored procedure
            DB.Execute("sproc_tblCar_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisCar
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CarID", mThisCar.CarID);
            DB.AddParameter("@CarColour", mThisCar.CarColour);
            DB.AddParameter("@CarMake", mThisCar.CarMake);
            DB.AddParameter("@CarModel", mThisCar.CarModel);
            DB.AddParameter("@RegistrationNo", mThisCar.RegistrationNo);
            DB.AddParameter("@Active", mThisCar.Active);
            //execute the stored procedure
            DB.Execute("sproc_tblCar_Update");
        }
    }

}

       