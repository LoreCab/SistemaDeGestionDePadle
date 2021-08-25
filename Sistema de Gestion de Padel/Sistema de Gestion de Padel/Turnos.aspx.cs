using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_Gestion_de_Padel
{
    public partial class Turnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            Cancha EntCancha = new Cancha();

            EntCancha = OMapeo.RecuperarCancha(Convert.ToInt16(GridView1.SelectedDataKey.Value.ToString()));
            Label6.Visible = true;
            TextBoxFechaReserva.Visible = true;
            TextBoxFechaReserva.Text = "";

            Session["codcancha"] = EntCancha.CanchaId;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona = new PersonasPad();

            EntPersona = OMapeo.RecuperarPersonaDNI(Convert.ToInt32(TextBoxDNI.Text));
            if (EntPersona != null)
            {
                GridView1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                Label4.Visible = true;
                Label5.Visible = true;
                Label2.Text = EntPersona.PersonasPAdApellido + ", " + EntPersona.PersonasPadNombre;
                Label3.Text = Convert.ToString(EntPersona.PersonasPadId);
                LabelError.Visible = false;
                Session["codpersona"] = EntPersona.PersonasPadId;
            }
            else
            {
                LabelError.Visible = true;
            }
        }

        protected void TextBoxFechaReserva_TextChanged(object sender, EventArgs e)
        {
            DateTime dia = Convert.ToDateTime(TextBoxFechaReserva.Text);
            DateTime hoy = DateTime.Now;

            if (dia.Date >= hoy.Date)
            {
                DropDownList1.Visible = true;
                Button2.Visible = true;
                LabelFijo.Visible = true;
                DropDownList3.Visible = true;
                Label9.Visible = true;
                Label10.Visible = false;
            }
            else
            {
                DropDownList1.Visible = false;
                Button2.Visible = false;
                LabelFijo.Visible = false;
                DropDownList3.Visible = false;
                Label9.Visible = false;
                Label10.Text = "* La fecha ingresada es incorrecta, ingrese una nueva fecha";
                Label10.Visible = true;
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DateTime dia = Convert.ToDateTime(TextBoxFechaReserva.Text);
            int idcancha = Convert.ToInt16(Session["codcancha"]);

            MAPEO OMapeo = new MAPEO();
            Cancha EntCancha = new Cancha();
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            ReservaCanPad EntReserva = new ReservaCanPad();

            

            if (Convert.ToInt16(DropDownList3.SelectedValue) == 0)
            {
                EntReserva = OMapeo.RecuperarReserva(Convert.ToInt16(DropDownList1.SelectedValue), dia, idcancha);
                EntTurno = OMapeo.RecuperarTurno(Convert.ToInt16(DropDownList1.SelectedValue), Convert.ToInt16(dia.DayOfWeek), idcancha);
                if (EntTurno == null)
                {
                    if (EntReserva != null)
                    {
                        LabelReservaError.Text = "La fecha ya se encuentra reservada";
                        LabelReservaError.Visible = true;
                        GridView2.Visible = true;
                        Panel1.Visible = false;
                        ButtonGuardarReserva.Visible = false;
                    }
                    else
                    {
                        GridView2.Visible = false;
                        GridView3.Visible = false;
                        Label8.Visible = false;
                        GridView4.Visible = false;
                        Label7.Visible = false;
                        Panel1.Visible = true;
                        ButtonGuardarReserva.Visible = true;
                    }
                }
                else
                {
                    LabelError.Text = "La fecha tiene un turno fijo asignado";
                    LabelError.Visible = true;
                    GridView2.Visible = true;
                    Panel1.Visible = false;
                    ButtonGuardarReserva.Visible = false;
                }
            }
            else
            {
                if (Convert.ToInt16(DropDownList3.SelectedValue) == 1)
                {
                    EntReserva = OMapeo.RecuperarReserva(Convert.ToInt16(DropDownList1.SelectedValue), dia, idcancha);
                    EntTurno = OMapeo.RecuperarTurno(Convert.ToInt16(DropDownList1.SelectedValue), Convert.ToInt16(dia.DayOfWeek), idcancha);

                    if (EntReserva != null)
                    {
                        LabelReservaError.Text = "La fecha ya se encuentra reservada";
                        LabelReservaError.Visible = true;
                        GridView2.Visible = true;
                        Panel1.Visible = false;
                        ButtonGuardarReserva.Visible = false;
                    }
                    else
                    {
                        LabelReservaError.Visible = false;
                        GridView2.Visible = false;
                        Panel1.Visible = true;
                        ButtonGuardarReserva.Visible = true;
                    }

                    if (EntTurno != null)
                    {
                        LabelReservaError.Text = "La fecha para el turno fijo ya se encuentra reservada";
                        LabelReservaError.Visible = true;
                        Panel1.Visible = false;
                        ButtonGuardarReserva.Visible = false;

                        if (idcancha == 1)
                        {
                            GridView3.Visible = true;
                            Label8.Visible = true;
                            GridView4.Visible = false;
                            Label7.Visible = false;
                        }
                        else
                        {
                            GridView3.Visible = false;
                            Label8.Visible = false;
                            GridView4.Visible = true;
                            Label7.Visible = true;
                        }

                    }
                    else
                    {
                        LabelReservaError.Visible = false;
                        Panel1.Visible = true;
                        ButtonGuardarReserva.Visible = true;
                        GridView3.Visible = false;
                        Label8.Visible = false;
                        GridView4.Visible = false;
                        Label7.Visible = false;
                    }

                }
            }
        }

        protected void ButtonGuardarReserva_Click(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            ReservaCanPad EntReserva = new ReservaCanPad();
            int idcancha = Convert.ToInt16(Session["codcancha"]);
            int idsocio = Convert.ToInt16(Session["codpersona"]);
            DateTime dia = Convert.ToDateTime(TextBoxFechaReserva.Text);

            EntReserva.ReservaCanPadDia = Convert.ToInt16(dia.DayOfWeek);
            EntReserva.ReservaCanPadFecha = Convert.ToDateTime(TextBoxFechaReserva.Text);
            EntReserva.ReservaCanPadHora = Convert.ToByte(DropDownList1.SelectedValue);
            EntReserva.PersonasPadId = Convert.ToByte(idsocio);
            EntReserva.CanchaId = idcancha;
            EntReserva.ReservaCanPadEstado = 1;
            EntReserva.ReservaCanPadPago = Convert.ToByte(DropDownList2.SelectedValue);
            EntReserva.ReservaCanPadTipo = Convert.ToByte(DropDownList3.SelectedValue);

            OMapeo.AltaReserva(EntReserva);

            if (Convert.ToInt16(DropDownList2.SelectedValue) == 0)
            {
                PersonasPad EntPersona = new PersonasPad();
                EntPersona = OMapeo.RecuperarPersona(idsocio);
                EntPersona.PersonasPadDeuda = (EntPersona.PersonasPadDeuda + 150);
                OMapeo.ModificaPersona(EntPersona, EntPersona.PersonasPadId);
            }

            if (Convert.ToInt16(DropDownList3.SelectedValue) == 1)
            {
                TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();

                EntTurno = OMapeo.RecuperaTurnoLibre(Convert.ToInt16(DropDownList1.SelectedValue), Convert.ToInt16(dia.DayOfWeek), idcancha);

                EntTurno.TurnoFijoCanPadFecha = Convert.ToDateTime(TextBoxFechaReserva.Text);
                EntTurno.PersonasPadId = idsocio;
                EntTurno.TurnoFijoCanPadEstado = 1;

                OMapeo.ModificarTurnoFijo(EntTurno, EntTurno.TurnoFijoCanPadId);
            }
            Server.Transfer("Inicio.aspx");
        }
    }
}