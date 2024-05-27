using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace WebApplication2
{
    public partial class RH : System.Web.UI.Page
    {
        ClassSesion ssSesiones = new ClassSesion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                //  FillUser();



                FillImagen("2");

                //RadComboBoxUsuarios.SelectedValue = ssSesiones.IDUsua;

            }
        }
        protected void onClientButtonClicking(object sender, Telerik.Web.UI.RadToolBarEventArgs e)
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
            
                RadWindow1.NavigateUrl = "~/NewUser.aspx";
                RadWindow1.VisibleOnPageLoad = true;
                RadWindow1.Visible = true;
                // RadWindow1.VisibleStatusbar = false;
                RadWindow1.Title = "Nuevo Usuario";
                RadWindow1.Width = 720;
                RadWindow1.Height = 320;
                // RadGrid1.Rebind();


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
        protected void RadGrid1_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            RadWindow1.VisibleOnPageLoad = false;
            RadWindow1.Visible = false;




        }
        //public void FillUser()
        //{
        //    RadComboBoxUsuarios.Items.Clear();
        //    if (ssSesiones.IDUsua == "1")
        //    {
        //        SubSonicDB.CatUsuarioCollection ssUsuarios = new SubSonicDB.CatUsuarioCollection()
        //            .Where(SubSonicDB.CatUsuario.Columns.Status, true)

        //            .Load();
        //        foreach (SubSonicDB.CatUsuario ssUser in ssUsuarios)
        //        {
        //            Telerik.Web.UI.RadComboBoxItem add = new Telerik.Web.UI.RadComboBoxItem(ssUser.Nombre, ssUser.Id.ToString());
        //            RadComboBoxUsuarios.Items.Add(add);

        //        }
        //    }
        //    else
        //    {
        //        SubSonicDB.CatUsuarioCollection ssUsuarios = new SubSonicDB.CatUsuarioCollection()
        //            .Where(SubSonicDB.CatUsuario.Columns.Status, true)
        //            .Where(SubSonicDB.CatUsuario.Columns.Id, ssSesiones.IDUsua)
        //            .Load();
        //        foreach (SubSonicDB.CatUsuario ssUser in ssUsuarios)
        //        {
        //            Telerik.Web.UI.RadComboBoxItem add = new Telerik.Web.UI.RadComboBoxItem(ssUser.Nombre, ssUser.Id.ToString());
        //            RadComboBoxUsuarios.Items.Add(add);

        //        }



        //    }

        //}

        //protected void RadComboBoxUsuarios_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
        //{
        //    //RadGrid1.Rebind();
        //    FillImagen(RadComboBoxUsuarios.SelectedValue);
        //}
        public void FillImagen(string Valuer)
        {
            try
            {

                if (!IsPostBack)
                {
                    SubSonicDB.CatUsuario ssUsuario = SubSonicDB.CatUsuario.FetchByID(ssSesiones.VerExpediente);
                    ImageButtonImg.ImageUrl = "~/img/Users/" + ssUsuario.Imagen + ssSesiones.ExtensionUsua;
                    Generales(ssSesiones.VerExpediente);
                    ImageButtonstatus.ImageUrl = "~/img/stados/" + ssUsuario.Status + ".png";
                }
                else
                {

                    SubSonicDB.CatUsuario ssUsuario = SubSonicDB.CatUsuario.FetchByID(ssSesiones.VerExpediente);
                    ImageButtonImg.ImageUrl = "~/img/Users/" + ssUsuario.Imagen + ssUsuario.Extension;
                    Generales(ssSesiones.VerExpediente);
                    ImageButtonstatus.ImageUrl = "~/img/stados/" + ssUsuario.Status + ".png";
                }


            }
            catch { }
        }
        public void Generales(string Valor)
        {
            SubSonicDB.CatUsuario ssUsuario = SubSonicDB.CatUsuario.FetchByID(Valor);
            LabelName.Text = ssUsuario.Nom;
            LabelPaterno.Text = ssUsuario.Paterno;
            LabelMaterno.Text = ssUsuario.Materno;
            LabelNOEMPLEADO.Text = ssUsuario.Noempleado;

            SubSonicDB.RelCatCategoriaRhCollection ssCategoria = new SubSonicDB.RelCatCategoriaRhCollection()
                .Where(SubSonicDB.RelCatCategoriaRh.Columns.IDUsuario, Valor)
                .Where(SubSonicDB.RelCatCategoriaRh.Columns.Status, true)
                .Load();
            LabelCATEGORIA.Text = ssCategoria[0].CatCategoriaRh.Descripcion;

            SubSonicDB.RelCatCategoriaRhCollection ssCatTipoPlaza = new SubSonicDB.RelCatCategoriaRhCollection()
                .Where(SubSonicDB.RelCatTipoplazaRh.Columns.IDUsuario, Valor)
                .Where(SubSonicDB.RelCatTipoplazaRh.Columns.Status, true)
                .Load();

            LabelTIPOPLAZA.Text = ssCatTipoPlaza[0].CatCategoriaRh.Descripcion;
            LabelSUELDO.Text = ssUsuario.Sueldo.ToString();
            LabelFECHAINGRESO.Text = Convert.ToDateTime(ssUsuario.FechaIngreso).ToShortDateString();
            LabelRFC.Text = ssUsuario.Rfc;

            //*********************************************DOMICILIO************************************************/
            LabelCalle.Text = ssUsuario.Calle;
            LabelNumero.Text = ssUsuario.NoCalle;
            LabelColonia.Text = ssUsuario.Colonila;

            /************************************************ADSCRIPCION***********************************************/
            SubSonicDB.RelCatAdscripcionCollection ssAdscripcion = new SubSonicDB.RelCatAdscripcionCollection()
                .Where(SubSonicDB.RelCatAdscripcion.Columns.IDUsuario, Valor)
                .Where(SubSonicDB.RelCatAdscripcion.Columns.Status, true)
                .Load();

            LabelaDSCRIPCION.Text = ssAdscripcion[0].CatAdscripcionRh.Descripcion;
            LabelTelCasa.Text = ssUsuario.TelCasa;
            LabelTelCelular.Text = ssUsuario.Celular;
            LabelNoContacto.Text = ssUsuario.NombreContacto;
            LabelTelContacto.Text = ssUsuario.TelContacto;
            /************************************************JEFE DIRECTO***********************************************/
            SubSonicDB.CatJefeAdscripcionRHCollection ssJefe = new SubSonicDB.CatJefeAdscripcionRHCollection()
                .Where(SubSonicDB.CatJefeAdscripcionRH.Columns.IDAdscripcion, ssAdscripcion[0].IDAdscripcion)
                .Where(SubSonicDB.CatJefeAdscripcionRH.Columns.Status,true)
                .Load();

            LabelJefe.Text = ssJefe[0].Descripcion;


        }
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {


            RadWindow1.VisibleOnPageLoad = true;
            RadWindow1.Visible = true;
            RadWindow1.NavigateUrl = "~/NewFoto.aspx?ID=" + ssSesiones.IDUsua;
            RadWindow1.VisibleStatusbar = false;



        }
        protected void RadComboBox1_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
        {
            //RadGrid1.Rebind();


        }
        protected void ImageButton2_Click1(object sender, ImageClickEventArgs e)
        {
            FillImagen(null);


            RadWindow1.Visible = false;
            RadWindow1.VisibleOnPageLoad = false;
        }
    }
}