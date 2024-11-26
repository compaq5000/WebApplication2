using System;
using System.Web.UI;
using System.IO;



namespace WebApplication2
{


    public partial class UploadCorrespondencia : System.Web.UI.Page
    {
        ClassSesion ssSesiones = new ClassSesion();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //AQUI SE ESTARA SUBIENDO LAS IMAGENES
            Boolean fileOK = false;
            String path = Server.MapPath("~/files/Correspondencia/");
            string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
            if (!string.IsNullOrEmpty(fileExtension))
            {
                //String[] allowedExtensions = { ".pdf, .xls, .xlsx, .doc, .docx" };
                //for (int i = 0; i < allowedExtensions.Length; i++)
                //{
                //    if (fileExtension == allowedExtensions[i])
                //    {
                fileOK = true;
                //    }
                //}
                if (fileOK)
                {
                    try
                    {
                        // string NombreArchivo = Request.QueryString["ID"].Remove(0,1);
                        string NombreArchivo = Request.QueryString["ID"];
                        SubSonicDB.ArchivoCorrespondencium ssArchivo = new SubSonicDB.ArchivoCorrespondencium();
                        ssArchivo.Nombre = System.IO.Path.GetFileNameWithoutExtension(FileUpload1.FileName).ToLower(); 
                        ssArchivo.Extencion = fileExtension;
                        ssArchivo.Status = true;
                        ssArchivo.IDExpediente = Convert.ToInt32(NombreArchivo);
                        ssArchivo.IDTipo = 1;
                        ssArchivo.DateX = DateTime.Now;
                        ssArchivo.IDUserCarga = Convert.ToInt32(ssSesiones.IDUsua);
                        
                        ssArchivo.Save();

                        FileUpload1.SaveAs(path + ssArchivo.Id + fileExtension);


                        //if (ssSesiones.EnviarCorreo())
                        //{
                        //    //  ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua), 10, ssExpedientes.Descripcion);
                        //    //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Se ha guardado correctamente');</script>", false);
                        //}
                        //else
                        //{
                        //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Se ha guardado correctamente. Pero no se pudo enviar el correo a algunos usuarios');</script>", false);
                        //};

                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Se ha guardado correctamente');</script>", false);
                    }
                    catch (Exception ex)
                    {
                        // Label1.Text = "Ocurrió un error al cargar el archivo comuniquese al administrador del sistema";
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Ha ocurrido un error al guardar');</script>", false);

                    }
                }
            }
            else
            {
                //string NombreArchivo = Request.QueryString["ID"];
                //UltimaActualizacion(Convert.ToInt32(ssSesiones.Usua), Convert.ToInt32(NombreArchivo));

            }
            //crear el archivo de correspondencia
            string path1 = Server.MapPath("~/files/ArchivoDigital/" + Request.QueryString["ID"] + "/");
            if (Directory.Exists(path1))
            {
            }
            else
            {
                Directory.CreateDirectory(path1);
            }
        }
    }
}