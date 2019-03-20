using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using STMainClassLibrary;

namespace STFrontEnd
{
    public partial class DestinationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnDisplayDestination_Click(object sender, EventArgs e)
        {
            //call the display Destination function
            lblError.Text = DisplaysDestination() + " found";
        }
        Int32 DisplaysDestination()
        {
            //create an instance of the Destination collection
            clsDestinationCollection Destinations = new clsDestinationCollection();
            //find all destination
            Destinations.FindAllDestinations();
            //set the data source to the list of the destinations in the collection
            lstDestinations.DataSource = Destinations.DestinationList;
            //set the test to be displayed
            lstDestinations.DataTextField = "EndPointTown";
            //set the primary key
            lstDestinations.DataValueField = "DestinationID";
            //return the count of records in the list
            lstDestinations.DataBind();
            //bind the data to the list
            return Destinations.DestinationList.Count;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["DestinationID"] = -1;
            //redirect to the data entry page
            Response.Redirect("AddDestination.aspx");
        }
    }
}