using System;

namespace WebApplication2
{
    public partial class LogOff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
            Session.Abandon();
            Session.Clear();
        }
    }
}