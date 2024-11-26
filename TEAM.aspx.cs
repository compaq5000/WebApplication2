using System;

namespace WebApplication2
{
    public partial class TEAM : System.Web.UI.Page
    {
        ClassSesion ssSesiones = new ClassSesion();
        protected void Page_Load(object sender, EventArgs e)
        {

            SubSonicDB.ArboladoGridCollection ssUsuarios = new SubSonicDB.ArboladoGridCollection()
                .Where(SubSonicDB.ArboladoGrid.Columns.Id, ssSesiones.VerExpediente)
                .Where(SubSonicDB.ArboladoGrid.Columns.ValueX, SubSonic.Comparison.NotEquals, 1)
                .Where(SubSonicDB.ArboladoGrid.Columns.ValueX, SubSonic.Comparison.NotEquals, 15)
                .Load();


            TableDatos.DataSource = ssUsuarios; ;
            TableDatos.DataBind();
        }
        public string ProcessMyDataItem(object myValue)
        {
            SubSonicDB.Anexo ss = new SubSonicDB.Anexo();



            SubSonicDB.CatUsuario ssUser = SubSonicDB.CatUsuario.FetchByID(myValue.ToString());

            myValue = ssUser.Nombre;


            return myValue.ToString();
        }
        public string ProcessMyDataItemIMG(object myValue)
        {
            try
            {
                SubSonicDB.CatUsuario ssUser = SubSonicDB.CatUsuario.FetchByID(myValue.ToString()); ;
                myValue = ssUser.Imagen;
                return myValue.ToString();
            }
            catch
            {
                return "144_1";
            }
        }
        public string ProcessMyDataItemExt(object myValue)
        {
            try
            {
                SubSonicDB.CatUsuario ssUser = SubSonicDB.CatUsuario.FetchByID(myValue.ToString()); ;
                myValue = ssUser.Extension;
                return myValue.ToString();
            }
            catch
            {
                return ".jpg";
            }
        }
    }
}