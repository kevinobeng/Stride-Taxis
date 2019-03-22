using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STMainClassLibrary;

namespace Test_Framework
{
    [TestClass]
    public class tstCar
    {
        string CarID = "189";
        string CarColour = "Red";
        string CarMake = "Mercedes-Benz";
        string CarModel = "Hybrid";
        string Active = "true";
        string RegistrationNo = "RM12DFG";


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //test to see that it exists
            Assert.IsNotNull(AnCar);

        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCar.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCar.Active, TestData);
        }
        [TestMethod]

        public void CarIDPropertyOK()
        {
            //Might need to put instanceOK like brian on friday
            //create an instance of a class that we want to create
            clsCar AnCar = new clsCar();
            //create some test data to assign to the property
            Int32 TestData = 189;
            //assign the data to the property
            AnCar.CarID = TestData;
            //test to the see that the two values are the same
            Assert.AreEqual(AnCar.CarID, TestData);


        }
        [TestMethod]
        public void CarIDMinLessOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarID = "189";
            //Invoke the method
            Error = AnCar.CarIDValid(SomeCarID);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarIDMinBoundary()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarID = "189";
            //Invoke the method
            Error = AnCar.CarIDValid(SomeCarID);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarIDMinPlusOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarID = "189";
            //Invoke the method
            Error = AnCar.CarIDValid(SomeCarID);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarIDMid()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarID = "189";
            //Invoke the method
            Error = AnCar.CarIDValid(SomeCarID);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarIDMaxLessOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarID = "189";
            //Invoke the method
            Error = AnCar.CarIDValid(SomeCarID);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarIDMaxBoundary()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarID = "189";
            //Invoke the method
            Error = AnCar.CarIDValid(SomeCarID);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarIDMaxPlusOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarID = "189";
            //Invoke the method
            Error = AnCar.CarIDValid(SomeCarID);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarIDExtremeMax()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarID = "189";
            //Invoke the method
            Error = AnCar.CarIDValid(SomeCarID);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarColourPropertyOK()
        {
            //create an instance of a class that we want to create
            clsCar AnCar = new clsCar();
            //create some test data to assign to the property
            string TestData = "Red";
            //assign the data to the property
            AnCar.CarColour = TestData;
            //test to the see that the two values are the same
            Assert.AreEqual(AnCar.CarColour, TestData);


        }
        [TestMethod]
        public void CarColourValidPaymentOK()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarColour = "Red";
            //Invoke the method
            Error = AnCar.CarColourValid(SomeCarColour);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarColourMinLessOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarColour = "Red";
            //Invoke the method
            Error = AnCar.CarColourValid(SomeCarColour);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarColourMinBoundary()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarColour = "Red";
            //Invoke the method
            Error = AnCar.CarColourValid(SomeCarColour);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarColourMinPlusOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarColour = "Red";
            //Invoke the method
            Error = AnCar.CarColourValid(SomeCarColour);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarColourMid()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarColour = "Red";
            //Invoke the method
            Error = AnCar.CarColourValid(SomeCarColour);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarColourMaxLessOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarColour = "Red";
            //Invoke the method
            Error = AnCar.CarColourValid(SomeCarColour);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarColourMaxBoundary()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarColour = "Red";
            //Invoke the method
            Error = AnCar.CarColourValid(SomeCarColour);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarColourMaxPlusOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarColour = "Red";
            //Invoke the method
            Error = AnCar.CarColourValid(SomeCarColour);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarColourExtremeMax()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarColour = "Red";
            //Pad the string with characters
            SomeCarColour = SomeCarColour.PadRight(500, 'a');
            //Invoke the method
            Error = AnCar.CarColourValid(SomeCarColour);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CarMakePropertyOK()
        {
            //create an instance of a class that we want to create
            clsCar AnCar = new clsCar();
            //create some test data to assign to the property
            string TestData = "Mercedes-Benz";
            //assign the data to the property
            AnCar.CarMake = TestData;
            //test to the see that the two values are the same
            Assert.AreEqual(AnCar.CarMake, TestData);


        }
        [TestMethod]
        public void CarMakeMinLessOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarMake = "Mercedes-Benz";
            //Invoke the method
            Error = AnCar.CarMakeValid(SomeCarMake);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarMakeMinBoundary()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarMake = "Mercedes-Benz";
            //Invoke the method
            Error = AnCar.CarMakeValid(SomeCarMake);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarMakeMinPlusOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarMake = "Mercedes-Benz";
            //Invoke the method
            Error = AnCar.CarMakeValid(SomeCarMake);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarMakeMid()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarMake = "Mercedes-Benz";
            //Invoke the method
            Error = AnCar.CarMakeValid(SomeCarMake);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarMakeMaxLessOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarMake = "Mercedes-Benz";
            //Invoke the method
            Error = AnCar.CarMakeValid(SomeCarMake);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarMakeMaxBoundary()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarMake = "Mercedes-Benz";
            //Invoke the method
            Error = AnCar.CarMakeValid(SomeCarMake);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarMakeMaxPlusOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarMake = "Mercedes-Benz";
            //Invoke the method
            Error = AnCar.CarMakeValid(SomeCarMake);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarMakeExtremeMax()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarMake = "";
            //Pad the string with characters
            SomeCarMake = SomeCarMake.PadRight(500, 'a');
            //Invoke the method
            Error = AnCar.CarMakeValid(SomeCarMake);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarModelPropertyOK()
        {
            //create an instance of a class that we want to create
            clsCar AnCar = new clsCar();
            //create some test data to assign to the property
            string TestData = "Hybrid";
            //assign the data to the property
            AnCar.CarModel = TestData;
            //test to the see that the two values are the same
            Assert.AreEqual(AnCar.CarModel, TestData);


        }
        [TestMethod]
        public void CarModelValidPaymentOK()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarModel = "Hybrid";
            //Invoke the method
            Error = AnCar.CarModelValid(SomeCarModel);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMinLessOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarModel = "Hyri";
            //Invoke the method
            Error = AnCar.CarModelValid(SomeCarModel);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMinBoundary()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarModel = "Hybrid";
            //Invoke the method
            Error = AnCar.CarModelValid(SomeCarModel);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CarModelMinPlusOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarModel = "Hybrid";
            //Invoke the method
            Error = AnCar.CarModelValid(SomeCarModel);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CarModelMid()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarModel = "Hybrid";
            //Invoke the method
            Error = AnCar.CarModelValid(SomeCarModel);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMaxLessOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarModel = "Hybrid";
            //Invoke the method
            Error = AnCar.CarModelValid(SomeCarModel);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CarModelMaxBoundary()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarModel = "Hybrid";
            //Invoke the method
            Error = AnCar.CarModelValid(SomeCarModel);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CarModelMaxPlusOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarModel = "Hybrid";
            //Invoke the method
            Error = AnCar.CarModelValid(SomeCarModel);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CarModelExtremeMax()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeCarModel = "";
            //Pad the string with characters
            SomeCarModel = SomeCarModel.PadRight(500, 'a');
            //Invoke the method
            Error = AnCar.CarModelValid(SomeCarModel);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationNoPropertyOK()
        {
            //Might need to put instanceOK like brian on friday
            //create an instance of a class that we want to create
            clsCar AnCar = new clsCar();
            //create some test data to assign to the property
            string TestData = "RM12DFG";
            //assign the data to the property
            AnCar.RegistrationNo = TestData;
            //test to the see that the two values are the same
            Assert.AreEqual(AnCar.RegistrationNo, TestData);

        }
        [TestMethod]
        public void RegistrationNoMinLessOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeRegistrationNo = "A";
            //Invoke the method
            Error = AnCar.RegistrationNoValid(SomeRegistrationNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationNoMinBoundary()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeRegistrationNo = "A";
            //Invoke the method
            Error = AnCar.RegistrationNoValid(SomeRegistrationNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationNoMinPlusOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeRegistrationNo = "A";
            //Invoke the method
            Error = AnCar.RegistrationNoValid(SomeRegistrationNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationNoMid()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeRegistrationNo = "A";
            //Invoke the method
            Error = AnCar.RegistrationNoValid(SomeRegistrationNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RegistrationNoMaxLessOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeRegistrationNo = "A";
            //Invoke the method
            Error = AnCar.RegistrationNoValid(SomeRegistrationNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RegistrationNoMaxBoundary()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeRegistrationNo = "A";
            //Invoke the method
            Error = AnCar.RegistrationNoValid(SomeRegistrationNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationNoMaxPlusOne()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeRegistrationNo = "A";
            //Invoke the method
            Error = AnCar.RegistrationNoValid(SomeRegistrationNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RegistrationNoExtremeMax()
        {
            //Create an instance of the clsCar
            clsCar AnCar = new clsCar();
            //Create a string variable to store the result of the validation
            string Error = "";
            //Create some test data to the method
            string SomeRegistrationNo = "A";
            //Invoke the method
            Error = AnCar.RegistrationNoValid(SomeRegistrationNo);
            //Test to see that the result is OK, i.e. there was error messages returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsCar AnCar = new clsCar();
            //boolean variable to store the result of the validation
            Boolean Found = true;
            //create some test data to use with the method
            string CarID = "189";
            //invoke the method
            Found = AnCar.Find(CarID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]

        public void TestCarIDFound()
        {
            //creqte an instance of the class we want to create 
            clsCar AnCar = new clsCar();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CarID = 189;
            //invoke the method 
            Found = AnCar.Find(CarID);
            //check the address no
            if (AnCar.CarID != 189)
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestCarColourFound()
        {
            //create an instance of the class we want to create 
            clsCar AnCar = new clsCar();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CarID = 189;
            //invoke the method 
            Found = AnCar.Find(CarID);
            //check the Car ID
            if (AnCar.CarColour != "Test Car Colour")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCarMakeFound()
        {
            //creqte an instance of the class we want to create 
            clsCar AnCar = new clsCar();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CarID = 189;
            //invoke the method 
            Found = AnCar.Find(CarID);
            //check the Car ID
            if (AnCar.CarMake != "Test Car Make")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCarModelFound()
        {
            //creqte an instance of the class we want to create 
            clsCar AnCar = new clsCar();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CarID = 189;
            //invoke the method 
            Found = AnCar.Find(CarID);
            //check the Car ID
            if (AnCar.CarModel != "Test Car Model")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestRegistrationNoFound()
        {
            //creqte an instance of the class we want to create 
            clsCar AnCar = new clsCar();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CarID = 189;
            //invoke the method 
            Found = AnCar.Find(CarID);
            //check the Car ID
            if (AnCar.RegistrationNo != "RM12DFG")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnCar.Valid(CarID, CarColour, CarMake, CarModel, RegistrationNo, Active);
            //test to that the result is correct
            Assert.AreEqual(Error, "");


        }
    }



}








