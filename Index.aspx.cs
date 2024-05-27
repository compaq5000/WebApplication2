using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
 
    public partial class Index : System.Web.UI.Page
    {
        ClassSesion ssSesiones = new ClassSesion();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Click(object sender, EventArgs e)
        {
            SubSonicDB.CatUsuarioCollection ssUsuarios = new SubSonicDB.CatUsuarioCollection()
                     .Where(SubSonicDB.CatUsuario.Columns.Usuario, RadTextBoxUsuario.Text)
                     .Load();
            ssSesiones.Ip = Request.UserHostAddress;
            if (ssUsuarios.Count > 0)
            {
                if (ssUsuarios[0].Passw == RadTextBoxpassw.Text)
                {
                    ssSesiones.Usua = ssUsuarios[0].Id.ToString();
                    ssSesiones.TipoUser = ssUsuarios[0].IDTipoUser.ToString();
                    ssSesiones.IDTipoUser = ssUsuarios[0].IDTipoUser.ToString();
                    ssSesiones.IDUsua = ssUsuarios[0].Id.ToString();
                    ssSesiones.ExtensionUsua = ssUsuarios[0].Extension.ToString();
                    ssSesiones.Bitacora(Convert.ToInt32(ssSesiones.Usua), 1, "ACCEDE AL SISTEMA");
                    Response.Redirect("~/mindex.aspx");
                }
            }
            else
            {
                ssSesiones.Bitacora(1017, 22, "ACCESO NEGADO");
            }
        }
    }
}