using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_Gestion_de_Padel
{
    public partial class Inicio_Cierre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonInicio_Click(object sender, EventArgs e)
        {
            DateTime dia = Convert.ToDateTime(DateTime.Now);

            MAPEO OMapeo = new MAPEO();
            List<TurnoFijoCanPad> LEntTurno = new List<TurnoFijoCanPad>();
            List<ReservaCanPad> LEntReserva = new List<ReservaCanPad>();

            LEntTurno =  OMapeo.RecuperaTurnosFecha(Convert.ToInt16(dia.DayOfWeek));
            LEntReserva = OMapeo.RecuperaReservaFecha(dia);

            bool band = false;

            if (LEntTurno.Count() > 0)
            {
                if (LEntReserva.Count() > 0)
                {
                    TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
                    EntTurno = LEntTurno.ElementAt(0);

                    for (int j = 0; j < LEntReserva.Count(); j++)
                    {
                        if ((EntTurno.TurnoFijoCanPadHora == LEntReserva.ElementAt(j).ReservaCanPadHora) && (EntTurno.CanchaId == LEntReserva.ElementAt(j).CanchaId))// && (EntTurno.PersonasPadId == LEntReserva.ElementAt(j).PersonasPadId))
                        {
                            band = false;
                        }
                        else
                        {
                            band = true;
                        }
                    }
                }
                else
                {
                    band = true;
                }

                if (band == true)
                {
                    LabelError.Visible = false;

                    for (int i = 0; i < LEntTurno.Count(); i++)
                    {
                        TurnoFijoCanPad EntTurnoFijo = new TurnoFijoCanPad();
                        EntTurnoFijo = LEntTurno.ElementAt(i);

                        ReservaCanPad EntReserva = new ReservaCanPad();
                        EntReserva.ReservaCanPadDia = EntTurnoFijo.TurnoFijoCanPadDia;
                        EntReserva.ReservaCanPadFecha = Convert.ToDateTime(DateTime.Now);
                        EntReserva.ReservaCanPadHora = EntTurnoFijo.TurnoFijoCanPadHora;
                        EntReserva.PersonasPadId = EntTurnoFijo.PersonasPadId;
                        EntReserva.CanchaId = EntTurnoFijo.CanchaId;
                        EntReserva.ReservaCanPadEstado = EntTurnoFijo.TurnoFijoCanPadEstado;
                        EntReserva.ReservaCanPadPago = 0;
                        EntReserva.ReservaCanPadTipo = 1;

                        OMapeo.AltaReserva(EntReserva);

                        PersonasPad EntPersona = new PersonasPad();

                        EntPersona = OMapeo.RecuperarPersona(EntReserva.PersonasPadId);
                        EntPersona.PersonasPadDeuda = (EntPersona.PersonasPadDeuda + 150);
                        OMapeo.ModificaPersona(EntPersona, EntPersona.PersonasPadId);
                    }
                }
                else
                {
                    LabelError.Text = "*YA se inicio el día";
                    LabelError.Visible = true;
                }
            }

            Server.Transfer("Inicio.aspx");
        }

        protected void ButtonFinalizar_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            MAPEO OMapeo = new MAPEO();
            List<ReservaCanPad> LEntReserva = new List<ReservaCanPad>();

            LEntReserva = OMapeo.RecuperaReservaFecha(DateTime.Now);
            int Pago = 0;
            int Deuda = 0;
            int Total = LEntReserva.Count();
            for (int i = 0; i < Total; i++)
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

            TextBoxTotalReservas.Text = Convert.ToString(LEntReserva.Count());
            TextBoxPago.Text = "$ " + Convert.ToString(Pago * 150);
            TextBoxDeuda.Text = "$ " + Convert.ToString(Deuda * 150);
        }

    }
}