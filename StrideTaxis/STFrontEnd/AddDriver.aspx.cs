using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace STFrontEnd
{
    public partial class AddDriver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //add button
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to the indicate this is a new record
            Session["LicenseNo"] = -1;
            //redirect work to the data entry page 
            Response.Redirect("Default.aspx");
        }
     
        }
    }
    
