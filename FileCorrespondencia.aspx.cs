using System;
using System.IO;
using System.Threading;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
namespace WebApplication2
{
    public partial class FileCorrespondencia : System.Web.UI.Page
    {
        ClassSesion classSesion = new ClassSesion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                //CheckBoxRegresaCorresp.Checked = false;
                RadDatePicker1.SelectedDate = DateTime.Now;
                FillTipoArchivo();

                RadImageGallery2.ImagesFolderPath = "~/files/ArchivoDigital/" + classSesion.VerExpediente;
                SubSonicDB.Expediente ssExpediente = SubSonicDB.Expediente.FetchByID(classSesion.VerExpediente);
                Label5.Text = ssExpediente.Descripcion;

            }

        }
        public string randomNumber()
        {
            var random = new Random();
            int randomNumber = random.Next(10, 99999);
            return randomNumber.ToString();
        }
        protected void RadAsyncUpload1_FileUploaded1(object sender, FileUploadedEventArgs e)
        {

            string path = Server.MapPath("~/files/ArchivoDigital/" + classSesion.VerExpediente + "/");

            if (Directory.Exists(path))
            {
            }
            else
            {
                Directory.CreateDirectory(path);
            }
            string NombreImg = randomNumber();
            int milliseconds = 1000;
            Thread.Sleep(milliseconds);
            e.File.SaveAs(path + NombreImg + e.File.GetExtension());

            RadImageGallery2.ImagesFolderPath = "~/files/ArchivoDigital/" + classSesion.VerExpediente;
            RadImageGallery2.Rebind();





        }


        public void FillTipoArchivo()
        {
            DropDownListTipoARchivo.Items.Clear();
            DropDownListTipoARchivo.Text = "";


            //   List<ClassReporte> ssClassReporte = new List<ClassReporte>();

            SubSonicDB.CatTipoArchivoInventarioCollection ssInventarios = new SubSonicDB.CatTipoArchivoInventarioCollection()
                .Where(SubSonicDB.CatTipoArchivoInventario.Columns.Status, true)
                .Load();
            foreach (SubSonicDB.CatTipoArchivoInventario ssTio in ssInventarios)
            {
                //    ClassReporte ssAdd = new ClassReporte();
                //   ssAdd.AgregarElemento(ssTio.Id.ToString(), ssTio.Descripcion, "X");
                //     ssClassReporte.Add(ssAdd);


                ListItem listItem = new ListItem(ssTio.Descripcion, ssTio.Id.ToString());
                DropDownListTipoARchivo.Items.Add(listItem);


            }



            //  SubSonicDB.ViewReporteInventarioExpedienteCollection ssReporteExpe = new SubSonicDB.ViewReporteInventarioExpedienteCollection()
            //.Where(SubSonicDB.ViewReporteInventarioExpediente.Columns.IDExpediente, classSesion.VerExpediente)
            //.Load();

            //foreach (SubSonicDB.ViewReporteInventarioExpediente ssReporte in ssReporteExpe)
            //{

            //    ///      var itemToRemove = ssClassReporte.SingleOrDefault(r => r.ID == ssReporte.Id.ToString());


            //    ssClassReporte.RemoveAll(x => x.ID.ToString().Equals(ssReporte.Id.ToString()));


            //}















            //SubSonicDB.CatTipoArchivoInventarioCollection sscatTipoArchivoInventarios = new SubSonicDB.CatTipoArchivoInventarioCollection()
            //        .Where(SubSonicDB.CatTipoArchivoInventario.Columns.Status, true)
            //        .Load();


            //foreach (ClassReporte valor in ssClassReporte)
            //{

            //    ListItem listItem = new ListItem(valor.DESCRIPCION, valor.ID);
            //    DropDownListTipoARchivo.Items.Add(listItem);

            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(DropDownListTipoARchivo.SelectedValue) != 12)
            {
                //AQUI SE ESTARA SUBIENDO LAS IMAGENES
                Boolean fileOK = false;
                String path = Server.MapPath("~/files/Correspondencia/");
                string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                if (!string.IsNullOrEmpty(fileExtension))
                {
                    String[] allowedExtensions = { ".pdf", ".png", ".jpg", ".doc", ".docx", ".xlsx", ".xls" };
                    for (int i = 0; i < allowedExtensions.Length; i++)
                    {
                        if (fileExtension == allowedExtensions[i])
                        {
                            fileOK = true;
                            continue;
                        }
                    }
                    if (fileOK)
                    {
                        try
                        {
                            // string NombreArchivo = Request.QueryString["ID"].Remove(0,1);
                            //string NombreArchivo = Request.QueryString["ID"];
                            string NombreArchivo = classSesion.VerExpediente.ToString();
                            //     UltimaActualizacion(Convert.ToInt32(ssSesiones.Usua), Convert.ToInt32(NombreArchivo));

                            SubSonicDB.ArchivoCorrespondencium ssExpedientes = new SubSonicDB.ArchivoCorrespondencium();
                            ssExpedientes.Nombre = System.IO.Path.GetFileNameWithoutExtension(FileUpload1.FileName).ToLower();
                            ssExpedientes.Extencion = fileExtension;
                            ssExpedientes.Status = true;
                            //  ssExpedientes.IDExpediente = Convert.ToInt32(Request.QueryString["ID"]);
                            ssExpedientes.IDExpediente = Convert.ToInt32(classSesion.VerExpediente);
                            ssExpedientes.DateX = RadDatePicker1.SelectedDate;
                            ssExpedientes.Descripcion = TextBox1.Text.ToUpper();
                            ssExpedientes.IDTipo = 2;
                            ssExpedientes.IDUserCarga = Convert.ToInt32(classSesion.IDUsua);
                            ssExpedientes.IDInventario = Convert.ToInt32(DropDownListTipoARchivo.SelectedValue);


                            ssExpedientes.Save();
                            // VerificarSiExiste(ssExpedientes.Descripcion, fileExtension);
                            //  String fileExtensions = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                            FileUpload1.SaveAs(path + ssExpedientes.Id + fileExtension);
                            // Button1.Visible = false;
                            Label1.Text = "Se han cargado correctamente";
                            Label1.Visible = true;
                            SubSonicDB.Expediente ssExpeDien = SubSonicDB.Expediente.FetchByID(classSesion.VerExpediente);
                            ssExpeDien.IDStatusCorrespondencia = 12;
                            ssExpeDien.Save();
                            RadGrid2.Rebind();
                            TextBox1.Text = "";





                        }
                        catch (Exception)
                        {
                            Label1.Text = "Ocurrió un error al cargar el archivo comuniquese al administrador del sistema";
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Ha ocurrido un error al guardar');</script>", false);

                        }
                    }
                }
                else
                {

                    try
                    {
                        string NombreArchivo = classSesion.VerExpediente.ToString();

                        SubSonicDB.ArchivoCorrespondencium ssExpedientes = new SubSonicDB.ArchivoCorrespondencium();
                        ssExpedientes.Nombre = "Sin Archivo";
                        ssExpedientes.Extencion = "note";
                        ssExpedientes.Status = true;
                        ssExpedientes.IDExpediente = Convert.ToInt32(classSesion.VerExpediente);
                        ssExpedientes.DateX = RadDatePicker1.SelectedDate;
                        ssExpedientes.Descripcion = TextBox1.Text.ToUpper();
                        ssExpedientes.IDTipo = 2;
                        ssExpedientes.IDUserCarga = Convert.ToInt32(classSesion.IDUsua);
                        /*************************************ENTRA EN CASO DE QUE REGRESE CORRESPONDENCIA A RECEPCION*********************************************/
                        if (Convert.ToInt16(DropDownListTipoARchivo.SelectedValue) == 12)
                        {

                            ssExpedientes.StatusCorresponde = true;
                        }
                        /*******************************************************************************************************************************************/
                        ssExpedientes.Save();

                        // VerificarSiExiste(ssExpedientes.Descripcion, fileExtension);
                        //  String fileExtensions = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                        // FileUpload1.SaveAs(path + ssExpedientes.Id + fileExtension);
                        // Button1.Visible = false;
                        Label1.Text = "Se han cargado correctamente";
                        Label1.Visible = true;


                        SubSonicDB.Expediente ssExpeDien = SubSonicDB.Expediente.FetchByID(classSesion.VerExpediente);


                        /*************************************ENTRA EN CASO DE QUE REGRESE CORRESPONDENCIA A RECEPCION*********************************************/
                        if (Convert.ToInt16(DropDownListTipoARchivo.SelectedValue) == 12)
                        {
                            ssExpeDien.StatusRetornado = true;

                        }
                        /*******************************************************************************************************************************************/
                        ssExpeDien.IDStatusCorrespondencia = 12;
                        ssExpeDien.Save();

                        RadGrid2.Rebind();
                        TextBox1.Text = "";








                        //  ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua), 10, ssExpedientes.Descripcion);
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Se ha guardado correctamente');</script>", false);
                    }
                    catch
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Ha ocurrido un error al guardar');</script>", false);
                    }
                }



            }
            else
            {

                ///ESTE ES EL CASO DE QUE AL QUE SE LE ENVIO NO LE CORRESPONDE EL TEMA ATENDERLO Y LO DETALLA 
                string NombreArchivo = classSesion.VerExpediente.ToString();

                SubSonicDB.ArchivoCorrespondencium ssExpedientes = new SubSonicDB.ArchivoCorrespondencium();
                //ssExpedientes.Nombre = System.IO.Path.GetFileNameWithoutExtension(FileUpload1.FileName).ToLower();
                ssExpedientes.Nombre = "Sin Archivo";
                ssExpedientes.Extencion = ".note";
                ssExpedientes.Status = true;
                ssExpedientes.IDExpediente = Convert.ToInt32(classSesion.VerExpediente);
                //ssExpedientes.IDExpediente =1;
                ssExpedientes.DateX = RadDatePicker1.SelectedDate;
                ssExpedientes.Descripcion = TextBox1.Text.ToUpper();
                ssExpedientes.IDTipo = 2;//AQUI SE INDICA QUE ESTE ARCHIVO ES DE TIPO CONTESTACIÓN;
                ssExpedientes.IDUserCarga = Convert.ToInt32(classSesion.IDUsua);
                ssExpedientes.IDInventario = Convert.ToInt32(DropDownListTipoARchivo.SelectedValue);
                ssExpedientes.Save();
                //FileUpload1.SaveAs(path + ssExpedientes.Id + fileExtension);

                Label1.Text = "Se han cargado correctamente";
                Label1.Visible = true;
                SubSonicDB.Expediente ssExpeDien = SubSonicDB.Expediente.FetchByID(classSesion.VerExpediente);
                ssExpeDien.IDStatusCorrespondencia = 12;
                // ssExpeDien.Save();
                RadGrid2.Rebind();
                TextBox1.Text = "";








            }
            // FillTipoArchivo();

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Se ha guardado correctamente');</script>", false);

        }

        protected void RadGrid1_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {

            SubSonicDB.ViewContestacionCorresponCollection ssEjemplo = new SubSonicDB.ViewContestacionCorresponCollection()
                //.Where(SubSonicDB.ViewContestacionCorrespon.Columns.IDExpediente, Request.QueryString["ID"])
                .Where(SubSonicDB.ViewContestacionCorrespon.Columns.IDExpediente, Convert.ToInt32(classSesion.VerExpediente))
                .OrderByDesc(SubSonicDB.ViewContestacionCorrespon.Columns.Id)
                .Load();

            RadGrid2.DataSource = ssEjemplo;
        }




        public bool ProcessMyDataItem(object n)
        {

            SubSonicDB.ArchivoCorrespondencium ValorClave = SubSonicDB.ArchivoCorrespondencium.FetchByID(n.ToString());

            if (ValorClave.Extencion == ".note")
            {

                return false;
            }
            else
            {

                return true;
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        //protected void CheckBoxRegresaCorresp_CheckedChanged(object sender, EventArgs e)
        //{

        //    if (ecked == true)
        //    {
        //        LabelRecomendacion.Visible = true;
        //        LabelRecomendacion.Text = "Rellena la causa del retorno de la correspondencia en la caja de texto de la descripción. Por último da click en el Boton de confirmar";
        //    }
        //    else
        //    {

        //        LabelRecomendacion.Visible = false;
        //        LabelRecomendacion.Text = "";


        //    }
        //}
    }
}