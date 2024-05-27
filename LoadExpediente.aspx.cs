using System;
using System.Net;
using System.IO;
using System.Windows;
using Telerik.Pdf;
using Telerik.Web.UI;
using System.Web;

namespace WebApplication2
{
    public partial class LoadExpediente : System.Web.UI.Page
    {
        ClassSesion ssSesiones = new ClassSesion();
        //string FilePath;
        // private const string ProviderSessionKey = "Telerik.Web.Examples.SpreadSheet.Overview.LoadExpediente";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ssSesiones.IDUsua == "1")
            {

                string[] weekDays = new string[] { "pager", "spacer", "zoom", "download" };
                RadPdfViewer1.ToolBarSettings.Items = weekDays;
            }
            else
            {
                string[] weekDays = new string[] { "pager", "spacer", "zoom" };
                RadPdfViewer1.ToolBarSettings.Items = weekDays;
            }
            string g = ssSesiones.VerExpediente;
            SubSonicDB.Expediente ssexpediente = SubSonicDB.Expediente.FetchByID(g);
            SubSonicDB.ArchivoCorrespondenciumCollection ssexpediente1 = new SubSonicDB.ArchivoCorrespondenciumCollection()
                .Where(SubSonicDB.ArchivoCorrespondencium.Columns.IDExpediente, ssSesiones.VerExpediente)
                .Load();
            try
            {
                ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua), 21, ssexpediente1[0].Expediente.Descripcion);
                string FilePath = Server.MapPath("~/files/correspondencia/" + ssexpediente1[0].Id + ssexpediente1[0].Extencion);

                ssSesiones.PathCorrespondencia = Server.MapPath("~/files/correspondencia/" + ssexpediente1[0].Id + ssexpediente1[0].Extencion);

                bool Existe = File.Exists(Server.MapPath("~/files/correspondencia/" + ssexpediente1[0].Id + ssexpediente1[0].Extencion));
                if (Existe)
                {
                    WebClient User = new WebClient();
                    Byte[] FileBuffer = User.DownloadData(FilePath);
                    if (FileBuffer != null)
                    {
                        if (ssexpediente1[0].Extencion == ".pdf")
                        {

                            //string FilePath = FilePath;
                            //WebClient User = new WebClient();
                            //Byte[] FileBuffer1 = User.DownloadData(FilePath);

                            //string FilePath = Server.MapPath("javascript1-sample.pdf");
                            //WebClient User = new WebClient();
                            //Byte[] FileBuffer = User.DownloadData(FilePath);

                            Response.ContentType = "application/pdf";
                            Response.AddHeader("content-length", FileBuffer.Length.ToString());
                            Response.BinaryWrite(FileBuffer);

                            RadPdfViewer1.PdfjsProcessingSettings.File = "/files/correspondencia/" + ssexpediente1[0].Id + ".pdf";
                            //RadPdfViewer1.Visible = false;



                            //if (ssexpediente1[0].Extencion == ".xlsx")
                            //{
                            //Response.ClearContent();
                            //Response.ClearHeaders();
                            //Response.ContentType = "application/pdf";
                            //Response.AddHeader("content-disposition", "attachment; filename=Nombre.pdf");
                            //HttpContext.Current.Response.BinaryWrite(System.IO.File.ReadAllBytes(FilePath));
                            //Response.Flush();
                            //Response.End();


                            //}

                        }
                    }
                }

                else
                {

                    Response.Redirect("~/notexist.aspx");
                }

            }
            catch (Exception)
            {

                string filepath = ssSesiones.PathCorrespondencia;
                //string filepath = Server.MapPath("~/files/correspondencia/" + "20547" + ".pdf");



                // Get the physical Path of the file
                // string filepath = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath + "/files/correspondencia/20547.pdf";

                // Create New instance of FileInfo class to get the properties of the file being downloaded
                FileInfo file = new FileInfo(filepath);

                // Checking if file exists
                if (file.Exists)
                {
                    // Clear the content of the response
                    Response.ClearContent();

                    // LINE1: Add the file name and attachment, which will force the open/cance/save dialog to show, to the header
                    Response.AddHeader("Content-Disposition", String.Format("attachment; filename={0}", file.Name));

                    // Add the file size into the response header
                    Response.AddHeader("Content-Length", file.Length.ToString());

                    // Set the ContentType
                    Response.ContentType = ReturnFiletype(file.Extension.ToLower());

                    // Write the file into the response (TransmitFile is for ASP.NET 2.0. In ASP.NET 1.1 you have to use WriteFile instead)
                    Response.TransmitFile(file.FullName);

                    // End the response
                    Response.End();

                    //send statistics to the class
                }

                Response.Redirect("~/notexist.aspx");
            }

        }
        public static string ReturnFiletype(string fileExtension)
        {
            switch (fileExtension)
            {
                case ".htm":
                case ".html":
                case ".log":
                    return "text/HTML";
                case ".txt":
                    return "text/plain";
                case ".doc":
                    return "application/ms-word";
                case ".tiff":
                case ".tif":
                    return "image/tiff";
                case ".asf":
                    return "video/x-ms-asf";
                case ".avi":
                    return "video/avi";
                case ".zip":
                    return "application/zip";
                case ".xls":
                case ".csv":
                    return "application/vnd.ms-excel";
                case ".gif":
                    return "image/gif";
                case ".jpg":
                case "jpeg":
                    return "image/jpeg";
                case ".bmp":
                    return "image/bmp";
                case ".wav":
                    return "audio/wav";
                case ".mp3":
                    return "audio/mpeg3";
                case ".mpg":
                case "mpeg":
                    return "video/mpeg";
                case ".rtf":
                    return "application/rtf";
                case ".asp":
                    return "text/asp";
                case ".pdf":
                    return "application/pdf";
                case ".fdf":
                    return "application/vnd.fdf";
                case ".ppt":
                    return "application/mspowerpoint";
                case ".dwg":
                    return "image/vnd.dwg";
                case ".msg":
                    return "application/msoutlook";
                case ".xml":
                case ".sdxl":
                    return "application/xml";
                case ".xdp":
                    return "application/vnd.adobe.xdp+xml";
                default:
                    return "application/octet-stream";
            }
        }
        protected void RadButton1_Click(object sender, EventArgs e)
        {

            string g = ssSesiones.VerExpediente;
            SubSonicDB.Expediente ssexpediente = SubSonicDB.Expediente.FetchByID(g);
            SubSonicDB.ArchivoCorrespondenciumCollection ssexpediente1 = new SubSonicDB.ArchivoCorrespondenciumCollection()
                .Where(SubSonicDB.ArchivoCorrespondencium.Columns.IDExpediente, ssSesiones.VerExpediente)
                .Load();
            ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua), 21, ssexpediente1[0].Expediente.Descripcion);
            string FilePath = Server.MapPath("~/files/correspondencia/" + ssexpediente1[0].Id + ssexpediente1[0].Extencion);
            bool Existe = File.Exists(Server.MapPath("~/files/correspondencia/" + ssexpediente1[0].Id + ssexpediente1[0].Extencion));
            if (Existe)
            {
                WebClient User = new WebClient();
                Byte[] FileBuffer = User.DownloadData(FilePath);
                if (FileBuffer != null)
                {
                    Response.ContentType = ("application/pdf");
                    Response.AddHeader("content-length", FileBuffer.Length.ToString());
                    Response.BinaryWrite(FileBuffer);

                }
            }
        }

        //protected void RadButton1_Click(object sender, EventArgs e)
        //{
        //    if (ssSesiones.IDUsua == "1")
        //    {

        //        string[] weekDays = new string[] { "pager", "spacer", "zoom", "download" };
        //        RadPdfViewer1.ToolBarSettings.Items = weekDays;
        //    }
        //    else
        //    {
        //        string[] weekDays = new string[] { "pager", "spacer", "zoom" };
        //        RadPdfViewer1.ToolBarSettings.Items = weekDays;
        //    }





        //    string g = ssSesiones.VerExpediente;
        //    SubsonicDB.Expediente ssexpediente = SubsonicDB.Expediente.FetchByID(g);
        //    SubsonicDB.ArchivoCorrespondenciumCollection ssexpediente1 = new SubsonicDB.ArchivoCorrespondenciumCollection()
        //        .Where(SubsonicDB.ArchivoCorrespondencium.Columns.IDExpediente, ssSesiones.VerExpediente)
        //        .Load();
        //    try
        //    {
        //        ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.IDUsua), 21, ssexpediente1[0].Expediente.Descripcion);
        //        string FilePath = Server.MapPath("~/files/correspondencia/" + ssexpediente1[0].Id + ssexpediente1[0].Extencion);
        //        bool Existe = File.Exists(Server.MapPath("~/files/correspondencia/" + ssexpediente1[0].Id + ssexpediente1[0].Extencion));
        //        if (Existe)
        //        {
        //            WebClient User = new WebClient();
        //            Byte[] FileBuffer = User.DownloadData(FilePath);
        //            if (FileBuffer != null)
        //            {
        //                if (ssexpediente1[0].Extencion == ".pdf")
        //                {

        //                    RadPdfViewer1.PdfjsProcessingSettings.File = "/files/correspondencia/" + ssexpediente1[0].Id + ".pdf";
        //                    RadPdfViewer1.Visible = true;
        //                }
        //                else
        //                {

        //                    Response.ContentType = "Application/x-msexcel";
        //                    Response.AddHeader("content-length", FileBuffer.Length.ToString());
        //                    Response.AddHeader("Content-Disposition", "attachment; filename= " + ssexpediente1[0].Id + ssexpediente1[0].Extencion);

        //                    Response.BinaryWrite(FileBuffer);
        //                    //Response.TransmitFile(Server.MapPath("/Files/MyFile.pdf"));
        //                    //Response.End();


        //                    //Response.ContentType = ("application/vnd.ms-excel");

        //                    //Response.AddHeader("content-length", FileBuffer.Length.ToString());
        //                    //Response.BinaryWrite(FileBuffer);

        //                }
        //            }
        //        }
        //        else
        //        {

        //            Response.Redirect("~/notexist.aspx");
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        //Response.Redirect("~/notexist.aspx");










        //    }





        //}
    }
}