using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_Gestion_de_Padel
{
    public partial class Ganancias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Label2.Text = (Convert.ToDateTime(TextBoxFecha.Text)).ToLongDateString().ToUpper();
            MAPEO OMapeo = new MAPEO();
            List<ReservaCanPad> LEntReserva = new List<ReservaCanPad>();
            List<PersonasPad> LEntPersona = new List<PersonasPad>();
            List<Cancha> LEntCancha = new List<Cancha>();

            LEntReserva = OMapeo.RecuperaReservaFecha(Convert.ToDateTime(TextBoxFecha.Text));

            for (int i = 0; i < LEntReserva.Count(); i++)
            {
                PersonasPad EntPersona = new PersonasPad();
                Cancha EntCancha = new Cancha();

                EntPersona = OMapeo.RecuperarPersona(LEntReserva.ElementAt(i).PersonasPadId);
                EntCancha = OMapeo.RecuperarCancha(LEntReserva.ElementAt(i).CanchaId);

                LEntPersona.Add(EntPersona);
                LEntCancha.Add(EntCancha);
            }

            List<PersonasPad> ListaAuxiliar = new List<PersonasPad>();
            
            for (int i = 0; i < LEntReserva.Count(); i++)
            {
                PersonasPad Auxiliar = new PersonasPad();
                Auxiliar.PersonasPadNombre = LEntPersona.ElementAt(i).PersonasPAdApellido+" "+LEntPersona.ElementAt(i).PersonasPadNombre;
                Auxiliar.PersonasPadTelefono = LEntCancha.ElementAt(i).CanchaDescripcion;
                Auxiliar.LocalidadPId = Convert.ToByte(LEntReserva.ElementAt(i).ReservaCanPadHora);
                if (LEntReserva.ElementAt(i).ReservaCanPadPago == 0)
                {
                    Auxiliar.PersonasPAdApellido = "NO";
                }
                else
                {
                    Auxiliar.PersonasPAdApellido = "SI";
                }
                ListaAuxiliar.Add(Auxiliar);
            }


            GridView1.DataSource = ListaAuxiliar;
            GridView1.DataBind();


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