﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using STMainClassLibrary;

namespace STFrontEnd
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsDataConnection myDB2 = new clsDataConnection();
        }

        protected void btnDestination_Click(object sender, EventArgs e)
        {

        }
    }
}