using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Sistema_de_Gestion_de_Padel
{
    public partial class Consultar_TurnoFijo : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["SistemaDeGestionDePadelConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "1")
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
            }
            else
            {
                if (DropDownList1.SelectedValue == "2")
                {
                    Panel1.Visible = false;
                    Panel2.Visible = true;
                }
                else
                {
                    Panel1.Visible = false;
                    Panel2.Visible = false;
                }
            }

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TurnoFijoCanPad.TurnoFijoCanPadHora AS HORARIO, MAX(CASE WHEN TurnoFijoCanPad.TurnoFijoCanPadDia = 1 THEN (PersonasPad.PersonasPAdApellido+' '+PersonasPad.PersonasPadNombre) END) AS LUNES, MAX(CASE WHEN TurnoFijoCanPad.TurnoFijoCanPadDia = 2 THEN (PersonasPad.PersonasPAdApellido+' '+PersonasPad.PersonasPadNombre) END) AS MARTES, MAX(CASE WHEN TurnoFijoCanPad.TurnoFijoCanPadDia = 3 THEN (PersonasPad.PersonasPAdApellido+' '+PersonasPad.PersonasPadNombre) END) AS MIERCOLES, MAX(CASE WHEN TurnoFijoCanPad.TurnoFijoCanPadDia = 4 THEN (PersonasPad.PersonasPAdApellido+' '+PersonasPad.PersonasPadNombre) END) AS JUEVES, MAX(CASE WHEN TurnoFijoCanPad.TurnoFijoCanPadDia = 5 THEN (PersonasPad.PersonasPAdApellido+' '+PersonasPad.PersonasPadNombre) END) AS VIERNES, MAX(CASE WHEN TurnoFijoCanPad.TurnoFijoCanPadDia = 6 THEN (PersonasPad.PersonasPAdApellido+' '+PersonasPad.PersonasPadNombre) END) AS SABADO FROM TurnoFijoCanPad INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId WHERE TurnoFijoCanPad.CanchaId ="+ Convert.ToInt16(DropDownList1.SelectedValue) +"GROUP BY TurnoFijoCanPad.TurnoFijoCanPadHora",con);
                DataSet ds = new DataSet();

                da.Fill(ds);

                List<TurnoFijoCanPad> ListTF = new List<TurnoFijoCanPad>();


                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }

        #region PANEL 1
        protected void GridViewLunesI_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel3.Visible = true;

            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona = new PersonasPad();
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            Cancha EntCancha = new Cancha();

            EntTurno = OMapeo.RecuperaUnTurnoFijo(Convert.ToInt16(GridViewLunesI.SelectedDataKey.Value.ToString()));
            EntPersona = OMapeo.RecuperarPersona(EntTurno.PersonasPadId);
            EntCancha = OMapeo.RecuperarCancha(EntTurno.CanchaId);

            TextBoxNombreSocio.Text = EntPersona.PersonasPAdApellido + ' ' + EntPersona.PersonasPadNombre;
            TextBoxCancha.Text = EntCancha.CanchaDescripcion;
            TextBoxHora.Text = Convert.ToString(EntTurno.TurnoFijoCanPadHora);
            TextBoxDia.Text = Convert.ToString(EntTurno.TurnoFijoCanPadDia);

            Session["turno"] = EntTurno;
        }

        protected void GridViewMartesI_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel3.Visible = true;

            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona = new PersonasPad();
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            Cancha EntCancha = new Cancha();

            EntTurno = OMapeo.RecuperaUnTurnoFijo(Convert.ToInt16(GridViewMartesI.SelectedDataKey.Value.ToString()));
            EntPersona = OMapeo.RecuperarPersona(EntTurno.PersonasPadId);
            EntCancha = OMapeo.RecuperarCancha(EntTurno.CanchaId);

            TextBoxNombreSocio.Text = EntPersona.PersonasPAdApellido + ' ' + EntPersona.PersonasPadNombre;
            TextBoxCancha.Text = EntCancha.CanchaDescripcion;
            TextBoxHora.Text = Convert.ToString(EntTurno.TurnoFijoCanPadHora);
            TextBoxDia.Text = Convert.ToString(EntTurno.TurnoFijoCanPadDia);

            Session["turno"] = EntTurno;
        }

        protected void GridViewMiercolesI_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel3.Visible = true;

            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona = new PersonasPad();
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            Cancha EntCancha = new Cancha();

            EntTurno = OMapeo.RecuperaUnTurnoFijo(Convert.ToInt16(GridViewMiercolesI.SelectedDataKey.Value.ToString()));
            EntPersona = OMapeo.RecuperarPersona(EntTurno.PersonasPadId);
            EntCancha = OMapeo.RecuperarCancha(EntTurno.CanchaId);

            TextBoxNombreSocio.Text = EntPersona.PersonasPAdApellido + ' ' + EntPersona.PersonasPadNombre;
            TextBoxCancha.Text = EntCancha.CanchaDescripcion;
            TextBoxHora.Text = Convert.ToString(EntTurno.TurnoFijoCanPadHora);
            TextBoxDia.Text = Convert.ToString(EntTurno.TurnoFijoCanPadDia);

            Session["turno"] = EntTurno;
        }

        protected void GridViewJueves_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel3.Visible = true;

            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona = new PersonasPad();
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            Cancha EntCancha = new Cancha();

            EntTurno = OMapeo.RecuperaUnTurnoFijo(Convert.ToInt16(GridViewJueves.SelectedDataKey.Value.ToString()));
            EntPersona = OMapeo.RecuperarPersona(EntTurno.PersonasPadId);
            EntCancha = OMapeo.RecuperarCancha(EntTurno.CanchaId);

            TextBoxNombreSocio.Text = EntPersona.PersonasPAdApellido + ' ' + EntPersona.PersonasPadNombre;
            TextBoxCancha.Text = EntCancha.CanchaDescripcion;
            TextBoxHora.Text = Convert.ToString(EntTurno.TurnoFijoCanPadHora);
            TextBoxDia.Text = Convert.ToString(EntTurno.TurnoFijoCanPadDia);

            Session["turno"] = EntTurno;
        }

        protected void GridViewViernesI_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel3.Visible = true;

            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona = new PersonasPad();
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            Cancha EntCancha = new Cancha();

            EntTurno = OMapeo.RecuperaUnTurnoFijo(Convert.ToInt16(GridViewViernesI.SelectedDataKey.Value.ToString()));
            EntPersona = OMapeo.RecuperarPersona(EntTurno.PersonasPadId);
            EntCancha = OMapeo.RecuperarCancha(EntTurno.CanchaId);

            TextBoxNombreSocio.Text = EntPersona.PersonasPAdApellido + ' ' + EntPersona.PersonasPadNombre;
            TextBoxCancha.Text = EntCancha.CanchaDescripcion;
            TextBoxHora.Text = Convert.ToString(EntTurno.TurnoFijoCanPadHora);
            TextBoxDia.Text = Convert.ToString(EntTurno.TurnoFijoCanPadDia);

            Session["turno"] = EntTurno;
        }

        protected void GridViewSabadoI_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel3.Visible = true;

            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona = new PersonasPad();
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            Cancha EntCancha = new Cancha();

            EntTurno = OMapeo.RecuperaUnTurnoFijo(Convert.ToInt16(GridViewSabadoI.SelectedDataKey.Value.ToString()));
            EntPersona = OMapeo.RecuperarPersona(EntTurno.PersonasPadId);
            EntCancha = OMapeo.RecuperarCancha(EntTurno.CanchaId);

            TextBoxNombreSocio.Text = EntPersona.PersonasPAdApellido + ' ' + EntPersona.PersonasPadNombre;
            TextBoxCancha.Text = EntCancha.CanchaDescripcion;
            TextBoxHora.Text = Convert.ToString(EntTurno.TurnoFijoCanPadHora);
            TextBoxDia.Text = Convert.ToString(EntTurno.TurnoFijoCanPadDia);

            Session["turno"] = EntTurno;
        }
        #endregion

        #region PANEL 2
        protected void GridViewLunesII_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel3.Visible = true;

            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona = new PersonasPad();
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            Cancha EntCancha = new Cancha();

            EntTurno = OMapeo.RecuperaUnTurnoFijo(Convert.ToInt16(GridViewLunesII.SelectedDataKey.Value.ToString()));
            EntPersona = OMapeo.RecuperarPersona(EntTurno.PersonasPadId);
            EntCancha = OMapeo.RecuperarCancha(EntTurno.CanchaId);

            TextBoxNombreSocio.Text = EntPersona.PersonasPAdApellido + ' ' + EntPersona.PersonasPadNombre;
            TextBoxCancha.Text = EntCancha.CanchaDescripcion;
            TextBoxHora.Text = Convert.ToString(EntTurno.TurnoFijoCanPadHora);
            TextBoxDia.Text = Convert.ToString(EntTurno.TurnoFijoCanPadDia);

            Session["turno"] = EntTurno;
        }

        protected void GridViewMartesII_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel3.Visible = true;

            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona = new PersonasPad();
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            Cancha EntCancha = new Cancha();

            EntTurno = OMapeo.RecuperaUnTurnoFijo(Convert.ToInt16(GridViewMartesII.SelectedDataKey.Value.ToString()));
            EntPersona = OMapeo.RecuperarPersona(EntTurno.PersonasPadId);
            EntCancha = OMapeo.RecuperarCancha(EntTurno.CanchaId);

            TextBoxNombreSocio.Text = EntPersona.PersonasPAdApellido + ' ' + EntPersona.PersonasPadNombre;
            TextBoxCancha.Text = EntCancha.CanchaDescripcion;
            TextBoxHora.Text = Convert.ToString(EntTurno.TurnoFijoCanPadHora);
            TextBoxDia.Text = Convert.ToString(EntTurno.TurnoFijoCanPadDia);

            Session["turno"] = EntTurno;
        }

        protected void GridViewMiercolesII_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel3.Visible = true;

            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona = new PersonasPad();
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            Cancha EntCancha = new Cancha();

            EntTurno = OMapeo.RecuperaUnTurnoFijo(Convert.ToInt16(GridViewMierolesII.SelectedDataKey.Value.ToString()));
            EntPersona = OMapeo.RecuperarPersona(EntTurno.PersonasPadId);
            EntCancha = OMapeo.RecuperarCancha(EntTurno.CanchaId);

            TextBoxNombreSocio.Text = EntPersona.PersonasPAdApellido + ' ' + EntPersona.PersonasPadNombre;
            TextBoxCancha.Text = EntCancha.CanchaDescripcion;
            TextBoxHora.Text = Convert.ToString(EntTurno.TurnoFijoCanPadHora);
            TextBoxDia.Text = Convert.ToString(EntTurno.TurnoFijoCanPadDia);

            Session["turno"] = EntTurno;
        }

        protected void GridViewJuevesII_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel3.Visible = true;

            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona = new PersonasPad();
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            Cancha EntCancha = new Cancha();

            EntTurno = OMapeo.RecuperaUnTurnoFijo(Convert.ToInt16(GridViewJuevesII.SelectedDataKey.Value.ToString()));
            EntPersona = OMapeo.RecuperarPersona(EntTurno.PersonasPadId);
            EntCancha = OMapeo.RecuperarCancha(EntTurno.CanchaId);

            TextBoxNombreSocio.Text = EntPersona.PersonasPAdApellido + ' ' + EntPersona.PersonasPadNombre;
            TextBoxCancha.Text = EntCancha.CanchaDescripcion;
            TextBoxHora.Text = Convert.ToString(EntTurno.TurnoFijoCanPadHora);
            TextBoxDia.Text = Convert.ToString(EntTurno.TurnoFijoCanPadDia);

            Session["turno"] = EntTurno;
        }

        protected void GridViewViernesII_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel3.Visible = true;

            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona = new PersonasPad();
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            Cancha EntCancha = new Cancha();

            EntTurno = OMapeo.RecuperaUnTurnoFijo(Convert.ToInt16(GridViewViernesII.SelectedDataKey.Value.ToString()));
            EntPersona = OMapeo.RecuperarPersona(EntTurno.PersonasPadId);
            EntCancha = OMapeo.RecuperarCancha(EntTurno.CanchaId);

            TextBoxNombreSocio.Text = EntPersona.PersonasPAdApellido + ' ' + EntPersona.PersonasPadNombre;
            TextBoxCancha.Text = EntCancha.CanchaDescripcion;
            TextBoxHora.Text = Convert.ToString(EntTurno.TurnoFijoCanPadHora);
            TextBoxDia.Text = Convert.ToString(EntTurno.TurnoFijoCanPadDia);

            Session["turno"] = EntTurno;
        }

        protected void GridViewSabadoII_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel3.Visible = true;

            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona = new PersonasPad();
            TurnoFijoCanPad EntTurno = new TurnoFijoCanPad();
            Cancha EntCancha = new Cancha();

            EntTurno = OMapeo.RecuperaUnTurnoFijo(Convert.ToInt16(GridViewSabadoII.SelectedDataKey.Value.ToString()));
            EntPersona = OMapeo.RecuperarPersona(EntTurno.PersonasPadId);
            EntCancha = OMapeo.RecuperarCancha(EntTurno.CanchaId);

            TextBoxNombreSocio.Text = EntPersona.PersonasPAdApellido + ' ' + EntPersona.PersonasPadNombre;
            TextBoxCancha.Text = EntCancha.CanchaDescripcion;
            TextBoxHora.Text = Convert.ToString(EntTurno.TurnoFijoCanPadHora);
            TextBoxDia.Text = Convert.ToString(EntTurno.TurnoFijoCanPadDia);

            Session["turno"] = EntTurno;
        }
        #endregion

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

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string estado = (DataBinder.Eval(e.Row.DataItem, "LUNES").ToString());
                if (estado == "TURNO DISPONIBLE")
                {
                    e.Row.ForeColor = System.Drawing.Color.Black;
                    e.Row.BackColor = System.Drawing.Color.Aquamarine;
                }
            }
        }

        protected void GridViewLunesI_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int estado = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "ESTADO").ToString());
                if (estado == 1)
                {
                    e.Row.ForeColor = System.Drawing.Color.Black;
                    e.Row.BackColor = System.Drawing.Color.Aquamarine;
                }
            }
        }

        protected void GridViewMartesI_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int estado = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "ESTADO").ToString());
                if (estado == 1)
                {
                    e.Row.ForeColor = System.Drawing.Color.Black;
                    e.Row.BackColor = System.Drawing.Color.Aquamarine;
                }
            }
        }

    }
}