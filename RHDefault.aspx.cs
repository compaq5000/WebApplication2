using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using Telerik.Web.UI;


namespace WebApplication2
{
    public partial class RHDefault : System.Web.UI.Page
    {
        ClassSesion ssSesiones = new ClassSesion();
        protected void Page_Load(object sender, EventArgs e)
        {
            RadWindow2.VisibleOnPageLoad = false;
            RadWindow2.Visible = false;
            RadWindow1.VisibleOnPageLoad = false;
            RadWindow1.Visible = false;

            if (ssSesiones.IDTipoUser.ToString() == "3")
            {
                RadSlidingPane1.Visible = true;
            }
            if (!IsPostBack)
            {
                FillAdscripcion();
                FillCategorias();
                FillTipoPermisos();
                FillPeriodo();
                RadWindow1.VisibleOnPageLoad = false;
                RadWindow1.Visible = false;
            }
        }
        public void FillPeriodo()
        {
            RadComboBoxPeriodo.Text = "";
            RadComboBoxPeriodo.Items.Clear();
            SubSonicDB.CatPeriodoVAcaionesRhCollection ssPeriodos = new SubSonicDB.CatPeriodoVAcaionesRhCollection().Load();
            foreach (SubSonicDB.CatPeriodoVAcaionesRh ssPeriodo in ssPeriodos)
            {
                Telerik.Web.UI.RadComboBoxItem add = new RadComboBoxItem(ssPeriodo.Descripcion, ssPeriodo.Id.ToString());
                RadComboBoxPeriodo.Items.Add(add);
            }
        }
        public void FillTipoPermisos()
        {
            RadComboBoxTipoPermiso.Items.Clear();
            RadComboBoxTipoPermiso.Text = "";
            SubSonicDB.CatAnoVacacionesRhCollection ssAnos = new SubSonicDB.CatAnoVacacionesRhCollection()
                .Load();
            foreach (SubSonicDB.CatAnoVacacionesRh ssAnoVacaciones in ssAnos)
            {
                Telerik.Web.UI.RadComboBoxItem add = new Telerik.Web.UI.RadComboBoxItem(ssAnoVacaciones.Descripcion, ssAnoVacaciones.Id.ToString());
                RadComboBoxTipoPermiso.Items.Add(add);
            }
        }
        protected void RadAutoCompleteUsuarioas_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {


                SubSonicDB.ViewRHDetalleUsuarioCollection ssss = new SubSonicDB.ViewRHDetalleUsuarioCollection()
                   .Where(SubSonicDB.ViewRHDetalleUsuario.Columns.StatusUser, true)
                .Load();
                RadAutoCompleteBoxUsuarios.DataSource = ssss;
                RadAutoCompleteBoxUsuarios.DataTextField = "Nombre";
                RadAutoCompleteBoxUsuarios.DataValueField = "ID";
                RadAutoCompleteBoxUsuarios.DataBind();
            }

        }
        protected void RadGrid3_ItemCommandCorrespondencia(object sender, GridCommandEventArgs e)
        {

            if (e.CommandName.ToString() != "Page")
            {
                if (e.CommandName.ToString() != "ChangePageSize")
                {
                    string g = e.CommandArgument.ToString();


                    if (g.Contains("-"))
                    {

                        g.Replace("-", "");
                        string[] words = g.Split(' ');

                        try
                        {
                            SubSonicDB.CatUsuario ssUsuarios = SubSonicDB.CatUsuario.FetchByID(words[0]);
                            ssUsuarios.Status = false;
                            ssUsuarios.Save();
                            RadGrid2.Rebind();
                        }
                        catch
                        {

                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('No fue posible dar de baja. ');</script>", false);

                        }
                    }
                    else
                    {
                        string[] words = g.Split(' ');
                        ssSesiones.VerExpediente = words[0];
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>window.open('../rhhome.aspx', '_blank');</script>", false);
                    }
                }
            }
        }
        protected void RadGrid1_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxBusca.Text))
            {

                if (ssSesiones.IDTipoUser.ToString() == "3")
                {

                    SubSonicDB.ViewRHDetalleUsuarioCollection ssUsuarios = new SubSonicDB.ViewRHDetalleUsuarioCollection()
                        .Where(SubSonicDB.ViewRHDetalleUsuario.Columns.Busqueda, SubSonic.Comparison.Like, "%" + TextBoxBusca.Text + "%")
                        .Load();
                    RadGrid2.DataSource = ssUsuarios;
                }
                else if (ssSesiones.IDTipoUser.ToString() == "4")
                {
                    SubSonicDB.ViewRHDetalleUsuarioCollection ssUsuarios = new SubSonicDB.ViewRHDetalleUsuarioCollection()
                            .Where(SubSonicDB.ViewRHDetalleUsuario.Columns.Busqueda, SubSonic.Comparison.Like, "%" + TextBoxBusca.Text + "%")
                            .Where(SubSonicDB.ViewRHDetalleUsuario.Columns.Expr2, ssSesiones.IDAdcripcion)
                            .Load();
                    RadGrid2.DataSource = ssUsuarios;

                }

            }
            else
            {

                if (ssSesiones.IDTipoUser.ToString() == "3")
                {

                    //ENTRA EN CASO DE SER DE RECURSOS HUMANOS

                    SubSonicDB.ViewRHDetalleUsuarioCollection ssUsuarios = new SubSonicDB.ViewRHDetalleUsuarioCollection()
                      .Load();
                    RadGrid2.DataSource = ssUsuarios;
                }
                else if (ssSesiones.IDTipoUser.ToString() == "4")

                {//ENTRA EN CASO DE SER JEFE DE DEPARTAMENTO
                    SubSonicDB.ViewRHDetalleUsuarioCollection ssUsuarios = new SubSonicDB.ViewRHDetalleUsuarioCollection()
                          .Where(SubSonicDB.ViewRHDetalleUsuario.Columns.Expr2, ssSesiones.IDAdcripcion)
                       .Load();
                    RadGrid2.DataSource = ssUsuarios;
                }
            }
            RadWindow1.Visible = false;
            RadWindow2.Visible = false;
        }
        public void FillAdscripcion()
        {
            RadComboBoxADSCRIPCION.Text = "";
            RadComboBoxADSCRIPCION.Items.Clear();
            SubSonicDB.CatAdscripcionRhCollection ssAdscripcion = new SubSonicDB.CatAdscripcionRhCollection()
                .Load();
            foreach (SubSonicDB.CatAdscripcionRh ssadd in ssAdscripcion)
            {
                Telerik.Web.UI.RadComboBoxItem add = new Telerik.Web.UI.RadComboBoxItem(ssadd.Descripcion, ssadd.Id.ToString());
                RadComboBoxADSCRIPCION.Items.Add(add);
            }
        }
        public void FillCategorias()
        {
            RadComboBoxCATEGORIA.Text = "";
            RadComboBoxCATEGORIA.Items.Clear();
            SubSonicDB.CatCategoriaRhCollection ssCategorias = new SubSonicDB.CatCategoriaRhCollection().Load();
            foreach (SubSonicDB.CatCategoriaRh ssCategoria in ssCategorias)
            {
                Telerik.Web.UI.RadComboBoxItem add = new Telerik.Web.UI.RadComboBoxItem(ssCategoria.Descripcion, ssCategoria.Id.ToString());
                RadComboBoxCATEGORIA.Items.Add(add);
            }
        }
        protected void RadButton1_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxBusca.Text = "";
                SubSonicDB.CatUsuario ssNewUser = new SubSonicDB.CatUsuario();
                ssNewUser.Nom = RadTextBoxNOMBRE.Text.ToUpper();
                ssNewUser.Paterno = RadTextBoxPATERNO.Text.ToUpper();
                ssNewUser.Materno = RadTextBoxMATERNO.Text.ToUpper();
                ssNewUser.Noempleado = RadTextBoxNoEmpledo.Text;

                ssNewUser.FechaIngreso = RadDatePickerfECHAiNGRESO.SelectedDate;
                ssNewUser.Sueldo = Convert.ToDecimal(RadNumericTextBoxSueldo.Text);
                ssNewUser.Rfc = RadTextBoxRFC.Text.ToUpper();
                ssNewUser.Correo = RadtextboxCorreo.Text.ToUpper();
                ssNewUser.TelCasa = RadMaskedTextBoxTelCasa.Text;
                ssNewUser.Celular = RadMaskedTextBoxMovil.Text;
                ssNewUser.Calle = RadTextBoxCalle.Text.ToUpper();
                ssNewUser.NoCalle = RadTextBoxNo.Text;
                ssNewUser.Colonila = RadTextBoxColonia.Text.ToUpper();
                ssNewUser.NombreContacto = RadTextBoxNomContacto.Text.ToUpper();
                ssNewUser.TelContacto = RadTextBoxTelContacto.Text;
                ssNewUser.Status = true;
                ssNewUser.Imagen = "144_1";
                ssNewUser.Extension = ".jpg";
                ssNewUser.IDTipoUser = 2;
                ssNewUser.Save();

                SubSonicDB.RelCatCategoriaRh ssNewcategoria = new SubSonicDB.RelCatCategoriaRh();
                ssNewcategoria.IDCategoria = Convert.ToInt32(RadComboBoxCATEGORIA.SelectedValue);
                ssNewcategoria.Status = true;
                ssNewcategoria.IDUsuario = ssNewUser.Id;
                ssNewcategoria.Save();

                SubSonicDB.RelCatAdscripcion ssNewAdscripcion = new SubSonicDB.RelCatAdscripcion();
                ssNewAdscripcion.IDAdscripcion = Convert.ToInt32(RadComboBoxADSCRIPCION.SelectedValue);
                ssNewAdscripcion.IDUsuario = ssNewUser.Id;
                ssNewAdscripcion.Status = true;
                ssNewAdscripcion.Save();


                SubSonicDB.RelFuncionesUsuarioRH ssNewFuncion = new SubSonicDB.RelFuncionesUsuarioRH();
                ssNewFuncion.Descripcion = RadTextBoxFunciones.Text.ToUpper();
                ssNewFuncion.Fecha = DateTime.Now;
                ssNewFuncion.IDCategoria = Convert.ToInt32(RadComboBoxCATEGORIA.SelectedValue);
                ssNewFuncion.IDUsuario = ssNewUser.Id;
                ssNewFuncion.Status = true;
                ssNewFuncion.Save();
                RadGrid2.Rebind();


                //CARGARLE LOS PERMIDOS AL USUARIO EN LA CARPETA DE EXPEDIENTES
                SubSonicDB.Expediente InExpedi = SubSonicDB.Expediente.FetchByID(1);
                SubSonicDB.Expediente InExpeMinutario = SubSonicDB.Expediente.FetchByID("6090");

                string[] words = InExpedi.Usuarios.Split(',');
                string[] wordsMisArchi = InExpeMinutario.Usuarios.Split(',');

                if (words.Contains(ssNewUser.Id.ToString()))
                {

                }
                else
                {
                    InExpedi.Usuarios = InExpedi.Usuarios + "," + ssNewUser.Id;
                    InExpedi.Save();

                    InExpeMinutario.Usuarios = InExpeMinutario.Usuarios + "," + ssNewUser.Id;
                    InExpeMinutario.Save();
                }

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Guardado correctamente. ');</script>", false);


            }
            catch (Exception)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('No fue posible guardar el registro. ');</script>", false);
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            RadGrid2.Rebind();
        }
        protected void ImageButtonBusqueda_Click(object sender, EventArgs e)
        {
            RadGrid2.Rebind();
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
        public static double GetBusinessDays(DateTime startD, DateTime endD)
        {
            double calcBusinessDays =
                1 + ((endD - startD).TotalDays * 5 -
                (startD.DayOfWeek - endD.DayOfWeek) * 2) / 7;

            if (endD.DayOfWeek == DayOfWeek.Saturday) calcBusinessDays--;
            if (startD.DayOfWeek == DayOfWeek.Sunday) calcBusinessDays--;

            return calcBusinessDays;
        }
        protected void RadButton1_ClickVACACIONES(object sender, EventArgs e)
        {

            for (int i = 0; i < RadAutoCompleteBoxUsuarios.Entries.Count; i++)
            {
                try
                {
                    SubSonicDB.RelTipoPermisoRH ssRelTipoPermisoRH = new SubSonicDB.RelTipoPermisoRH();
                    ssRelTipoPermisoRH.IDUser = Convert.ToInt32(RadAutoCompleteBoxUsuarios.Entries[i].Value);
                    //ssRelTipoPermisoRH.IDTipoPermiso =Convert.ToInt32(RadComboBoxTipoPermiso.SelectedValue);
                    ssRelTipoPermisoRH.Status = true;
                    ssRelTipoPermisoRH.FechaCaptura = DateTime.Now;
                    ssRelTipoPermisoRH.IDUserCaptura = Convert.ToInt32(ssSesiones.IDUsua);
                    ssRelTipoPermisoRH.IDano = Convert.ToInt32(RadComboBoxTipoPermiso.SelectedValue);
                    ssRelTipoPermisoRH.IDPeriodo = Convert.ToInt32(RadComboBoxPeriodo.SelectedValue);

                    ssRelTipoPermisoRH.Save();

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('SI SE guardarDO el registro. ');</script>", false);

                }
                catch
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('El elemento ya tomo sus vacaciones correspondientes al periodo seleccionado. ');</script>", false);

                }

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
        protected void RadGrid1Pases_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {

            if (Convert.ToInt32(ssSesiones.IDTipoUser) == 3)
            {
                //muestra el grid para los pases en recursos humanos

                SubSonicDB.ViewRHJustificanteCollection ssJustificantes = new SubSonicDB.ViewRHJustificanteCollection()
                   // .Where(SubSonicDB.ViewRHJustificante.Columns.Expr1, ssSesiones.VerExpediente)
                   .Where(SubSonicDB.ViewRHJustificante.Columns.Status, true)
                   .OrderByDesc(SubSonicDB.ViewRHJustificante.Columns.Status)
                   //.Where(SubSonicDB.ViewRHJustificante.Columns.Idtipoinsid,2)
                   .Load();
                RadGrid1.DataSource = ssJustificantes;
            }
            if (Convert.ToInt32(ssSesiones.IDTipoUser) == 4)
            {
                //en caso de que seas jefe de un departamento
                SubSonicDB.ViewRHJustificanteCollection ssJustificantes = new SubSonicDB.ViewRHJustificanteCollection()
                  .Where(SubSonicDB.ViewRHJustificante.Columns.IDacrip, ssSesiones.IDAdcripcion)
                  .Where(SubSonicDB.ViewRHJustificante.Columns.Status, true)
                  .OrderByDesc(SubSonicDB.ViewRHJustificante.Columns.Id)
                  .Load();
                RadGrid1.DataSource = ssJustificantes;
            }
        }
        protected void RadGrid22_ItemCommand(object sender, GridCommandEventArgs e)
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

                        if (ssEditar.Autorizado != true)

                        {
                            ssEditar.Status = false;
                            ssEditar.Save();

                        }
                        else
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('No es permitido eliminar un registro autorizado. ');</script>", false);
                        }
                        RadGrid1.Rebind();

                    }
                    else
                    {
                        SubSonicDB.TranInsidenciasRH ssMostrar = SubSonicDB.TranInsidenciasRH.FetchByID(words[0]);
                        if (ssMostrar.Autorizado == true)
                        {
                            if (words[1] == "2")
                            {
                                //string _open = "WebForm3.aspx";
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
                            if (words[1] == "1")
                            {
                                // string _open = "WebForm2.aspx";
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
                        else
                        {

                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Aún no ha sido autorizado. ');</script>", false);

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
        protected void RadButton2_Click(object sender, EventArgs e)
        {
            //AUTORIZAR LOS PASES DE SALIDA
            if (RadGrid1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < RadGrid1.SelectedItems.Count; i++)
                {
                    SubSonicDB.TranInsidenciasRH ssAutorizar = SubSonicDB.TranInsidenciasRH.FetchByID(Convert.ToString(RadGrid1.SelectedItems[i].OwnerTableView.DataKeyValues[RadGrid1.SelectedItems[i].ItemIndex]["ID"]));
                    ssAutorizar.Autorizado = true;
                    ssAutorizar.Save();
                    RadGrid1.Rebind();
                }
            }
        }

        //protected void RadButton2_Click(object sender, EventArgs e)
        //{

        //    int Valor = Convert.ToInt32(RadComboBoxHojas.SelectedValue) * 3;
        //    bool pibote = false;
        //    int inicio;
        //    int final;
        //    int recibo=0;

        //    SubSonicDB.ImprimirinsidenciaCollection ssImprimir = new SubSonicDB.ImprimirinsidenciaCollection()
        //             .Where(SubSonicDB.Imprimirinsidencia.Columns.Idadscripcion, RadComboBoxAdscripciones1.SelectedValue)
        //             .Load();
        //    ssSesiones.Total = RadComboBoxAdscripciones1.SelectedValue;

        //    recibo =Convert.ToInt32(ssImprimir[ssImprimir.Count-1].Recibo);

        //    for (int i = 0; i < Valor; i++)
        //    {
        //        SubSonicDB.Imprimirinsidencia ssNewInsi = new SubSonicDB.Imprimirinsidencia();
        //        ssNewInsi.Idadscripcion = Convert.ToInt32(RadComboBoxAdscripciones1.SelectedValue);
        //        ssNewInsi.Status = true;
        //        recibo = recibo + 1;

        //        ssNewInsi.Recibo = recibo;
        //        ssNewInsi.Save();
        //        RadWindow2.NavigateUrl = "~/WEbForm5.aspx";
        //        RadWindow2.VisibleOnPageLoad = true;
        //        RadWindow2.Visible = true;
        //        RadWindow2.VisibleStatusbar = true;
        //        RadWindow2.Title = "Expediente: ";
        //        RadWindow2.Width = 700;
        //        RadWindow2.Height = 500;


        //        if (pibote == false)
        //        {
        //        ssSesiones.from= ssNewInsi.Id;
        //            pibote = true;
        //        }

        //        if (i == (Valor - 1))
        //        {
        //            ssSesiones.to= ssNewInsi.Id;


        //           // ssSesiones.Total = ssImprimir.Count;

        //        }
        //    }
        //}
    }
}