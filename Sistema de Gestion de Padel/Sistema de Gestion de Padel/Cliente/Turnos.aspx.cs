using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_Gestion_de_Padel.Cliente
{
    public partial class Turnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            Label2.Text = (Convert.ToDateTime(TextBoxFecha.Text)).ToLongDateString().ToUpper();
            Panel1.Visible = true;

            DateTime dia = Convert.ToDateTime(TextBoxFecha.Text);

            MAPEO OMapeo = new MAPEO();
            List<TurnoFijoCanPad> LEntTurno = new List<TurnoFijoCanPad>();
            List<ReservaCanPad> LEntReserva = new List<ReservaCanPad>();

            LEntTurno = OMapeo.RecuperaTurnosFecha(Convert.ToInt16(dia.DayOfWeek));
            LEntReserva = OMapeo.RecuperaReservaSoloFecha(dia);

            if (LEntTurno != null) //Existen turnos fijo
            {
                if (LEntReserva == null) //Existen turnos fijos pero no hay reservas para hoy
                {
                    
                    ReservaCanPad EntReserva = new ReservaCanPad();
                    for (int i = 0; i < LEntTurno.Count(); i++)
                    {
                        EntReserva.ReservaCanPadDia = LEntTurno.ElementAt(i).TurnoFijoCanPadDia;
                        EntReserva.ReservaCanPadFecha = dia;
                        EntReserva.ReservaCanPadHora = LEntTurno.ElementAt(i).TurnoFijoCanPadHora;
                        EntReserva.PersonasPadId = LEntTurno.ElementAt(i).PersonasPadId;
                        EntReserva.CanchaId = LEntTurno.ElementAt(i).CanchaId;
                        EntReserva.ReservaCanPadEstado = LEntTurno.ElementAt(i).TurnoFijoCanPadEstado;
                        EntReserva.ReservaCanPadPago = 0;
                        EntReserva.ReservaCanPadTipo = 1;

                        LEntReserva.Add(EntReserva);
                    }
                }
                else //Existen turnos fijos y reservas para hoy
                {
                    for (int i = 0; i < LEntTurno.Count(); i++) //Recorro la lista de turnos fijos
                    {
                        bool elemento = LEntReserva.Any(x => (x.ReservaCanPadHora == LEntTurno.ElementAt(i).TurnoFijoCanPadHora) && (x.CanchaId == LEntTurno.ElementAt(i).CanchaId));

                        if (elemento == false) //Si no encuentra el elemento i de Turno fijos en la lista de Reservas lo asigna
                        {
                            ReservaCanPad EntReserva = new ReservaCanPad();

                            EntReserva.ReservaCanPadDia = LEntTurno.ElementAt(i).TurnoFijoCanPadDia;
                            EntReserva.ReservaCanPadFecha = dia;
                            EntReserva.ReservaCanPadHora = LEntTurno.ElementAt(i).TurnoFijoCanPadHora;
                            EntReserva.PersonasPadId = LEntTurno.ElementAt(i).PersonasPadId;
                            EntReserva.CanchaId = LEntTurno.ElementAt(i).CanchaId;
                            EntReserva.ReservaCanPadEstado = LEntTurno.ElementAt(i).TurnoFijoCanPadEstado;
                            EntReserva.ReservaCanPadPago = 0;
                            EntReserva.ReservaCanPadTipo = 1;

                            LEntReserva.Add(EntReserva);
                        }
                    }
                }
            }

            LEntReserva = LEntReserva.OrderBy(o => o.ReservaCanPadHora).ToList();

            List<PersonasPad> LEntPersona = new List<PersonasPad>();

            for (int i = 0; i < LEntReserva.Count(); i++)
            {
                PersonasPad EntPersona = new PersonasPad();
                MAPEO ObjMapeo = new MAPEO();
                PersonasPad Aux = new PersonasPad();
                Cancha AuxCancha = new Cancha();

                Aux = ObjMapeo.RecuperarPersona(LEntReserva.ElementAt(i).PersonasPadId);
                AuxCancha = ObjMapeo.RecuperarCancha(LEntReserva.ElementAt(i).CanchaId);

                EntPersona.PersonasPAdApellido = Aux.PersonasPAdApellido + " " + Aux.PersonasPadNombre;
                EntPersona.PersonasPadNombre = AuxCancha.CanchaDescripcion;
                EntPersona.PersonasPadDni = Convert.ToInt32(LEntReserva.ElementAt(i).ReservaCanPadHora);
                EntPersona.PersonasPadEstado = LEntReserva.ElementAt(i).ReservaCanPadTipo;

                LEntPersona.Add(EntPersona);
            }

            GridView1.DataSource = LEntPersona;
            GridView1.DataBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int estado = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "PersonasPadEstado").ToString());
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