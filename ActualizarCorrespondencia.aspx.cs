using System;
using System.Web.UI;

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
                        SubSonicDB.ArchivoCorrespondencium ssNewDocumento = new SubSonicDB.ArchivoCorrespondencium();
                        ssNewDocumento.Nombre = System.IO.Path.GetFileNameWithoutExtension(FileUpload1.FileName).ToLower();
                        ssNewDocumento.Extencion = fileExtension;
                        ssNewDocumento.Status=true;
                        ssNewDocumento.IDExpediente=Convert.ToInt32(ssSesiones.VerExpediente);
                        ssNewDocumento.DateX=DateTime.Now;
                        ssNewDocumento.IDTipo = 1;
                        ssNewDocumento.IDUserCarga =Convert.ToInt32( ssSesiones.IDUsua);
                        ssNewDocumento.Save();  

                        SubSonicDB.ArchivoCorrespondencium ssArchivo = new SubSonicDB.ArchivoCorrespondencium();
                        ssArchivo.LoadByParam(SubSonicDB.ArchivoCorrespondencium.Columns.IDExpediente, NombreArchivo);
                        ssArchivo.Extencion = fileExtension;
                        ssArchivo.DateX = DateTime.Now;
                        ssArchivo.IDUserCarga = Convert.ToInt32(ssSesiones.IDUsua);
                        ssArchivo.Save();

                        FileUpload1.SaveAs(path + ssNewDocumento.Id + fileExtension);

                        //sender carga el nuevo archivo y se inhabilita el anterior

                        SubSonicDB.ArchivoCorrespondenciumCollection ssexpediente1 = new SubSonicDB.ArchivoCorrespondenciumCollection()
              .Where(SubSonicDB.ArchivoCorrespondencium.Columns.IDExpediente, ssSesiones.VerExpediente)
              .Where(SubSonicDB.ArchivoCorrespondencium.Columns.IDTipo,1)
              .Where(SubSonicDB.ArchivoCorrespondencium.Columns.Status,true)
              .Load();


                        SubSonicDB.ArchivoCorrespondencium ssCambiar = SubSonicDB.ArchivoCorrespondencium.FetchByID(ssexpediente1[0].Id);
                        ssCambiar.Status = false;
                        ssCambiar.Save();

                        RadGrid2.Rebind();

                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "customScript", "<script>alert('Se ha guardado correctamente');</script>", false);
                    }
                    catch (Exception )
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


        public bool ProcessMyDataItem(object n)
        {

            return true;
        }

        protected void RadGrid1_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {

            //CREAR UNA VISTA CON LOS DATOS SOLICITADOS PARA LLENAR EL GRID CON LA ULTIMAACTUA

            SubSonicDB.ViewHistorialArchivoCorrespondenciumCollection ssExiste = new SubSonicDB.ViewHistorialArchivoCorrespondenciumCollection()
                .Where(SubSonicDB.ViewHistorialArchivoCorrespondencium.Columns.IDExpediente,ssSesiones.VerExpediente)
                .OrderByDesc(SubSonicDB.ViewHistorialArchivoCorrespondencium.Columns.Id)
                .Load();
            RadGrid2.DataSource = ssExiste;

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