using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_Gestion_de_Padel.Organizador
{
    public partial class Cargar_Torneo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            Torneo EntTorneo = new Torneo();

            EntTorneo.NombreTorneo = TextBoxNombre.Text;
            EntTorneo.FechaInicioTorneo = Convert.ToDateTime(TextBoxFInicio.Text).Date;
            EntTorneo.FechaFinTorneo = Convert.ToDateTime(TextBoxFFin.Text).Date;
            EntTorneo.Estado = 1;

            OMapeo.AltaTorneos(EntTorneo);

            Response.Redirect("/Organizador/Inicio.aspx");
        }
    }
}