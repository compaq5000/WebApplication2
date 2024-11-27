using System;

namespace WebApplication2
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        ClassSesion ID = new ClassSesion();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ReportViewer2.ReportSource.Parameters.Add("to", ID.to);
            this.ReportViewer2.ReportSource.Parameters.Add("from", ID.from);
            this.ReportViewer2.ReportSource.Parameters.Add("total", ID.Total);

        }
    }
}