using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace WebApplication2
{
    public partial class Pases : System.Web.UI.Page
    {
        ClassSesion ssSesiones = new ClassSesion();
        protected void Page_Load(object sender, EventArgs e)
        {
            RadWindow1.VisibleOnPageLoad = false;
            RadWindow1.Visible = false;
            if (!IsPostBack) 
            {
                RadComboBoxJUSTIFI.Visible = false;
                RadDatePicker1.SelectedDate = DateTime.Now;
                RadTimePicker1.SelectedDate = DateTime.Now;
                RadTimePicker2.SelectedDate = DateTime.Now;
                Label8.Visible = false;

                FillTipos();
                FillJustificar();

                RadComboBoxtIPO.SelectedValue = "2";
            }
        }
        public void FillJustificar()
        {
            SubSonicDB.CatRHJustificarCollection ssJustificantes = new SubSonicDB.CatRHJustificarCollection()
                .Load();

            foreach (SubSonicDB.CatRHJustificar ssJustificar in ssJustificantes)
            {
                RadComboBoxItem add = new RadComboBoxItem(ssJustificar.Descripcion, ssJustificar.Id.ToString());
             RadComboBoxJUSTIFI.Items.Add(add);
            }
        }
        public void FillTipos()
        {
            SubSonicDB.CatRHTipoInsidenciumCollection ssTipos = new SubSonicDB.CatRHTipoInsidenciumCollection()
                .Where(SubSonicDB.CatRHTipoInsidencium.Columns.Status, true)
                .Load();
            foreach (SubSonicDB.CatRHTipoInsidencium ssTipo in ssTipos)
            {
                RadComboBoxItem add = new RadComboBoxItem(ssTipo.Descripcion,ssTipo.Id.ToString());
                RadComboBoxtIPO.Items.Add(add);
            }
           
        }
        protected void RadGrid1_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            SubSonicDB.ViewRHJustificanteCollection ssJustificantes = new SubSonicDB.ViewRHJustificanteCollection()
                .Where(SubSonicDB.ViewRHJustificante.Columns.Expr1,ssSesiones.VerExpediente)
                .Where(SubSonicDB.ViewRHJustificante.Columns.Status,true)
                .OrderByDesc(SubSonicDB.ViewRHJustificante.Columns.Id)
                //.Where(SubSonicDB.ViewRHJustificante.Columns.Idtipoinsid,2)
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
                    string[] words = g.Split(',');

                    if (g.Contains("?"))
                    {
                        //ENTRA PARA ELIMINAR 
                        SubSonicDB.TranInsidenciasRH ssEditar = SubSonicDB.TranInsidenciasRH.FetchByID(g.Replace('?', ' '));

                        if (ssEditar.Autorizado!=true ) {

                            ssEditar.Status = false;
                            ssEditar.Save();
                        }
                        else
                        {

                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('No es permitido eliminar un registro autorizado. ');</script>", false);


                        }
                        RadGrid2.Rebind();
                    }
                    else
                    {
                        if (words[1]=="2") {
                            string _open = "WebForm3.aspx";
                            ssSesiones.to = words[0];

                            RadWindow1.NavigateUrl = "~/WebForm3.aspx";
                            RadWindow1.VisibleOnPageLoad = true;
                            RadWindow1.Visible = true;
                            RadWindow1.VisibleStatusbar = false;
                            RadWindow1.Title = "Expediente: ";
                            RadWindow1.Width = 1400;
                            RadWindow1.Height = 900;

                          //  Response.Write("<script> window.open('" + _open + "','_blank'); </script>");
                        }
                        if (words[1]=="1")
                        {
                            string _open = "WebForm2.aspx";
                            ssSesiones.to = words[0];
                            RadWindow1.NavigateUrl = "~/WebForm2.aspx";
                            RadWindow1.VisibleOnPageLoad = true;
                            RadWindow1.Visible = true;
                            RadWindow1.VisibleStatusbar = false;
                            RadWindow1.Title = "Expediente";
                            RadWindow1.Width = 1400;
                            RadWindow1.Height = 900;


                          //  Response.Write("<script> window.open('" + _open + "','_blank'); </script>");
                        }
                    }
                    // Response.Redirect("~/WebForm2.aspx");
                    //ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(), _open, true);
                    ////SubSonicDB.RelCatArchivoDigitalRH ssQuitar = SubSonicDB.RelCatArchivoDigitalRH.FetchByID(words[0]);
                    //ssQuitar.Status = false;
                    //ssQuitar.Save();
                    //RadGrid2.Rebind();
                }
            }
        }
        protected void RadButton1_Click(object sender, EventArgs e)
        {
            SubSonicDB.TranInsidenciasRH ssNew = new SubSonicDB.TranInsidenciasRH();
            ssNew.IDUser =Convert.ToInt32( ssSesiones.VerExpediente);
            ssNew.Fecha = RadDatePicker1.SelectedDate;
            ssNew.Salida = RadTimePicker1.SelectedTime.ToString();
            ssNew.Entrada = RadTimePicker2.SelectedTime.ToString();
            ssNew.Asunto = TextBoxAsunto.Text;
            //ssNew.IDJustificar = null;
            ssNew.Status = true;
            ssNew.IDJustificar = Convert.ToInt32(RadComboBoxJUSTIFI.SelectedValue);
            ssNew.Idtipoinsid =Convert.ToInt32(RadComboBoxtIPO.SelectedValue);
            ssNew.Save();
            RadGrid2.Rebind();
            TextBoxAsunto.Text = "";
        }
        protected void RadComboBoxtIPO_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {

            if (RadComboBoxtIPO.SelectedValue=="2") {

                //PASE DE SALIDA
                Label8.Visible = false;
                RadComboBoxJUSTIFI.Visible = true;
                RadTimePicker1.Visible = true;
                RadTimePicker2.Visible = true;
                lBL1.Visible = true;
                Label1.Visible = true;

                RadComboBoxJUSTIFI.Visible = false;
            }

            if (RadComboBoxtIPO.SelectedValue == "1")
            {
                //JUSTIFICANTE
                Label8.Visible = true;
                RadComboBoxJUSTIFI.Visible = true;
                RadTimePicker1.Visible = false;
                RadTimePicker2.Visible = false;
                lBL1.Visible = false;
                Label1.Visible = false;


            }

        }
    }
}