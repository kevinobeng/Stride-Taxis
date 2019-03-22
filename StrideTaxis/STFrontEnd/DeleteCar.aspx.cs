using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using STFrontEnd;

namespace STFrontEnd
{
    public partial class Delete : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 CarID;

        //event handler for the load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the car to be deleted from the session object 
            CarID = Convert.ToInt32(Session["CarID"]);
        }



    }
    
    
    

        
    }


