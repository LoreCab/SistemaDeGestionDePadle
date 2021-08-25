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
    public partial class Consultar_TurnoFijo : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["SistemaDeGestionDePadelConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            LabelCancha.Text = Convert.ToString(DropDownList1.SelectedItem);
            Panel1.Visible = true;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT [TurnoFijoCanPadId] AS Cod, [TurnoFijoCanPadHora] AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO] FROM [TurnoFijoCanPad] INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId WHERE (([TurnoFijoCanPadDia] = 1) and ([CanchaId] =" + (Convert.ToInt16(DropDownList1.SelectedIndex) + 1) + "))", con);
                DataSet ds = new DataSet();

                da.Fill(ds);

                GridViewLunes.DataSource = ds;
                GridViewLunes.DataBind();
            }

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT [TurnoFijoCanPadId] AS Cod, [TurnoFijoCanPadHora] AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO] FROM [TurnoFijoCanPad] INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId WHERE (([TurnoFijoCanPadDia] = 2) and ([CanchaId] =" + (Convert.ToInt16(DropDownList1.SelectedIndex) + 1) + "))", con);
                DataSet ds = new DataSet();

                da.Fill(ds);

                GridViewMartes.DataSource = ds;
                GridViewMartes.DataBind();
            }

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT [TurnoFijoCanPadId] AS Cod, [TurnoFijoCanPadHora] AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO] FROM [TurnoFijoCanPad] INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId WHERE (([TurnoFijoCanPadDia] = 3) and ([CanchaId] =" + (Convert.ToInt16(DropDownList1.SelectedIndex) + 1) + "))", con);
                DataSet ds = new DataSet();

                da.Fill(ds);

                GridViewMiercoles.DataSource = ds;
                GridViewMiercoles.DataBind();
            }

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT [TurnoFijoCanPadId] AS Cod, [TurnoFijoCanPadHora] AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO] FROM [TurnoFijoCanPad] INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId WHERE (([TurnoFijoCanPadDia] = 4) and ([CanchaId] =" + (Convert.ToInt16(DropDownList1.SelectedIndex) + 1) + "))", con);
                DataSet ds = new DataSet();

                da.Fill(ds);

                GridViewJueves.DataSource = ds;
                GridViewJueves.DataBind();
            }

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT [TurnoFijoCanPadId] AS Cod, [TurnoFijoCanPadHora] AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO] FROM [TurnoFijoCanPad] INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId WHERE (([TurnoFijoCanPadDia] = 5) and ([CanchaId] =" + (Convert.ToInt16(DropDownList1.SelectedIndex) + 1) + "))", con);
                DataSet ds = new DataSet();

                da.Fill(ds);

                GridViewViernes.DataSource = ds;
                GridViewViernes.DataBind();
            }

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT [TurnoFijoCanPadId] AS Cod, [TurnoFijoCanPadHora] AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO] FROM [TurnoFijoCanPad] INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId WHERE (([TurnoFijoCanPadDia] = 6) and ([CanchaId] =" + (Convert.ToInt16(DropDownList1.SelectedIndex) + 1) + "))", con);
                DataSet ds = new DataSet();

                da.Fill(ds);

                GridViewSabado.DataSource = ds;
                GridViewSabado.DataBind();
            }
        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            MAPEO OMapeo = new MAPEO();
            ReservaCanPad EntReserva = new ReservaCanPad();

            EntTurno = (TurnoFijoCanPad)(Session["turno"]);

            EntTurno.TurnoFijoCanPadEstado = 0;
            EntTurno.PersonasPadId = 0;
            OMapeo.ModificarTurnoFijo(EntTurno, EntTurno.TurnoFijoCanPadId);

            DateTime hoy = DateTime.Today;

            EntReserva = OMapeo.RecuperarReservaDia(Convert.ToInt16(EntTurno.TurnoFijoCanPadHora), hoy, Convert.ToInt16(EntTurno.CanchaId), Convert.ToInt16(EntTurno.PersonasPadId), Convert.ToInt16(EntTurno.TurnoFijoCanPadDia));

            if (EntReserva != null)
            {
                EntReserva.ReservaCanPadEstado = 0;
                OMapeo.ModificarReserva(EntReserva, EntReserva.ReservaCanPadId);
                PersonasPad EntPersona = new PersonasPad();

                EntPersona = OMapeo.RecuperarPersona(EntReserva.PersonasPadId);
                EntPersona.PersonasPadDeuda = (EntPersona.PersonasPadDeuda - 150);
                OMapeo.ModificaPersona(EntPersona, EntPersona.PersonasPadId);
            }
            Server.Transfer("Inicio.aspx");
        }

        protected void GridViewLunes_RowDataBound(object sender, GridViewRowEventArgs e)
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

        protected void GridViewMartes_RowDataBound(object sender, GridViewRowEventArgs e)
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

        protected void GridViewMiercoles_RowDataBound(object sender, GridViewRowEventArgs e)
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

        protected void GridViewJueves_RowDataBound(object sender, GridViewRowEventArgs e)
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

        protected void GridViewViernes_RowDataBound(object sender, GridViewRowEventArgs e)
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

        protected void GridViewSabado_RowDataBound(object sender, GridViewRowEventArgs e)
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

        protected void GridViewLunes_SelectedIndexChanged(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            EntTurno = OMapeo.RecuperaUnTurnoFijo(Convert.ToInt16(GridViewLunes.SelectedDataKey.Value.ToString()));

            if (EntTurno.PersonasPadId != 0)
            {
                Panel3.Visible = true;
                LabelError.Visible = false;

                PersonasPad EntPersona = new PersonasPad();
                Cancha EntCancha = new Cancha();


                EntPersona = OMapeo.RecuperarPersona(EntTurno.PersonasPadId);
                EntCancha = OMapeo.RecuperarCancha(EntTurno.CanchaId);

                TextBoxNombreSocio.Text = EntPersona.PersonasPAdApellido + ' ' + EntPersona.PersonasPadNombre;
                TextBoxCancha.Text = EntCancha.CanchaDescripcion;
                TextBoxHora.Text = Convert.ToString(EntTurno.TurnoFijoCanPadHora);
                TextBoxDia.Text = Convert.ToString(EntTurno.TurnoFijoCanPadDia);

                Session["turno"] = EntTurno;
            }
            else
            {
                LabelError.Visible = true;
                Panel3.Visible = false;
            }
        }

        protected void GridViewMartes_SelectedIndexChanged(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            EntTurno = OMapeo.RecuperaUnTurnoFijo(Convert.ToInt16(GridViewMartes.SelectedDataKey.Value.ToString()));

            if (EntTurno.PersonasPadId != 0)
            {
                Panel3.Visible = true;
                LabelError.Visible = false;

                PersonasPad EntPersona = new PersonasPad();
                Cancha EntCancha = new Cancha();


                EntPersona = OMapeo.RecuperarPersona(EntTurno.PersonasPadId);
                EntCancha = OMapeo.RecuperarCancha(EntTurno.CanchaId);

                TextBoxNombreSocio.Text = EntPersona.PersonasPAdApellido + ' ' + EntPersona.PersonasPadNombre;
                TextBoxCancha.Text = EntCancha.CanchaDescripcion;
                TextBoxHora.Text = Convert.ToString(EntTurno.TurnoFijoCanPadHora);
                TextBoxDia.Text = Convert.ToString(EntTurno.TurnoFijoCanPadDia);

                Session["turno"] = EntTurno;
            }
            else
            {
                LabelError.Visible = true;
                Panel3.Visible = false;
            }
        }

        protected void GridViewMiercoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            EntTurno = OMapeo.RecuperaUnTurnoFijo(Convert.ToInt16(GridViewMiercoles.SelectedDataKey.Value.ToString()));

            if (EntTurno.PersonasPadId != 0)
            {
                Panel3.Visible = true;
                LabelError.Visible = false;

                PersonasPad EntPersona = new PersonasPad();
                Cancha EntCancha = new Cancha();


                EntPersona = OMapeo.RecuperarPersona(EntTurno.PersonasPadId);
                EntCancha = OMapeo.RecuperarCancha(EntTurno.CanchaId);

                TextBoxNombreSocio.Text = EntPersona.PersonasPAdApellido + ' ' + EntPersona.PersonasPadNombre;
                TextBoxCancha.Text = EntCancha.CanchaDescripcion;
                TextBoxHora.Text = Convert.ToString(EntTurno.TurnoFijoCanPadHora);
                TextBoxDia.Text = Convert.ToString(EntTurno.TurnoFijoCanPadDia);

                Session["turno"] = EntTurno;
            }
            else
            {
                LabelError.Visible = true;
                Panel3.Visible = false;
            }
        }

        protected void GridViewJueves_SelectedIndexChanged(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            EntTurno = OMapeo.RecuperaUnTurnoFijo(Convert.ToInt16(GridViewJueves.SelectedDataKey.Value.ToString()));

            if (EntTurno.PersonasPadId != 0)
            {
                Panel3.Visible = true;
                LabelError.Visible = false;

                PersonasPad EntPersona = new PersonasPad();
                Cancha EntCancha = new Cancha();


                EntPersona = OMapeo.RecuperarPersona(EntTurno.PersonasPadId);
                EntCancha = OMapeo.RecuperarCancha(EntTurno.CanchaId);

                TextBoxNombreSocio.Text = EntPersona.PersonasPAdApellido + ' ' + EntPersona.PersonasPadNombre;
                TextBoxCancha.Text = EntCancha.CanchaDescripcion;
                TextBoxHora.Text = Convert.ToString(EntTurno.TurnoFijoCanPadHora);
                TextBoxDia.Text = Convert.ToString(EntTurno.TurnoFijoCanPadDia);

                Session["turno"] = EntTurno;
            }
            else
            {
                LabelError.Visible = true;
                Panel3.Visible = false;
            }
        }

        protected void GridViewViernes_SelectedIndexChanged(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            EntTurno = OMapeo.RecuperaUnTurnoFijo(Convert.ToInt16(GridViewViernes.SelectedDataKey.Value.ToString()));

            if (EntTurno.PersonasPadId != 0)
            {
                Panel3.Visible = true;
                LabelError.Visible = false;

                PersonasPad EntPersona = new PersonasPad();
                Cancha EntCancha = new Cancha();


                EntPersona = OMapeo.RecuperarPersona(EntTurno.PersonasPadId);
                EntCancha = OMapeo.RecuperarCancha(EntTurno.CanchaId);

                TextBoxNombreSocio.Text = EntPersona.PersonasPAdApellido + ' ' + EntPersona.PersonasPadNombre;
                TextBoxCancha.Text = EntCancha.CanchaDescripcion;
                TextBoxHora.Text = Convert.ToString(EntTurno.TurnoFijoCanPadHora);
                TextBoxDia.Text = Convert.ToString(EntTurno.TurnoFijoCanPadDia);

                Session["turno"] = EntTurno;
            }
            else
            {
                LabelError.Visible = true;
                Panel3.Visible = false;
            }
        }

        protected void GridViewSabado_SelectedIndexChanged(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            EntTurno = OMapeo.RecuperaUnTurnoFijo(Convert.ToInt16(GridViewSabado.SelectedDataKey.Value.ToString()));

            if (EntTurno.PersonasPadId != 0)
            {
                Panel3.Visible = true;
                LabelError.Visible = false;

                PersonasPad EntPersona = new PersonasPad();
                Cancha EntCancha = new Cancha();


                EntPersona = OMapeo.RecuperarPersona(EntTurno.PersonasPadId);
                EntCancha = OMapeo.RecuperarCancha(EntTurno.CanchaId);

                TextBoxNombreSocio.Text = EntPersona.PersonasPAdApellido + ' ' + EntPersona.PersonasPadNombre;
                TextBoxCancha.Text = EntCancha.CanchaDescripcion;
                TextBoxHora.Text = Convert.ToString(EntTurno.TurnoFijoCanPadHora);
                TextBoxDia.Text = Convert.ToString(EntTurno.TurnoFijoCanPadDia);

                Session["turno"] = EntTurno;
            }
            else
            {
                LabelError.Visible = true;
                Panel3.Visible = false;
            }
        }
    }
}