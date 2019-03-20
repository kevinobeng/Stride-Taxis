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
        protected void Page_Load(object sender, EventArgs e)
        {

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
                DestinationBook.ThisDestination.EndPointHouseNo = Convert.ToInt32(txtHouseNo.Text);
                DestinationBook.ThisDestination.EndPointPostCode = txtPostCode.Text;
                DestinationBook.ThisDestination.EndPointStreet = txtStreet.Text;
                DestinationBook.ThisDestination.EndPointTown = txtTown.Text;
                DestinationBook.ThisDestination.PickupTime = Convert.ToDateTime(txtPickUp.Text);
                //add the record
                DestinationBook.Add();
            }
            else
            {
                //report an error
                lblError.Text = "There is issue with information entered " + Error;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //added the new record
            Add();
            //redirect back to the destination page
            Response.Redirect("DestinationPage.aspx");
        }
    }
}