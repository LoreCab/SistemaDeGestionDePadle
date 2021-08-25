using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Sistema_de_Gestion_de_Padel.Operario
{
    public partial class Reservas : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["SistemaDeGestionDePadelConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            if ((DropDownList3.SelectedValue != "Seleccione") && (Convert.ToDateTime(TextBoxFechaReserva.Text).Date >= DateTime.Now.Date))
            {
                Label10.Visible = false;
                Panel2.Visible = true;
                
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        string fecha = Convert.ToDateTime(TextBoxFechaReserva.Text).ToString("yyyyMMdd");

                        SqlDataAdapter da = new SqlDataAdapter("SELECT ReservaCanPadId AS CODIGO, [ReservaCanPadHora] AS HORA, ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS SOCIO, [ReservaCanPadTipo] AS TIPO FROM [ReservaCanPad] INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = ReservaCanPad.PersonasPadId WHERE ReservaCanPadEstado = 1 AND  CONVERT(char(10), [ReservaCanPadFecha], 112) = " + fecha +" ORDER BY [ReservaCanPadHora]", con);
                        DataSet di = new DataSet();

                        da.Fill(di);


                        GridView2.DataSource = di;
                        GridView2.DataBind();
                    }

                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        SqlDataAdapter da = new SqlDataAdapter("SELECT TurnoFijoCanPadId AS CODIGO, CONVERT(char(10), [TurnoFijoCanPadHora], 103) AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], TurnoFijoCanPadEstado AS [ESTADO] FROM [TurnoFijoCanPad] INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId WHERE (([TurnoFijoCanPadDia] =" + Convert.ToInt16(Convert.ToDateTime(TextBoxFechaReserva.Text).DayOfWeek) + ") and ([CanchaId] =" + (DropDownList4.SelectedIndex + 1) + "))", con);
                        DataSet ds = new DataSet();

                        da.Fill(ds);


                        GridView3.DataSource = ds;
                        GridView3.DataBind();
                    }
                
                Label8.Text = string.Concat("Reservas fijas ", DropDownList4.SelectedItem);

                List<TurnoFijoCanPad> LEntTurno = new List<TurnoFijoCanPad>();
                List<ReservaCanPad> LEntReserva = new List<ReservaCanPad>();

                int dia = Convert.ToInt16(Convert.ToDateTime(TextBoxFechaReserva.Text).DayOfWeek);
                LEntTurno = OMapeo.RecuperaTurnosDiaCancha(Convert.ToInt16(Convert.ToDateTime(TextBoxFechaReserva.Text).DayOfWeek), DropDownList4.SelectedIndex + 1);
                LEntReserva = OMapeo.RecuperaReservaFecha(Convert.ToDateTime(TextBoxFechaReserva.Text));

                if (LEntReserva.Count() > 0)
                {
                    for (int i = 0; i < LEntTurno.Count(); i++)
                    {
                        for (int j = 0; j < LEntReserva.Count(); j++)
                        {
                            if ((LEntTurno.ElementAt(i).TurnoFijoCanPadHora == LEntReserva.ElementAt(j).ReservaCanPadHora) && (LEntTurno.ElementAt(i).TurnoFijoCanPadEstado == 0))
                            {
                                LEntTurno.ElementAt(i).TurnoFijoCanPadEstado = 1;
                            }
                        }
                    }
                }

                List<TurnoFijoCanPad> Aux = new List<TurnoFijoCanPad>();

                for (int i = 0; i < LEntTurno.Count(); i++)
                {
                    if (LEntTurno.ElementAt(i).TurnoFijoCanPadEstado == 0)
                    {
                        Aux.Add(LEntTurno.ElementAt(i));
                    }
                }

                for (int i = 0; i < Aux.Count(); i++)
                {
                    DropDownList1.Items.Add(Convert.ToString(Aux.ElementAt(i).TurnoFijoCanPadHora));
                }
            }
            else
            {
                Label10.Visible = true;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona = new PersonasPad();

            EntPersona = OMapeo.RecuperarPersonaDNI(Convert.ToInt32(TextBoxDNI.Text));
            if (EntPersona != null)
            {
                Label2.Text = EntPersona.PersonasPAdApellido + ", " + EntPersona.PersonasPadNombre;
                Label3.Text = Convert.ToString(EntPersona.PersonasPadId);
                LabelError.Visible = false;
                Session["codpersona"] = EntPersona.PersonasPadId;
                Panel3.Visible = true;
            }
            else
            {
                LabelError.Visible = true;
                Panel3.Visible = false;
            }
        }

        protected void ButtonGuardarReserva_Click(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            ReservaCanPad EntReserva = new ReservaCanPad();
            int idcancha = Convert.ToInt32(DropDownList4.SelectedIndex) + 1;
            int idsocio = Convert.ToInt16(Session["codpersona"]);
            DateTime dia = Convert.ToDateTime(TextBoxFechaReserva.Text);

            EntReserva.ReservaCanPadDia = Convert.ToInt16(dia.DayOfWeek);
            EntReserva.ReservaCanPadFecha = Convert.ToDateTime(TextBoxFechaReserva.Text);
            EntReserva.ReservaCanPadHora = Convert.ToByte(DropDownList1.SelectedValue);
            EntReserva.PersonasPadId = Convert.ToByte(idsocio);
            EntReserva.CanchaId = idcancha;
            EntReserva.ReservaCanPadEstado = 1;
            EntReserva.ReservaCanPadPago = 0;
            EntReserva.ReservaCanPadTipo = Convert.ToByte(DropDownList3.SelectedValue);

            OMapeo.AltaReserva(EntReserva);

            PersonasPad EntPersona = new PersonasPad();
            EntPersona = OMapeo.RecuperarPersona(idsocio);
            EntPersona.PersonasPadDeuda = EntPersona.PersonasPadDeuda + 150;
            OMapeo.ModificaPersona(EntPersona, EntPersona.PersonasPadId);

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

        protected void GridView3_RowDataBound(object sender, GridViewRowEventArgs e) //GRID DE TURNOS FIJOS
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int estado = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "ESTADO").ToString());
                if (estado == 1)
                {
                    string hex = "#00BFFF";
                    e.Row.ForeColor = System.Drawing.Color.White;
                    e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml(hex);
                }
                else
                {
                    string hex = "#80FF00";
                    e.Row.ForeColor = System.Drawing.Color.Black;
                    e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml(hex);
                }
            }
        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e) //GRID DE RESERVAS
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