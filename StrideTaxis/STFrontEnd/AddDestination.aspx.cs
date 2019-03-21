using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using STMainClassLibrary;

namespace STFrontEnd
{
    public partial class AddDestination : System.Web.UI.Page
    {
        Int32 DestinationID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get number of the destination to be processed
            DestinationID = Convert.ToInt32(Session["DestinationID"]);
            if (IsPostBack == false)
            {
                //Display the current data for the record
                DisplayDestination();
            }
        }

        void Add()
        {
            clsDestinationCollection DestinationBook = new clsDestinationCollection();
            //validate the data on the web form
            String Error = DestinationBook.ThisDestination.Valid(txtHouseNo.Text, txtPostCode.Text, txtStreet.Text, txtTown.Text, txtPickUp.Text);
            //if the datas is OK the add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                DestinationBook.ThisDestination.EndPointHouseNo = txtHouseNo.Text;
                DestinationBook.ThisDestination.EndPointPostCode = txtPostCode.Text;
                DestinationBook.ThisDestination.EndPointStreet = txtStreet.Text;
                DestinationBook.ThisDestination.EndPointTown = txtTown.Text;
                DestinationBook.ThisDestination.PickupTime = Convert.ToDateTime(txtPickUp.Text);
                DestinationBook.ThisDestination.DropoffTime = Convert.ToDateTime(txtPickUp.Text);
                //add the record
                DestinationBook.Add();
            }
            else
            {
                //report an error
                lblError.Text = "There is issue with information entered " + Error;
            }
        }

        void Update()
        {
            clsDestinationCollection DestinationBook = new clsDestinationCollection();
            //validate the data on the web form
            String Error = DestinationBook.ThisDestination.Valid(txtHouseNo.Text, txtPostCode.Text, txtStreet.Text, txtTown.Text, txtPickUp.Text);
            //if the datas is OK the add it to the object
            if (Error == "")
            {
                //find the record to update 
                DestinationBook.ThisDestination.Find(DestinationID);
                //get the data entered by the user
                DestinationBook.ThisDestination.EndPointHouseNo = txtHouseNo.Text;
                DestinationBook.ThisDestination.EndPointPostCode = txtPostCode.Text;
                DestinationBook.ThisDestination.EndPointStreet = txtStreet.Text;
                DestinationBook.ThisDestination.EndPointTown = txtTown.Text;
                DestinationBook.ThisDestination.PickupTime = Convert.ToDateTime(txtPickUp.Text);
                DestinationBook.ThisDestination.DropoffTime = Convert.ToDateTime(txtPickUp.Text);
                //add the record
                DestinationBook.Update();
                Response.Redirect("DestinationPage.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problem with the data enetered " + Error;
            }
        }

        void DisplayDestination()
        {
            clsDestinationCollection DestinationBook = new clsDestinationCollection();
            //find the record to update 
            DestinationBook.ThisDestination.Find(DestinationID);
            //find the record to update
            txtHouseNo.Text = DestinationBook.ThisDestination.EndPointHouseNo;
            txtPostCode.Text = DestinationBook.ThisDestination.EndPointPostCode;
            txtStreet.Text = DestinationBook.ThisDestination.EndPointStreet;
            txtTown.Text = DestinationBook.ThisDestination.EndPointTown;
            txtPickUp.Text = DestinationBook.ThisDestination.PickupTime.ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if(DestinationID == -1)
            {
                //added the new record
                Add();
            }
            
            else
            {
                //update the record 
                Update();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect back to the destination page
            Response.Redirect("DestinationPage.aspx");
        }
    }
}