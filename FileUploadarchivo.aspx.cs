using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace WebApplication2
{
    public partial class FileUploadarchivo : System.Web.UI.Page
    {
        ClassSesion ssSesiones = new ClassSesion();
        protected void Page_Load(object sender, EventArgs e)
        {
            SubSonicDB.Expediente ss = SubSonicDB.Expediente.FetchByID(ssSesiones.VerExpediente);

            Label2.Text = "<br><br><strong>" + "Expediente Técnico:  " + ss.Descripcion + "</strong><br>";
        }
        protected void RadGrid1_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            List<ClassReporte> ssClassReporte = new List<ClassReporte>();

            SubSonicDB.CatTipoArchivoInventarioCollection ssInventarios = new SubSonicDB.CatTipoArchivoInventarioCollection()
                .Where(SubSonicDB.CatTipoArchivoInventario.Columns.Status, true)
                .Load();
            foreach (SubSonicDB.CatTipoArchivoInventario ssTio in ssInventarios)
            {
                ClassReporte ssAdd = new ClassReporte();
                ssAdd.AgregarElemento(ssTio.Id.ToString(), ssTio.Descripcion, "X");
                ssClassReporte.Add(ssAdd);
            }

            SubSonicDB.ViewReporteInventarioExpedienteCollection ssReporteExpe = new SubSonicDB.ViewReporteInventarioExpedienteCollection()
             .Where(SubSonicDB.ViewReporteInventarioExpediente.Columns.IDExpediente, ssSesiones.VerExpediente)
             .Load();

            foreach (SubSonicDB.ViewReporteInventarioExpediente ssReporte in ssReporteExpe)
            {
                foreach (var tom in ssClassReporte.Where(w => w.ID == ssReporte.Id.ToString()))
                {
                    tom.ChangeStatus("CARGADO");
                }
            }
            RadGrid1.DataSource = ssClassReporte;

        }





        protected void RadButton1_Click(object sender, EventArgs e)
        {
            RadGrid1.Rebind();
        }
    }
}