using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STMainClassLibrary;
using System.Collections.Generic;

namespace TestProjects.KevinsTests
{
    [TestClass]
    public class tstDestinationCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsDestinationCollection AllDestinations = new clsDestinationCollection();
            //test to see that it exists
            Assert.IsNotNull(AllDestinations);
        }
        [TestMethod]
        public void DestinationListOk()
        {
            //create an instance of the class we want to create
            clsDestinationCollection AllDestinations = new clsDestinationCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsDestination> TestList = new List<clsDestination>();
            //add an item to the list 
            //create the item of test data
            clsDestination TestItem = new clsDestination();
            //set its properties 
            TestItem.DestinationID = 1;
            TestItem.EndPointHouseNo = "1";
            TestItem.EndPointPostCode = "LE2 2WX";
            TestItem.EndPointStreet = "God Street";
            TestItem.EndPointTown = "Leicester";
            TestItem.PickupTime = DateTime.Now.Date;
            TestItem.DropoffTime = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the date to the property
            AllDestinations.DestinationList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllDestinations.DestinationList, TestList);
        }
        [TestMethod]
        public void ThisDestinationPropertyOK()
        {
            //create an instance of the class we want to create
            clsDestinationCollection AllDestinations = new clsDestinationCollection();
            //create some test data to assign to the property
            clsDestination TestDestination = new clsDestination();
            //set its properties 
            TestDestination.DestinationID = 1;
            TestDestination.EndPointHouseNo = "1";
            TestDestination.EndPointPostCode = "LE2 2WX";
            TestDestination.EndPointStreet = "God Street";
            TestDestination.EndPointTown = "Leicester";
            TestDestination.PickupTime = DateTime.Now.Date;
            TestDestination.DropoffTime = DateTime.Now.Date;
            //assign the data to the property
            AllDestinations.ThisDestination = TestDestination;
            //test to see that the two values are the same
            Assert.AreEqual(AllDestinations.ThisDestination, TestDestination);
        }
        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to creat
            clsDestinationCollection AllDestinations = new clsDestinationCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsDestination> TestList = new List<clsDestination>();
            //add an item to the list 
            //create the item of test data
            clsDestination TestItem = new clsDestination();
            //set its properties 
            TestItem.DestinationID = 1;
            TestItem.EndPointHouseNo = "1";
            TestItem.EndPointPostCode = "LE2 2WX";
            TestItem.EndPointStreet = "God Street";
            TestItem.EndPointTown = "Leicester";
            TestItem.PickupTime = DateTime.Now.Date;
            TestItem.DropoffTime = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the date to the property
            AllDestinations.DestinationList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllDestinations.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to creat
            clsDestinationCollection AllDestinations = new clsDestinationCollection();
            //create the item of test data
            clsDestination TestItem = new clsDestination();
            //var to store the primary key
            Int32 Primarykey = 0;
            //set its properties 
            TestItem.DestinationID = 1;
            TestItem.EndPointHouseNo = "1";
            TestItem.EndPointPostCode = "LE2 2WX";
            TestItem.EndPointStreet = "God Street";
            TestItem.EndPointTown = "Leicester";
            TestItem.PickupTime = DateTime.Now.Date;
            TestItem.DropoffTime = DateTime.Now.Date;
            //set ThisDestination to the test data
            AllDestinations.ThisDestination = TestItem;
            //add the record
            Primarykey = AllDestinations.Add();
            //find the record
            AllDestinations.ThisDestination.Find(Primarykey);
            //test to see that the two valyes are the same
            Assert.AreEqual(AllDestinations.ThisDestination, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to creat
            clsDestinationCollection AllDestinations = new clsDestinationCollection();
            //create the item of test data
            clsDestination TestItem = new clsDestination();
            //var to store the primary key
            Int32 Primarykey = 0;
            //set its properties 
            TestItem.DestinationID = 1;
            TestItem.EndPointHouseNo = "1";
            TestItem.EndPointPostCode = "LE2 2WX";
            TestItem.EndPointStreet = "God Street";
            TestItem.EndPointTown = "Leicester";
            TestItem.PickupTime = DateTime.Now.Date;
            TestItem.DropoffTime = DateTime.Now.Date;
            //set ThisDestination to the test data
            AllDestinations.ThisDestination = TestItem;
            //add the record
            Primarykey = AllDestinations.Add();
            //find the record
            AllDestinations.ThisDestination.Find(Primarykey);
            //Delete the record
            AllDestinations.Delete();
            //not find the record
            Boolean Found = AllDestinations.ThisDestination.Find(Primarykey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to creat
            clsDestinationCollection AllDestinations = new clsDestinationCollection();
            //create the item of test data
            clsDestination TestItem = new clsDestination();
            //var to store the primary key
            Int32 Primarykey = 0;
            //set its properties 
            TestItem.EndPointHouseNo = "1";
            TestItem.EndPointPostCode = "LE2 2WX";
            TestItem.EndPointStreet = "God Street";
            TestItem.EndPointTown = "Leicester";
            TestItem.PickupTime = DateTime.Now.Date;
            TestItem.DropoffTime = DateTime.Now.Date;
            //set ThisDestination to the test data
            AllDestinations.ThisDestination = TestItem;
            //add the record
            Primarykey = AllDestinations.Add();
            //set the primary key of the test data
            TestItem.DestinationID = Primarykey;
            //modify the test data
            TestItem.EndPointHouseNo = "132";
            TestItem.EndPointPostCode = "GH2 2WX";
            TestItem.EndPointStreet = "God's Son Street";
            TestItem.EndPointTown = "Ash Town";
            TestItem.PickupTime = DateTime.Now.Date;
            TestItem.DropoffTime = DateTime.Now.Date;
            //set the record based on the new test data
            AllDestinations.ThisDestination = TestItem;
            //update the record
            AllDestinations.Update();
            //find the record
            AllDestinations.ThisDestination.Find(Primarykey);
            //test to see ThisDestionation match the test date
            Assert.AreEqual(AllDestinations.ThisDestination, TestItem);
        }

        [TestMethod]
        public void ReportByTownMethodOK()
        {
            //create an instance of the class we want to creat
            clsDestinationCollection AllDestinations = new clsDestinationCollection();
            //create an instance of the filtered data 
            clsDestinationCollection FilteredDestinations = new clsDestinationCollection();
            //Apply a blank string (should return all of the record on the database)
            FilteredDestinations.ReportByTown("");
            //test to see that the two value are the same 
            Assert.AreEqual(AllDestinations.Count, FilteredDestinations.Count);
        }
    }
}
