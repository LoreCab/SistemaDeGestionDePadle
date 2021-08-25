using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_Gestion_de_Padel.Operario
{
    public partial class Inicio_Cierre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            Historial EntHistorial = new Historial();
            EntHistorial = OMapeo.RecuperarHistorial(Convert.ToDateTime(DateTime.Now));

            if (EntHistorial != null)
            {
                ButtonFinalizar.Visible = true;
                ButtonInicio.Visible = false;
            }
            else
            {
                ButtonInicio.Visible = true;
                ButtonFinalizar.Visible = false;
            }
        }

        protected void ButtonInicio_Click(object sender, EventArgs e)
        {
            DateTime dia = Convert.ToDateTime(DateTime.Now);

            MAPEO OMapeo = new MAPEO();
            List<TurnoFijoCanPad> LEntTurno = new List<TurnoFijoCanPad>();
            List<ReservaCanPad> LEntReserva = new List<ReservaCanPad>();
            Historial EntHistorial = new Historial();

            LEntTurno = OMapeo.RecuperaTurnosFecha(Convert.ToInt16(dia.DayOfWeek));
            LEntReserva = OMapeo.RecuperaReservaFecha(dia);
            EntHistorial = OMapeo.RecuperarHistorial(dia);

            if (EntHistorial == null) //Historial es null es porque no se inicio el día
            {
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
                            OMapeo.AltaReserva(EntReserva);
                        }
                        Historial EntHistorial1 = new Historial();
                        EntHistorial1.Fecha = dia;
                        OMapeo.AltaHistorial(EntHistorial1);
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
                                OMapeo.AltaReserva(EntReserva);

                                PersonasPad EntPersona = new PersonasPad();
                                EntPersona = OMapeo.RecuperarPersona(LEntTurno.ElementAt(i).PersonasPadId);
                                EntPersona.PersonasPadDeuda = EntPersona.PersonasPadDeuda + 150;
                                OMapeo.ModificaPersona(EntPersona, EntPersona.PersonasPadId);
                            }
                        }
                        Historial EntHistorial2 = new Historial();
                        EntHistorial2.Fecha = dia;
                        OMapeo.AltaHistorial(EntHistorial2);
                    }
                }
                else
                {
                    Historial EntHistorial3 = new Historial();
                    EntHistorial3.Fecha = dia;
                    OMapeo.AltaHistorial(EntHistorial3);
                }
            }
        }

        protected void ButtonFinalizar_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = true;

            MAPEO OMapeo = new MAPEO();
            List<ReservaCanPad> LEntReserva = new List<ReservaCanPad>();

            LEntReserva = OMapeo.RecuperaReservaFecha(DateTime.Now);
            int Pago = 0;
            int Deuda = 0;
            int Total = LEntReserva.Count();
            int Extra = 0;
            for (int i = 0; i < Total; i++)
            {
                if ((Convert.ToDateTime(LEntReserva.ElementAt(i).ReservaCanPadFecha).Date) == (DateTime.Now.Date))
                {
                    if (LEntReserva.ElementAt(i).ReservaCanPadPago == 1)
                    {
                        Pago++;
                    }
                    else
                    {
                        Deuda++;
                    }
                }
                else
                {
                    Extra++;
                }
            }

            TextBoxNoPagas.Text = Convert.ToString(Deuda);
            TextBoxPagadoExtra.Text = "$" + Convert.ToString(Extra * 150);
            TextBoxPagadoHoy.Text = "$" + Convert.ToString(Pago * 150);
            TextBoxPagoAnterior.Text = Convert.ToString(Extra);
            TextBoxPagoHoy.Text = Convert.ToString(Pago);
            TextBoxTotalFial.Text = "$" + Convert.ToString((Pago + Extra) * 150);
            TextBoxTotalReservas.Text = Convert.ToString(Pago + Deuda);

            Historial EntHistorial = new Historial();

            EntHistorial = OMapeo.RecuperarHistorial(DateTime.Now);

            EntHistorial.GananciasDiarias = Pago * 150;
            EntHistorial.GananciasExtra = Extra * 150;

            OMapeo.ModificarHistorial(EntHistorial, EntHistorial.HistorialId);

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int estado = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "PAGO").ToString());
                if (estado == 1)
                {
                    string hex = "#80FF00";
                    e.Row.ForeColor = System.Drawing.Color.Black;
                    e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml(hex);
                }
                else
                {
                    string hex = "#FF0000";
                    e.Row.ForeColor = System.Drawing.Color.White;
                    e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml(hex);
                }
            }
        }
    }
}