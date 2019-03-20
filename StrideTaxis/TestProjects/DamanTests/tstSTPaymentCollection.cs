﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STMainClassLibrary;
using System.Collections.Generic;

namespace TestProjects
{
    [TestClass]
    public class tstSTPaymentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsSTPaymentCollection AllTestPayments = new clsSTPaymentCollection();
            //Test to see if that it exists
            Assert.IsNotNull(AllTestPayments);
        }

        [TestMethod]
        public void PaymentListOK()
        {
            //Create an instance of the class we want to create
            clsSTPaymentCollection AllTestPayments = new clsSTPaymentCollection();
            //Create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsSTPayment> PaymentTestList = new List<clsSTPayment>();
            //Add an item to the list
            clsSTPayment PaymentTestItem = new clsSTPayment();
            //Set it properties
            PaymentTestItem.CardNumber = "1234567891234567";
            PaymentTestItem.AccountNumber = "12345678";
            PaymentTestItem.SortCode = "123456";
            PaymentTestItem.ExpiryDate = "12/22";
            PaymentTestItem.ValidFrom = "12/19";
            PaymentTestItem.CardHolderName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLM";
            PaymentTestItem.CVC = "123";
            //Add the test payment item to the list
            PaymentTestList.Add(PaymentTestItem);
            //Assign the data to the property
            AllTestPayments.PaymentList = PaymentTestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllTestPayments.PaymentList, PaymentTestList);
        }

        //[TestMethod]
        //public void PaymentCountPropertyOK()
        //{
        //    //Create an instance of the class we want to create
        //    clsSTPaymentCollection AllTestPayments = new clsSTPaymentCollection();
        //    //Create some test data to assign to the property
        //    Int32 SomePaymentCount = 2;
        //    //Assign the data to the property
        //    AllTestPayments.Count = SomePaymentCount;
        //    //Test to see that the two values are the same
        //    Assert.AreEqual(AllTestPayments.Count, SomePaymentCount);
        //}

        [TestMethod]
        public void ThisPaymentPropertyOK()
        {
            //Create an instance of the class we want to create
            clsSTPaymentCollection AllTestPayments = new clsSTPaymentCollection();
            //Create some test data to assign to the property
            //in this case the data needs to be a list of objects
            clsSTPayment PaymentTest = new clsSTPayment();
            //Set it properties
            PaymentTest.CardNumber = "1234567891234567";
            PaymentTest.AccountNumber = "12345678";
            PaymentTest.SortCode = "123456";
            PaymentTest.ExpiryDate = "12/22";
            PaymentTest.ValidFrom = "12/19";
            PaymentTest.CardHolderName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLM";
            PaymentTest.CVC = "123";
            //Assign the data to the property
            AllTestPayments.ThisPayment = PaymentTest;
            //Test to see that the two values are the same
            Assert.AreEqual(AllTestPayments.ThisPayment, PaymentTest);
        }

        [TestMethod]
        public void ListPaymentAndCountOK()
        {
            //Create an instance of the class we want to create
            clsSTPaymentCollection AllTestPayments = new clsSTPaymentCollection();
            //Create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsSTPayment> PaymentTestList = new List<clsSTPayment>();
            //Add an item to the list
            clsSTPayment PaymentTestItem = new clsSTPayment();
            //Set it properties
            PaymentTestItem.CardNumber = "1234567891234567";
            PaymentTestItem.AccountNumber = "12345678";
            PaymentTestItem.SortCode = "123456";
            PaymentTestItem.ExpiryDate = "12/22";
            PaymentTestItem.ValidFrom = "12/19";
            PaymentTestItem.CardHolderName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLM";
            PaymentTestItem.CVC = "123";
            //Add the test payment item to the list
            PaymentTestList.Add(PaymentTestItem);
            //Assign the data to the property
            AllTestPayments.PaymentList = PaymentTestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllTestPayments.Count, PaymentTestList.Count);

        }

        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    //Create an instance of the class we want to create
        //    clsSTPaymentCollection AllTestPayments = new clsSTPaymentCollection();
        //    //Test to see that the two values are the same
        //    Assert.AreEqual(AllTestPayments.Count, 2);

        //}
    }
}
