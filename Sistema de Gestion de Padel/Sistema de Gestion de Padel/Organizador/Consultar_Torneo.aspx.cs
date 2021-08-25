using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_Gestion_de_Padel.Organizador
{
    public partial class Consultar_Torneo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;

            GridView1.Visible = true;

            MAPEO OMapeo = new MAPEO();

            List<Equipos> LEntEquipos = new List<Equipos>();

            LEntEquipos = OMapeo.RecuperaEquiposTorneo(Convert.ToInt16(DropDownList1.SelectedIndex + 1));

            List<PersonasPad> LEntJugadores = new List<PersonasPad>();

            for (int i = 0; i < LEntEquipos.Count(); i++)
            {
                PersonasPad EntPersona = new PersonasPad();
                EntPersona.PersonasPAdApellido = OMapeo.RecuperarPersona(LEntEquipos.ElementAt(i).PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(LEntEquipos.ElementAt(i).SegundoJugadorE).PersonasPAdApellido;
                if (LEntEquipos.ElementAt(i).GrupoEquipo == 1)
                {
                    EntPersona.PersonasPadNombre = "Grupo A";
                }
                if (LEntEquipos.ElementAt(i).GrupoEquipo == 2)
                {
                    EntPersona.PersonasPadNombre = "Grupo B";
                }
                if (LEntEquipos.ElementAt(i).GrupoEquipo == 3)
                {
                    EntPersona.PersonasPadNombre = "Grupo C";
                }
                if (LEntEquipos.ElementAt(i).GrupoEquipo == 4)
                {
                    EntPersona.PersonasPadNombre = "Grupo D";
                }
                EntPersona.PersonasPadEstado = Convert.ToInt16(LEntEquipos.ElementAt(i).GrupoEquipo);
                LEntJugadores.Add(EntPersona);
            }

            LEntJugadores = LEntJugadores.OrderBy(x => x.PersonasPadEstado).ToList();
            GridView1.DataSource = LEntJugadores;
            GridView1.DataBind();
            Panel1.Visible = true;

            Torneo EntTorneo = new Torneo();

            EntTorneo = OMapeo.RecuperarTorneo(Convert.ToInt16(DropDownList1.SelectedIndex + 1));

            DateTime FechaInicio = Convert.ToDateTime(EntTorneo.FechaInicioTorneo);
            DateTime FechaFin = Convert.ToDateTime(EntTorneo.FechaFinTorneo);

            string mes = Convert.ToString((FechaInicio).Month);
            string dia = Convert.ToString((FechaInicio).Day);
            if (Convert.ToInt16(mes) < 10)
            {
                mes = string.Concat("0", mes);
            }
            if (Convert.ToInt16(dia) < 10)
            {
                dia = string.Concat("0", dia);
            }
            TextBoxFInicio.Text = string.Concat((FechaInicio).Year, "-", mes, "-", dia);

            string mesf = Convert.ToString((FechaFin).Month);
            string diaf = Convert.ToString((FechaFin).Day);
            if (Convert.ToInt16(mesf) < 10)
            {
                mesf = string.Concat("0", mesf);
            }
            if (Convert.ToInt16(diaf) < 10)
            {
                diaf = string.Concat("0", diaf);
            }
            TextBoxFFin.Text = string.Concat((FechaFin).Year, "-", mesf, "-", diaf);

            Equipos Ganador = OMapeo.RecuperaUnEquipoTorneo(Convert.ToInt16(DropDownList1.SelectedIndex + 1), Convert.ToInt16(EntTorneo.IdGanador));
            TextBoxGanador.Text = OMapeo.RecuperarPersona(Ganador.PrimerJugadorE).PersonasPAdApellido + " - " + OMapeo.RecuperarPersona(Ganador.SegundoJugadorE).PersonasPAdApellido;

            List<Partidos> LEntPartido = new List<Partidos>();

            LEntPartido = OMapeo.RecuperaPartidosTorneo(Convert.ToInt16(DropDownList1.SelectedIndex + 1));

            List<Partidos> LEntPartido4to = new List<Partidos>();
            List<Partidos> LEntPartidoSemi = new List<Partidos>();
            List<Partidos> LEntPartidoFinal = new List<Partidos>();

            LEntPartido4to = LEntPartido.FindAll(x => x.TipoPartido == 5);
            LEntPartidoSemi = LEntPartido.FindAll(x => x.TipoPartido == 6);
            LEntPartidoFinal = LEntPartido.FindAll(x => x.TipoPartido == 7);

            LEntPartido4to = LEntPartido4to.OrderBy(x => x.PartidosId).ToList();
            LEntPartidoSemi = LEntPartidoSemi.OrderBy(x => x.PartidosId).ToList();

            Equipos EntEquipo = new Equipos();

            // CARGA DE PRIMER CUARTO
            EntEquipo = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex + 1)), Convert.ToInt16(LEntPartido4to.ElementAt(0).PrimerEquipoId));
            cuarto1equipo1.Text = "EQUIPO 1 " + OMapeo.RecuperarPersona(EntEquipo.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo.SegundoJugadorE).PersonasPAdApellido;
            cuarto1equipo1partido1set1.Text = Convert.ToString(LEntPartido4to.ElementAt(0).Set1PE);
            cuarto1equipo1partido1set2.Text = Convert.ToString(LEntPartido4to.ElementAt(0).Set2PE);
            cuarto1equipo1partido1set3.Text = Convert.ToString(LEntPartido4to.ElementAt(0).Set3PE);
            cuarto1equipo1partido1puntos.Text = Convert.ToString(LEntPartido4to.ElementAt(0).SetGanadosPE);

            EntEquipo = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex + 1)), Convert.ToInt16(LEntPartido4to.ElementAt(0).SegundoEquipoId));
            cuarto1equipo2.Text = "EQUIPO 2 " + OMapeo.RecuperarPersona(EntEquipo.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo.SegundoJugadorE).PersonasPAdApellido;
            cuarto1equipo2partido1set1.Text = Convert.ToString(LEntPartido4to.ElementAt(0).Set1SE);
            cuarto1equipo2partido1set2.Text = Convert.ToString(LEntPartido4to.ElementAt(0).Set2SE);
            cuarto1equipo2partido1set3.Text = Convert.ToString(LEntPartido4to.ElementAt(0).Set3SE);
            cuarto1equipo2partido1puntos.Text = Convert.ToString(LEntPartido4to.ElementAt(0).SetGanadosSE);

            // CARGA DE SEGUNDO CUARTO
            EntEquipo = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex + 1)), Convert.ToInt16(LEntPartido4to.ElementAt(1).PrimerEquipoId));
            cuarto2equipo1.Text = "EQUIPO 1 " + OMapeo.RecuperarPersona(EntEquipo.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo.SegundoJugadorE).PersonasPAdApellido;
            cuarto2equipo1partido1set1.Text = Convert.ToString(LEntPartido4to.ElementAt(1).Set1PE);
            cuarto2equipo1partido1set2.Text = Convert.ToString(LEntPartido4to.ElementAt(1).Set2PE);
            cuarto2equipo1partido1set3.Text = Convert.ToString(LEntPartido4to.ElementAt(1).Set3PE);
            cuarto2equipo1partido1puntos.Text = Convert.ToString(LEntPartido4to.ElementAt(1).SetGanadosPE);

            EntEquipo = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex + 1)), Convert.ToInt16(LEntPartido4to.ElementAt(1).SegundoEquipoId));
            cuarto2equipo2.Text = "EQUIPO 2 " + OMapeo.RecuperarPersona(EntEquipo.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo.SegundoJugadorE).PersonasPAdApellido;
            cuarto2equipo2partido1set1.Text = Convert.ToString(LEntPartido4to.ElementAt(1).Set1SE);
            cuarto2equipo2partido1set2.Text = Convert.ToString(LEntPartido4to.ElementAt(1).Set2SE);
            cuarto2equipo2partido1set3.Text = Convert.ToString(LEntPartido4to.ElementAt(1).Set3SE);
            cuarto2equipo2partido1puntos.Text = Convert.ToString(LEntPartido4to.ElementAt(1).SetGanadosSE);

            // CARGA DE TERCER CUARTO
            EntEquipo = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex + 1)), Convert.ToInt16(LEntPartido4to.ElementAt(2).PrimerEquipoId));
            cuarto3equipo1.Text = "EQUIPO 1 " + OMapeo.RecuperarPersona(EntEquipo.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo.SegundoJugadorE).PersonasPAdApellido;
            cuarto3equipo1partido1set1.Text = Convert.ToString(LEntPartido4to.ElementAt(2).Set1PE);
            cuarto3equipo1partido1set2.Text = Convert.ToString(LEntPartido4to.ElementAt(2).Set2PE);
            cuarto3equipo1partido1set3.Text = Convert.ToString(LEntPartido4to.ElementAt(2).Set3PE);
            cuarto3equipo1partido1puntos.Text = Convert.ToString(LEntPartido4to.ElementAt(2).SetGanadosPE);

            EntEquipo = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex + 1)), Convert.ToInt16(LEntPartido4to.ElementAt(2).SegundoEquipoId));
            cuarto3equipo2.Text = "EQUIPO 2 " + OMapeo.RecuperarPersona(EntEquipo.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo.SegundoJugadorE).PersonasPAdApellido;
            cuarto3equipo2partido1set1.Text = Convert.ToString(LEntPartido4to.ElementAt(2).Set1SE);
            cuarto3equipo2partido1set2.Text = Convert.ToString(LEntPartido4to.ElementAt(2).Set2SE);
            cuarto3equipo2partido1set3.Text = Convert.ToString(LEntPartido4to.ElementAt(2).Set3SE);
            cuarto3equipo2partido1puntos.Text = Convert.ToString(LEntPartido4to.ElementAt(2).SetGanadosSE);

            // CARGA DE CUARTO CUARTO
            EntEquipo = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex + 1)), Convert.ToInt16(LEntPartido4to.ElementAt(3).PrimerEquipoId));
            cuarto4equipo1.Text = "EQUIPO 1 " + OMapeo.RecuperarPersona(EntEquipo.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo.SegundoJugadorE).PersonasPAdApellido;
            cuarto4equipo1partido1set1.Text = Convert.ToString(LEntPartido4to.ElementAt(3).Set1PE);
            cuarto4equipo1partido1set2.Text = Convert.ToString(LEntPartido4to.ElementAt(3).Set2PE);
            cuarto4equipo1partido1set3.Text = Convert.ToString(LEntPartido4to.ElementAt(3).Set3PE);
            cuarto4equipo1partido1puntos.Text = Convert.ToString(LEntPartido4to.ElementAt(3).SetGanadosPE);

            EntEquipo = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex + 1)), Convert.ToInt16(LEntPartido4to.ElementAt(3).SegundoEquipoId));
            cuarto4equipo2.Text = "EQUIPO 2 " + OMapeo.RecuperarPersona(EntEquipo.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo.SegundoJugadorE).PersonasPAdApellido;
            cuarto4equipo2partido1set1.Text = Convert.ToString(LEntPartido4to.ElementAt(3).Set1SE);
            cuarto4equipo2partido1set2.Text = Convert.ToString(LEntPartido4to.ElementAt(3).Set2SE);
            cuarto4equipo2partido1set3.Text = Convert.ToString(LEntPartido4to.ElementAt(3).Set3SE);
            cuarto4equipo2partido1puntos.Text = Convert.ToString(LEntPartido4to.ElementAt(3).SetGanadosSE);

            // CARGAR 1° SEMI
            EntEquipo = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex + 1)), Convert.ToInt16(LEntPartidoSemi.ElementAt(0).PrimerEquipoId));
            semi1equipo1.Text = "EQUIPO 1 " + OMapeo.RecuperarPersona(EntEquipo.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo.SegundoJugadorE).PersonasPAdApellido;
            semi1equipo1set1.Text = Convert.ToString(LEntPartidoSemi.ElementAt(0).Set1PE);
            semi1equipo1set2.Text = Convert.ToString(LEntPartidoSemi.ElementAt(0).Set2PE);
            semi1equipo1set3.Text = Convert.ToString(LEntPartidoSemi.ElementAt(0).Set3PE);
            semi1equipo1puntos.Text = Convert.ToString(LEntPartidoSemi.ElementAt(0).SetGanadosPE);

            EntEquipo = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex + 1)), Convert.ToInt16(LEntPartidoSemi.ElementAt(0).SegundoEquipoId));
            semi1equipo2.Text = "EQUIPO 2 " + OMapeo.RecuperarPersona(EntEquipo.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo.SegundoJugadorE).PersonasPAdApellido;
            semi1equipo2set1.Text = Convert.ToString(LEntPartidoSemi.ElementAt(0).Set1SE);
            semi1equipo2set2.Text = Convert.ToString(LEntPartidoSemi.ElementAt(0).Set2SE);
            semi1equipo2set3.Text = Convert.ToString(LEntPartidoSemi.ElementAt(0).Set3SE);
            semi1equipo2puntos.Text = Convert.ToString(LEntPartidoSemi.ElementAt(0).SetGanadosSE);

            // CARGAR 2° SEMI
            EntEquipo = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex + 1)), Convert.ToInt16(LEntPartidoSemi.ElementAt(1).PrimerEquipoId));
            semi2equipo1.Text = "EQUIPO 1 " + OMapeo.RecuperarPersona(EntEquipo.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo.SegundoJugadorE).PersonasPAdApellido;
            semi2equipo1set1.Text = Convert.ToString(LEntPartidoSemi.ElementAt(1).Set1PE);
            semi2equipo1set2.Text = Convert.ToString(LEntPartidoSemi.ElementAt(1).Set2PE);
            semi2equipo1set3.Text = Convert.ToString(LEntPartidoSemi.ElementAt(1).Set3PE);
            semi2equipo1puntos.Text = Convert.ToString(LEntPartidoSemi.ElementAt(1).SetGanadosPE);

            EntEquipo = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex + 1)), Convert.ToInt16(LEntPartidoSemi.ElementAt(1).SegundoEquipoId));
            semi2equipo2.Text = "EQUIPO 2 " + OMapeo.RecuperarPersona(EntEquipo.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo.SegundoJugadorE).PersonasPAdApellido;
            semi2equipo2set1.Text = Convert.ToString(LEntPartidoSemi.ElementAt(1).Set1SE);
            semi2equipo2set2.Text = Convert.ToString(LEntPartidoSemi.ElementAt(1).Set2SE);
            semi2equipo2set3.Text = Convert.ToString(LEntPartidoSemi.ElementAt(1).Set3SE);
            semi2equipo2puntos.Text = Convert.ToString(LEntPartidoSemi.ElementAt(1).SetGanadosSE);

            // CARGAR FINAL
            EntEquipo = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex + 1)), Convert.ToInt16(LEntPartidoFinal.ElementAt(0).PrimerEquipoId));
            finalequipo1.Text = "EQUIPO 1 " + OMapeo.RecuperarPersona(EntEquipo.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo.SegundoJugadorE).PersonasPAdApellido;
            finalequipo1set1.Text = Convert.ToString(LEntPartidoFinal.ElementAt(0).Set1PE);
            finalequipo1set2.Text = Convert.ToString(LEntPartidoFinal.ElementAt(0).Set2PE);
            finalequipo1set3.Text = Convert.ToString(LEntPartidoFinal.ElementAt(0).Set3PE);
            finalequipo1puntos.Text = Convert.ToString(LEntPartidoFinal.ElementAt(0).SetGanadosPE);

            EntEquipo = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex + 1)), Convert.ToInt16(LEntPartidoFinal.ElementAt(0).SegundoEquipoId));
            finalequipo2.Text = "EQUIPO 2 " + OMapeo.RecuperarPersona(EntEquipo.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo.SegundoJugadorE).PersonasPAdApellido;
            finalequipo2set1.Text = Convert.ToString(LEntPartidoFinal.ElementAt(0).Set1SE);
            finalequipo2set2.Text = Convert.ToString(LEntPartidoFinal.ElementAt(0).Set2SE);
            finalequipo2set3.Text = Convert.ToString(LEntPartidoFinal.ElementAt(0).Set3SE);
            finalequipo2puntos.Text = Convert.ToString(LEntPartidoFinal.ElementAt(0).SetGanadosSE);
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int estado = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "PersonasPadEstado").ToString());
                if (estado == 1)
                {
                    string hex = "#FFFF00";
                    e.Row.ForeColor = System.Drawing.Color.Black;
                    e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml(hex);
                }
                if(estado == 2)
                {
                    string hex = "#80FF00";
                    e.Row.ForeColor = System.Drawing.Color.Black;
                    e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml(hex);
                }
                if (estado == 3)
                {
                    string hex = "#FB0180";
                    e.Row.ForeColor = System.Drawing.Color.Black;
                    e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml(hex);
                }
                if (estado == 4)
                {
                    string hex = "#BF00FF";
                    e.Row.ForeColor = System.Drawing.Color.Black;
                    e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml(hex);
                }
            }
        }



    }
}