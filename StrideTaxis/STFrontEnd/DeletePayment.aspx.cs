using System;
using System.Collections.Generic;
using System.Linq;
//using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using STMainClassLibrary;
namespace STFrontEnd
{
    public partial class DeletePayment : System.Web.UI.Page
    {
        //Var to store the primary key value of the record to be deleted
        Int32 PaymentID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the number of the payment record to be deleted from the session object
            PaymentID = Convert.ToInt32(Session["PaymentID"]);
        }

        void DeletePayments()
        {
            //Create a new instance of the payment book
            clsSTPaymentCollection PaymentBook = new clsSTPaymentCollection();
            //Find the record to delete
            PaymentBook.ThisPayment.Find(PaymentID);
            //Delete the record
            PaymentBook.Delete();

        }

        //Event handler for the yes button
        protected void ButtonYes_Click(object sender, EventArgs e)
        {
            //Delete the record
            DeletePayments();
            //Redirect back to the main page
            Response.Redirect("Payment.aspx");

        }

        protected void ButtonNo_Click(object sender, EventArgs e)
        {
            //Redirect to to the payment.aspx
            Response.Redirect("Payment.aspx");
        }
    }
}