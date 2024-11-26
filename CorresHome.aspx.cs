using System;

namespace WebApplication2
{
    public partial class CorresHome : System.Web.UI.Page
    {
        ClassSesion ssSesiones = new ClassSesion();
        protected void Page_Load(object sender, EventArgs e)
        {
            //RadTabStrip1.Tabs[1].Visible = VisibleJefe(); 
            //RadTabStrip1.Tabs[2].Visible = VisibleJefe();
            //RadTabStrip1.Tabs[3].Visible = VisibleJefe();
            //RadTabStrip1.Tabs[0].Visible = VisibleJefe();
        }
        public bool VisibleJefe()
        {

            if (ssSesiones.IDUsua == "1")
            {

                return false;
            }
            else
            {
                return true;
            }

        }
    }
}