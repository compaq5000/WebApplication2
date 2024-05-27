using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class ActualizarCorrespondencia : System.Web.UI.Page
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

                        string NombreArchivo = ssSesiones.VerExpediente;



                        SubSonicDB.ArchivoCorrespondencium ssArchivo = new SubSonicDB.ArchivoCorrespondencium();
                        ssArchivo.LoadByParam(SubSonicDB.ArchivoCorrespondencium.Columns.IDExpediente, NombreArchivo);
                        ssArchivo.Extencion = fileExtension;
                        ssArchivo.DateX = DateTime.Now;
                        ssArchivo.IDUserCarga = Convert.ToInt32(ssSesiones.IDUsua);
                        ssArchivo.Save();

                        FileUpload1.SaveAs(path + ssArchivo.Id + fileExtension);

                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Se ha guardado correctamente');</script>", false);
                    }
                    catch (Exception)
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
        }










        //public void UltimaActualizacion(int IDUser, int IDExpediente)
        //{
        //    SubsonicDB.HistirlaExpedienteCollection ssExiste = new SubsonicDB.HistirlaExpedienteCollection()
        //           .Where(SubsonicDB.HistirlaExpediente.Columns.IDExpediente, IDExpediente)
        //           .Where(SubsonicDB.HistirlaExpediente.Columns.Status, true)
        //           .Load();
        //    if (ssExiste.Count > 0)
        //    {
        //        SubsonicDB.HistirlaExpediente ssExpediente = SubsonicDB.HistirlaExpediente.FetchByID(ssExiste[0].Id);
        //        ssExpediente.Status = false;
        //        ssExpediente.Save();
        //        SubsonicDB.HistirlaExpediente ssNewActualizacion = new SubsonicDB.HistirlaExpediente();
        //        ssNewActualizacion.IDExpediente = Convert.ToInt32(IDExpediente);
        //        ssNewActualizacion.IDUsuario = IDUser;
        //        ssNewActualizacion.Actualizado = DateTime.Now;
        //        ssNewActualizacion.Status = true;
        //        ssNewActualizacion.Detalle = TextBox1.Text.ToUpper();
        //        ssNewActualizacion.IDEtapa = Convert.ToInt32(RadComboBoxEtapa.SelectedValue);
        //        ssNewActualizacion.Save();
        //        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Se ha guardado correctamente');</script>", false);

        //    }
        //    else
        //    {
        //        SubsonicDB.HistirlaExpediente ssNewActualizacion = new SubsonicDB.HistirlaExpediente();
        //        ssNewActualizacion.IDExpediente = Convert.ToInt32(IDExpediente);
        //        ssNewActualizacion.IDUsuario = IDUser;
        //        ssNewActualizacion.Actualizado = DateTime.Now;
        //        ssNewActualizacion.Status = true;
        //        ssNewActualizacion.Detalle = TextBox1.Text.ToUpper();
        //        ssNewActualizacion.IDEtapa = Convert.ToInt32(RadComboBoxEtapa.SelectedValue);
        //        ssNewActualizacion.Save();
        //        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Se ha guardado correctamente');</script>", false);

        //    }
        //    SubsonicDB.Expediente sssexpediente = SubsonicDB.Expediente.FetchByID(IDExpediente);
        //    sssexpediente.Actualizacion = DateTime.Now;
        //    sssexpediente.IDEtapa = Convert.ToInt32(RadComboBoxEtapa.SelectedValue);
        //    sssexpediente.Save();

        //    ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua), 11, sssexpediente.Descripcion);

        //}


    }
}