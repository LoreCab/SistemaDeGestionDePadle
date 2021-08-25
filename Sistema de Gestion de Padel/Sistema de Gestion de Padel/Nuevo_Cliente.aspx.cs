using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_Gestion_de_Padel
{
    public partial class Nuevo_Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PersonasPad EntPersona = new PersonasPad();
            EntPersona.PersonasPadDni = Convert.ToInt32(TextBoxDNI.Text);
            EntPersona.PersonasPadNombre = TextBoxNombre.Text.ToUpper();
            EntPersona.PersonasPAdApellido = TextBoxApellido.Text.ToUpper();
            EntPersona.LocalidadPId = Convert.ToSByte(DropDownList1.SelectedIndex + 1);
            EntPersona.PersonasPadTelefono = TextBoxTelefono.Text;
            EntPersona.PersonasPadFecNac = Convert.ToDateTime(TextBoxFNac.Text);
            EntPersona.PersonasPadDeuda = 0;
            EntPersona.PersonasPadEstado = 1;

            MAPEO OMapeo = new MAPEO();
            OMapeo.AltaPersona(EntPersona);

            Server.Transfer("Inicio.aspx");
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona = new PersonasPad();
            
            EntPersona = OMapeo.RecuperarPersonaDNI(Convert.ToInt32(TextBoxDNI.Text));

            if ((EntPersona != null) && (EntPersona.PersonasPadEstado == 0))
            {
                Panel1.Visible = true;
                TextBoxNombre.Text = EntPersona.PersonasPadNombre;
                TextBoxApellido.Text = EntPersona.PersonasPAdApellido;
                LocalidadP EntLocalidad = new LocalidadP();
                EntLocalidad = OMapeo.RecuperarLocalidad(Convert.ToByte(EntPersona.LocalidadPId));
                DropDownList1.Text = EntLocalidad.NombreLocalidadP;
                string mes = Convert.ToString((Convert.ToDateTime(EntPersona.PersonasPadFecNac)).Month);
                string dia = Convert.ToString((Convert.ToDateTime(EntPersona.PersonasPadFecNac)).Day);
                if (Convert.ToInt16(mes) < 10)
                {
                    mes = string.Concat("0", mes);
                }
                if (Convert.ToInt16(dia) < 10)
                {
                    dia = string.Concat("0", dia);
                }
                TextBoxFNac.Text = string.Concat((Convert.ToDateTime(EntPersona.PersonasPadFecNac)).Year, "-", mes, "-", dia);
                TextBoxTelefono.Text = EntPersona.PersonasPadTelefono;

                Button1.Visible = false;
                Button2.Visible = true;
                LabelError.Text = "";
            }
            else
            {
                if ((EntPersona != null) && (EntPersona.PersonasPadEstado == 1))
                {
                    LabelError.Text = "Ya existe un socio con ese DNI";
                    Panel1.Visible = false;
                }
                else
                {
                    Panel1.Visible = true;
                    Button1.Visible = true;
                    Button2.Visible = false;
                    LabelError.Text = "";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona = new PersonasPad();

            EntPersona = OMapeo.RecuperarPersonaDNI(Convert.ToInt32(TextBoxDNI.Text));

            EntPersona.PersonasPadEstado = 1;

            OMapeo.ModificaPersona(EntPersona, EntPersona.PersonasPadId);
            Server.Transfer("Inicio.aspx");
        }
    }
}