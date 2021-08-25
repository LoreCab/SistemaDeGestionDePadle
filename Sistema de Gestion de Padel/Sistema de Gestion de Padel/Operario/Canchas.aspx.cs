using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_Gestion_de_Padel.Operario
{
    public partial class Canchas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            Cancha EntCancha = new Cancha();

            EntCancha = OMapeo.RecuperarCancha(Convert.ToInt16(GridView1.SelectedDataKey.Value.ToString()));
            TextBoxNombre.Text = EntCancha.CanchaDescripcion;
            DropDownList1.SelectedValue = Convert.ToString(EntCancha.EstadoCancha);

            Session["codcancha"] = EntCancha.CanchaId;

            ButtonRegistrar.Visible = false;
            ButtonModificar.Visible = true;
        }

        protected void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            Cancha EntCancha = new Cancha();
            EntCancha.CanchaDescripcion = TextBoxNombre.Text.ToUpper();
            EntCancha.EstadoCancha = Convert.ToByte(DropDownList1.SelectedValue);

            MAPEO OMapeo = new MAPEO();
            OMapeo.AltaCancha(EntCancha);

            for (int dia = 1; dia < 7; dia++)
            {
                for (int hora = 15; hora < 25; hora++)
                {
                    TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
                    EntTurno.CanchaId = OMapeo.RecuperaUltimaCancha();
                    EntTurno.TurnoFijoCanPadDia = Convert.ToSByte(dia);
                    EntTurno.TurnoFijoCanPadHora = Convert.ToSByte(hora);
                    EntTurno.PersonasPadId = 0;
                    EntTurno.TurnoFijoCanPadEstado = 0;

                    OMapeo.AltaTurnoFijo(EntTurno);
                }
            }

            Server.Transfer("Inicio.aspx");
        }

        protected void ButtonModificar_Click(object sender, EventArgs e)
        {
            Cancha EntCancha = new Cancha();
            EntCancha.CanchaDescripcion = TextBoxNombre.Text;
            EntCancha.EstadoCancha = Convert.ToByte(DropDownList1.SelectedValue);

            int cod = Convert.ToInt16(Session["codcancha"]);

            MAPEO OMapeo = new MAPEO();
            OMapeo.ModificarCancha(EntCancha, cod);

            Server.Transfer("Inicio.aspx");
        }

    }
}