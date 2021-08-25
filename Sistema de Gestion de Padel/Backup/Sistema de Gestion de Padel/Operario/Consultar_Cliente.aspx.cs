using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_Gestion_de_Padel.Operario
{
    public partial class Consultar_Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona = new PersonasPad();
            LocalidadP EntLocalidad = new LocalidadP();

            EntPersona = OMapeo.RecuperarPersona(Convert.ToInt16(GridView1.SelectedDataKey.Value.ToString()));

            TextBoxNombre.Text = EntPersona.PersonasPadNombre;
            TextBoxApellido.Text = EntPersona.PersonasPAdApellido;
            TextBoxDNI.Text = Convert.ToString(EntPersona.PersonasPadDni);
            EntLocalidad = OMapeo.RecuperarLocalidad(Convert.ToByte(EntPersona.LocalidadPId));
            DropDownList1.Text = EntLocalidad.NombreLocalidadP;

            string mes = Convert.ToString((Convert.ToDateTime(EntPersona.PersonasPadFecNac)).Month);
            string dia = Convert.ToString((Convert.ToDateTime(EntPersona.PersonasPadFecNac)).Day);
            if (Convert.ToInt16(mes) < 10)
            {
                mes = string.Concat("0", mes);
            }
            if (Convert.ToInt16(dia) < 10)
            {
                dia = string.Concat("0", dia);
            }
            TextBoxFNac.Text = string.Concat((Convert.ToDateTime(EntPersona.PersonasPadFecNac)).Year, "-", mes, "-", dia);

            TextBoxTelefono.Text = EntPersona.PersonasPadTelefono;

            ButtonModificar.Visible = true;
            ButtonEliminar.Visible = true;

            Session["codpersona"] = EntPersona.PersonasPadId;
        }

        protected void ButtonModificar_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt16(Session["codpersona"]);
            PersonasPad EntPersona = new PersonasPad();
            EntPersona.PersonasPadDni = Convert.ToInt32(TextBoxDNI.Text);
            EntPersona.PersonasPadNombre = TextBoxNombre.Text;
            EntPersona.PersonasPAdApellido = TextBoxApellido.Text;
            EntPersona.LocalidadPId = Convert.ToSByte(DropDownList1.SelectedIndex + 1);
            EntPersona.PersonasPadTelefono = TextBoxTelefono.Text;
            EntPersona.PersonasPadFecNac = Convert.ToDateTime(TextBoxFNac.Text);
            EntPersona.PersonasPadEstado = 1;

            MAPEO OMapeo = new MAPEO();
            OMapeo.ModificaPersona(EntPersona, cod);

            Server.Transfer("Inicio.aspx");
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt16(Session["codpersona"]);
            MAPEO OMapeo = new MAPEO();
            OMapeo.EliminarPersona(cod);

            List<ReservaCanPad> LEntReserva = new List<ReservaCanPad>();
            List<TurnoFijoCanPad> LEntTurno = new List<TurnoFijoCanPad>();

            LEntReserva = OMapeo.RecuperarTodasReservaSocio(cod);
            LEntTurno = OMapeo.RecuperarTodosTurnosSocio(cod);

            for (int i = 0; i < LEntReserva.Count(); i++)
            {
                if (Convert.ToDateTime(LEntReserva.ElementAt(i).ReservaCanPadFecha).Date >= Convert.ToDateTime(DateTime.Now).Date)
                {
                    ReservaCanPad EntReserva = new ReservaCanPad();
                    EntReserva = LEntReserva.ElementAt(i);

                    EntReserva.ReservaCanPadEstado = 0;

                    OMapeo.ModificarReserva(EntReserva, EntReserva.ReservaCanPadId);
                }
            }

            for (int i = 0; i < LEntTurno.Count(); i++)
            {
                TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
                EntTurno = LEntTurno.ElementAt(i);

                EntTurno.TurnoFijoCanPadEstado = 0;
                EntTurno.PersonasPadId = 0;
                OMapeo.ModificarTurnoFijo(EntTurno, EntTurno.TurnoFijoCanPadId);
            }

            Server.Transfer("Inicio.aspx");
        }
    }
}