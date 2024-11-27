using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.NetworkInformation;

/// <summary>
/// Summary description for ClassSesion
/// </summary>
public class ClassSesion : System.Web.UI.Page
{
    // object Narra;

    public ClassSesion()
    {

    }
    //public string ParteNovedadIDReParar
    //{
    //    get
    //    {
    //        DateTime FechaInicial = new DateTime(DateTime.Now.Year ,DateTime.Now.Month, DateTime.Now.Day, 00, 00, 00);
    //        DateTime FechaFinal = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);

    //        string reg = Request.QueryString["Region"];
    //        string sec = Request.QueryString["Sector"];

    //        SubsonicDB.ViewNovedadeCollection ssNovedades = new SubsonicDB.ViewNovedadeCollection()
    //           .Where(SubsonicDB.ViewNovedade.Columns.Seccion, SubSonic.Comparison.Equals, Convert.ToString(5))
    //           .Where(SubsonicDB.ViewNovedade.Columns.SectorId, SubSonic.Comparison.Equals, Request.QueryString["Sector"])
    //           .Where(SubsonicDB.ViewNovedade.Columns.RegionId, SubSonic.Comparison.Equals, Request.QueryString["Region"])
    //           .BetweenAnd(SubsonicDB.ViewNovedade.Columns.Fecha, FechaInicial, FechaFinal)
    //            .Load();
    //        ss.ParteNovedadID = Convert.ToString(ssNovedades[0].ParteNovedadId);

    //        object o = Session["ParteNovedadID"];
    //        return (o == null) ? "" : (string)o;
    //    }
    //    set
    //    {
    //        Session["ParteNovedadID"] = value;
    //    }
    //}


    //public string TipoDeImagen
    //{
    //    get
    //    {
    //        try
    //        {
    //            object o = Session["TipoDeImagen"];
    //            return (o == null) ? "" : (string)o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/login.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["TipoDeImagen"] = value;
    //    }
    //}
    //public string SecargaFotos
    //{
    //    get
    //    {
    //        try
    //        {
    //            object o = Session["SecargaFotos"];
    //            return (o == null) ? "" : (string)o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/login.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["SecargaFotos"] = value;
    //    }
    //}
    //public string PrimerValor
    //{
    //    get
    //    {
    //        try
    //        {
    //            object o = Session["FistValor"];
    //            return (o == null) ? "" : (string)o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/login.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["FistValor"] = value;
    //    }
    //}
    //public string ParteNovedadID
    //{
    //    get
    //    {
    //        try
    //        {
    //            object o = Session["ParteNovedadID"];
    //            return (o == null) ? "" : (string)o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/login.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["ParteNovedadID"] = value;
    //    }
    //}
    //public string UserID
    //{
    //    get
    //    {
    //        try
    //        {
    //            object o = Session["IDUsuario"];
    //            return (o == null) ? "" : (string)o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["IDUsuario"] = value;
    //    }
    //}
    //public string IDArchivoNomina
    //{
    //    get
    //    {
    //        try
    //        {
    //            object o = Session["IDArchivoNomina"];
    //            return (o == null) ? "" : (string)o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["IDArchivoNomina"] = value;
    //    }
    //}
    //public string Dia
    //{
    //    get
    //    {
    //        try
    //        {

    //            SubsonicDB.CatDia ssDia = new SubsonicDB.CatDia();
    //            ssDia.LoadByParam(SubsonicDB.CatDia.Columns.Fecha, DateTime.Now);
    //            object o = ssDia.Id.ToString();
    //            return (o == null) ? "" : (string)o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");

    //            object o = "false";
    //            return (string)o;
    //        }
    //    }
    //    set
    //    {
    //        Session["Dia"] = value;
    //    }
    //}
    //public string ConductorID
    //{
    //    get
    //    {
    //        try
    //        {
    //            object o = Session["Conductor"];
    //            return (o == null) ? "" : (string)o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["Conductor"] = value;
    //    }
    //}
    //public string NombreUsuario
    //{
    //    get
    //    {

    //        try
    //        {
    //            SubsonicDB.Permiso ssPersona = SubsonicDB.Permiso.FetchByID(this.UserID);
    //            //SubsonicDB.Persona ssPersona = SubsonicDB.Persona.FetchByID(Convert.ToInt32(Session["Conductor"]));

    //            object o = ssPersona.Nombre + " " + ssPersona.ApellidoPaterno + " " + ssPersona.ApellidoMaterno;
    //            return (o == null) ? "" : (string)o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");

    //            object o = null;
    //            return (string)o;
    //        }
    //    }
    //    set
    //    {
    //        Session["Conductor"] = value;
    //    }
    //}
    ////public string Mpio
    ////{
    ////    get
    ////    {






    ////        SubsonicDB.CatalogoMunicipio ss = SubsonicDB.CatalogoMunicipio.FetchByID(this.MpioID);
    ////        object o = ss.Nombre;
    ////        return (o == null) ? "" : (string)o;
    ////    }
    ////    set
    ////    {
    ////        Session["MpioID"] = value;
    ////    }
    ////}
    //public string IdEntidad
    //{
    //    get
    //    {
    //        try
    //        {
    //            SubsonicDB.CatEntidade ssentidades = SubsonicDB.CatEntidade.FetchByID(Session["IDEntidad"].ToString());
    //            object o = ssentidades.IdEntidad.ToString();
    //            return (o == null) ? "" : (string)o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["IDEntidad"] = value;
    //    }
    //}
    //public string MpioID
    //{
    //    get
    //    {
    //        try
    //        {
    //            SubsonicDB.CatMunicipioCollection ss = new SubsonicDB.CatMunicipioCollection()
    //            .Where(SubsonicDB.CatMunicipio.Columns.IdEntidad, SubSonic.Comparison.Equals, Session["IDEntidad"])
    //            .Where(SubsonicDB.CatMunicipio.Columns.IdMunicipio, SubSonic.Comparison.Equals, Session["MpioID"])
    //            .Load();


    //            object o = Session["MpioID"];

    //            return (o == null) ? "" : (string)o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["MpioID"] = value;
    //    }
    //}
    //public string MpioIDFederal
    //{
    //    get
    //    {
    //        try
    //        {
    //            SubsonicDB.CatMunicipioCollection ss = new SubsonicDB.CatMunicipioCollection()
    //            .Where(SubsonicDB.CatMunicipio.Columns.IdEntidad, SubSonic.Comparison.Equals, Session["IDEntidad"])
    //            .Where(SubsonicDB.CatMunicipio.Columns.IdMunicipio, SubSonic.Comparison.Equals, Session["MpioID"])
    //            .Load();
    //            object o = ss[0].Id.ToString();
    //            return (o == null) ? "" : (string)o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["MpioIDFederal"] = value;
    //    }
    //}
    //public string claveacceso
    //{
    //    get
    //    {

    //        try
    //        {

    //            SubsonicDB.CatMunicipio ssClaveAcceso = new SubsonicDB.CatMunicipio();
    //            ssClaveAcceso.LoadByParam(SubsonicDB.CatMunicipio.Columns.Id, this.MpioIDFederal);

    //            object o = ssClaveAcceso.Clave;
    //            return (o == null) ? "" : (string)o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");

    //            object o = null;
    //            return (string)o;
    //        }
    //    }
    //    set
    //    {
    //        Session["claveacceso"] = value;
    //    }
    //}
    //public string NombreMunicipio
    //{
    //    get
    //    {

    //        try
    //        {
    //            SubsonicDB.CatMunicipioCollection ss = new SubsonicDB.CatMunicipioCollection()
    //             .Where(SubsonicDB.CatMunicipio.Columns.IdEntidad, SubSonic.Comparison.Equals, Session["IDEntidad"])
    //             .Where(SubsonicDB.CatMunicipio.Columns.IdMunicipio, SubSonic.Comparison.Equals, Session["MpioID"])
    //             .Load();
    //            // SubsonicDB.CatalogoLocalidade ss = SubsonicDB.CatalogoLocalidade.FetchByID(Convert.ToByte());
    //            object o = ss[0].Descripcion;
    //            return (o == null) ? "" : (string)o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");

    //            object o = null;
    //            return (string)o;
    //        }
    //    }
    //    set
    //    {
    //        Session["LocalidadID"] = value;
    //    }
    //}
    //public string LocalidadID
    //{
    //    get
    //    {
    //        try
    //        {
    //            //SubsonicDB.CatalogoSectore ss = SubsonicDB.CatalogoSectore.FetchByID(Convert.ToInt32(Session["SectorID"]));
    //            object o = Session["LocalidadID"];

    //            return (o == null) ? "" : (string)o;
    //        }
    //        catch
    //        {

    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["LocalidadID"] = value;
    //    }
    //}
    //public string Sector
    //{
    //    get
    //    {
    //        //SubsonicDB.CatalogoSectore ss = SubsonicDB.CatalogoSectore.FetchByID(Convert.ToInt32(Session["SectorID"]));
    //        //object o = ss.Nombre;
    //        object o = Session["SectorID"];
    //        return (o == null) ? "" : (string)o;


    //    }
    //    set
    //    {
    //        Session["SectorID"] = value;
    //    }
    //}
    ////public string Region
    ////{
    ////    get
    ////    {
    ////        SubsonicDB.CatalogoRegione ss = SubsonicDB.CatalogoRegione.FetchByID(Convert.ToInt32(Session["RegionID"]));
    ////        //object o = Session["RegionID"];
    ////        object o = ss.Nombre;
    ////        return (o == null) ? "" : (string)o;
    ////    }
    ////    set
    ////    {
    ////        Session["RegionID"] = value;
    ////    }
    ////}
    ////public string Correo
    ////{
    ////    get
    ////    {
    ////        SubsonicDB.Permiso ss = SubsonicDB.Permiso.FetchByID(Convert.ToInt32(Session["IDUsuario"]));
    ////        //object o = Session["RegionID"];
    ////        object o = ss.Correo;
    ////        return (o == null) ? "" : (string)o;
    ////    }
    ////    set
    ////    {
    ////        Session["IDUsuario"] = value;
    ////    }
    ////}
    //public object RegionID
    //{
    //    get
    //    {
    //        try
    //        {
    //            object o = Session["RegionID"];
    //            return (o == null) ? "" : (string)o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["RegionID"] = value;
    //    }
    //}

    ////public string Seccion
    ////{
    ////    get
    ////    {
    ////        //SubsonicDB.Seccione ss = SubsonicDB.Seccione.FetchByID(Convert.ToInt32(Session["SeccionID"]));
    ////        //object o = ss.Nombre;
    ////        return (o == null) ? "" : (string)o;
    ////    }
    ////    set
    ////    {
    ////        Session["SeccionID"] = value;
    ////    }
    ////}
    //public string NombreSeccion
    //{
    //    get
    //    {
    //        try
    //        {
    //            try
    //            {
    //                SubsonicDB.Permiso ssSeccion = SubsonicDB.Permiso.FetchByID(this.UserID);
    //                object o = ssSeccion.CatSeccione.Descripcion;
    //                return (o == null) ? "" : (string)o;
    //            }
    //            catch
    //            {
    //                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
    //                return null;
    //            }
    //        }
    //        catch
    //        {
    //            object o = null;
    //            return (string)o;
    //        }
    //    }
    //    set
    //    {
    //        Session["SeccionID"] = value;
    //    }
    //}
    //public string Narrativa
    //{
    //    get
    //    {
    //        //object o = "";
    //        //object o = ss.Nombre;
    //        // return (o == null) ? "" : (string)o;
    //        return (Narra == null) ? "" : Narra.ToString();
    //    }
    //    set
    //    {
    //        Narra = value;
    //    }
    //}
    //public string Nivel
    //{
    //    get
    //    {
    //        try
    //        {

    //            SubsonicDB.Nivele ss = SubsonicDB.Nivele.FetchByID(Convert.ToInt32(Session["NivelID"]));
    //            object o = ss.Descripcion;
    //            return (o == null) ? "" : (string)o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");

    //            object o = "false";
    //            return (string)o;
    //        }
    //    }
    //    set
    //    {
    //        Session["NivelID"] = value;
    //    }
    //}
    ////public object SeccionID
    ////{
    ////    get
    ////    {
    ////        SubsonicDB.Seccione ss = SubsonicDB.Seccione.FetchByID(Convert.ToInt32(Session["SeccionID"]));
    ////        object o = ss.Seccion;
    ////        return o;
    ////    }
    ////    set
    ////    {
    ////        Session["SeccionID"] = value;
    ////    }
    ////}


    public object IDAdcripcion
    {
        get
        {
            try
            {

                SubSonicDB.RelCatAdscripcionCollection ssAdcrio = new SubSonicDB.RelCatAdscripcionCollection()
                    .Where(SubSonicDB.RelCatAdscripcion.Columns.IDUsuario, this.IDUsua)
                    .Where(SubSonicDB.RelCatAdscripcion.Columns.Status, true)
                    .Load();




                object o = ssAdcrio[0].IDAdscripcion;
                return o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["ssNewMinuta"] = value;
        }
    }









    public object to
    {
        get
        {
            try
            {
                object o = Session["to"];
                return o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["to"] = value;
        }
    }


    public object Total
    {
        get
        {
            try
            {
                object o = Session["Total"];
                return o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["Total"] = value;
        }
    }
    public object IDMunicipio
    {
        get
        {
            try
            {
                object o = Session["IDMunicipio"];
                return o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["IDMunicipio"] = value;
        }
    }


    public object from
    {
        get
        {
            try
            {
                object o = Session["from"];
                return o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["from"] = value;
        }
    }



    public string sujestig
    {
        get
        {
            try
            {
                object o = Session["sujestig"];
                return (o == null) ? "" : (string)o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["sujestig"] = value;
        }
    }

    public string MyBody
    {
        get
        {
            try
            {
                object o = Session["MyBody"];
                return (o == null) ? "" : (string)o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["MyBody"] = value;
        }
    }
    public string OficeQueEnvia
    {
        get
        {
            try
            {
                object o = Session["OficeQueEnvia"];
                return (o == null) ? "" : (string)o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["OficeQueEnvia"] = value;
        }
    }
    public bool EnviarCorreo()
    {
        List<int> h = (List<int>)this.to;
        try
        {
            foreach (int x in h)
            {
                SubSonicDB.CatUsuario ssUser = SubSonicDB.CatUsuario.FetchByID(x);
                string from = "compaq5000@hotmail.com";
                SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
                var mail = new MailMessage();
                mail.From = new MailAddress(from);
                // mail.CC = "coralmartines88@gmail.com";
                mail.To.Add(ssUser.Correo);
                mail.Subject = "📜 CORRESPONDENCIA: " + sujestig;
                mail.IsBodyHtml = true;
                mail.Body = "<img src ='https://lh3.googleusercontent.com/proxy/8L6Y1DXOVN7ovc6rKST1zc6x1-p9MnQcpjH3HoabSYQs2yTnjDDTydjymyZBesG-C7yaV1Cnol9TT1PC0SjixS_xxZIrANN5-HfL9LA2rJyRtQBU9lg' ><br>" +
                      "<strong>" + OficeQueEnvia + "</strong>" + "<hr>" + MyBody + "<br>Consúltalo:<br> <a href='http://juridico.guerrero.gob.mx/'> Estoy conectado a la red de palacio.</a><br><br>Consúltalo:<br> <a href='http://correspondencia.hopto.org/'> Estoy fuera de la red de palacio.</a><br><br>Si no recuerdas tu cuenta comunicate a este numero:7471098624";
                mail.Priority = System.Net.Mail.MailPriority.High;
                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("compaq5000@hotmail.com", "Ivan2610");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            return true;
        }
        catch
        {
            return false;
        }
    }
    public bool EnviarCorreo(List<int> to, string sujestig, string MyBody, string OficeQueEnvia)
    {
        try
        {
            foreach (int x in to)
            {
                SubSonicDB.CatUsuario ssUser = SubSonicDB.CatUsuario.FetchByID(x);
                string from = "compaq5000@hotmail.com";
                SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
                var mail = new MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add(ssUser.Correo);
                mail.Subject = "📜 CORRESPONDENCIA: " + sujestig;
                mail.IsBodyHtml = true;
                mail.Body = OficeQueEnvia + ": <hr>" + MyBody;
                mail.Priority = System.Net.Mail.MailPriority.High;
                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("compaq5000@hotmail.com", "Ivan2610");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);


            }
            return true;
        }
        catch
        {

            return false;
        }
    }
    public bool EnviarCorreo(int to, string sujestig, string MyBody, string OficeQueEnvia)
    {
        try
        {
            SubSonicDB.CatUsuario ssUser = SubSonicDB.CatUsuario.FetchByID(to);


            string from = "compaq5000@hotmail.com";

            SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
            var mail = new MailMessage();
            mail.From = new MailAddress(from);
            mail.To.Add(ssUser.Correo);
            // mail.CC.Add("ENDIOLA73@hotmail.com");
            mail.Subject = "📜 CORRESPONDENCIA: " + sujestig;
            mail.IsBodyHtml = true;
            mail.Body = OficeQueEnvia + ": <hr>" + MyBody + "<hr>Puedes consultar tu correspondencia Desde la red de palacio: http://juridico.guerrero.gob.mx <hr>Fuera de la red de palacio: http://correspondencia.hopto.org/ ";
            mail.Priority = System.Net.Mail.MailPriority.High;
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("compaq5000@hotmail.com", "Ivan2610");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
            return true;

        }
        catch
        {

            return false;
        }
    }
    public void Bitacora(int IDUser, int IDOperacion, string Descripcion)
    {

        var macAddr =
         (
             from nic in NetworkInterface.GetAllNetworkInterfaces()
             where nic.OperationalStatus == OperationalStatus.Up
             select nic.GetPhysicalAddress().ToString()
         ).FirstOrDefault();




        // Strip the domain off of the result
        //Response.Write(Request.UserHostAddress + "<br>" + macAddr + "<br>");

        SubSonicDB.TableBitacora ssBitacora = new SubSonicDB.TableBitacora();
        ssBitacora.TipoOperacion = IDOperacion;
        ssBitacora.Descripcion = Descripcion;
        ssBitacora.IDUser = IDUser;
        ssBitacora.Fecha = DateTime.Now;
        ssBitacora.Status = true;
        ssBitacora.Ip = this.Ip;
        ssBitacora.Mac = macAddr;
        //   ssBitacora.Save();




    }
    public string Ip
    {
        get
        {
            try
            {
                object o = Session["Ip"];
                return (o == null) ? "" : (string)o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["Ip"] = value;
        }
    }
    public string VerExpediente
    {
        get
        {
            try
            {
                object o = Session["VerExpediente"];
                return (o == null) ? "" : (string)o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["VerExpediente"] = value;
        }
    }

    public string PathCorrespondencia
    {
        get
        {
            try
            {
                object o = Session["PathCorrespondencia"];
                return (o == null) ? "" : (string)o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["PathCorrespondencia"] = value;
        }
    }

    public string Usua
    {
        get
        {
            try
            {
                object o = Session["Usua"];
                return (o == null) ? "" : (string)o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["Usua"] = value;
        }
    }
    public string IDUsua
    {
        get
        {
            try
            {
                string o = Session["IDUsua"].ToString();
                return o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["IDUsua"] = value;
        }
    }
    public string ExtensionUsua
    {
        get
        {
            try
            {
                object o = Session["ExtensionUsua"];
                return (o == null) ? "" : (string)o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["ExtensionUsua"] = value;
        }
    }
    public object StatusCopy
    {
        get
        {

            object o = Session["StatusCopy"];
            return o;
        }
        set
        {
            Session["StatusCopy"] = value;
        }
    }
    public object TipoUser
    {
        get
        {
            try
            {

                object o = Session["TipoUser"];

                if (o.ToString() == "1")
                {
                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch
            {

                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;

            }
        }
        set
        {
            Session["TipoUser"] = value;
        }
    }
    public object IDTipoUser
    {
        get
        {
            try
            {

                object o = Session["IDTipoUser"];
                return o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;

            }
        }
        set
        {
            Session["IDTipoUser"] = value;
        }
    }
    public object StatusCut
    {
        get
        {

            object o = Session["StatusCut"];
            return o;
        }
        set
        {
            Session["StatusCut"] = value;
        }
    }
    public object FileDownload
    {
        get
        {
            try
            {
                object o = Session["FileDownload"];
                return o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["FileDownload"] = value;
        }
    }
    public object KEYcarpeta
    {
        get
        {
            try
            {
                object o = Session["KEY"];
                return o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["KEY"] = value;
        }
    }
    public object ArchivosSelect
    {
        get
        {
            try
            {
                object o = Session["ArchivosSelect"];
                return o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["ArchivosSelect"] = value;
        }
    }
    public object CarpetasSelect
    {
        get
        {
            try
            {
                object o = Session["CarpetasSelect"];
                return o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["CarpetasSelect"] = value;
        }
    }
    public object NombreArchivo
    {
        get
        {
            try
            {
                object o = Session["NombreArchivo"];
                return o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["NombreArchivo"] = value;
        }
    }
    public string[] ViewPaths
    {
        get
        {
            //string[] a = new string[1];
            //SubsonicDB.Seccione ssSeccion = SubsonicDB.Seccione.FetchByID(Convert.ToInt32(Session["SeccionID"]));
            //SubsonicDB.CatalogoRegione ssRegion = SubsonicDB.CatalogoRegione.FetchByID(Convert.ToInt32(Session["RegionID"]));
            //SubsonicDB.CatalogoSectore ssSector = SubsonicDB.CatalogoSectore.FetchByID(Convert.ToInt32(Session["SectorID"]));
            //a[0] = "~/" + ssSeccion.Nombre + "/NOVEDAD/" + ssRegion.Nombre + "/" + ssSector.Nombre + "/" + Session["ParteNovedadID"];
            //return a;
            string[] a = new string[1];

            a[0] = "~/Minutario/" + this.GetIDFolioMinuta;
            return a;
        }
    }
    //vARIABLES PARA MODULO CREAR EN MINUTARIO
    public object NewIDFolioMinuta
    {
        get
        {
            try
            {
                SubSonicDB.TranMinutum ssNewMinuta = new SubSonicDB.TranMinutum();
                ssNewMinuta.IDUser = Convert.ToInt32(this.IDUsua);
                ssNewMinuta.Staus = true;
                ///ssNewMinuta.Para=
                ssNewMinuta.Save();
                this.GetIDFolioMinuta = ssNewMinuta.Id;
                object o = ssNewMinuta.Id;
                return o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["ssNewMinuta"] = value;
        }
    }
    public object GetIDFolioMinuta
    {
        get
        {
            try
            {
                object o = Session["GetIDFolioMinuta"];
                return o;
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["GetIDFolioMinuta"] = value;
        }
    }
    public string ContenidoMinuta
    {
        get
        {
            try
            {
                string o = Session["ContenidoMinuta"].ToString();
                return o;
            }
            catch
            {
                //  System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
                return null;
            }
        }
        set
        {
            Session["ContenidoMinuta"] = value;
        }
    }

    //public object Fecha
    //{
    //    get
    //    {
    //        try
    //        {
    //            object o = Session["Fecha"];
    //            return o;
    //        }
    //        catch
    //        {

    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["Fecha"] = value;
    //    }
    //}
    //public object status
    //{
    //    get
    //    {
    //        try
    //        {
    //            object o = Session["status"];
    //            return o;
    //        }
    //        catch
    //        {

    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["status"] = value;
    //    }
    //}
    //public object StatusIMGCapturada
    //{
    //    get
    //    {
    //        try
    //        {
    //            object o = Session["StatusIMG"];
    //            return o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["StatusIMG"] = value;
    //    }
    //}
    //public object Cargo
    //{
    //    get
    //    {
    //        try
    //        {
    //            object o = Session["Cargo"];
    //            return o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["Cargo"] = value;
    //    }
    //}
    //public object IDLicenciaSinAprobar
    //{
    //    get
    //    {
    //        try
    //        {
    //            object o = Session["IDLicenciaNoaprobada"];
    //            return o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["IDLicenciaNoaprobada"] = value;
    //    }
    //}
    //public object IDLicenciaAprobada
    //{
    //    get
    //    {
    //        try
    //        {
    //            object o = Session["IDLicenciaAprobada"];
    //            return o;
    //        }
    //        catch
    //        {

    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["IDLicenciaAprobada"] = value;
    //    }
    //}
    //public object StatusProsesado
    //{
    //    get
    //    {
    //        try
    //        {
    //            object o = Session["StatusProsesado"];
    //            return o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["StatusProsesado"] = value;
    //    }
    //}
    //public object statusReposicion
    //{
    //    get
    //    {
    //        try
    //        {
    //            object o = Session["statusReposicion"];
    //            return o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["statusReposicion"] = value;
    //    }
    //}
    //public object IDReposicion
    //{
    //    get
    //    {
    //        try
    //        {
    //            object o = Session["IDReposicion"];
    //            return o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["IDReposicion"] = value;
    //    }
    //}
    //public object ExistFoto
    //{
    //    get
    //    {
    //        try
    //        {
    //            object o = Session["ExistFoto"];
    //            return o;
    //        }
    //        catch
    //        {
    //            System.Web.HttpContext.Current.Response.Redirect("~/LogOff.aspx");
    //            return null;
    //        }
    //    }
    //    set
    //    {
    //        Session["StatusProsesado"] = value;
    //    }
    //}
    //public string Skin
    //{
    //    get
    //    {
    //        string h = Session["IDSkin"].ToString();

    //        SubsonicDB.CatSkin ss = SubsonicDB.CatSkin.FetchByID(Convert.ToInt32(Session["IDSkin"]));
    //        string o = ss.Descripcion;
    //        return o;
    //    }
    //    set
    //    {
    //        SubsonicDB.Permiso ss = SubsonicDB.Permiso.FetchByID(Convert.ToInt32(Session["IDUsuario"]));
    //        ss.IDSkin = Convert.ToInt32(value);
    //        ss.Save();
    //        Session["IDSkin"] = ss.IDSkin;
    //    }
    //}
}