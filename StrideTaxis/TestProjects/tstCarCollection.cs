using System;
using STMainClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace Testing
{
    [TestClass]
    public class tstCarCollection
    {
        public clsCar TestItem { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create and instance of the class we want to create 
            clsCarCollection AllCars = new clsCarCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCars);
        }
        [TestMethod]
        public void CarListOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create some test data needs to be a list of objects
            List<clsCar> TestList = new List<clsCar>();
            //add an item to the test data
            clsCar TestItem = new clsCar();
            //set its properties
            TestItem.Active = true;
            TestItem.CarID = 189;
            TestItem.CarColour = "Red";
            TestItem.CarMake = "Mercedes-Benz";
            TestItem.CarModel = "Hybrid";
            TestItem.RegistrationNo = "RM12DFG";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCars.CarList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.CarList, TestList);

        }
        [TestMethod]
        public void ThisCarPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCarCollection AllCars = new clsCarCollection();
            //create some test data to assign to the property
            clsCar TestCar = new clsCar();
            //set the properties of the test object
            TestCar.Active = true;
            TestCar.CarID = 189;
            TestCar.CarColour = "Red";
            TestCar.CarMake = "Mercedes-Benz";
            TestCar.CarModel = "Hybrid";
            TestCar.RegistrationNo = "RM12DFG";
            //assign the data to the property
            AllCars.ThisCar = TestCar;
            Assert.AreEqual(AllCars.ThisCar, TestCar);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllCars.Count = SomeCount;
            //test to see that two values are the same
            Assert.AreEqual(AllCars.Count, SomeCount);


        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create the item of the test data
            clsCar TestItem = new clsCar();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CarID = 189;
            TestItem.CarColour = "Red";
            TestItem.CarMake = "Mercedes-Benz";
            TestItem.CarModel = "Hybrid";
            TestItem.RegistrationNo = "RM12DFG";
            //set ThisCar to the test data
            TestItem.CarID = TestItem;
            //add the record
            PrimaryKey = AllCars.Add();
            //set the primary key of the tst data
            TestItem.CarID = PrimaryKey;
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //test to see that two values are the same
            Assert.AreEqual(AllCars.ThisCar, TestItem);


        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create the item of test data
            clsCar TestItem = new clsCar();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CarID = 189;
            TestItem.CarColour = "Red";
            TestItem.CarMake = "Mercedes-Benz";
            TestItem.CarModel = "Hybrid";
            TestItem.RegistrationNo = "RM12DFG";
            //set ThisCar to the test data
            AllCars.ThisCar = TestItem;
            //add the record
            PrimaryKey = AllCars.Add();
            //set the primary key of the test data
            TestItem.CarID = PrimaryKey;
            //find the record
            AllCars.Delete();
            //now find the record
            Boolean Found = AllCars.ThisCar.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create the item of test data
            clsCar TestItem = new clsCar();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CarID = 189;
            TestItem.CarColour = "Red";
            TestItem.CarMake = "Mercedes-Benz";
            TestItem.CarModel = "Hybrid";
            TestItem.RegistrationNo = "RM12DFG";
            //set ThisCar to the test data
            AllCars.ThisCar = TestItem;
            //add the record
            PrimaryKey = AllCars.Add();
            //set the primary key of the test data
            TestItem.CarID = PrimaryKey;
            //modify test data
            TestItem.Active = false;
            TestItem.CarID = 193;
            TestItem.CarColour = "Black";
            TestItem.CarMake = "Vauxhall";
            TestItem.CarModel = "Z";
            TestItem.RegistrationNo = "JL11ASD";
            //set the record based on the new test data
            AllCars.ThisCar = TestItem;
            //update the record
            AllCars.Update();
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //test to see ThisCar matches the test data
            Assert.AreEqual(AllCars.ThisCar, TestItem);
        }
    }
}
        



