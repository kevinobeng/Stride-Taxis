using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using STMainClassLibrary;

namespace STFrontEnd
{
    public partial class DeleteDestination : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted 
        Int32 DestinationID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the address to be deleted from the session object
            DestinationID = Convert.ToInt32(Session["DestinationID"]);
        }
        void DeleteDestination()
        {
            //function to delete the select record
            //create a new instance of the Destination book
            clsDestinationCollection DestinationBook = new clsDestinationCollection();
            //find the record to delete
            DestinationBook.ThisDestination.Find(DestinationID);
            //Delete the record
            DestinationBook.Delete();
        }
        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteDestination();
            //redirect back to the main page

        }
    }
}