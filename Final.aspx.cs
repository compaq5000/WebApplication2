using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using System.Data;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;


namespace WebApplication2
{
    public partial class Final : System.Web.UI.Page
    {

        ClassSesion ssSesiones = new ClassSesion();
        /****************************************GRAFICAR********************************************/
        protected void RadSlider2_ValueChanged(object sender, EventArgs e)
        {
            FillValues(RadComboBoxGrafic.SelectedValue);
        }
        private void FillValues(string Pagina)
        {
            //foreach (var series in Chart2.Series)
            //{
            //    series.Points.Clear();
            //}

            DateTime fechaInicio = new DateTime(DateTime.Now.Year, Convert.ToInt32(RadSlider2.SelectionStart), 1, 0, 0, 0);
            DateTime fechaFin = new DateTime(DateTime.Now.Year, Convert.ToInt32(RadSlider2.SelectionEnd), DateTime.DaysInMonth(DateTime.Now.Year, Convert.ToInt32(RadSlider2.SelectionEnd)), 23, 59, 59);
            Session["FechaInicio"] = fechaInicio;
            Session["FechaFin"] = fechaFin;
            DataSet EJEMPLO = SubSonicDB.SPs.Storearbolado(Convert.ToDateTime(Session["FechaInicio"]), Convert.ToDateTime(Session["FechaFin"])).GetDataSet();


            ////  List<DataRow> LIST = EJEMPLO.Tables[0].AsEnumerable().ToList();
            DataView dv = EJEMPLO.Tables[0].DefaultView;
            //Series series1 = Chart2.Series["Series1"];
            //Series series2 = Chart2.Series["Series2"];
            //Series series3 = Chart2.Series["Series3"];
            //Series series4 = Chart2.Series["Series4"];

            FillTotal(dv.Count, Pagina);

            List<ClassGrafica> ClaseGrafica = new List<ClassGrafica>();
            int Index = 1;
            int pibote = 1;
            foreach (DataRowView dr in dv)
            {
                if (pibote > 5)
                {
                    Index++;
                    pibote = 1;
                }
                pibote++;
                ClassGrafica Val = new ClassGrafica();
                int result = (100 * Convert.ToInt32(dr.Row.ItemArray[3])) / Convert.ToInt32(dr.Row.ItemArray[1]);

                //////Val.Elemento(Index.ToString(), dr.Row.ItemArray[0].ToString(), dr.Row.ItemArray[1].ToString(), dr.Row.ItemArray[2].ToString(), dr.Row.ItemArray[3].ToString(), dr.Row.ItemArray[4].ToString(), result.ToString() + "%");

                //////ClaseGrafica.Add(Val);

                //if (RadComboBoxGrafic.SelectedValue == Index.ToString())
                //{
                //    series1.Points.AddXY(Val.GetNombre(dr.Row.ItemArray[0].ToString()), dr.Row.ItemArray[1].ToString());
                //    series2.Points.AddXY(Val.GetNombre(dr.Row.ItemArray[0].ToString()), dr.Row.ItemArray[2].ToString());
                //    series3.Points.AddXY(Val.GetNombre(dr.Row.ItemArray[0].ToString()), dr.Row.ItemArray[3].ToString());
                //    series4.Points.AddXY(Val.GetNombre(dr.Row.ItemArray[0].ToString()), dr.Row.ItemArray[4].ToString());
                //}
            }


            RadGridGRafic.DataSource = ClaseGrafica.Where(x => x.Pag == RadComboBoxGrafic.SelectedValue);
            RadGridGRafic.DataBind();

            //series1.LegendText = "ASIGNADOS";
            //series2.LegendText = "ATENDIENDO";
            //series3.LegendText = "CONTESTADOS";
            //series4.LegendText = "SIN ABRIR";
            //Chart2.ChartAreas["ChartArea1"].AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            //Chart2.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            //Chart2.ChartAreas[0].AxisX.IsLabelAutoFit = false;
            //Chart2.Titles[0].Text = " Del: " + fechaInicio.ToString("dd MMMM yyyy").ToUpper() + " A: " + fechaFin.ToString(" dd MMMM yyyy").ToUpper() + ".";
        }
        public void FillTotal(int xx, string Pagin)
        {
            RadComboBoxGrafic.Items.Clear();
            int result = xx / 5;
            if (decimal.Remainder(xx, 5) == 0)
            {
            }
            else
            {
                result = result + 1;
            }
            for (int i = 1; i <= result; i++)
            {
                Telerik.Web.UI.RadComboBoxItem elemnt = new Telerik.Web.UI.RadComboBoxItem("Pag." + i, i.ToString());
                RadComboBoxGrafic.Items.Add(elemnt);
            }
            //  if (!IsPostBack)
            //  {

            RadComboBoxGrafic.SelectedValue = Pagin;
            // }
        }
        protected void RadGrid1_NeedDataSourGrafic(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)



        {
            FillValues(RadComboBoxGrafic.SelectedValue);
        }
        protected void RadComboBoxGrafic_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
        {
            FillValues(RadComboBoxGrafic.SelectedValue);
        }
        /************************************FIN DE GRAFICAR***************************************************/
        //   ClassSesion ssSesiones = new ClassSesion();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Radpane1.Visible = VisibleJefe();
            //EndPane.Visible = VisibleJefe();
            //Radslidingpane2.Visible = VisibleJefe();
            if (!IsPostBack)
            {
                /********************************************COMIENZA GRAFICAR************************************/
                RadSlider2.SelectionStart = DateTime.Now.Month;
                RadSlider2.SelectionEnd = DateTime.Now.Month;
                FillValues(null);
                /***************************************FIN GRAFICAR******************************************/
                ////FillPersonas();
                FillUser();
                TextBoxCorrespondenciaFecha.SelectedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                //Label1.Text = "UBICACIÓN: " + "JURIDICO";
                /// ssSesiones.Usua = "1";
                VisibleUpload(true);
                ssSesiones.Usua = Convert.ToString(ssSesiones.Usua);
                RadGrid1.Visible = true;
                SubSonicDB.ArboladoCollection SS = new SubSonicDB.ArboladoCollection()
                    .Where(SubSonicDB.Arbolado.Columns.ValueX, ssSesiones.Usua)
                    .OrderByAsc(SubSonicDB.Arbolado.Columns.Descripcion)
                    .Load();
                List<Car> Lista = new List<Car>();
                foreach (SubSonicDB.Arbolado ssCarpeta in SS)
                {
                    Lista.Add(new Car(ssCarpeta.Descripcion, ssCarpeta.Id, Convert.ToInt32(ssCarpeta.IDDepende)));
                }
                RadTreeView1.DataSource = Lista;
                RadTreeView1.DataTextField = "DESCRIPCION";
                RadTreeView1.DataFieldID = "Id";
                RadTreeView1.DataFieldParentID = "IDDepende";
                RadTreeView1.DataValueField = "Id";
                RadTreeView1.DataBind();
                ssSesiones.KEYcarpeta = 1;
                RadTreeNode node = RadTreeView1.FindNodeByValue("1");
                if (node != null)
                {
                    node.Selected = true;
                    node.Expanded = true;
                    node.ExpandParentNodes();
                    node.Focus();
                }
                /**************************************PARA QUE USUARIOS DIFERENTES A ADMINISTRADOR BUSQUE EN SOLO EN CORRESPONDENCIA*****************************************************/
                if (Convert.ToInt32(ssSesiones.IDTipoUser) != 1)
                {
                    RadioButtonListBuscarEn.SelectedValue = "2";
                    RadioButtonListBuscarEn.Enabled = false;
                }
                RadioButtonListTipoCorrespondencia.SelectedValue = "3";
            }
            FillTomos();
            RadWindow1.VisibleOnPageLoad = false;
            RadWindow1.Visible = false;
            TextBoxBusca.Focus();
        }
        public void FillUser()
        {
            // RadMenu1.Items.Add();


        }
        public void FillTomos()
        {

            SubSonicDB.CatTomoCollection ssTomos = new SubSonicDB.CatTomoCollection()
                .Load();
            foreach (SubSonicDB.CatTomo ssTomo in ssTomos)
            {
                Telerik.Web.UI.RadComboBoxItem add = new Telerik.Web.UI.RadComboBoxItem(ssTomo.Descripcion, ssTomo.Id.ToString());
                RadComboBoxTomo.Items.Add(add);

            }


            if (Convert.ToInt32(ssSesiones.IDTipoUser) != 2)
            {


                RadToolBar1.Items[3].Visible = false;
                //RadToolBar1.Items[3].Visible = false;

            }
            else
            {
                RadToolBar1.Items[2].Visible = false;

            }

        }
        protected void RadAutoCompleteBoxTipoJuicio_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                SubSonicDB.CattipoJuicioCollection sss = new SubSonicDB.CattipoJuicioCollection()
                      .Load();

                RadAutoCompleteBoxTipoJuicio.DataSource = sss;
                RadAutoCompleteBoxTipoJuicio.DataTextField = "descripocion";
                RadAutoCompleteBoxTipoJuicio.DataValueField = "IDTipojuicio";
                RadAutoCompleteBoxTipoJuicio.DataBind();
            }

        }
        protected void RadAutoCompleteBoxAutoridadCaso_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                SubSonicDB.CatAutocasoCollection sss = new SubSonicDB.CatAutocasoCollection()
                    .Load();
                RadAutoCompleteBoxAutocasos.DataSource = sss;
                RadAutoCompleteBoxAutocasos.DataTextField = "Descripcion";
                RadAutoCompleteBoxAutocasos.DataValueField = "IDAutoCaso";
                RadAutoCompleteBoxAutocasos.DataBind();
            }

        }
        protected void RadAutoCompleteBoxActor_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                SubSonicDB.CatActorCollection ssss = new SubSonicDB.CatActorCollection()
                   .Load();
                IDActor.DataSource = ssss;
                IDActor.DataTextField = "Descripcion";
                IDActor.DataValueField = "IDActor";
                IDActor.DataBind();
            }

        }
        protected void RadAutoCompleteBoxAbogado_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

                SubSonicDB.CatAbogadoActorCollection ssss = new SubSonicDB.CatAbogadoActorCollection()
                .Load();
                RadAutoCompleteBoxAbogado.DataSource = ssss;
                RadAutoCompleteBoxAbogado.DataTextField = "Descripcion";
                RadAutoCompleteBoxAbogado.DataValueField = "IDAbogadoActor";
                RadAutoCompleteBoxAbogado.DataBind();
            }
        }
        protected void RadAutoCompleteBoxDemandado_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                SubSonicDB.CatDemandadoCollection ssss = new SubSonicDB.CatDemandadoCollection()
                .Load();
                RadAutoCompleteBoxDemandado.DataSource = ssss;
                RadAutoCompleteBoxDemandado.DataTextField = "Descripcion";
                RadAutoCompleteBoxDemandado.DataValueField = "IDDemandado";
                RadAutoCompleteBoxDemandado.DataBind();
            }

        }
        /**********************COMIENZA CORRESPONDENCIA**************************************/
        protected void RadAutoCompleteOrigen_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                SubSonicDB.CatOrigenCorrespondenciumCollection ssss = new SubSonicDB.CatOrigenCorrespondenciumCollection()
                    .Where(SubSonicDB.CatOrigenCorrespondencium.Columns.Status, true)
                .Load();

                RadAutoCompleteBoxOrigen.DataSource = ssss;
                RadAutoCompleteBoxOrigen.DataTextField = "Descripcion";
                RadAutoCompleteBoxOrigen.DataValueField = "ID";
                RadAutoCompleteBoxOrigen.DataBind();
            }

        }
        protected void RadAutoCompleteDestino_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                SubSonicDB.CatDestinoCorrespondenciumCollection ssss = new SubSonicDB.CatDestinoCorrespondenciumCollection()
                    .Where(SubSonicDB.CatDestinoCorrespondencium.Columns.Status, true)
                .Load();

                RadAutoCompleteBoxDestino.DataSource = ssss;
                RadAutoCompleteBoxDestino.DataTextField = "Descripcion";
                RadAutoCompleteBoxDestino.DataValueField = "ID";
                RadAutoCompleteBoxDestino.DataBind();
            }

        }
        protected void RadAutoCompleteUsuarioas_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                SubSonicDB.CatUsuarioCollection ssss = new SubSonicDB.CatUsuarioCollection()
                    .Where(SubSonicDB.CatUsuario.Columns.Status, true)
                // SubSonicDB.CatDemandadoCollection ssss = new SubSonicDB.CatDemandadoCollection()
                .Load();
                RadAutoCompleteBoxUsuarios.DataSource = ssss;
                RadAutoCompleteBoxUsuarios.DataTextField = "Nombre";
                RadAutoCompleteBoxUsuarios.DataValueField = "ID";
                RadAutoCompleteBoxUsuarios.DataBind();
            }

        }
        /*******************************FINALIZA CORRESPONDENCIA*****************************/
        //public void BindToArrayList(RadAutoCompleteBox autoCompleteBox)
        //{
        //   SubSonicDB.CatActorCollection ssss= new SubSonicDB.CatActorCollection()
        //        .Load();
        //    IDActor.DataSource = ssss;
        //    IDActor.DataTextField = "Descripcion";
        //    IDActor.DataValueField = "IDActor";
        //    IDActor.DataBind();

        //}
        protected void RadTreeView1_NodeClick(object sender, Telerik.Web.UI.RadTreeNodeEventArgs e)
        {
            Label1.Text = "UBICACIÓN: " + e.Node.FullPath.Replace("/", ">");
            TextBoxBusca.Text = "";
            //bool h = e.Node.FullPath.Contains("CORRESPONDENCIA");
            ssSesiones.KEYcarpeta = e.Node.Value;
            //SubSonicDB.Expediente ssExpe = SubSonicDB.Expediente.FetchByID(ssSesiones.KEYcarpeta.ToString());
            RadGrid1.Rebind();
            RadWindow1.VisibleOnPageLoad = false;
            RadWindow1.Visible = false;
            RadTreeNode node = RadTreeView1.FindNodeByValue(ssSesiones.KEYcarpeta.ToString());
            if (node != null)
            {
                node.Selected = true;
                node.Expanded = true;
                node.ExpandParentNodes();
                node.Focus();
            }
        }
        protected void onClientButtonClicking(object sender, Telerik.Web.UI.RadToolBarEventArgs e)
        {
            RadWindow1.VisibleOnPageLoad = false;
            RadWindow1.Visible = false;
            List<int> list = new List<int>();
            //copy****************************************************************/
            if (e.Item.Value == "copy")
            {

                if (RadGrid1.Visible == true)
                {
                    if (RadGrid1.SelectedItems.Count > 0)
                    {
                        for (int i = 0; i < RadGrid1.SelectedItems.Count; i++)
                        {
                            try
                            {
                                list.Add(Convert.ToInt32(RadGrid1.SelectedItems[i].OwnerTableView.DataKeyValues[RadGrid1.SelectedItems[i].ItemIndex]["ID"]));
                            }
                            catch
                            {
                                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Ha ocurrido un error. ');</script>", false);
                            }
                        }
                        ssSesiones.StatusCopy = true;
                    }

                }
                else
                {

                    /**************************************PARA SELECCIONAR CORRESPONDENCIA************************************************/


                    if (RadGrid2.SelectedItems.Count > 0)
                    {
                        for (int i = 0; i < RadGrid2.SelectedItems.Count; i++)
                        {
                            try
                            {
                                list.Add(Convert.ToInt32(RadGrid2.SelectedItems[i].OwnerTableView.DataKeyValues[RadGrid2.SelectedItems[i].ItemIndex]["ID"]));
                            }
                            catch
                            {
                                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Ha ocurrido un error. ');</script>", false);
                            }
                        }
                        ssSesiones.StatusCopy = true;
                    }

                }


                ssSesiones.ArchivosSelect = list;
            }
            if (e.Item.Value == "paste")
            {
                if (Convert.ToBoolean(ssSesiones.StatusCopy) == true)
                {
                    List<int> liste = new List<int>();
                    liste = (List<int>)ssSesiones.ArchivosSelect;
                    try
                    {
                        foreach (int j in liste)
                        {
                            SubSonicDB.Expediente sscopiExpediente = SubSonicDB.Expediente.FetchByID(j);

                            SubSonicDB.Expediente ssNewExpedienteCopiado = new SubSonicDB.Expediente();
                            ssNewExpedienteCopiado.IDDepende = Convert.ToInt32(ssSesiones.KEYcarpeta);
                            ssNewExpedienteCopiado.IDTIpoContenido = Convert.ToInt32(sscopiExpediente.IDTIpoContenido);
                            ssNewExpedienteCopiado.Descripcion = sscopiExpediente.Descripcion;
                            ssNewExpedienteCopiado.IDActor = sscopiExpediente.IDActor;
                            ssNewExpedienteCopiado.IDAbogadoActor = sscopiExpediente.IDAbogadoActor;
                            ssNewExpedienteCopiado.IDDemandado = sscopiExpediente.IDDemandado;
                            ssNewExpedienteCopiado.IDAutocaso = sscopiExpediente.IDAutocaso;
                            ssNewExpedienteCopiado.IDTipojuicio = sscopiExpediente.IDTipojuicio;
                            ssNewExpedienteCopiado.Causa = sscopiExpediente.Causa;
                            ssNewExpedienteCopiado.Etapa = sscopiExpediente.Etapa;
                            ssNewExpedienteCopiado.Fechaconoce = Convert.ToDateTime(sscopiExpediente.Fechaconoce);
                            ssNewExpedienteCopiado.Fechainterpone = sscopiExpediente.Fechainterpone;
                            ssNewExpedienteCopiado.Status = sscopiExpediente.Status;
                            ssNewExpedienteCopiado.Usuarios = ssSesiones.Usua;
                            ssNewExpedienteCopiado.IDOrigenCorres = sscopiExpediente.IDOrigenCorres;
                            ssNewExpedienteCopiado.IDStatusCorrespondencia = sscopiExpediente.IDStatusCorrespondencia;
                            ssNewExpedienteCopiado.Save();

                            SubSonicDB.Expediente ssPego = SubSonicDB.Expediente.FetchByID(Convert.ToInt32(ssSesiones.KEYcarpeta));
                            ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua), 16, sscopiExpediente.Descripcion + "a: " + ssPego.Descripcion);
                            ssSesiones.StatusCopy = false;
                        }
                    }
                    catch (Exception) { }

                    RadGrid1.Rebind();
                }

                /////////////////////////////pega lo que se corta con el boton de paste


                string hii = ssSesiones.KEYcarpeta.ToString();
                if (Convert.ToBoolean(ssSesiones.StatusCut) == true)
                {
                    List<int> liste = new List<int>();

                    liste = (List<int>)ssSesiones.ArchivosSelect;

                    try
                    {

                        //pega los archivos cortados
                        foreach (int j in liste)
                        {
                            SubSonicDB.Expediente sscopiExpediente = SubSonicDB.Expediente.FetchByID(j);
                            sscopiExpediente.IDDepende = Convert.ToInt32(ssSesiones.KEYcarpeta);
                            sscopiExpediente.Save();



                            ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua), 17, sscopiExpediente.Descripcion);
                        }
                        ssSesiones.StatusCut = false;
                    }
                    catch { }





                    RadTreeNode node = RadTreeView1.FindNodeByValue("1");

                    if (node != null)
                    {
                        node.Selected = true;
                        node.Expanded = true;
                        node.ExpandParentNodes();
                        node.Focus();
                    }










                    RadGrid1.Rebind();
                }

                ///////////////////////////Fin del pegado de archivos
            }
            ////////////////////////////////////FIN DEL COPY//////////////////////////////////////////
            //**********************************empieza si es cortar*****************************************************/////////////////////
            if (e.Item.Value == "cut")
            {


                if (RadGrid1.Visible == true)
                {
                    if (RadGrid1.SelectedItems.Count > 0)
                    {
                        for (int i = 0; i < RadGrid1.SelectedItems.Count; i++)
                        {
                            try
                            {
                                list.Add(Convert.ToInt32(RadGrid1.SelectedItems[i].OwnerTableView.DataKeyValues[RadGrid1.SelectedItems[i].ItemIndex]["ID"]));
                            }
                            catch
                            {
                                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Ha ocurrido un error. No se ha podido eliminar el registro');</script>", false);
                            }
                        }
                        ssSesiones.StatusCopy = false;
                        ssSesiones.StatusCut = true;
                    }
                }
                /**************************cortar en caso de que el arhivo sea correspondencia*****************************/
                else
                {

                    if (RadGrid2.SelectedItems.Count > 0)
                    {
                        for (int i = 0; i < RadGrid2.SelectedItems.Count; i++)
                        {
                            try
                            {
                                list.Add(Convert.ToInt32(RadGrid2.SelectedItems[i].OwnerTableView.DataKeyValues[RadGrid2.SelectedItems[i].ItemIndex]["ID"]));
                            }
                            catch
                            {
                                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Ha ocurrido un error. No se ha podido eliminar el registro');</script>", false);
                            }
                        }
                        ssSesiones.StatusCopy = false;
                        ssSesiones.StatusCut = true;
                    }



                }



                ssSesiones.ArchivosSelect = list;
            }
            ////////////////////////////////////////////////////////////SI SE PRESIONA EL BOTON NAVEGAR ATRAS//////////////////////////////////////////////////////////////////////////////////


            if (e.Item.Value== "Pases de Salida") {
                Response.Redirect("~/PermisosyPases.aspx");
            }
            
            
            if (e.Item.Value == "RH")
            {
                Response.Redirect("~/RHdefault.aspx");
                //            SubSonicDB.Expediente ssdondeestoy = SubSonicDB.Expediente.FetchByID(Convert.ToInt32(ssSesiones.KEYcarpeta));
                //          ssSesiones.KEYcarpeta = ssdondeestoy.IDDepende;
                ////try
                ////{
                ////    RadTreeNode node = RadTreeView1.FindNodeByValue(ssSesiones.KEYcarpeta.ToString());
                ////    ssSesiones.KEYcarpeta = node.ParentNode.Value;
                ////    RadTreeNode node1 = RadTreeView1.FindNodeByValue(ssSesiones.KEYcarpeta.ToString());
                ////    Label1.Text = "UBICACIÓN: " + node1.FullPath;
                ////    if (node1 != null)
                ////    {
                ////        node1.Selected = true;
                ////        node1.Expanded = true;
                ////        node1.ExpandParentNodes();
                ////        node1.Focus();
                ////    }
                ////}
                ////catch { }
                //////RadListView1.Visible = false;
                ////RadGrid1.Rebind();
            }
            //if (e.Item.Value == "Catalogos")
            //{
            //    Response.Redirect("~/Catalogos.aspx");
            //}

            if (e.Item.Value == "Upload")
            {
                VisibleUpload(true);
                //RadListView1.Visible = false;
                VisibleNewFolder(false);
            }
            if (e.Item.Value == "folder")
            {

                Response.Redirect("~/revicion.aspx");
                //VisibleNewFolder(true);
                //VisibleUpload(false);
                //RadListView1.Visible = false;
            }
            if (e.Item.Value == "Users")
            {
                Response.Redirect("~/Default2.aspx");
            }
            if (e.Item.Value == "Bitacora")
            {
                ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua), 20, "");


                Response.Redirect("~/Bitacora.aspx");

            }
            if (e.Item.Value == "exit")
            {

                ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua), 18, "");

                Session.Abandon();
                Session.Clear();
                Response.Redirect("~/LogOff.aspx");



            }
            if (e.Item.Value == "Soporte")
            {
                ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua), 18, "");
                //Session.Abandon();
                //Session.Clear();
                Response.Redirect("~/SoporteTecnico.aspx");
            }
        }
        protected void RadGrid1_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            RadTreeNode node = RadTreeView1.FindNodeByValue(ssSesiones.KEYcarpeta.ToString());
            /***************************SE EJECUTA CUANDO ES EXPEDIENTE*********************************/
            bool Expedientes = node.FullPath.Contains("EXPEDIENTES");
            if (Expedientes == true)
            {
                //  DataSet SSfIND = SubSonicDB.SPs.ArboladoGridSPD(Convert.ToInt32(ssSesiones.Usua), Convert.ToInt32(ssSesiones.KEYcarpeta)).GetDataSet();
                SubSonicDB.ArboladoGridCollection SSfIND = new SubSonicDB.ArboladoGridCollection()
                    .Where(SubSonicDB.ArboladoGrid.Columns.IDDepende, ssSesiones.KEYcarpeta)
                    .Where(SubSonicDB.ArboladoGrid.Columns.ValueX, ssSesiones.Usua)
                    .OrderByAsc(SubSonicDB.ArboladoGrid.Columns.IDTIpoContenido)
                    //LO PIDE LA LICENCIADA MAYRA
                    .Where(SubSonicDB.ArboladoGrid.Columns.IDTIpoContenido, SubSonic.Comparison.NotEquals, 1)
                    .Load();

                RadGrid1.DataSource = SSfIND;
                //SSfIND.Reset();
                RadGrid2.Visible = false;
                RadGrid1.Visible = true;
                TotaldeRegistros.Text = "Total de registros: " + SSfIND.Count;
                                                                              
            }
            /*************************ENTRA A CARPETASNO EXPEDIENTES*******************************************/
            else if (Expedientes == false)

            {

                if (!string.IsNullOrEmpty(TextBoxBusca.Text) && RadioButtonListBuscarEn.SelectedValue == "1")
                {
                    SubSonicDB.ArboladoGridCollection ssBusqueda = new SubSonicDB.ArboladoGridCollection()
                         .Where(SubSonicDB.ArboladoGrid.Columns.Busqueda, SubSonic.Comparison.Like, "%" + TextBoxBusca.Text + "%")
                         .Where(SubSonicDB.ArboladoGrid.Columns.ValueX, ssSesiones.Usua)
                         .OrderByAsc(SubSonicDB.ArboladoGrid.Columns.IDTIpoContenido)
                         .Where(SubSonicDB.ArboladoGrid.Columns.IDTIpoContenido, 2)
                            //LO PIDE LA LICENCIADA MAYRA
                            .Where(SubSonicDB.ArboladoGrid.Columns.IDTIpoContenido, SubSonic.Comparison.NotEquals, 1)
                         .Load();
                    //   SubSonicDB.ViewGridExpedienteCollection ssBusqueda = new SubSonicDB.ViewGridExpedienteCollection()
                    //.Where(SubSonicDB.ViewGridExpediente.Columns.Busqueda, SubSonic.Comparison.Like,"%"+ TextBoxBusca.Text +"%")
                    //.Load();
                    RadGrid1.DataSource = ssBusqueda;
                    RadGrid1.Visible = true;
                    RadGrid2.Visible = false;
                    //  RadGrid1.DataBind();
                    TotaldeRegistros.Text = "Total de registros: " + ssBusqueda.Count;
                }
                if (!string.IsNullOrEmpty(TextBoxBusca.Text) && RadioButtonListBuscarEn.SelectedValue == "2")
                {



                    SubSonicDB.ArboladoGridCollection SSfIND = new SubSonicDB.ArboladoGridCollection()
                        .Where(SubSonicDB.ArboladoGrid.Columns.IDDepende, ssSesiones.KEYcarpeta)
                        .Where(SubSonicDB.ArboladoGrid.Columns.ValueX, ssSesiones.Usua)
                        .OrderByAsc(SubSonicDB.ArboladoGrid.Columns.IDTIpoContenido)
                        //LO PIDE LA LICENCIADA MAYRA
                        .Where(SubSonicDB.ArboladoGrid.Columns.IDTIpoContenido, SubSonic.Comparison.GreaterThan, 2)
                        .Load();

                    RadGrid2.DataSource = SSfIND;
                    //SSfIND.Reset();
                    RadGrid2.Visible = true;
                    RadGrid1.Visible = false;
                    TotaldeRegistros.Text = "Total de registros: " + SSfIND.Count;

                }
                if (string.IsNullOrEmpty(TextBoxBusca.Text))
                {

                    /********entra a todas las demas carpetas que no es expedientes*/




                    RadGrid2.Visible = true;
                    RadGrid1.Visible = false;
                    try
                    {
                        // DataSet SSfIND = SubSonicDB.SPs.ArboladoGridSPD(Convert.ToInt32( ssSesiones.Usua), Convert.ToInt32(ssSesiones.KEYcarpeta)).GetDataSet();
                        SubSonicDB.ArboladoGridCollection SSfIND = new SubSonicDB.ArboladoGridCollection()
                                .Where(SubSonicDB.ArboladoGrid.Columns.IDDepende, ssSesiones.KEYcarpeta)
                                .Where(SubSonicDB.ArboladoGrid.Columns.ValueX, ssSesiones.Usua)
                                .OrderByDesc(SubSonicDB.ArboladoGrid.Columns.Fechaconoce)
                                //LO PIDE LA LICENCIADA MAYRA
                                .Where(SubSonicDB.ArboladoGrid.Columns.IDTIpoContenido, SubSonic.Comparison.NotEquals, 1)
                                .Load();

                        RadGrid2.DataSource = SSfIND;
                        RadGrid2.DataBind();
                        // SSfIND.Reset();
                        TotaldeRegistros.Text = "Total de registros: " + SSfIND.Count;
                    }
                    catch
                    {
                        /*********************PARA SOLUCIONAR EL PROBLEMA DE PAGINACION*****************************/

                        SubSonicDB.ArboladoGridCollection SSfIND = new SubSonicDB.ArboladoGridCollection()
                        .Where(SubSonicDB.ArboladoGrid.Columns.IDDepende, ssSesiones.KEYcarpeta)
                        .Where(SubSonicDB.ArboladoGrid.Columns.ValueX, ssSesiones.Usua)
                        .OrderByDesc(SubSonicDB.ArboladoGrid.Columns.Fechaconoce)
                        //LO PIDE LA LICENCIADA MAYRA
                        .Where(SubSonicDB.ArboladoGrid.Columns.IDTIpoContenido, SubSonic.Comparison.NotEquals, 1)
                        .Load();
                        RadGrid2.DataSource = SSfIND;
                        TotaldeRegistros.Text = "Total de registros: " + SSfIND.Count;
                    }
                }
            }
















            /**************************************************************************************************/
            /****************************************************************************************************/
            FillCut(ssSesiones.KEYcarpeta.ToString());
            FillCopy(ssSesiones.KEYcarpeta.ToString());
            FillCreate(ssSesiones.KEYcarpeta.ToString());
            FillCORRESPONDENCIA(ssSesiones.KEYcarpeta.ToString());
        }
        protected void RadGrid1_PreRender(object sender, EventArgs e)
        {
            RadGrid1.MasterTableView.Items[0].Selected = true;
        }
        protected void RadGrid3_ItemCommand(object sender, GridCommandEventArgs e)
        {
            ssSesiones.NombreArchivo = null;
            RadWindow1.VisibleOnPageLoad = false;
            RadWindow1.Visible = false;
            ///*****************************************************/
            //if (e.CommandName == "RowClick")
            //{
            //    string g = e.CommandArgument.ToString();
            //    string[] words = g.Split(' ');
            //    SubSonicDB.Expediente ssExpediente = SubSonicDB.Expediente.FetchByID(words[0]);

            //    try
            //    {
            //        RadListView1.DataSource = ssExpediente;
            //        RadListView1.DataBind();
            //    }
            //    catch { };
            //}

            /****************************************************/

            if (e.CommandName.ToString() != "Page")
            {
                if (e.CommandName.ToString() != "ChangePageSize")
                {
                    string g = e.CommandArgument.ToString();
                    string[] words = g.Split(' ');

                    /*************************************ENTRA A LOS METADATOS*************************************/
                    if (g.IndexOf("_") != -1)
                    {
                        g = g.Replace('_', ' ');
                        SubSonicDB.ViewGridExpedienteCollection ssExp = new SubSonicDB.ViewGridExpedienteCollection()
                            .Where(SubSonicDB.ViewGridExpediente.Columns.Id, Convert.ToInt32(g))
                            .Load();

                        //SubSonicDB.ViewGridExpediente ssExp = new SubSonicDB.ViewGridExpediente();
                        //ssExp.LoadByParam(SubSonicDB.ViewGridExpediente.Columns.Id, g);
                        //RadListView1.Visible = true;
                        //RadListView1.DataSource = ssExp;
                        //RadListView1.DataBind();
                        RadWindow1.VisibleOnPageLoad = false;
                        RadWindow1.Visible = false;
                        VisibleUpload(false);
                        for (int i = 0; i < RadGrid1.SelectedItems.Count; i++)
                        {
                            RadGrid1.SelectedItems[i].Selected = false;
                        }
                        e.Item.Selected = true;
                        bitacora(Convert.ToInt32(g), ssExp[0].Descripcion);
                    }
                    /************************************************ACTUALIAR EXPEDIENTE************************************************/
                    else if (g.IndexOf("-") != -1)
                    {
                        g = g.Replace('-', ' ');
                        SubSonicDB.Expediente ssExpedientes = SubSonicDB.Expediente.FetchByID(g.Remove(0, 1));
                        RadWindow1.NavigateUrl = "~/upload.aspx?ID=" + ssExpedientes.Id;
                        RadWindow1.VisibleOnPageLoad = true;
                        RadWindow1.Visible = true;
                        RadWindow1.VisibleStatusbar = true;
                        RadWindow1.Title = "Expediente: " + ssExpedientes.Descripcion;
                        RadWindow1.Width = 700;
                        RadWindow1.Height = 500;
                        // RadGrid1.Rebind();

                        for (int i = 0; i < RadGrid1.SelectedItems.Count; i++)
                        {
                            RadGrid1.SelectedItems[i].Selected = false;
                        }
                        e.Item.Selected = true;
                    }
                    //************************************ABRIR CARPETA****************************************/
                    else if (words[1] == "1")
                    {
                        ssSesiones.KEYcarpeta = words[0];
                        // Ubicacion(Convert.ToInt32(ssSesiones.KEYcarpeta));
                        //RadListView1.Visible = false;
                        RadWindow1.VisibleOnPageLoad = false;
                        RadWindow1.Visible = false;
                        RadTreeNode node = RadTreeView1.FindNodeByValue(ssSesiones.KEYcarpeta.ToString());
                        Label1.Text = "UBICACIÓN: " + node.FullPath.Replace("/", ">");
                        //LabelDepende.Text = 
                        if (node != null)
                        {
                            node.Selected = true;
                            node.Expanded = true;
                            node.ExpandParentNodes();
                            node.Focus();
                        }
                        RadGrid1.Rebind();
                        FillValues(RadComboBoxGrafic.SelectedValue);
                    }
                    /**********************************ABRIR ARCHIVO*************************************/
                    else
                    {
                        SubSonicDB.Expediente ssexpediente = SubSonicDB.Expediente.FetchByID(words[0]);
                        //  Boolean fileOK = false;
                        String path = Server.MapPath("~/files/");
                        //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>window.open('../ExpedHome.aspx', '_blank');</script>", false);
                        if (System.IO.File.Exists(path + ssexpediente.Descripcion.Replace('/', '_') + ".tif"))
                        {
                            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>window.open('../tif.aspx', '_blank');</script>", false);
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>window.open('../ExpeTif.aspx', '_blank');</script>", false);
                            ssSesiones.VerExpediente = words[0];
                            //RadWindow1.NavigateUrl = "~/tif.aspx?ID=" + words[0];
                            //RadWindow1.VisibleOnPageLoad = true;
                            //RadWindow1.Visible = true;
                            //RadWindow1.Title = "Expediente: " + ssexpediente.Descripcion;
                            //RadWindow1.Width = 600;
                            //RadWindow1.Height = 600;

                            ssSesiones.NombreArchivo = ssexpediente.Descripcion.Replace('/', '_') + ".tif";
                            ssSesiones.FileDownload = words[0];

                        }
                        else if (System.IO.File.Exists(path + ssexpediente.Descripcion.Replace('/', '_') + ".pdf"))
                        {

                            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>window.open('../LoadExpediente.aspx', '_this');</script>", false);
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>window.open('../ExpedfHome.aspx', '_blank');</script>", false);
                            ssSesiones.VerExpediente = words[0];
                            //RadWindow1.NavigateUrl = "~/LoadExpediente.aspx?ID=" + words[0];
                            //RadWindow1.VisibleOnPageLoad = true;
                            //RadWindow1.Visible = true;
                            //RadWindow1.Title = "Expediente: " + ssexpediente.Descripcion;
                            //RadWindow1.Width = 600;
                            //RadWindow1.Height = 600;
                        }
                        else
                        {
                            string Archivo = "El archivo no existe";
                        }
                    }
                }
            }
        }
        protected void RadGrid3_ItemCommandCorrespondencia(object sender, GridCommandEventArgs e)
        {

            ssSesiones.NombreArchivo = null;
            RadWindow1.VisibleOnPageLoad = false;
            RadWindow1.Visible = false;
            ///*****************************************************/
            //if (e.CommandName == "RowClick")
            //{
            //    string g = e.CommandArgument.ToString();
            //    string[] words = g.Split(' ');
            //    SubSonicDB.Expediente ssExpediente = SubSonicDB.Expediente.FetchByID(words[0]);

            //    try
            //    {
            //        RadListView1.DataSource = ssExpediente;
            //        RadListView1.DataBind();
            //    }
            //    catch { };
            //}

            /****************************************************/

            if (e.CommandName.ToString() != "Page")
            {
                if (e.CommandName.ToString() != "ChangePageSize")
                {
                    string g = e.CommandArgument.ToString();
                    string[] words = g.Split(' ');

                    if (words[1] == "1")
                    {
                        ssSesiones.KEYcarpeta = words[0];
                        SubSonicDB.ArboladoGridCollection SSfIND = new SubSonicDB.ArboladoGridCollection()
                       .Where(SubSonicDB.ArboladoGrid.Columns.IDDepende, ssSesiones.KEYcarpeta)
                       .Where(SubSonicDB.ArboladoGrid.Columns.ValueX, ssSesiones.Usua)
                       .OrderByAsc(SubSonicDB.ArboladoGrid.Columns.IDTIpoContenido)
                       .Load();
                        RadGrid2.DataSource = SSfIND;
                        RadGrid2.DataBind();
                        TotaldeRegistros.Text = "Total de registros: " + SSfIND.Count;
                        RadTreeNode node = RadTreeView1.FindNodeByValue(ssSesiones.KEYcarpeta.ToString());
                        Label1.Text = "UBICACIÓN: " + node.FullPath.Replace("/", ">");
                        if (node != null)
                        {
                            node.Selected = true;
                            node.Expanded = true;
                            node.ExpandParentNodes();
                            node.Focus();
                        }
                    }
                    else if ((words[1] == "3") || (words[1] == "5"))
                    {
                        SubSonicDB.Expediente ssExpedient = SubSonicDB.Expediente.FetchByID(words[0]);
                        ssSesiones.VerExpediente = words[0];
                        //cambia la correspondencia ya fue abierto
                        if (ssExpedient.IDStatusCorrespondencia == 10)
                        {
                            /**************************NO QUITARLO ES PARA QUE SI SE RESPONDE NO VUELVA A PONER COMO EN CONTESTACION**********************************************/
                            bool Pibol = true;
                            if (ssSesiones.IDUsua == "15" || ssSesiones.IDUsua == "1")
                            {
                                Pibol = false;
                            }
                            if (Pibol)
                            {
                                ssExpedient.IDStatusCorrespondencia = 11;
                                ssExpedient.Save();
                            }
                        }
                        if (string.IsNullOrWhiteSpace(TextBoxBusca.Text))

                        {
                            Button2_Click(null, null);
                            Button2.Click += new EventHandler(Button2_Click);
                        }
                        else
                        {
                            ImageButtonBusqueda_Click(null, null);
                            Button1.Click += new EventHandler(Button1_Click);
                        }

                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>window.open('../Correshome.aspx', '_blank');</script>", false);
                        //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>window.open('../CORRESPONDENCIA/Correshome.aspx', '_blank');</script>", false);
                        //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>window.open('../LoadExpediente.aspx', '_blank');</script>", false);
                    }
                    else if (words[1] == "11" || words[1] == "12")
                    {
                        ssSesiones.VerExpediente = words[0];
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>window.open('../CORRESPONDENCIA/Correshome.aspx', '_blank');</script>", false);

                        //RadWindow1.Width = 750;
                        //RadWindow1.Height = 600;
                        //RadWindow1.Title = "Cargar o listar contestación de la correspondencia";
                        //RadWindow1.VisibleOnPageLoad = true;
                        //RadWindow1.Visible = true;
                        //RadWindow1.NavigateUrl = "~/FileCorrespondencia.aspx?ID=" + words[0];
                        RadTreeNode node = RadTreeView1.FindNodeByValue(ssSesiones.KEYcarpeta.ToString());
                    }
                }
            }
            FillValues(RadComboBoxGrafic.SelectedValue);
        }
        protected void RadGrid3_ItemCommandCorrespondenciaRetornada(object sender, GridCommandEventArgs e)
        {

            //ssSesiones.NombreArchivo = null;
            //RadWindow1.VisibleOnPageLoad = false;
            //RadWindow1.Visible = false;


            //if (e.CommandName.ToString() != "Page")
            //{
            //    if (e.CommandName.ToString() != "ChangePageSize")
            //    {
            //        string g = e.CommandArgument.ToString();
            //        string[] words = g.Split(' ');




            //            RadWindow1.Height = 600;
            //            RadWindow1.Title = "Cargar o listar contestación de la correspondencia";


            //            RadWindow1.VisibleOnPageLoad = true;
            //            RadWindow1.Visible = true;
            //            RadWindow1.NavigateUrl = "~/FileCorrespondencia.aspx?ID=" + words[0];
            //            RadTreeNode node = RadTreeView1.FindNodeByValue(ssSesiones.KEYcarpeta.ToString());


            //    }
            //}
        }
        protected void RadComboBox1_SelectedIndexChangedCambiarDestinatario(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
        {
            try
            {
                /***************************************************************agregar usuario a las carpetas juridico y correspondencia si es que no esta ddo de alta/*********************************/
                RadComboBox Radcombo = sender as RadComboBox;
                // you can access grid row here
                GridDataItem item = Radcombo.NamingContainer as GridDataItem;
                string IDregistro = item.GetDataKeyValue("IDRegistro").ToString();
                string IDExpediente = item.GetDataKeyValue("IDExpedienteOri").ToString();
                int IDNewActor = Convert.ToInt32(Radcombo.SelectedValue);
                List<int> ListActorSAve = new List<int>();
                ListActorSAve.Add(IDNewActor);
                List<int> Carpetas = new List<int>();
                Carpetas.Add(1);//acceso a la carpeta juridico
                Carpetas.Add(6090);//Acceso a la carpeta correspondencia
                foreach (int Ele in Carpetas)
                {
                    List<string> NuevosUsers = new List<string>();
                    SubSonicDB.Expediente ssExpediente = SubSonicDB.Expediente.FetchByID(Ele);
                    string[] separadas = ssExpediente.Usuarios.Split(',');
                    NuevosUsers = separadas.ToList();

                    foreach (int Val in ListActorSAve)
                    {
                        if (!Array.Exists(separadas, element => element == Val.ToString()))
                        {
                            NuevosUsers.Add(Val.ToString());
                        }
                    }
                    string cadena = string.Join(",", NuevosUsers);
                    ssExpediente.Usuarios = cadena;
                    bool pibot = false;
                    if (ssSesiones.IDUsua == "1" || ssSesiones.IDUsua == "15")
                    {
                        pibot = true;
                    }
                    if (pibot)
                    {
                        ssExpediente.Save();
                    }
                }
                /*************************************************************************agregar el usuario al archivo********************************************************************************/
                SubSonicDB.Expediente ssNewExpedienteCorrespondencia = SubSonicDB.Expediente.FetchByID(IDExpediente);
                string[] separadas1 = ssNewExpedienteCorrespondencia.Usuarios.Split(',');
                List<string> NuevosUsers1 = new List<string>();
                NuevosUsers1 = separadas1.ToList();
                foreach (int Val1 in ListActorSAve)
                {
                    if (!Array.Exists(separadas1, element1 => element1 == Val1.ToString()))
                    {
                        NuevosUsers1.Add(Val1.ToString());
                    }
                }
                ssNewExpedienteCorrespondencia.Usuarios = string.Join(",", NuevosUsers1);
                ssNewExpedienteCorrespondencia.Fechaconoce = DateTime.Now;
                ssNewExpedienteCorrespondencia.IDDepende = 6090;
                ssNewExpedienteCorrespondencia.IDStatusCorrespondencia = 10;
                ssNewExpedienteCorrespondencia.StatusRetornado = false;
                bool pibot1 = true;
                if (ssSesiones.IDUsua == "1" || ssSesiones.IDUsua == "15")
                {
                    pibot1 = false;
                }
                if (pibot1)
                {
                    ssNewExpedienteCorrespondencia.Save();
                    SubSonicDB.ArchivoCorrespondencium ssQuitarAlerta = SubSonicDB.ArchivoCorrespondencium.FetchByID(IDregistro);
                    ssQuitarAlerta.StatusCorresponde = false;
                    ssQuitarAlerta.Save();
                    ssSesiones.EnviarCorreo(IDNewActor, ssNewExpedienteCorrespondencia.Descripcion, ssNewExpedienteCorrespondencia.Causa, ssNewExpedienteCorrespondencia.CatOrigenCorrespondencium.Descripcion);
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Se ha guardado correctamente.');</script>", false);
                }
            }
            catch
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Ocurrio un error al guardar.');</script>", false);
            }
        }
        public bool VisibleJefe()
        {
            if (ssSesiones.IDUsua == "1")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public string ProcessMyDataItem(object myValue)
        {
            myValue = myValue;
            return myValue.ToString();
        }
        public string ProcessMyDataItemTipoContenido(object myValue)
        {

            if (myValue.ToString() == "1")
            {

                return "Folder";
            }
            else
            {
                return "Archivo";
            }
        }
        public string ProcessMyDataItemTipoContenidoPara(object myValue, object id)
        {
            string valoet = "<hr>";

            if (myValue.ToString() == "3" || myValue.ToString() == "5")
            {
                SubSonicDB.ViewUserCorrespondenciumCollection ssUsuarios = new SubSonicDB.ViewUserCorrespondenciumCollection()
                    .Where(SubSonicDB.ViewUserCorrespondencium.Columns.Id, id)
                    .Where(SubSonicDB.ViewUserCorrespondencium.Columns.ValueX, SubSonic.Comparison.NotEquals, 1)
                   .Where(SubSonicDB.ViewUserCorrespondencium.Columns.ValueX, SubSonic.Comparison.NotEquals, 15)
                  .Load();
                foreach (SubSonicDB.ViewUserCorrespondencium ssCorres in ssUsuarios)
                {
                    valoet = valoet + ssCorres.Nombre + "<hr>";
                }
                return valoet;
            }
            else
            {
                return "Sin Destinatarios";
            }
        }
        public bool ProcessMyDataItemVisible(object myValue)
        {
            if (myValue.ToString() == "1")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool ProcessMyDataItemVisibleCorrespondencia(object myValue)
        {
            if (myValue.ToString() == "1")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string ProcessMyDataItemEtapa(object myValue, object tipoArchivo)
        {
            if (Convert.ToInt32(tipoArchivo) == 2)
            {
                try
                {
                    SubSonicDB.RelEtapasDeExpediente ssEtapa = SubSonicDB.RelEtapasDeExpediente.FetchByID(myValue.ToString());

                    return ssEtapa.Descripcion;
                }
                catch { return "DESCONOCIDO"; }
            }
            else
            {
                return null;
            }
        }
        public string ProcessMyDataItemTamano(object myValue)
        {
            return Convertir(Convert.ToInt32(myValue));
        }
        public string ProcessMyDataItemaCTUALIZADO(object myValue, object MyValue2)
        {
            if (Convert.ToInt32(MyValue2) != 1)
            {

                SubSonicDB.ViewUserActualiza ssActualiza = new SubSonicDB.ViewUserActualiza();
                ssActualiza.LoadByParam(SubSonicDB.ViewUserActualiza.Columns.Id, myValue);
                if (ssActualiza.Detalle != "")
                {

                    return ssActualiza.Detalle + ":  Actualizado Por: " + ssActualiza.Nombre + "  El: " + ssActualiza.Actualizado;
                }
                else
                {
                    return "Sin actualización al momento";
                }
            }
            else
            {
                return "";
            }
        }
        public string ProcessMyDataItemaCTUALIZADOCorrespondencia(object myValue, object MyValue2)
        {
            if (Convert.ToInt32(MyValue2) != 1)
            {

                SubSonicDB.ViewUserActualiza ssActualiza = new SubSonicDB.ViewUserActualiza();
                ssActualiza.LoadByParam(SubSonicDB.ViewUserActualiza.Columns.Id, myValue);
                if (ssActualiza.Detalle != "")
                {

                    return ssActualiza.Detalle + ":  Actualizado Por: " + ssActualiza.Nombre + "  El: " + ssActualiza.Actualizado;
                }
                else
                {
                    return "Sin actualización al momento";
                }
            }
            else
            {
                return "";
            }
        }
        public void Ubicacion(int ID)
        {
            //LabelDepende.Text = "";
            //try
            //{
            //    List<String> list = new List<String>();

            //    SubSonicDB.Expediente ssExpe = SubSonicDB.Expediente.FetchByID(ID);

            // //   ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua),13 ,ssExpe.Descripcion);
            //    list.Add(ssExpe.Descripcion);

            //    int Padre = Convert.ToInt32(ssExpe.IDDepende);
            //    do
            //    {
            //        SubSonicDB.Expediente ssExped = SubSonicDB.Expediente.FetchByID(Padre);
            //        list.Add(ssExped.Descripcion);
            //        Padre--;
            //    }
            //    while (Padre > 0);

            //    //Enviarlosdatos

            //    List<String> listreverse = new List<String>();

            //    list.Reverse();

            //    foreach (string k in list)
            //    {


            //        LabelDepende.Text = LabelDepende.Text + "/" + k;
            //    }

            //}
            //catch { }


        }
        protected void ImageButtonBusqueda_Click(object sender, EventArgs e)
        {
            ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua), 2, TextBoxBusca.Text);
            if (RadioButtonListBuscarEn.SelectedValue == "1")
            {

                //RadListView1.Visible = false;
                RadGrid1.Rebind();


                RadWindow1.VisibleOnPageLoad = false;
                RadWindow1.Visible = false;
            }
            else
            {

                /**********************************entra cuando es correspondencia********************************************/
                RadGrid2.Visible = true;
                RadGrid1.Visible = false;
                SubSonicDB.ArboladoGridCollection SSfIND = new SubSonicDB.ArboladoGridCollection()
                    .Where(SubSonicDB.ArboladoGrid.Columns.ValueX, ssSesiones.Usua)
                    .Where(SubSonicDB.ArboladoGrid.Columns.IDTIpoContenido, SubSonic.Comparison.GreaterOrEquals, 3)
                    .Where(SubSonicDB.ArboladoGrid.Columns.BuscaCorres, SubSonic.Comparison.Like, "%" + TextBoxBusca.Text + "%")
                    .OrderByDesc(SubSonicDB.ArboladoGrid.Columns.Fechaconoce)
                    .Load();
                RadGrid2.DataSource = SSfIND;
                RadGrid2.DataBind();
                TotaldeRegistros.Text = "Total de registros: " + SSfIND.Count;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            List<int> ListActorSAve = new List<int>();
            List<string> ListActorNew = new List<string>();
            List<int> ListAbogadoSAve = new List<int>();
            List<string> ListAbogadoNew = new List<string>();
            List<int> ListdemandadoSAve = new List<int>();
            List<string> ListdemandadoNew = new List<string>();
            List<int> ListAutoCasoSAve = new List<int>();
            List<string> ListAutoCasoNew = new List<string>();
            List<int> ListTipoJuicioSAve = new List<int>();
            List<string> ListTipoJuicioNew = new List<string>();



            for (int i = 0; i < IDActor.Entries.Count; i++)
            {
                try
                {
                    ListActorSAve.Add(Convert.ToInt32(IDActor.Entries[i].Value));
                }
                catch
                {
                    ListActorNew.Add(IDActor.Entries[i].Text);
                }
            }

            ///primero guardamos los nuevos Acctores que no exxisten
            foreach (string NuevoActor in ListActorNew)
            {
                SubSonicDB.CatActor ssNewActor = new SubSonicDB.CatActor();
                ssNewActor.Descripcion = NuevoActor.ToUpper();
                ssNewActor.Status = true;
                ssNewActor.Save();
                ListActorSAve.Add(ssNewActor.IDActor);
            }

            for (int i = 0; i < RadAutoCompleteBoxAbogado.Entries.Count; i++)
            {
                try
                {
                    ListAbogadoSAve.Add(Convert.ToInt32(RadAutoCompleteBoxAbogado.Entries[i].Value));
                }
                catch
                {
                    ListAbogadoNew.Add(RadAutoCompleteBoxAbogado.Entries[i].Text);
                }
            }
            //guardamos los abogado
            foreach (string NuevoAbogado in ListAbogadoNew)
            {

                SubSonicDB.CatAbogadoActor ssNewAbogado = new SubSonicDB.CatAbogadoActor();
                ssNewAbogado.Descripcion = NuevoAbogado.ToUpper();
                ssNewAbogado.Status = true;
                ssNewAbogado.Save();
                ListAbogadoSAve.Add(ssNewAbogado.IDAbogadoActor);

            }

            for (int i = 0; i < RadAutoCompleteBoxDemandado.Entries.Count; i++)
            {
                try
                {
                    ListdemandadoSAve.Add(Convert.ToInt32(RadAutoCompleteBoxDemandado.Entries[i].Value));
                }
                catch
                {
                    ListdemandadoNew.Add(RadAutoCompleteBoxDemandado.Entries[i].Text);
                }
            }
            //guardamos los Demandados
            foreach (string NuevoDemandado in ListdemandadoNew)
            {
                SubSonicDB.CatDemandado ssNewDemandado = new SubSonicDB.CatDemandado();
                ssNewDemandado.Descripcion = NuevoDemandado.ToUpper();
                ssNewDemandado.Status = true;
                ssNewDemandado.Save();
                ListdemandadoSAve.Add(ssNewDemandado.IDDemandado);
            }

            for (int i = 0; i < RadAutoCompleteBoxAutocasos.Entries.Count; i++)
            {
                try
                {
                    ListAutoCasoSAve.Add(Convert.ToInt32(RadAutoCompleteBoxAutocasos.Entries[i].Value));
                }
                catch
                {
                    ListAutoCasoNew.Add(RadAutoCompleteBoxAutocasos.Entries[i].Text);
                }
            }
            ///primero guardamos los nueva autoridad que conoce el caso que no exxisten
            foreach (string NuevaAutoridad in ListAutoCasoNew)
            {
                SubSonicDB.CatAutocaso ssNewAutocaso = new SubSonicDB.CatAutocaso();
                ssNewAutocaso.Descripcion = NuevaAutoridad.ToUpper();
                ssNewAutocaso.Status = true;
                ssNewAutocaso.Save();
                ListAutoCasoSAve.Add(ssNewAutocaso.IDAutocaso);
            }

            for (int i = 0; i < RadAutoCompleteBoxTipoJuicio.Entries.Count; i++)
            {
                try
                {
                    ListTipoJuicioSAve.Add(Convert.ToInt32(RadAutoCompleteBoxTipoJuicio.Entries[i].Value));
                }
                catch
                {
                    ListTipoJuicioNew.Add(RadAutoCompleteBoxTipoJuicio.Entries[i].Text);
                }
            }
            ///primero guardamos los nueva autoridad que conoce el caso que no exxisten
            foreach (string NuevaAutoridad in ListTipoJuicioNew)
            {
                SubSonicDB.CattipoJuicio ssNewAutocaso = new SubSonicDB.CattipoJuicio();
                ssNewAutocaso.Descripocion = NuevaAutoridad.ToUpper();
                ssNewAutocaso.Status = true;
                //  ssNewAutocaso.Save();
                ListTipoJuicioSAve.Add(ssNewAutocaso.IDTipojuicio);

            }
            //busca los usuarios que tendran acceso al archivo

            SubSonicDB.ExpedienteCollection ssUsersDepen = new SubSonicDB.ExpedienteCollection()
                .Where(SubSonicDB.Expediente.Columns.Id, ssSesiones.KEYcarpeta)
                .Load();



            SubSonicDB.Expediente ssNewExpediente = new SubSonicDB.Expediente();

            ssNewExpediente.Usuarios = ssUsersDepen[0].Usuarios;
            ssNewExpediente.IDDepende = Convert.ToInt32(ssSesiones.KEYcarpeta);
            ssNewExpediente.IDTIpoContenido = 2;


            //SE GUARDA EL ACTOR O LOS ACTORES SEGUN SEA EL CASO

            ssNewExpediente.IDActor = ListActorSAve.ElementAt(0);
            ssNewExpediente.IDAbogadoActor = ListAbogadoSAve.ElementAt(0);
            ssNewExpediente.IDDemandado = ListdemandadoSAve.ElementAt(0);
            ssNewExpediente.IDAutocaso = ListAutoCasoSAve.ElementAt(0);
            ssNewExpediente.IDTipojuicio = ListTipoJuicioSAve.ElementAt(0);
            ssNewExpediente.Causa = TextBoxCAusaUpload.Text.ToUpper();
            ssNewExpediente.Etapa = TextBoxEtapa.Text.ToUpper();
            ssNewExpediente.Fechaconoce = DateTime.Now;
            ssNewExpediente.Fechainterpone = TextBoxExpedienteUpload.Text.Substring(4, 4);
            ssNewExpediente.Status = true;
            if (Convert.ToInt32(RadComboBoxTomo.SelectedValue) > 1)
            {
                ssNewExpediente.Tomo = RadComboBoxTomo.SelectedItem.Text;
                ssNewExpediente.Descripcion = TextBoxExpedienteUpload.Text.Insert(4, "/") + " " + RadComboBoxTomo.SelectedItem.Text;
            }
            else
            {
                ssNewExpediente.Descripcion = TextBoxExpedienteUpload.Text.Insert(4, "/");
            }
            ssNewExpediente.Save();
            ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua), 3, ssNewExpediente.Descripcion);

            TextBoxExpedienteUpload.Text = "";
            IDActor.Entries.Clear();
            RadAutoCompleteBoxAbogado.Entries.Clear();
            RadAutoCompleteBoxDemandado.Entries.Clear();
            RadAutoCompleteBoxAutocasos.Entries.Clear();
            RadAutoCompleteBoxTipoJuicio.Entries.Clear();
            TextBoxCAusaUpload.Text = "";
            TextBoxEtapa.Text = "";


            ssSesiones.VerExpediente = ssNewExpediente.Id.ToString();
            //  RadGrid1.Rebind();
            // RadWindow1.NavigateUrl = "~/Upload.aspx?ID=" + ssNewExpediente.Id;
            RadWindow1.NavigateUrl = "~/Upload.aspx?ID=" + ssSesiones.VerExpediente;
            //RadWindow1.NavigateUrl = "~/Upload.aspx?ID=" + TextBoxExpedienteUpload.Text.Insert(4, "-");
            RadWindow1.VisibleOnPageLoad = true;
            RadWindow1.Visible = true;
            RadWindow1.VisibleStatusbar = false;
            //RadWindow1.Title = "Expediente: " + TextBoxExpedienteUpload.Text.Insert(4, "-");
            RadWindow1.Title = "Expediente: " + ssSesiones.VerExpediente;
            RadWindow1.Modal = true;
            RadWindow1.VisibleStatusbar = false;
            RadWindow1.Width = 600;
            RadWindow1.Height = 400;
            // RadWindow1.Behaviors = WindowBehaviors.Move & WindowBehaviors.Maximize;


        }
        public void VisibleUpload(bool Valor)
        {
            TextBoxExpedienteUpload.Mask = "####/####";
            TextBoxExpedienteUpload.Visible = Valor;
            IDActor.Visible = Valor;
            RadAutoCompleteBoxAbogado.Visible = Valor;
            RadAutoCompleteBoxDemandado.Visible = Valor;
            TextBoxCAusaUpload.Visible = Valor;
            TextBoxEtapa.Visible = Valor;
            // RadDatePickerFEchaconoce.Visible = Valor;
            Label2.Visible = Valor;
            //Label3.Visible = Valor;
            //Label4.Visible = Valor;
            //Label5.Visible = Valor;
            //Label6.Visible = Valor;
            //Label7.Visible = Valor;
            //Label8.Visible = Valor;
            ButtonUpload.Visible = Valor;
            ButtonCancelar.Visible = Valor;
            //RadUpload1.Visible = Valor;
            Detalle.Visible = Valor;


        }
        public void VisibleNewFolder(bool Valor)
        {
            //LabelNomFolder.Visible = Valor;
            //TextBoxNomFolder.Visible = Valor;
            // ButtonSaveFolder.Visible = Valor;
            //RadListView1.Visible = Valor;
        }
        public void bitacora(int valuee, string Expe)
        {

            RadListBoxBitacora.Items.Clear();

            SubSonicDB.ViewHistorialExpedienteCollection ssActualiza = new SubSonicDB.ViewHistorialExpedienteCollection()
                .Where(SubSonicDB.ViewHistorialExpediente.Columns.Id, valuee)
                .OrderByDesc(SubSonicDB.ViewHistorialExpediente.Columns.Actualizado)
                .Load();
            //SubSonicDB.ViewBitacoraCollection ssActualiza = new SubSonicDB.ViewBitacoraCollection()
            //    .Where(SubSonicDB.ViewBitacora.Columns.Id, valuee)
            //    .OrderByDesc(SubSonicDB.ViewBitacora.Columns.Actualizado)
            //    .Load();
            Telerik.Web.UI.RadListBoxItem itemms = new RadListBoxItem("Expediente " + Expe, "1");
            RadListBoxBitacora.Items.Add(itemms);
            foreach (SubSonicDB.ViewHistorialExpediente ssActu in ssActualiza)
            {
                Telerik.Web.UI.RadListBoxItem itemm = new RadListBoxItem("ETAPA PROCESAL:" + "[" + ssActu.Expr1 + "] " + ssActu.Nombre + ":            OBSERVACIONES: " + ssActu.Detalle + "_ " + "[" + ssActu.Actualizado + "]", ssActu.Id.ToString());
                RadListBoxBitacora.Items.Add(itemm);
            }
            ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua), 12, Expe);
        }
        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {

        }
        protected void ImageButtonUploadPDF_Click(object sender, ImageClickEventArgs e)
        {
            RadWindow1.NavigateUrl = "~/Upload.aspx?ID=" + TextBoxExpedienteUpload.Text;
            RadWindow1.VisibleOnPageLoad = true;
            RadWindow1.Visible = true;
            RadWindow1.Modal = true;
            RadWindow1.VisibleStatusbar = false;
            RadWindow1.Width = 500;
            RadWindow1.Height = 200;
            RadWindow1.Behaviors = WindowBehaviors.Move & WindowBehaviors.Maximize;
        }
        public string Convertir(int ID)
        {


            try
            {


                String path = Server.MapPath("~/files/");
                SubSonicDB.Expediente ss = SubSonicDB.Expediente.FetchByID(ID);

                if (System.IO.File.Exists(path + ss.Descripcion.Replace('/', '_') + ".tif"))
                {

                    System.IO.FileInfo info = new System.IO.FileInfo(path + ss.Descripcion.Replace('/', '_') + ".tif");
                    long tamano = info.Length;
                    return SizeSuffix(tamano, 1);
                }
                else
                {
                    System.IO.FileInfo info = new System.IO.FileInfo(path + ss.Descripcion.Replace('/', '_') + ".pdf");
                    long tamano = info.Length;
                    return SizeSuffix(tamano, 1);

                }

            }
            catch
            {

                return "No Existe Archivo";
            }



            //    try
            //{
            //    String path = Server.MapPath("~/files/");
            //    SubSonicDB.Expediente ss = SubSonicDB.Expediente.FetchByID(ID);

            //    System.IO.FileInfo info = new System.IO.FileInfo(path + ss.Descripcion + ".pdf");
            //    long tamano = info.Length;
            //    return SizeSuffix(tamano, 1);

            //}
            //catch
            //{

            //    return "No Existe Archivo";

            //}

        }
        static readonly string[] SizeSuffixes =
                       { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        static string SizeSuffix(Int64 value, int decimalPlaces = 1)
        {
            if (decimalPlaces < 0) { throw new ArgumentOutOfRangeException("decimalPlaces"); }
            if (value < 0) { return "-" + SizeSuffix(-value); }
            if (value == 0) { return string.Format("{0:n" + decimalPlaces + "} bytes", 0); }

            // mag is 0 for bytes, 1 for KB, 2, for MB, etc.
            int mag = (int)Math.Log(value, 1024);

            // 1L << (mag * 10) == 2 ^ (10 * mag) 
            // [i.e. the number of bytes in the unit corresponding to mag]
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            // make adjustment when the value is large enough that
            // it would round up to 1000 or more
            if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
            {
                mag += 1;
                adjustedSize /= 1024;
            }

            return string.Format("{0:n" + decimalPlaces + "} {1}",
                adjustedSize,
                SizeSuffixes[mag]);
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {

            if (RadGrid1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < RadGrid1.SelectedItems.Count; i++)
                {
                    string valued = RadGrid1.SelectedItems[i].OwnerTableView.DataKeyValues[RadGrid1.SelectedItems[i].ItemIndex]["ID"].ToString();
                    SubSonicDB.Expediente ssExP = SubSonicDB.Expediente.FetchByID(valued);
                    if (ssExP.IDTIpoContenido == 1)
                    {
                        ssExP.Descripcion = TextBoxNomFolder.Text.ToUpper();
                        // ssExP.Status = true;
                        ssExP.Save();
                        ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua), 14, TextBoxNomFolder.Text.ToUpper());
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Se ha cambiado el nombre al folder correctamente');</script>", false);
                    }
                }
            }


            else
            {
                if (ssSesiones.Usua == "1")
                {
                    SubSonicDB.Expediente ssNewFolder = new SubSonicDB.Expediente();
                    ssNewFolder.Usuarios = ssSesiones.Usua;
                    ssNewFolder.IDDepende = Convert.ToInt32(ssSesiones.KEYcarpeta);
                    ssNewFolder.IDTIpoContenido = 1;
                    ssNewFolder.Descripcion = TextBoxNomFolder.Text.ToUpper();
                    ssNewFolder.Save();
                    ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua), 14, TextBoxNomFolder.Text.ToUpper());
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Se ha creador correctamente el folder');</script>", false);

                }
                else
                {
                    SubSonicDB.Expediente ssNewFolder = new SubSonicDB.Expediente();
                    ssNewFolder.Usuarios = ssSesiones.Usua + "," + "1";
                    ssNewFolder.IDDepende = Convert.ToInt32(ssSesiones.KEYcarpeta);
                    ssNewFolder.IDTIpoContenido = 1;
                    ssNewFolder.Descripcion = TextBoxNomFolder.Text.ToUpper();
                    ssNewFolder.Save();
                    ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua), 14, TextBoxNomFolder.Text.ToUpper());

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Se ha creador correctamente el folder');</script>", false);



                }

                //   VisibleNewFolder(false);
                //   VisibleUpload(false);
                //   RadListView1.Visible = false;


            }
            RadGrid1.Rebind();
            TextBoxNomFolder.Text = "";
            SubSonicDB.ArboladoCollection SS = new SubSonicDB.ArboladoCollection()
                  .Where(SubSonicDB.Arbolado.Columns.ValueX, ssSesiones.Usua)
                  .Load();
            // BindToArrayList(IDActor);
            List<Car> Lista = new List<Car>();
            foreach (SubSonicDB.Arbolado ssCarpeta in SS)
            {
                Lista.Add(new Car(ssCarpeta.Descripcion, ssCarpeta.Id, Convert.ToInt32(ssCarpeta.IDDepende)));
            }


            //DataSet EJEMPLO = SubSonicDB.SPs.StoreArbolado1(Convert.ToInt32(ssSesiones.IDUsua)).GetDataSet();
            //List<DataRow> LIST = EJEMPLO.Tables[0].AsEnumerable().ToList();

            RadTreeView1.DataSource = Lista;
            RadTreeView1.DataTextField = "DESCRIPCION";
            RadTreeView1.DataFieldID = "Id";
            RadTreeView1.DataFieldParentID = "IDDepende";
            RadTreeView1.DataValueField = "Id";
            RadTreeView1.DataBind();
            ssSesiones.KEYcarpeta = 1;


            //RadTreeNode nodo = new RadTreeNode();
            //nodo.Selected = true;
            //nodo.Value = "2";
            //nodo.Expanded = true;





            //RadTreeNode node = RadTreeView1.FindNodeByValue(ssSesiones.KEYcarpeta.ToString());

            //Label1.Text = "UBICACIÓN: " + node.FullPath;
            ////LabelDepende.Text = 

            //if (node != null)
            //{
            //    node.Selected = true;
            //    node.Expanded = true;
            //    node.ExpandParentNodes();
            //    node.Focus();
            //}






        }
        protected void Button2_Click(object sender, EventArgs e)
        {



            RadWindow1.Visible = false;
            RadWindow1.VisibleOnPageLoad = false;

            if (RadioButtonListBuscarEn.SelectedValue == "1")
            {

                RadGrid1.Rebind();
            }
            else
            {

                RadGrid2.Rebind();
            }

            //RadGrid3.Rebind();
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>window.open('../tif.aspx?ID'" + "3" + ", '_blank');</script>", false);




        }
        public void FillCut(string Carpeta)
        {
            RadToolBar1.Items[6].Visible = Convert.ToBoolean(ssSesiones.TipoUser);

            try
            {
                SubSonicDB.TranPermisoCollection ssPermmiso = new SubSonicDB.TranPermisoCollection()
                   .Where(SubSonicDB.TranPermiso.Columns.IDUser, ssSesiones.Usua)
                   .Where(SubSonicDB.TranPermiso.Columns.IDPermiso, "C")
                   .Where(SubSonicDB.TranPermiso.Columns.IDExpediente, ssSesiones.KEYcarpeta)
                   .Load();

                // RadToolBar1.Items[3].Enabled = Convert.ToBoolean(ssPermmiso[0].Status);
                RadToolBar1.Items[3].Enabled = Convert.ToBoolean(true);
            }
            catch
            {
                RadToolBar1.Items[3].Enabled = true;
                //RadToolBar1.Items[3].Enabled = false;
            }

        }
        public void FillCopy(string Carpeta)
        {
            if (ssSesiones.IDUsua == "1")
            {
                try
                {
                    SubSonicDB.TranPermisoCollection ssPermmiso = new SubSonicDB.TranPermisoCollection()
                       .Where(SubSonicDB.TranPermiso.Columns.IDUser, ssSesiones.Usua)
                       .Where(SubSonicDB.TranPermiso.Columns.IDPermiso, "B")
                       .Where(SubSonicDB.TranPermiso.Columns.IDExpediente, ssSesiones.KEYcarpeta)
                       .Load();

                    //RadToolBar1.Items[4].Enabled = Convert.ToBoolean(ssPermmiso[0].Status);
                    RadToolBar1.Items[4].Enabled = Convert.ToBoolean(true);

                }
                catch
                {
                    // RadToolBar1.Items[4].Enabled = false;
                    RadToolBar1.Items[4].Enabled = true;
                }
            }
            else
            {

                RadToolBar1.Items[4].Enabled = true;
                //RadToolBar1.Items[4].Enabled = false;

            }

        }
        public void FillCORRESPONDENCIA(string Carpeta)
        {
            try
            {
                SubSonicDB.TranPermisoCollection ssPermmiso = new SubSonicDB.TranPermisoCollection()
                   .Where(SubSonicDB.TranPermiso.Columns.IDUser, ssSesiones.Usua)
                   .Where(SubSonicDB.TranPermiso.Columns.IDPermiso, "F")
                   .Where(SubSonicDB.TranPermiso.Columns.IDExpediente, ssSesiones.KEYcarpeta)
                   .Load();

                // RadButton1.Enabled = Convert.ToBoolean(ssPermmiso[0].Status);
                //  ButtonSaveFolder.Enabled = Convert.ToBoolean(ssPermmiso[0].Status);
                //RadToolBar1.Items[0].Enabled = Convert.ToBoolean(ssPermmiso[0].Status);


            }
            catch
            {
                //ButtonUpload.Enabled = false;
                //ButtonSaveFolder.Enabled = false;
                //RadToolBar1.Items[0].Enabled = false;

                // RadButton1.Enabled = false;

            }

        }
        public void FillCreate(string Carpeta)
        {
            try
            {
                SubSonicDB.TranPermisoCollection ssPermmiso = new SubSonicDB.TranPermisoCollection()
                   .Where(SubSonicDB.TranPermiso.Columns.IDUser, ssSesiones.Usua)
                   .Where(SubSonicDB.TranPermiso.Columns.IDPermiso, "A")
                   .Where(SubSonicDB.TranPermiso.Columns.IDExpediente, ssSesiones.KEYcarpeta)
                   .Load();

                ButtonUpload.Enabled = Convert.ToBoolean(ssPermmiso[0].Status);
                //ButtonSaveFolder.Enabled = Convert.ToBoolean(ssPermmiso[0].Status);
                RadToolBar1.Items[0].Enabled = Convert.ToBoolean(ssPermmiso[0].Status);


            }
            catch
            {
                ButtonUpload.Enabled = false;
                //ButtonSaveFolder.Enabled = false;
                RadToolBar1.Items[0].Enabled = false;

            }

        }
        protected void RadGrid1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var g = e;
        }
        protected void RadButtonNewCorrespondencia_Click(object sender, EventArgs e)
        {
            List<int> ListActorSAve = new List<int>();
            List<int> ListOrigenSAve = new List<int>();
            List<int> ListDestinoSAve = new List<int>();


            List<string> ListOrigenNew = new List<string>();
            List<string> ListDestinoNew = new List<string>();
            List<int> ListEnviarCorreo = new List<int>();

            /*****************************************Abogados*********************************************/


            if (Convert.ToInt32(ssSesiones.IDUsua) != 1)
            {//evita que se repita si es que quien lo guarda es el propio administrador
                ListActorSAve.Add(Convert.ToInt32(1));//lo ve administrador
            }
           
            
            ListActorSAve.Add(Convert.ToInt32(ssSesiones.IDUsua));//lo quien creo el archivo



            for (int i = 0; i < RadAutoCompleteBoxUsuarios.Entries.Count; i++)
            {
                try
                {

                    //valida que no exista en la lista para que no se repita el mismo elemento
                    if (Convert.ToInt32(RadAutoCompleteBoxUsuarios.Entries[i].Value) != Convert.ToInt32(ssSesiones.IDUsua))
                    {
                        ListActorSAve.Add(Convert.ToInt32(RadAutoCompleteBoxUsuarios.Entries[i].Value));
                        ListEnviarCorreo.Add(Convert.ToInt32(RadAutoCompleteBoxUsuarios.Entries[i].Value));
                    }
                }
                catch
                {
                    //si no existe que le agrege al administrador por defaul
                    ListActorSAve.Add(1);

                }
            }

            ssSesiones.to = ListEnviarCorreo;
            /***************************************Origenes***************************************/

            for (int i = 0; i < RadAutoCompleteBoxOrigen.Entries.Count; i++)
            {
                try
                {
                    ListOrigenSAve.Add(Convert.ToInt32(RadAutoCompleteBoxOrigen.Entries[i].Value));
                }
                catch
                {
                    ListOrigenNew.Add(RadAutoCompleteBoxOrigen.Entries[i].Text);
                }
            }
            //guardamos los Origenes no Existentes
            foreach (string NuevoOrigen in ListOrigenNew)
            {
                SubSonicDB.CatOrigenCorrespondencium ssNewOrigen = new SubSonicDB.CatOrigenCorrespondencium();
                ssNewOrigen.Descripcion = NuevoOrigen.ToUpper();
                ssNewOrigen.Status = true;
                ssNewOrigen.Save();
                ListOrigenSAve.Add(ssNewOrigen.Id);
            } 

            /**************************************Destino*****************************************/


            for (int i = 0; i < RadAutoCompleteBoxDestino.Entries.Count; i++)
            {
                try
                {
                    ListDestinoSAve.Add(Convert.ToInt32(RadAutoCompleteBoxDestino.Entries[i].Value));
                }
                catch
                {
                    ListDestinoNew.Add(RadAutoCompleteBoxDestino.Entries[i].Text);
                }
            }
            //guardamos los Destino no Existentes
            foreach (string NuevoDestino in ListDestinoNew)
            {
                SubSonicDB.CatDestinoCorrespondencium ssNewDestino = new SubSonicDB.CatDestinoCorrespondencium();
                ssNewDestino.Descripcion = NuevoDestino.ToUpper();
                ssNewDestino.Status = true;
                ssNewDestino.Save();
                ListDestinoSAve.Add(ssNewDestino.Id);
            }



            /************************************************SE GUARDA EL NUEVO EXPEDIENTE**********************************************/

            SubSonicDB.Expediente ssNewExpedienteCorrespondencia = new SubSonicDB.Expediente();
            ssNewExpedienteCorrespondencia.Usuarios = string.Join(",", ListActorSAve);
            ssNewExpedienteCorrespondencia.IDTIpoContenido = Convert.ToInt32(RadioButtonListTipoCorrespondencia.SelectedValue);//SE guarda un nuevo registro de tipo Correspondencia
            ssNewExpedienteCorrespondencia.IDOrigenCorres = ListOrigenSAve.ElementAt(0);
            ssNewExpedienteCorrespondencia.IDDestinoCorrespondencia = ListDestinoSAve.ElementAt(0);
            ssNewExpedienteCorrespondencia.Descripcion = RadTextBoxCorresondenciaFolio.Text.ToUpper();
            ssNewExpedienteCorrespondencia.Causa = TextBoxAsunto.Text.ToUpper();
            ssNewExpedienteCorrespondencia.Fechaconoce = TextBoxCorrespondenciaFecha.SelectedDate;
            ssNewExpedienteCorrespondencia.Fechaconoce = DateTime.Now;
            ssNewExpedienteCorrespondencia.IDDepende = !String.IsNullOrEmpty(ssSesiones.KEYcarpeta.ToString()) ? Convert.ToInt32(ssSesiones.KEYcarpeta) : 6090;
            ssNewExpedienteCorrespondencia.IDStatusCorrespondencia = 10;
            ssNewExpedienteCorrespondencia.Paginas = !String.IsNullOrEmpty(RadNumericTextBoxCantidad.Text) ? RadNumericTextBoxCantidad.Text : "1";
            ssNewExpedienteCorrespondencia.Save();
            RadioButtonListTipoCorrespondencia.SelectedValue = "3";
            /*****************************************VALIDA QUE EN LA CARPETA JURIDICO Y CORRESPONDENCIA CORRESPONDENCIA EXISTA EL USUARIO ***********************************************/
            List<int> Carpetas = new List<int>();
            Carpetas.Add(1);//acceso a la carpeta juridico
            Carpetas.Add(6090);//Acceso a la carpeta correspondencia
            foreach (int Ele in Carpetas)
            {
                List<string> NuevosUsers = new List<string>();
                SubSonicDB.Expediente ssExpediente = SubSonicDB.Expediente.FetchByID(Ele);
                string[] separadas = ssExpediente.Usuarios.Split(',');
                NuevosUsers = separadas.ToList();

                foreach (int Val in ListActorSAve)
                {
                    if (!Array.Exists(separadas, element => element == Val.ToString()))
                    {
                        NuevosUsers.Add(Val.ToString());
                    }
                }

                string cadena = string.Join(",", NuevosUsers);
                ssExpediente.Usuarios = cadena;
                ssExpediente.Save();
            }
            /*****************************************completo*****************************************************/

            RadAutoCompleteBoxUsuarios.Entries.Clear();
            RadAutoCompleteBoxOrigen.Entries.Clear();
            RadAutoCompleteBoxDestino.Entries.Clear();
            RadTextBoxCorresondenciaFolio.Text = "";
            TextBoxAsunto.Text = "";
            ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua), 23, ssNewExpedienteCorrespondencia.Descripcion);

            // bool result = ssSesiones.EnviarCorreo(ListEnviarCorreo, ssNewExpedienteCorrespondencia.Descripcion, ssNewExpedienteCorrespondencia.Causa, ssNewExpedienteCorrespondencia.CatOrigenCorrespondencium.Descripcion);

            ssSesiones.sujestig = ssNewExpedienteCorrespondencia.Descripcion;
            ssSesiones.MyBody = ssNewExpedienteCorrespondencia.Causa;

            ssSesiones.OficeQueEnvia = ssNewExpedienteCorrespondencia.CatOrigenCorrespondencium.Descripcion;

            RadGrid1.Rebind();

            //  RadGrid1.Rebind();
            RadWindow1.NavigateUrl = "~/UploadCorrespondencia.aspx?ID=" + ssNewExpedienteCorrespondencia.Id;
            RadWindow1.VisibleOnPageLoad = true;
            RadWindow1.Visible = true;
            RadWindow1.VisibleStatusbar = false;
            RadWindow1.Title = "Expediente: " + ssNewExpedienteCorrespondencia.Id;
            RadWindow1.Modal = true;
            RadWindow1.VisibleStatusbar = false;
            RadWindow1.Width = 600;
            RadWindow1.Height = 300;
            //  FillValues(RadComboBoxGrafic.SelectedValue);

        }
        public void FillPersonas()
        {
            SubSonicDB.CatUsuarioCollection ssUsuarios = new SubSonicDB.CatUsuarioCollection()
                .Where(SubSonicDB.CatUsuario.Columns.Status, true)
                .Load();

            foreach (SubSonicDB.CatUsuario ssUser in ssUsuarios)
            {
                Telerik.Web.UI.RadComboBoxItem add = new Telerik.Web.UI.RadComboBoxItem(ssUser.Nombre, ssUser.Id.ToString());

                // RadComboBoxUsuarios.Items.Add(add);
            }

        }
        protected void RadGrid1_NeedDataSourceCorres(object sender, GridNeedDataSourceEventArgs e)
        {

            /****************************************NO BORRAR ES PARA REGRESAR LA CORRESPONDENCIA */
            //       SubSonicDB.ViewRetornaCorrespondenciumCollection ssCorespondencias = new SubSonicDB.ViewRetornaCorrespondenciumCollection()
            //          .Load();


            ////   RadGrid3.DataSource = ssCorespondencias;



            //   if (ssCorespondencias.Count > 0)
            //   {


            //       Radslidingpane4.IconUrl = "~/img/alert.png";
            //   }
            //   else
            //   {
            //       Radslidingpane4.IconUrl = "~/img/complete.png";
            //   }

        }
        protected void Button3_Click(object sender, EventArgs e)
        {

            //quitado mientras regresalo es
            //RadGrid3.Rebind();
        }
        protected void RadGridGRafic_SelectedCellChanged1(object sender, EventArgs e)
        {





            RadGrid s = (RadGrid)sender;
            string Uniquename;  // CustomerID is the uniquename of column 
            string IDUserx = null;  // Works if you set the DataKeyValue as CustomerID 
            string[] words = null;
            string Index;
            foreach (GridDataItem item in s.SelectedItems)
            {
                //   Uniquename = item["NombreUser"].Text.ToString(); // CustomerID is the uniquename of column 

                if (ssSesiones.IDUsua == "15" || ssSesiones.IDUsua == "1")
                {

                    IDUserx = item.GetDataKeyValue("IdUser").ToString(); // Works if you set the DataKeyValue as CustomerID 


                    //    Index = item.ItemIndex.ToString();
                }
                else
                {
                    IDUserx = ssSesiones.IDUsua; // Works if you set the DataKeyValue as CustomerID 

                }

            }

            try
            {
                Telerik.Web.UI.GridTableCell h = s.SelectedCells[0];
                words = h.CellIndexHierarchical.Split('&', ' ');
            }
            catch { }


            DateTime fechaInicio = new DateTime(DateTime.Now.Year, Convert.ToInt32(RadSlider2.SelectionStart), 1, 0, 0, 0);
            DateTime fechaFin = new DateTime(DateTime.Now.Year, Convert.ToInt32(RadSlider2.SelectionEnd), DateTime.DaysInMonth(DateTime.Now.Year, Convert.ToInt32(RadSlider2.SelectionEnd)), 23, 59, 59);

            if (words[1].ToString() == "StatusRecibidos")
            {
                SubSonicDB.ArboladoGridCollection SSfIND = new SubSonicDB.ArboladoGridCollection()
               .Where(SubSonicDB.ArboladoGrid.Columns.IDDepende, 6090)
               .Where(SubSonicDB.ArboladoGrid.Columns.ValueX, IDUserx)
               .Where(SubSonicDB.ArboladoGrid.Columns.IDTIpoContenido, 3)
               .BetweenAnd(SubSonicDB.ArboladoGrid.Columns.Fechaconoce, fechaInicio, fechaFin)
               .Load();
                RadGrid2.Visible = true;
                RadGrid1.Visible = false;
                RadGrid2.DataSource = SSfIND;
                RadGrid2.DataBind();
                TotaldeRegistros.Text = "Total de registros: " + SSfIND.Count;
            }
            if (words[1].ToString() == "StatusContestados")
            {
                SubSonicDB.ArboladoGridCollection SSfIND = new SubSonicDB.ArboladoGridCollection()
               .Where(SubSonicDB.ArboladoGrid.Columns.IDDepende, 6090)
               .Where(SubSonicDB.ArboladoGrid.Columns.ValueX, IDUserx)
               .Where(SubSonicDB.ArboladoGrid.Columns.IDTIpoContenido, 3)
               .Where(SubSonicDB.ArboladoGrid.Columns.IDStatusCorrespondencia, 12)
               .BetweenAnd(SubSonicDB.ArboladoGrid.Columns.Fechaconoce, fechaInicio, fechaFin)
               .Load();
                RadGrid2.Visible = true;
                RadGrid1.Visible = false;
                RadGrid2.DataSource = SSfIND;
                RadGrid2.DataBind();
                TotaldeRegistros.Text = "Total de registros: " + SSfIND.Count;
            }
            if (words[1].ToString() == "StatusRevisados")
            {
                SubSonicDB.ArboladoGridCollection SSfIND = new SubSonicDB.ArboladoGridCollection()
               .Where(SubSonicDB.ArboladoGrid.Columns.IDDepende, 6090)
               .Where(SubSonicDB.ArboladoGrid.Columns.ValueX, IDUserx)
               .Where(SubSonicDB.ArboladoGrid.Columns.IDTIpoContenido, 3)
               .Where(SubSonicDB.ArboladoGrid.Columns.IDStatusCorrespondencia, 11)
               .BetweenAnd(SubSonicDB.ArboladoGrid.Columns.Fechaconoce, fechaInicio, fechaFin)
               .Load();
                RadGrid2.Visible = true;
                RadGrid1.Visible = false;
                RadGrid2.DataSource = SSfIND;
                RadGrid2.DataBind();
                TotaldeRegistros.Text = "Total de registros: " + SSfIND.Count;
            }

            if (words[1].ToString() == "StatusPorRevisar")
            {
                SubSonicDB.ArboladoGridCollection SSfIND = new SubSonicDB.ArboladoGridCollection()
               .Where(SubSonicDB.ArboladoGrid.Columns.IDDepende, 6090)
               .Where(SubSonicDB.ArboladoGrid.Columns.ValueX, IDUserx)
               .Where(SubSonicDB.ArboladoGrid.Columns.IDTIpoContenido, 3)
               .Where(SubSonicDB.ArboladoGrid.Columns.IDStatusCorrespondencia, 10)
               .BetweenAnd(SubSonicDB.ArboladoGrid.Columns.Fechaconoce, fechaInicio, fechaFin)
               .Load();
                RadGrid2.Visible = true;
                RadGrid1.Visible = false;
                RadGrid2.DataSource = SSfIND;
                RadGrid2.DataBind();
                TotaldeRegistros.Text = "Total de registros: " + SSfIND.Count;
            }

            FillValues(RadComboBoxGrafic.SelectedValue);

        }
    }
}
public class Car
{
    public Car(string DESCRIPCION, int Id, int IDPARENT)
    {
        _DESCRIPCION = DESCRIPCION;
        _Id = Id;
        _Iddepende = IDPARENT;
    }
    private string _DESCRIPCION;
    public string DESCRIPCION
    {
        get { return _DESCRIPCION; }
        set { _DESCRIPCION = value; }
    }
    private int _Id;
    public int Id
    {
        get { return _Id; }
        set { _Id = value; }
    }
    private int _Iddepende;
    public int Iddepende
    {
        get { return _Iddepende; }
        set { _Iddepende = value; }
    }
}