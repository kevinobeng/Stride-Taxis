using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STMainClassLibrary;
using System.Collections.Generic;

namespace TestProjects.Hanna_s_Tests
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign & needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item to test
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.UserNumber = 1;
            TestItem.FirstName = "Hanna";
            TestItem.LastName = "Burrows";
            TestItem.HouseNumber = 40;
            TestItem.Town = "Leicester";
            TestItem.Street = "Pastures";
            TestItem.PostCode = "ab12 3ab";
            TestItem.Email = "123@gmail.com";
            TestItem.TelephoneNumber = 12345;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            //test to see that it exists
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign 
            clsCustomer TestCustomer = new clsCustomer();
            //set its properties
            TestCustomer.UserNumber = 1;
            TestCustomer.FirstName = "Hanna";
            TestCustomer.LastName = "Burrows";
            TestCustomer.HouseNumber = 40;
            TestCustomer.Town = "Leicester";
            TestCustomer.Street = "Pastures";
            TestCustomer.PostCode = "ab12 3ab";
            TestCustomer.Email = "123@gmail.com";
            TestCustomer.TelephoneNumber = 12345;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            //test to see that it exists
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign & needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item to test
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.UserNumber = 1;
            TestItem.FirstName = "Hanna";
            TestItem.LastName = "Burrows";
            TestItem.HouseNumber = 40;
            TestItem.Town = "Leicester";
            TestItem.Street = "Pastures";
            TestItem.PostCode = "ab12 3ab";
            TestItem.Email = "123@gmail.com";
            TestItem.TelephoneNumber = 12345;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            //test to see that it exists
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign 
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.UserNumber = 1;
            TestItem.FirstName = "Hanna";
            TestItem.LastName = "Burrows";
            TestItem.HouseNumber = 40;
            TestItem.Town = "Leicester";
            TestItem.Street = "Pastures";
            TestItem.PostCode = "ab12 3ab";
            TestItem.Email = "123@gmail.com";
            TestItem.TelephoneNumber = 12345;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of test data
            TestItem.UserNumber = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            //test to see that it exists
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign 
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.UserNumber = 1;
            TestItem.FirstName = "Hanna";
            TestItem.LastName = "Burrows";
            TestItem.HouseNumber = 40;
            TestItem.Town = "Leicester";
            TestItem.Street = "Pastures";
            TestItem.PostCode = "ab12 3ab";
            TestItem.Email = "123@gmail.com";
            TestItem.TelephoneNumber = 12345;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of test data
            TestItem.UserNumber = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign 
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties            
            TestItem.FirstName = "Hanna";
            TestItem.LastName = "Burrows";
            TestItem.HouseNumber = 40;
            TestItem.Town = "Leicester";
            TestItem.Street = "Pastures";
            TestItem.PostCode = "ab12 3ab";
            TestItem.Email = "123@gmail.com";
            TestItem.TelephoneNumber = 12345;
            //set this as the data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of test data
            TestItem.UserNumber = PrimaryKey;
            //modify the test data           
            TestItem.FirstName = "Hannah";
            TestItem.LastName = "Burro";
            TestItem.HouseNumber = 47;
            TestItem.Town = "Leicestershire";
            TestItem.Street = "The Pastures";
            TestItem.PostCode = "ab13 3ab";
            TestItem.Email = "1234@gmail.com";
            TestItem.TelephoneNumber = 011612345;
            //set the record based on the new data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            //test to see that it exists
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            //create an instance of the class to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomers.ReportByPostCode("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByPostCodeNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomers.ReportByPostCode("XXXX XXX");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByPostCodeFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a poscode that doesnt exsit
            FilteredCustomers.ReportByPostCode("yyyy yyy");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredCustomers.CustomerList[0].UserNumber != 36)
                {
                    OK = false;
                }
                //check if the first record is ID 37
                if (FilteredCustomers.CustomerList[1].UserNumber != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}



