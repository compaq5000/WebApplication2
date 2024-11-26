using System;

namespace WebApplication2
{
    public partial class NewFoto : System.Web.UI.Page
    {
        ClassSesion ssSesiones = new ClassSesion();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 10000);


            //AQUI SE ESTARA SUBIENDO LAS IMAGENES
            Boolean fileOK = false;
            String path = Server.MapPath("~/IMG/Users/");

            string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
            if (!string.IsNullOrEmpty(fileExtension))
            {
                String[] allowedExtensions = { ".jpg", ".png", ".gif", ".icon" };
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
                        string NombreUser;
                        SubSonicDB.CatUsuario ssUser = SubSonicDB.CatUsuario.FetchByID(ssSesiones.VerExpediente);

                        String fileExtensions = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                        string NombreArchi = System.IO.Path.GetFileNameWithoutExtension(FileUpload1.FileName).ToLower();
                        int num = random.Next(10000);
                        ssUser.Extension = fileExtension;
                        FileUpload1.SaveAs(path + NombreArchi + randomNumber + fileExtension);
                        ssUser.Imagen = NombreArchi + randomNumber;
                        ssUser.Save();
                        Button1.Visible = false;
                        Label2.Text = "Se han cargado correctamente";
                        Label1.Visible = true;
                        // ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua), 10, ssExpedientes.Descripcion);
                    }
                    catch (Exception ex)
                    {
                        Label1.Text = "Ocurrió un error al cargar el archivo comuniquese al administrador del sistema";
                        Label2.Text = ex.ToString();
                    }
                }
            }
        }
    }
}