using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_Gestion_de_Padel.Organizador
{
    public partial class Cargar_Equipo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonBuscarE1_Click(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona1 = new PersonasPad();
            PersonasPad EntPersona2 = new PersonasPad();

            EntPersona1 = OMapeo.RecuperarPersonaDNI(Convert.ToInt32(TextBoxDNI1E1.Text));
            LabelNombre1E1.Text = " " + EntPersona1.PersonasPAdApellido + " " + EntPersona1.PersonasPadNombre;

            EntPersona2 = OMapeo.RecuperarPersonaDNI(Convert.ToInt32(TextBoxDNI2E1.Text));
            LabelNombre2E1.Text = " " + EntPersona2.PersonasPAdApellido + " " + EntPersona2.PersonasPadNombre;

            List<Equipos> LEntEquipo = new List<Equipos>();

            

            LEntEquipo = OMapeo.RecuperaEquiposTorneo(Convert.ToInt16(DropDownList1.SelectedIndex) + 1);

            if (LEntEquipo.Count() != 0)
            {
                bool estado1 = LEntEquipo.Any(x => x.PrimerJugadorE == EntPersona1.PersonasPadId || x.SegundoJugadorE == EntPersona1.PersonasPadId);
                bool estado2 = LEntEquipo.Any(x => x.SegundoJugadorE == EntPersona2.PersonasPadId || x.PrimerJugadorE == EntPersona2.PersonasPadId);

                if (estado1 == false)
                {
                    if (estado2 == false)
                    {
                        if (EntPersona1 != null && EntPersona2 != null)
                        {
                            PanelEquipo2.Visible = true;
                        }
                    }
                    else
                    {
                        LabelNombre2E1.Text = " " + EntPersona2.PersonasPAdApellido + " " + EntPersona2.PersonasPadNombre + " YA SE ENCUENTRA CARGADO EN ESTE TORNEO";
                    }
                }
                else
                {
                    LabelNombre1E1.Text = " " + EntPersona1.PersonasPAdApellido + " " + EntPersona1.PersonasPadNombre + " YA SE ENCUENTRA CARGADO EN ESTE TORNEO";
                }
            }
            else
            {
                if (EntPersona1 != null && EntPersona2 != null)
                {
                    PanelEquipo2.Visible = true;
                }
            }
        }

        protected void ButtonBuscarE2_Click(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona1 = new PersonasPad();
            PersonasPad EntPersona2 = new PersonasPad();

            EntPersona1 = OMapeo.RecuperarPersonaDNI(Convert.ToInt32(TextBoxDNI1E2.Text));
            LabelNombre1E2.Text = " " + EntPersona1.PersonasPAdApellido + " " + EntPersona1.PersonasPadNombre;

            EntPersona2 = OMapeo.RecuperarPersonaDNI(Convert.ToInt32(TextBoxDNI2E2.Text));
            LabelNombre2E2.Text = " " + EntPersona2.PersonasPAdApellido + " " + EntPersona2.PersonasPadNombre;

            List<Equipos> LEntEquipo = new List<Equipos>();

            LEntEquipo = OMapeo.RecuperaEquiposTorneo(Convert.ToInt16(DropDownList1.SelectedIndex) + 1);

            if (LEntEquipo.Count() != 0)
            {
                bool estado1 = LEntEquipo.Any(x => x.PrimerJugadorE == EntPersona1.PersonasPadId || x.SegundoJugadorE == EntPersona1.PersonasPadId);
                bool estado2 = LEntEquipo.Any(x => x.SegundoJugadorE == EntPersona2.PersonasPadId || x.PrimerJugadorE == EntPersona2.PersonasPadId);

                if (estado1 == false)
                {
                    if (estado2 == false)
                    {
                        if (EntPersona1 != null && EntPersona2 != null)
                        {
                            PanelEquipo3.Visible = true;
                        }
                    }
                    else
                    {
                        LabelNombre2E2.Text = " " + EntPersona2.PersonasPAdApellido + " " + EntPersona2.PersonasPadNombre + " YA SE ENCUENTRA CARGADO EN ESTE TORNEO";
                    }
                }
                else
                {
                    LabelNombre1E2.Text = " " + EntPersona1.PersonasPAdApellido + " " + EntPersona1.PersonasPadNombre + " YA SE ENCUENTRA CARGADO EN ESTE TORNEO";
                }
            }
            else
            {
                if (EntPersona1 != null && EntPersona2 != null)
                {
                    PanelEquipo3.Visible = true;
                }
            }
        }

        protected void ButtonBuscarE3_Click(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            PersonasPad EntPersona1 = new PersonasPad();
            PersonasPad EntPersona2 = new PersonasPad();

            EntPersona1 = OMapeo.RecuperarPersonaDNI(Convert.ToInt32(TextBoxDNI1E3.Text));
            LabelNombre1E3.Text = " " + EntPersona1.PersonasPAdApellido + " " + EntPersona1.PersonasPadNombre;

            EntPersona2 = OMapeo.RecuperarPersonaDNI(Convert.ToInt32(TextBoxDNI2E3.Text));
            LabelNombre2E3.Text = " " + EntPersona2.PersonasPAdApellido + " " + EntPersona2.PersonasPadNombre;

            List<Equipos> LEntEquipo = new List<Equipos>();

            LEntEquipo = OMapeo.RecuperaEquiposTorneo(Convert.ToInt16(DropDownList1.SelectedIndex) + 1);

            if (LEntEquipo.Count() != 0)
            {
                bool estado1 = LEntEquipo.Any(x => x.PrimerJugadorE == EntPersona1.PersonasPadId || x.SegundoJugadorE == EntPersona1.PersonasPadId);
                bool estado2 = LEntEquipo.Any(x => x.SegundoJugadorE == EntPersona2.PersonasPadId || x.PrimerJugadorE == EntPersona2.PersonasPadId);

                if (estado1 == false)
                {
                    if (estado2 == false)
                    {
                        if (EntPersona1 != null && EntPersona2 != null)
                        {
                            ButtonRegistrarGrupo.Visible = true;
                        }
                    }
                    else
                    {
                        LabelNombre2E3.Text = " " + EntPersona2.PersonasPAdApellido + " " + EntPersona2.PersonasPadNombre + " YA SE ENCUENTRA CARGADO EN ESTE TORNEO";
                    }
                }
                else
                {
                    LabelNombre1E3.Text = " " + EntPersona1.PersonasPAdApellido + " " + EntPersona1.PersonasPadNombre + " YA SE ENCUENTRA CARGADO EN ESTE TORNEO";
                }
            }
            else
            {
                if (EntPersona1 != null && EntPersona2 != null)
                {
                    ButtonRegistrarGrupo.Visible = true;
                }
            }
        }

        protected void ButtonBuscarTorneo_Click(object sender, EventArgs e)
        {

            MAPEO OMapeo = new MAPEO();
            List<Equipos> LEntEquipo = new List<Equipos>();

            LEntEquipo = OMapeo.RecuperaEquiposTorneo(Convert.ToInt16(DropDownList1.SelectedIndex)+1);

            if (LEntEquipo.Count() == 0)
            {
                DropDownList2.Visible = true;
                ButtonGrupo.Visible = true;
                Label1.Visible = false;
            }
            else
            {
                Label1.Visible = true;
            }
        }

        protected void ButtonGrupo_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            ButtonBuscarTorneo.Visible = false;
        }

        protected void ButtonRegistrarGrupo_Click(object sender, EventArgs e)
        {
            if (DropDownList2.Items.Count > 0)
            {
                MAPEO OMapeo = new MAPEO();
                Equipos EntEquipo1 = new Equipos();
                Equipos EntEquipo2 = new Equipos();
                Equipos EntEquipo3 = new Equipos();
                PersonasPad EntPersona = new PersonasPad();

                EntEquipo1.TorneoId = Convert.ToInt16(DropDownList1.SelectedIndex) + 1;
                EntPersona = OMapeo.RecuperarPersonaDNI(Convert.ToInt32(TextBoxDNI1E1.Text));
                EntEquipo1.PrimerJugadorE = EntPersona.PersonasPadId;
                EntPersona = OMapeo.RecuperarPersonaDNI(Convert.ToInt32(TextBoxDNI2E1.Text));
                EntEquipo1.SegundoJugadorE = EntPersona.PersonasPadId;
                EntEquipo1.GrupoEquipo = Convert.ToInt16(DropDownList2.SelectedValue);

                EntEquipo2.TorneoId = Convert.ToInt16(DropDownList1.SelectedIndex) + 1;
                EntPersona = OMapeo.RecuperarPersonaDNI(Convert.ToInt32(TextBoxDNI1E2.Text));
                EntEquipo2.PrimerJugadorE = EntPersona.PersonasPadId;
                EntPersona = OMapeo.RecuperarPersonaDNI(Convert.ToInt32(TextBoxDNI2E2.Text));
                EntEquipo2.SegundoJugadorE = EntPersona.PersonasPadId;
                EntEquipo2.GrupoEquipo = Convert.ToInt16(DropDownList2.SelectedValue);

                EntEquipo3.TorneoId = Convert.ToInt16(DropDownList1.SelectedIndex) + 1;
                EntPersona = OMapeo.RecuperarPersonaDNI(Convert.ToInt32(TextBoxDNI1E3.Text));
                EntEquipo3.PrimerJugadorE = EntPersona.PersonasPadId;
                EntPersona = OMapeo.RecuperarPersonaDNI(Convert.ToInt32(TextBoxDNI2E3.Text));
                EntEquipo3.SegundoJugadorE = EntPersona.PersonasPadId;
                EntEquipo3.GrupoEquipo = Convert.ToInt16(DropDownList2.SelectedValue);

                OMapeo.AltaEquipos(EntEquipo1);
                OMapeo.AltaEquipos(EntEquipo2);
                OMapeo.AltaEquipos(EntEquipo3);

                Panel1.Visible = false;
                ButtonRegistrarGrupo.Visible = false;
                DropDownList2.Items.RemoveAt(0);
                PanelEquipo2.Visible = false;
                PanelEquipo3.Visible = false;
                TextBoxDNI1E1.Text = "";
                TextBoxDNI2E1.Text = "";
                TextBoxDNI1E2.Text = "";
                TextBoxDNI2E2.Text = "";
                TextBoxDNI1E3.Text = "";
                TextBoxDNI2E3.Text = "";
                LabelNombre1E1.Text = "";
                LabelNombre2E1.Text = "";
                LabelNombre1E2.Text = "";
                LabelNombre2E2.Text = "";
                LabelNombre1E3.Text = "";
                LabelNombre2E3.Text = "";
            }

            if (DropDownList2.Items.Count == 0)
            {
                Response.Redirect("/Organizador/Inicio.aspx");
            }
        }
    }
}