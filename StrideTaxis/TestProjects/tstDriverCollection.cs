using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STMainClassLibrary;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class tstDriverCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsDriverCollection AllDrivers = new clsDriverCollection();
            //test to see that it exists
            Assert.IsNotNull(AllDrivers);
        }
        [TestMethod]

        public void DriverListOK()
        {
            //create an instance of the classwe want to create
            clsDriverCollection AllDrivers = new clsDriverCollection();
            //create some test data assign to the property
            //in this case the data needs to be a list of objects
            List<clsDriver> TestList = new List<clsDriver>();
            //add an item to the list 
            //create the item of test data
            clsDriver TestItem = new clsDriver();
            //set its properties 
            TestItem.LicenseNo = 1098789;
            TestItem.Email = "Test Email";
            TestItem.FirstName = "Test FirstName";
            TestItem.LastName = "Test LastName";
            TestItem.TelephoneNo = 10258794;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllDrivers.DriverList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllDrivers.DriverList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the clas we want to create
            clsDriverCollection AllDrivers = new clsDriverCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllDrivers.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreEqual(AllDrivers.Count, SomeCount);
        }
        [TestMethod]
        public void ThisDriverPropertyOK()
        {
            //create an instance of the class we want to create 
            clsDriverCollection AllDrivers = new clsDriverCollection();
            //create some test data to assign to the property 
            clsDriver TestDriver = new clsDriver();
            //set the properties of the test object
            TestDriver.LicenseNo = 1098789;
            TestDriver.Email = "Test Email";
            TestDriver.FirstName = "Test FirstName";
            TestDriver.LastName = "Test LastName";
            TestDriver.TelephoneNo = 10258794;
            AllDrivers.ThisDriver = TestDriver;
            //test to see that the two values are the same
            Assert.AreEqual(AllDrivers.ThisDriver, TestDriver);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsDriverCollection AllDrivers = new clsDriverCollection();
            //create the item of test data
            clsDriver TestItem = new clsDriver();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.LicenseNo = 1098789;
            TestItem.Email = "Test Email";
            TestItem.FirstName = "Test FirstName";
            TestItem.LastName = "Test LastName";
            TestItem.TelephoneNo = 10258794;
            //set ThisDriver to the test data 
            AllDrivers.ThisDriver = TestItem;
            //add the record 
            PrimaryKey = AllDrivers.Add();
            //set the primary key of the test data
            TestItem.LicenseNo = PrimaryKey;
            //find the record
            AllDrivers.ThisDriver.Find(PrimaryKey);
            //find the record 
            AllDrivers.ThisDriver.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllDrivers.ThisDriver, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsDriverCollection AllDrivers = new clsDriverCollection();
            //create the item of test data
            clsDriver TestItem = new clsDriver();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.LicenseNo = 1098789;
            TestItem.Email = "Test Email";
            TestItem.FirstName = "Test FirstName";
            TestItem.LastName = "Test LastName";
            TestItem.TelephoneNo = 10258794;
            //set ThisDriver to the test data 
            AllDrivers.ThisDriver = TestItem;
            //add the record 
            PrimaryKey = AllDrivers.Add();
            //set the primary key of the test data
            TestItem.LicenseNo = PrimaryKey;
            //find the record
            AllDrivers.ThisDriver.Find(PrimaryKey);
            //delete the record 
            AllDrivers.Delete();
            //now find the record 
            Boolean Found = AllDrivers.ThisDriver.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsDriverCollection AllDrivers = new clsDriverCollection();
            //create the item of test data
            clsDriver TestItem = new clsDriver();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.LicenseNo = 1098789;
            TestItem.Email = "Test Email";
            TestItem.FirstName = "Test FirstName";
            TestItem.LastName = "Test LastName";
            TestItem.TelephoneNo = 10258794;
            //set ThisDriver to the test data 
            AllDrivers.ThisDriver = TestItem;
            //add the record 
            PrimaryKey = AllDrivers.Add();
            //set the primary key of the test data
            TestItem.LicenseNo = PrimaryKey;
            //modify the test data
            TestItem.LicenseNo = 1098790;
            TestItem.Email = "Some Email";
            TestItem.FirstName = "Some FirstName";
            TestItem.LastName = "Some LastName";
            TestItem.TelephoneNo = 10258794;
            //set the record based on the new test data
            AllDrivers.ThisDriver =TestItem;
            //update the record 
            AllDrivers.Update();
            //find the record
            AllDrivers.ThisDriver.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllDrivers.ThisDriver, TestItem);
        }
        [TestMethod]
        public void ReportByLicenseNoMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsDriverCollection AllDrivers = new clsDriverCollection();
            //create an instance of the filtered data
            clsDriverCollection FilteredDrivers = new clsDriverCollection();
            //apply a blank string (should return all records);
            FilteredDrivers.ReportByLicenseNo("");
            //test to see that the two values are the same
            Assert.AreEqual(AllDrivers.Count, FilteredDrivers.Count);
        }
        [TestMethod]
        public void ReportByLicenseNoNoneFound()
        {
            //create an instance of the filtered data
            clsDriverCollection FilteredDrivers = new clsDriverCollection();
            //apply a post code that doesn't exist
            FilteredDrivers.ReportByLicenseNo("xxx xxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredDrivers.Count);
        }

    }
}
