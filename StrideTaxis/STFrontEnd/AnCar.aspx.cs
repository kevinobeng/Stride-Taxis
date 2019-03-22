using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using STFrontEnd;

namespace STFrontEnd
{
    public partial class AnCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }


        protected void btnOK_Click(object sender, EventArgs e)
        {
            //add the new record
            Add();
            //all done so redirect back to the main page
            Response.Redirect("Default.aspx");

        }
        void DisplayCars()
        {



        }
        private void Add()
        {
            return;
        }
        void Update()
        {
            
        }
    }

}    
  

