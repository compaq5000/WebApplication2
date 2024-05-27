using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace WebApplication2
{
    public partial class justificantes : System.Web.UI.Page
    {
        ClassSesion ssSesiones = new ClassSesion();
        protected void Page_Load(object sender, EventArgs e)
        {
            RadDatePicker1.SelectedDate = DateTime.Now;
        }

        protected void RadGrid1_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            SubSonicDB.ViewRHJustificanteCollection ssJustificantes = new SubSonicDB.ViewRHJustificanteCollection()
                .Load();
            RadGrid2.DataSource = ssJustificantes;

        }
        protected void RadGrid2_ItemCommand(object sender, GridCommandEventArgs e)
        {
            if (e.CommandName.ToString() != "Page")
            {
                if (e.CommandName.ToString() != "ChangePageSize")
                {
                    string g = e.CommandArgument.ToString();
                    string[] words = g.Split(' ');

                    string _open = "WebForm2.aspx";
                    ssSesiones.VerExpediente = words[0];
                    Response.Write("<script> window.open('" + _open + "','_blank'); </script>");

                    // Response.Redirect("~/WebForm2.aspx");




                    //ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(), _open, true);

                    ////SubSonicDB.RelCatArchivoDigitalRH ssQuitar = SubSonicDB.RelCatArchivoDigitalRH.FetchByID(words[0]);
                    //ssQuitar.Status = false;
                    //ssQuitar.Save();
                    //RadGrid2.Rebind();
                }
            }

        }
    }
}