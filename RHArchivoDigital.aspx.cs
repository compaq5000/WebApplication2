using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using System.Threading;
using System.IO;
using System.Web.UI.WebControls;


namespace WebApplication2
{
    public partial class RHArchivoDigital : System.Web.UI.Page
    {
        ClassSesion classSesion = new ClassSesion();

        protected void RadGrid3_ItemCommandCorrespondencia(object sender, GridCommandEventArgs e)
        {

            if (e.CommandName.ToString() != "Page")
            {
                if (e.CommandName.ToString() != "ChangePageSize")
                {
                    string g = e.CommandArgument.ToString();
                    string[] words = g.Split(' ');

                    //classSesion.VerExpediente = words[0];
                    // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>window.open('../rhhome.aspx', '_blank');</script>", false);
                    SubSonicDB.RelCatArchivoDigitalRH ssQuitar = SubSonicDB.RelCatArchivoDigitalRH.FetchByID(words[0]);
                    ssQuitar.Status = false;
                    ssQuitar.Save();


                    RadGrid2.Rebind();
                    FillTipoArchivo();



                }
            }




        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ValidaSihayCarpeta(classSesion.VerExpediente);
                FillTipoArchivo();
                RadImageGallery2.ImagesFolderPath = "~/files/PERSONAL/" + classSesion.VerExpediente;
                //SubSonicDB.Expediente ssExpediente = SubSonicDB.Expediente.FetchByID("2");
                SubSonicDB.CatUsuario ssUsuario = SubSonicDB.CatUsuario.FetchByID(classSesion.VerExpediente);
                Label5.Text = ssUsuario.Nom + ' ' + ssUsuario.Paterno + ' ' + ssUsuario.Materno;
            }
        }
        public void ValidaSihayCarpeta(string Usuario)
        {
            string path = Server.MapPath("~/files/PERSONAL/" + Usuario + "/");
            if (Directory.Exists(path))
            {
            }
            else
            {
                Directory.CreateDirectory(path);
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
            string path = Server.MapPath("~/files/Personal/" + classSesion.VerExpediente + "/");

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

            RadImageGallery2.ImagesFolderPath = "~/files/Personal/" + classSesion.VerExpediente;
            RadImageGallery2.Rebind();





        }
        public void FillTipoArchivo()
        {
            DropDownListTipoARchivo.Items.Clear();
            DropDownListTipoARchivo.Text = "";


            List<ClassReporte> ssClassReporte = new List<ClassReporte>();


            SubSonicDB.CatArchivoDigitalRhCollection ssArchivosDigitales = new SubSonicDB.CatArchivoDigitalRhCollection()
            .Load();

            foreach (SubSonicDB.CatArchivoDigitalRh ssTio in ssArchivosDigitales)
            {
                ClassReporte ssAdd = new ClassReporte();
                ssAdd.AgregarElemento(ssTio.Id.ToString(), ssTio.Descripcion, "X");
                ssClassReporte.Add(ssAdd);
            }


            SubSonicDB.ViewArchivoDigitalRHCollection ssReporteExpe = new SubSonicDB.ViewArchivoDigitalRHCollection()
                .Where(SubSonicDB.ViewArchivoDigitalRH.Columns.IDUasuario, classSesion.VerExpediente)
                .Load();

            // SubSonicDB.ViewReporteInventarioExpedienteCollection ssReporteExpe = new SubSonicDB.ViewReporteInventarioExpedienteCollection()
            //.Where(SubSonicDB.ViewReporteInventarioExpediente.Columns.IDExpediente, "2")
            //.Load();

            foreach (SubSonicDB.ViewArchivoDigitalRH ssReporte in ssReporteExpe)
            {

                ///      var itemToRemove = ssClassReporte.SingleOrDefault(r => r.ID == ssReporte.Id.ToString());


                ssClassReporte.RemoveAll(x => x.ID.ToString().Equals(ssReporte.IDArcivodigital.ToString()));


            }















            //SubSonicDB.CatTipoArchivoInventarioCollection sscatTipoArchivoInventarios = new SubSonicDB.CatTipoArchivoInventarioCollection()
            //        .Where(SubSonicDB.CatTipoArchivoInventario.Columns.Status, true)
            //        .Load();


            foreach (ClassReporte valor in ssClassReporte)
            {

                ListItem listItem = new ListItem(valor.DESCRIPCION, valor.ID);
                DropDownListTipoARchivo.Items.Add(listItem);

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            //AQUI SE ESTARA SUBIENDO LAS IMAGENES
            Boolean fileOK = false;
            String path = Server.MapPath("~/files/personal/");
            string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
            if (!string.IsNullOrEmpty(fileExtension))
            {
                String[] allowedExtensions = { ".pdf", ".png", ".jpg", ".doc", ".docx", ".xlsx", ".xls" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
                if (fileOK)
                {
                    try
                    {
                        // string NombreArchivo = Request.QueryString["ID"].Remove(0,1);
                        //string NombreArchivo = Request.QueryString["ID"];
                        // string NombreArchivo = classSesion.VerExpediente.ToString();
                        //     UltimaActualizacion(Convert.ToInt32(ssSesiones.Usua), Convert.ToInt32(NombreArchivo));

                        SubSonicDB.RelCatArchivoDigitalRH ssExpedientes = new SubSonicDB.RelCatArchivoDigitalRH();


                        //SubSonicDB.ArchivoCorrespondencium ssExpedientes = new SubSonicDB.ArchivoCorrespondencium();
                        ssExpedientes.NombreArchivo = System.IO.Path.GetFileNameWithoutExtension(FileUpload1.FileName).ToLower();
                        ssExpedientes.IDArcivodigital = Convert.ToInt32(DropDownListTipoARchivo.SelectedValue);
                        ssExpedientes.IDUasuario = Convert.ToInt32(classSesion.VerExpediente);
                        ssExpedientes.Status = true;
                        ssExpedientes.Extension = fileExtension;
                        ssExpedientes.FechaCarga = DateTime.Now;
                        // ssExpedientes.IDExpediente = Convert.ToInt32(Request.QueryString["ID"]);
                        ///ssExpedientes.IDExpediente = Convert.ToInt32(classSesion.VerExpediente);

                        ssExpedientes.Detalle = TextBox1.Text.ToUpper();

                        ssExpedientes.CargadoPor = Convert.ToInt32(1);
                        //ssExpedientes.IDTipo = 2;


                        ssExpedientes.Save();
                        // VerificarSiExiste(ssExpedientes.Descripcion, fileExtension);
                        //  String fileExtensions = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                        FileUpload1.SaveAs(path+ + ssExpedientes.Id + fileExtension);
                        // Button1.Visible = false;
                        Label1.Text = "Se han cargado correctamente";
                        Label1.Visible = true;
                        //SubSonicDB.Expediente ssExpeDien = SubSonicDB.Expediente.FetchByID(classSesion.VerExpediente);
                        //ssExpeDien.IDStatusCorrespondencia = 12;
                        //ssExpeDien.Save();
                        RadGrid2.Rebind();
                        TextBox1.Text = "";

                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('el archivo se ha cargado correctamente');</script>", false);



                    }
                    catch (Exception Ex)
                    {
                        Label1.Text = "Ocurrió un error al cargar el archivo comuniquese al administrador del sistema";
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Ha ocurrido un error al guardar');</script>", false);

                    }
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('No se encontró un archivo para cargar, seleccione uno porfavor');</script>", false);

            }




            FillTipoArchivo();


        }
        protected void RadGrid1_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            SubSonicDB.ViewArchivoDigitalRHCollection ssArchivoDigital = new SubSonicDB.ViewArchivoDigitalRHCollection()
                 .Where(SubSonicDB.ViewArchivoDigitalRH.Columns.IDUasuario, classSesion.VerExpediente)
                 .Load();
            RadGrid2.DataSource = ssArchivoDigital;
        }

    }
}