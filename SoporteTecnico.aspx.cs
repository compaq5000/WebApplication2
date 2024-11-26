using System;
using System.Collections.Generic;
using System.Web.UI;
using Telerik.Web.UI;

namespace WebApplication2
{
    public partial class SoporteTecnico : System.Web.UI.Page
    {
        ClassSesion ssSesiones = new ClassSesion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillServicios();
            }
        }
        public void FillServicios()
        {
            SubSonicDB.SoporteCatServicioCollection ssServicios = new SubSonicDB.SoporteCatServicioCollection()
                .Where(SubSonicDB.SoporteCatServicio.Columns.Status, true)
                .Load();
            foreach(SubSonicDB.SoporteCatServicio ssServicio in ssServicios)
            {
                Telerik.Web.UI.RadComboBoxItem add = new Telerik.Web.UI.RadComboBoxItem(ssServicio.Descripcion, ssServicio.Id.ToString());
                RadComboBoxServicio.Items.Add(add);
            }

        }
        protected void RadToolBar1_ButtonClick(object sender, RadToolBarEventArgs e)
        {
            //RadWindow1.VisibleOnPageLoad = false;
            //RadWindow1.Visible = false;
            List<int> list = new List<int>();
            //copy****************************************************************/
            if (e.Item.Value == "principal")
            {
                Response.Redirect("~/Final.aspx");
            }
            if (e.Item.Value == "newuser")
            {
                //RadWindow1.NavigateUrl = "~/NewUser.aspx";
                //RadWindow1.VisibleOnPageLoad = true;
                //RadWindow1.Visible = true;
                //// RadWindow1.VisibleStatusbar = false;
                //RadWindow1.Title = "Nuevo Usuario";
                //RadWindow1.Width = 720;
                //RadWindow1.Height = 320;
                //// RadGrid1.Rebind();

            }
            ////////////////////////////////////FIN DEL COPY//////////////////////////////////////////
            //**********************************empieza si es cortar*****************************************************/////////////////////

            if (e.Item.Value == "Users")
            {
                Response.Redirect("~/Default2.aspx");
            }
            if (e.Item.Value == "exit")
            {
                Session.Abandon();
                Session.Clear();
                Response.Redirect("~/Login.aspx");
            }
        }
        protected void RadGrid1_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            SubSonicDB.ViewSoporteTecnicoCollection ssSoportes = new SubSonicDB.ViewSoporteTecnicoCollection()
             .Where(SubSonicDB.ViewSoporteTecnico.Columns.IDUser, ssSesiones.IDUsua)
             .OrderByDesc(SubSonicDB.ViewSoporteTecnico.Columns.Status)
             .OrderByDesc(SubSonicDB.ViewSoporteTecnico.Columns.Id)
             .Load();
            RadGrid2.DataSource = ssSoportes;
        }
        protected void RadGrid3_ItemCommandCorrespondencia(object sender, GridCommandEventArgs e)
        {
            if (e.CommandName.ToString() != "Page")
            {
                if (e.CommandName.ToString() != "ChangePageSize")
                {
                    string g = e.CommandArgument.ToString();
                    string[] words = g.Split(',');
                    if (g.Contains("?"))
                    {
                        //ENTRA PARA ELIMINAR 
                        SubSonicDB.TranInsidenciasRH ssEditar = SubSonicDB.TranInsidenciasRH.FetchByID(g.Replace('?', ' '));
                    }
                    else
                    {
                        SubSonicDB.TranInsidenciasRH ssMostrar = SubSonicDB.TranInsidenciasRH.FetchByID(Convert.ToInt32( words[0]));
                        if (ssMostrar.Autorizado == true)
                        {
                                string _open = "WebForm3.aspx";
                                ssSesiones.to = words[0];
                                RadWindow1.NavigateUrl = "~/WebForm3.aspx";
                                RadWindow1.VisibleOnPageLoad = true;
                                RadWindow1.Visible = true;
                                RadWindow1.VisibleStatusbar = false;
                                RadWindow1.Title = "Expediente: ";
                                RadWindow1.Width = 1400;
                                RadWindow1.Height = 900;
                        }
                        else
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Aún no ha sido autorizado. ');</script>", false);
                        }
                    }
                }
            }
        }
        protected void RadGrid1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var g = e;
        }
        protected void RadButton1_Click(object sender, EventArgs e)
        {
            SubSonicDB.SoporteTranServicio ssNewSolicitud = new SubSonicDB.SoporteTranServicio();
            ssNewSolicitud.Descripcion = TextBoxDescripcion.Text;
            ssNewSolicitud.IDUser =Convert.ToInt32(ssSesiones.IDUsua);
            ssNewSolicitud.FechaAlta = DateTime.Now;
            ssNewSolicitud.Status = true;
            ssNewSolicitud.IDSoporte =Convert.ToInt32(RadComboBoxServicio.SelectedValue);
            ssNewSolicitud.Save();
            RadGrid2.Rebind();
        }
    }
}