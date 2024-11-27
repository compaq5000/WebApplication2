using System;

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