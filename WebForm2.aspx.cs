using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        ClassSesion ID = new ClassSesion();
        protected void Page_Load(object sender, EventArgs e)
        {
            //SubSonicDB.CatUsuarioCollection sss = new SubSonicDB.CatUsuarioCollection().Load();
            //SubSonicDB.CatTomoCollection ssTomo = new SubSonicDB.CatTomoCollection().Load();            
            this.ReportViewer1.ReportSource.Parameters.Add("IDS", ID.to);


        }
    }
}