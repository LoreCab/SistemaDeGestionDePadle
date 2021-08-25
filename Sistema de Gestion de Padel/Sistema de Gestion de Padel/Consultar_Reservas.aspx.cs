using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_Gestion_de_Padel
{
    public partial class Consultar_Reservas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel1.Visible = true;

            MAPEO OMapeo = new MAPEO();
            ReservaCanPad EntReserva = new ReservaCanPad();
            Cancha EntCancha = new Cancha();
            PersonasPad EntPersona = new PersonasPad();

            EntReserva = OMapeo.RecuperaUnaReserva(Convert.ToInt16(GridView1.SelectedDataKey.Value.ToString()));
            EntCancha = OMapeo.RecuperarCancha(EntReserva.CanchaId);
            EntPersona = OMapeo.RecuperarPersona(EntReserva.PersonasPadId);

            TextBoxNombreSocio.Text = EntPersona.PersonasPAdApellido + ' ' + EntPersona.PersonasPadNombre;
            TextBoxCancha.Text = EntCancha.CanchaDescripcion;
            TextBoxHora.Text = Convert.ToString(EntReserva.ReservaCanPadHora);

            string mes = Convert.ToString((Convert.ToDateTime(EntReserva.ReservaCanPadFecha)).Month);
            string dia = Convert.ToString((Convert.ToDateTime(EntReserva.ReservaCanPadFecha)).Day);
            if (Convert.ToInt16(mes) < 10)
            {
                mes = string.Concat("0", mes);
            }
            if (Convert.ToInt16(dia) < 10)
            {
                dia = string.Concat("0", dia);
            }
            TextBoxFecha.Text = string.Concat((Convert.ToDateTime(EntPersona.PersonasPadFecNac)).Year, "-", mes, "-", dia);

            Session["reserva"] = EntReserva;
        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            ReservaCanPad EntReserva = new ReservaCanPad();
            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona = new PersonasPad();
            EntReserva = (ReservaCanPad)(Session["reserva"]);

            EntReserva.ReservaCanPadEstado = 0;
            OMapeo.ModificarReserva(EntReserva, EntReserva.ReservaCanPadId);
            
            EntPersona = OMapeo.RecuperarPersona(EntReserva.PersonasPadId);
            EntPersona.PersonasPadDeuda = (EntPersona.PersonasPadDeuda - 150);
            OMapeo.ModificaPersona(EntPersona, EntPersona.PersonasPadId);

            Server.Transfer("Inicio.aspx");
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int estado = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "TIPO").ToString());
                if (estado == 1)
                {
                    string hex = "#00BFFF";
                    e.Row.ForeColor = System.Drawing.Color.White;
                    e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml(hex);
                }
                else
                {
                    string hex = "#9A2EFE";
                    e.Row.ForeColor = System.Drawing.Color.Black;
                    e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml(hex);
                }
            }
        }
    }
}