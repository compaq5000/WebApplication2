﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        ClassSesion ID = new ClassSesion();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ReportViewer1.ReportSource.Parameters.Add("IDS", ID.to);
        }
    }
}