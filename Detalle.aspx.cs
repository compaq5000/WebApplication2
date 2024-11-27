using System;
///
namespace WebApplication2
{
    public partial class Detalle : System.Web.UI.Page
    {
        ClassSesion ssSesiones = new ClassSesion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RadWindow1.VisibleOnPageLoad = false;
            }
            SubSonicDB.Expediente ssExiste = SubSonicDB.Expediente.FetchByID(ssSesiones.VerExpediente);
            SubSonicDB.CatDestinoCorrespondencium ssExistedestino = SubSonicDB.CatDestinoCorrespondencium.FetchByID(ssExiste.IDDestinoCorrespondencia);
            LabelDestino.Text = ssExistedestino.Descripcion;
            Labelfolio.Text = ssExiste.Descripcion;
            LabelPaginas.Text = ssExiste.Paginas + " Paginas.";
            LabelRemitente.Text = ssExiste.CatOrigenCorrespondencium.Descripcion;
            TextBoxBservaciones.Text = ssExiste.Causa;
            TextBoxCorrespondenciaFecha.SelectedDate = ssExiste.Fechaconoce;
        }
        public void LoadDatas()
        {
            SubSonicDB.Expediente ssLoadExpediente = SubSonicDB.Expediente.FetchByID(ssSesiones.VerExpediente);
        }
        protected void RadButton2_Click(object sender, EventArgs e)
        {
            RadWindow1.NavigateUrl = "~/catalogos.aspx";
            RadWindow1.VisibleOnPageLoad = true;
            RadWindow1.Visible = true;
            // RadWindow1.Title = "Expediente: " + ssexpediente.Descripcion;
            RadWindow1.Width = 400;
            RadWindow1.Height = 600;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/detalle.aspx");
        }
    }
}