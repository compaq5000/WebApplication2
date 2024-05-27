using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class ExpedPases : System.Web.UI.Page
    { 

                ClassSesion ssSesiones = new ClassSesion();

    protected void Page_Load(object sender, EventArgs e)
        {

            RadWindow2.VisibleOnPageLoad = false;
            RadWindow2.Visible = false;
            if (!IsPostBack)
            {
                FillAdscripcion();
            }

        }
        public void FillAdscripcion()
        {
            RadComboBoxAdscripciones1.Text = "";
            RadComboBoxAdscripciones1.Items.Clear();
            SubSonicDB.CatAdscripcionRhCollection ssAdscripcion = new SubSonicDB.CatAdscripcionRhCollection()
                .Load();
            foreach (SubSonicDB.CatAdscripcionRh ssadd in ssAdscripcion)
            {
                Telerik.Web.UI.RadComboBoxItem add = new Telerik.Web.UI.RadComboBoxItem(ssadd.Descripcion, ssadd.Id.ToString());
            
                RadComboBoxAdscripciones1.Items.Add(add);
            }
        }
        protected void RadButton2_Click(object sender, EventArgs e)
        {

            int Valor = Convert.ToInt32(RadComboBoxHojas.SelectedValue) * 3;
            bool pibote = false;
            int inicio;
            int final;
            int recibo = 0;

            SubSonicDB.ImprimirinsidenciaCollection ssImprimir = new SubSonicDB.ImprimirinsidenciaCollection()
                     .Where(SubSonicDB.Imprimirinsidencia.Columns.Idadscripcion, RadComboBoxAdscripciones1.SelectedValue)
                     .Load();
            ssSesiones.Total = RadComboBoxAdscripciones1.SelectedValue;

            recibo = Convert.ToInt32(ssImprimir[ssImprimir.Count - 1].Recibo);

            for (int i = 0; i < Valor; i++)
            {
                SubSonicDB.Imprimirinsidencia ssNewInsi = new SubSonicDB.Imprimirinsidencia();
                ssNewInsi.Idadscripcion = Convert.ToInt32(RadComboBoxAdscripciones1.SelectedValue);
                ssNewInsi.Status = true;
                recibo = recibo + 1;

                ssNewInsi.Recibo = recibo;
                ssNewInsi.Save();
                RadWindow2.NavigateUrl = "~/WEbForm5.aspx";
                RadWindow2.VisibleOnPageLoad = true;
                RadWindow2.Visible = true;
                RadWindow2.VisibleStatusbar = true;
                RadWindow2.Title = "Expediente: ";
                RadWindow2.Width = 1200;
                RadWindow2.Height = 500;


                if (pibote == false)
                {
                    ssSesiones.from = ssNewInsi.Id;
                    pibote = true;
                }

                if (i == (Valor - 1))
                {
                    ssSesiones.to = ssNewInsi.Id;


                    // ssSesiones.Total = ssImprimir.Count;

                }
            }
        }
    }
}