using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using STMainClassLibrary;

namespace STFrontEnd
{
    public partial class PaymentAddPage : System.Web.UI.Page
    {
        Int32 PaymentID;
        protected void Page_Load(object sender, EventArgs e)
        {
            PaymentID = Convert.ToInt32(Session["PaymentID"]);
            if (IsPostBack == false)
            {
                ////Populate the list of selected payments
                //DisplaySelectedPayments();
                            
                if (PaymentID != -1)
                {
                    //Display the current data for the payment record wanting to be updated
                    DisplaySelectedPayments();

                }

            }
        }

        void DisplaySelectedPayments()
        {
            //Create an instance of the payment book
            clsSTPaymentCollection PaymentBook = new clsSTPaymentCollection();
            //Find the record to update
            PaymentBook.ThisPayment.Find(PaymentID);
            //Display the data for the record wanting to be updated
            TextBoxCardNumber.Text = PaymentBook.ThisPayment.CardNumber;
            TextBoxAccountNumber.Text = PaymentBook.ThisPayment.AccountNumber;
            TextBoxSortCode.Text = PaymentBook.ThisPayment.SortCode;
            TextBoxExpiryDate.Text = PaymentBook.ThisPayment.ExpiryDate;
            TextBoxValidFrom.Text = PaymentBook.ThisPayment.ValidFrom;
            TextBoxCardHolderName.Text = PaymentBook.ThisPayment.CardHolderName;
            TextBoxCVC.Text = PaymentBook.ThisPayment.CVC;
        }

        void Add()
        {
            //Create an instance of the payment book
            clsSTPaymentCollection PaymentBook = new clsSTPaymentCollection();
            //Validate the data on the web form
            string Error = PaymentBook.ThisPayment.Valid(TextBoxCardNumber.Text, TextBoxAccountNumber.Text, TextBoxSortCode.Text, TextBoxExpiryDate.Text, TextBoxValidFrom.Text, TextBoxCardHolderName.Text, TextBoxCVC.Text);
            //If the data is ok then add it to the object
            if (Error == "")
            {
                //Get the data entered by the user
                PaymentBook.ThisPayment.CardNumber = TextBoxCardNumber.Text;
                PaymentBook.ThisPayment.AccountNumber = TextBoxAccountNumber.Text;
                PaymentBook.ThisPayment.SortCode = TextBoxSortCode.Text;
                PaymentBook.ThisPayment.ExpiryDate = TextBoxExpiryDate.Text;
                PaymentBook.ThisPayment.ValidFrom = TextBoxValidFrom.Text;
                PaymentBook.ThisPayment.CardHolderName = TextBoxCardHolderName.Text;
                PaymentBook.ThisPayment.CVC = TextBoxCVC.Text;
                //Add the payment record
                PaymentBook.Add();
                //All done so redirect to the home payment page
                Response.Redirect("Payment.aspx");

            }
            else
            {
                //Report an error
                LableError.Text = "There was a problem with the payment method you tried adding" + Error;
            }
        }

        void Update()
        {
            //Create an instance of the payment book
            clsSTPaymentCollection PaymentBook = new clsSTPaymentCollection();
            //Validate the data on the web form
            string Error = PaymentBook.ThisPayment.Valid(TextBoxCardNumber.Text, TextBoxAccountNumber.Text, TextBoxSortCode.Text, TextBoxExpiryDate.Text, TextBoxValidFrom.Text, TextBoxCardHolderName.Text, TextBoxCVC.Text);
            //If the data is ok then add it to the object
            if (Error == "")
            {
                //Find the payment id record to update
                PaymentBook.ThisPayment.Find(PaymentID);
                //Get the data entered by the user
                PaymentBook.ThisPayment.CardNumber = TextBoxCardNumber.Text;
                PaymentBook.ThisPayment.AccountNumber = TextBoxAccountNumber.Text;
                PaymentBook.ThisPayment.SortCode = TextBoxSortCode.Text;
                PaymentBook.ThisPayment.ExpiryDate = TextBoxExpiryDate.Text;
                PaymentBook.ThisPayment.ValidFrom = TextBoxValidFrom.Text;
                PaymentBook.ThisPayment.CardHolderName = TextBoxCardHolderName.Text;
                PaymentBook.ThisPayment.CVC = TextBoxCVC.Text;
                //Update the payment record
                PaymentBook.Update();
                //All done so redirect to the home payment page
                Response.Redirect("Payment.aspx");

            }
            else
            {
                //Report an error
                LableError.Text = "There was a problem with the payment method you tried updating" + Error;
            }
        }

        protected void ButtonOK_Click(object sender, EventArgs e)
        {
            if (PaymentID == -1)
            {
                //Add the new payment record
                Add();
            }
            else
            {
                //Update the payment record
                Update();
            }
        }
    }
}