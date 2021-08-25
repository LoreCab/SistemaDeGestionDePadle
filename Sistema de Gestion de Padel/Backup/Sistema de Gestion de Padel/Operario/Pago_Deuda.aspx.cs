using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_Gestion_de_Padel.Operario
{
    public partial class Pago_Deuda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;

            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona = new PersonasPad();
            EntPersona = OMapeo.RecuperarPersonaDNI(Convert.ToInt32(TextBoxDNI.Text));

            Label2.Text = EntPersona.PersonasPAdApellido + " " + EntPersona.PersonasPadNombre;
            Label3.Text = Convert.ToString(EntPersona.PersonasPadId);
            Label6.Text = Convert.ToString(EntPersona.PersonasPadDeuda);

            List<ReservaCanPad> LEntReserva = OMapeo.RecuperarReservaActivasSocio(EntPersona.PersonasPadId);
            List<PersonasPad> LEntPersona = new List<PersonasPad>();
            List<Cancha> LEntCancha = new List<Cancha>();

            for (int i = 0; i < LEntReserva.Count(); i++)
            {
                Cancha EntCancha = new Cancha();
                EntCancha = OMapeo.RecuperarCancha(LEntReserva.ElementAt(i).CanchaId);
                LEntCancha.Add(EntCancha);
            }

            List<PersonasPad> LAuxiliar = new List<PersonasPad>();

            for (int i = 0; i < LEntReserva.Count(); i++)
            {
                PersonasPad Auxiliar = new PersonasPad();

                Auxiliar.PersonasPadId = LEntReserva.ElementAt(i).ReservaCanPadId;
                Auxiliar.PersonasPAdApellido = (Convert.ToDateTime(LEntReserva.ElementAt(i).ReservaCanPadFecha)).ToShortDateString();
                Auxiliar.PersonasPadDni = Convert.ToInt16(LEntReserva.ElementAt(i).ReservaCanPadHora);
                Auxiliar.PersonasPadNombre = LEntCancha.ElementAt(i).CanchaDescripcion;

                LAuxiliar.Add(Auxiliar);
            }

            GridView1.DataSource = LAuxiliar;
            GridView1.DataBind();
            Session["auxiliar"] = LAuxiliar;
            Panel2.Visible = false;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReservaCanPad EntReserva = new ReservaCanPad();
            MAPEO OMapeo = new MAPEO();

            EntReserva = OMapeo.RecuperaReservaCod(Convert.ToInt16(GridView1.SelectedDataKey.Value.ToString()));

            Session["reserva"] = EntReserva;
            Panel2.Visible = true;

            List<PersonasPad> LAuxiliar = new List<PersonasPad>();
            LAuxiliar = (List<PersonasPad>)(Session["auxiliar"]);

            string id = GridView1.SelectedIndex.ToString();

            TextBoxCanchaR.Text = LAuxiliar.ElementAt(Convert.ToInt16(id)).PersonasPadNombre;
            Label8.Text = LAuxiliar.ElementAt(Convert.ToInt16(id)).PersonasPAdApellido;
            TextBoxHoraR.Text = Convert.ToString(LAuxiliar.ElementAt(Convert.ToInt16(id)).PersonasPadDni);
        }

        protected void ButtonPago_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(DropDownList1.SelectedValue) == 1)
            {
                Label7.Text = "";
                ReservaCanPad EntReserva = new ReservaCanPad();
                MAPEO OMapeo = new MAPEO();

                EntReserva = (ReservaCanPad)(Session["reserva"]);

                EntReserva.ReservaCanPadPago = 1;
                EntReserva.ReservaCanPadFechaPago = DateTime.Now;
                OMapeo.ModificarReserva(EntReserva, EntReserva.ReservaCanPadId);

                PersonasPad EntPersona = new PersonasPad();

                EntPersona = OMapeo.RecuperarPersona(EntReserva.PersonasPadId);

                EntPersona.PersonasPadDeuda = (EntPersona.PersonasPadDeuda - 150);
                OMapeo.ModificaPersona(EntPersona, EntPersona.PersonasPadId);

                Server.Transfer("Inicio.aspx");
            }
            else
            {
                if (Convert.ToInt16(DropDownList1.SelectedValue) == 0)
                {
                    Server.Transfer("Inicio.aspx");
                }
                else
                {
                    Label7.Text = "*Debe seleccionar una opción";
                }
            }
        }
    }
}