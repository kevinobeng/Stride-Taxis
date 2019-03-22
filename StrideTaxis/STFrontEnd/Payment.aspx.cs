using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace STFrontEnd
{
    public partial class Payment : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //If this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //Update the list box
                DisplayPayments();
            }

        }

        void DisplayPayments()
        {
            //Create an instance of the payment collection class
            STMainClassLibrary.clsSTPaymentCollection Payments = new STMainClassLibrary.clsSTPaymentCollection();
            //Set the data source to the list of counties in the collection
            ListBoxStoredPayments.DataSource = Payments.PaymentList;
            //Set the name of primary key
            ListBoxStoredPayments.DataValueField = "PaymentID";
            //Set the data field to display
            ListBoxStoredPayments.DataTextField = "CardHolderName";
            //Bind the data to the list
            ListBoxStoredPayments.DataBind();
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            //Store -1 into the session object to indicate this is a new payment record
            Session["PaymentID"] = -1;
            //Redirect to the payment add page
            Response.Redirect("PaymentAddPage.aspx");
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            //Var to store the primary key of the payment record being deleted
            Int32 PaymentID;
            //If a record has been selected from the list
            if (ListBoxStoredPayments.SelectedIndex != -1)
            {
                //Get the primary key value of the record to delete
                PaymentID = Convert.ToInt32(ListBoxStoredPayments.SelectedValue);
                //Store the data in the session object
                Session["PaymentID"] = PaymentID;
                //Redirect to the delete page
                Response.Redirect("DeletePayment.aspx");
            }
            else //If no record has been selected+
            {
                //Display an error
                LabelError.Text = "Please select a record to delete from the list";
            }
        }

        protected void ButtonEdit_Click(object sender, EventArgs e)
        {
            //Var to store the primary key of the payment record being deleted
            Int32 PaymentID;
            //If a record has been selected from the list
            if (ListBoxStoredPayments.SelectedIndex != -1)
            {
                //Get the primary key value of the record to delete
                PaymentID = Convert.ToInt32(ListBoxStoredPayments.SelectedValue);
                //Store the data in the session object
                Session["PaymentID"] = PaymentID;
                //Redirect to the delete page
                Response.Redirect("PaymentAddPage.aspx");
            }
            else //If no record has been selected+
            {
                //Display an error
                LabelError.Text = "Please select a record to update from the list";
            }
        }
    }
}