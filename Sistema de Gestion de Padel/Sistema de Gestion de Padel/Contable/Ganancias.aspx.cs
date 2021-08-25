using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace Sistema_de_Gestion_de_Padel.Contable
{
    public partial class Ganancias : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["SistemaDeGestionDePadelConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = true;
            Label2.Text = (Convert.ToDateTime(TextBoxFecha.Text)).ToLongDateString().ToUpper();

            MAPEO OMapeo = new MAPEO();
            List<ReservaCanPad> LEntReserva = new List<ReservaCanPad>();

            LEntReserva = OMapeo.RecuperaReservaFecha(Convert.ToDateTime(TextBoxFecha.Text));
            int Pago = 0;
            int Deuda = 0;
            int Total = LEntReserva.Count();
            int Extra = 0;
            for (int i = 0; i < Total; i++)
            {
                if ((Convert.ToDateTime(LEntReserva.ElementAt(i).ReservaCanPadFecha).Date) == (Convert.ToDateTime(TextBoxFecha.Text).Date))
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

            string fecha = (Convert.ToDateTime(TextBoxFecha.Text).ToString("yyyyMMdd"));
            
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT CONVERT(varchar(10),ReservaCanPadFecha,103) AS [FECHA DE RESERVA], ReservaCanPadHora AS HORA, (PersonasPad.PersonasPAdApellido + ' ' + PersonasPad.PersonasPadNombre) AS SOCIO, Cancha.CanchaDescripcion AS CANCHA, ReservaCanPadPago AS PAGO FROM ReservaCanPad INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = ReservaCanPad.PersonasPadId INNER JOIN Cancha ON Cancha.CanchaId = ReservaCanPad.CanchaId WHERE CONVERT(char(10),ReservaCanPadFecha,112) = "+ fecha +" and ReservaCanPadEstado = 1", con);
                DataSet ds = new DataSet();

                da.Fill(ds);

                GridView1.DataSource = ds;
                GridView1.DataBind();
            }

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT CONVERT(varchar(10),ReservaCanPadFecha,103) AS [FECHA DE RESERVA], ReservaCanPadHora AS HORA, (PersonasPad.PersonasPAdApellido + ' ' + PersonasPad.PersonasPadNombre) AS SOCIO, Cancha.CanchaDescripcion AS CANCHA FROM ReservaCanPad INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = ReservaCanPad.PersonasPadId INNER JOIN Cancha ON Cancha.CanchaId = ReservaCanPad.CanchaId WHERE (CONVERT(char(10),ReservaCanPadFechaPago,112) = " + fecha + " and CONVERT(char(10),ReservaCanPadFecha,112) <> " + fecha + " and ReservaCanPadEstado = 1)", con);
                DataSet ds = new DataSet();

                da.Fill(ds);

                GridView2.DataSource = ds;
                GridView2.DataBind();
            }
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