﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace STFrontEnd
{
    public partial class StrideTaxis : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDestination_Click(object sender, EventArgs e)
        {
            //Redirect to DestinationPage
            Response.Redirect("DestinationPage.aspx");
        }

        protected void btnBook_Click(object sender, EventArgs e)
        {

        }
        protected void btnHome_Click(object sender, EventArgs e)
        {
        
        }
        protected void btnPayment_Click(object sender, EventArgs e)
        {
            //Redirect to payment.aspx
            Response.Redirect("Payment.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //Redirect to payment.aspx
            Response.Redirect("Default.aspx");
        }
    }
}