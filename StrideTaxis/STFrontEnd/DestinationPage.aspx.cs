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
        
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be delete 
            Int32 DestinationID;
            //if a record has been selected from the list
            if(lstDestinations.SelectedIndex != -1)
            {
                //get the primary key value of the record to be delete
                DestinationID = Convert.ToInt32(lstDestinations.SelectedValue);
                //store the data in the session object
                Session["DestinationID"] = DestinationID;
                Response.Redirect("DestinationDeletePage.aspx");
            }
            else //if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited 
            Int32 DestinationID;
            //if a record has been selected from the list
            if (lstDestinations.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit 
                DestinationID = Convert.ToInt32(lstDestinations.SelectedValue);
                //store the data in the session object
                Session["DestinationID"] = DestinationID;
                //redirect to the edit page
                Response.Redirect("AddDestination.aspx");
            }
            else //if no record has been selected
            {
                //display an error
                lblError.Text = "Please a record to edit from the list";
            }
        }
    }
}