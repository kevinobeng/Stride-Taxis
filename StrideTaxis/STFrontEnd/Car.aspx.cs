using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace STFrontEnd
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into session object to indicate this is a new reocrd
            Session["CarID"] = -1;
            //redirect to the data entry page
            Response.Redirect("AnCar.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 CarID;
            //if a record has been seleted from the lit
            if (lstCar.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                CarID = Convert.ToInt32(lstCar.SelectedValue);
                //store the data in the session object
                Session["CarID"] = CarID;
                //redirect to the delete page
                Response.Redirect("Delete.aspx");
            }
            else //if no record has been selected 
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";


            }
        }

        protected void lstCar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 CarID;
            //if a record has been selected from the list
            if (lstCar.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                CarID = Convert.ToInt32(lstCar.SelectedValue);
                //store the data in the session object 
                Session["CarID"] = CarID;
                //redirect to the edit page
                Response.Redirect("AnCar.aspx");
            }
            else
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }

        }

        protected void btnAdd_Click1(object sender, EventArgs e)
        {

        }
    }
}
