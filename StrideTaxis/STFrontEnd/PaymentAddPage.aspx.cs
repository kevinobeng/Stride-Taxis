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
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void ButtonOK_Click(object sender, EventArgs e)
        {
            //Add the new record
            Add();
            //All done so redirect back the payment.aspx
            Response.Redirect("Payment.aspx");
        }
    }
}