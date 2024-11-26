using System;
using Telerik.Web.UI;

namespace WebApplication2
{
    public partial class vacaciones : System.Web.UI.Page
    {
        ClassSesion ssSesiones = new ClassSesion();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void RadGrid1_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            string g = ssSesiones.VerExpediente;
            SubSonicDB.ViewVacacionesRhCollection ssVacaciones = new SubSonicDB.ViewVacacionesRhCollection()
                .Where(SubSonicDB.ViewVacacionesRh.Columns.IDUser,ssSesiones.VerExpediente)
                .Load();
            RadGrid2.DataSource = ssVacaciones;
        }
        protected void RadGrid2_ItemCommand(object sender, GridCommandEventArgs e)
        {
            if (e.CommandName.ToString() != "Page")
            {
                if (e.CommandName.ToString() != "ChangePageSize")
                {
                    string g = e.CommandArgument.ToString();
                    string[] words = g.Split(' ');

                    string _open = "WebForm4.aspx";
                    ssSesiones.to = words[0];
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