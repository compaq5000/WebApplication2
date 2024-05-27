using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    
    public partial class WebForm4 : System.Web.UI.Page
    {
        ClassSesion ID = new ClassSesion();
        protected void Page_Load(object sender, EventArgs e)
        {

            

            this.ReportViewer2.ReportSource.Parameters.Add("ID", ID.to);
            this.ReportViewer2.ReportSource.Parameters.Add("dia", DateTime.Now.Day);
            this.ReportViewer2.ReportSource.Parameters.Add("mes", DateTime.Now.Month);
            this.ReportViewer2.ReportSource.Parameters.Add("ano", DateTime.Now.Year);

        }
    }
}