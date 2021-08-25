using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_Gestion_de_Padel.Organizador
{
    public partial class Cargar_Partidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonBuscarTorneo_Click(object sender, EventArgs e)
        {
            MAPEO OMapeo = new MAPEO();
            List<Equipos> LEntEquipo = new List<Equipos>();

            LEntEquipo = OMapeo.RecuperaEquiposTorneo(Convert.ToInt16(DropDownList1.SelectedIndex) + 1);

            List<Partidos> LEntPartido = new List<Partidos>();

            LEntPartido = OMapeo.RecuperaPartidosTorneo(Convert.ToInt16(DropDownList1.SelectedIndex) + 1);

            if ((LEntPartido.Count() == 0) && (LEntEquipo.Count()>0))
            {
                Panel1.Visible = true;

                int i = 0;
                PersonasPad EntPersona1 = new PersonasPad();
                PersonasPad EntPersona2 = new PersonasPad();

                //GRUPO A
                EntPersona1 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).PrimerJugadorE);
                EntPersona2 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).SegundoJugadorE);
                grupoAequipo1partido1.Text = "EQUIPO 1 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;
                grupoAequipo1partido2.Text = "EQUIPO 1 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;

                i++;
                EntPersona1 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).PrimerJugadorE);
                EntPersona2 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).SegundoJugadorE);
                grupoAequipo2partido1.Text = "EQUIPO 2 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;
                grupoAequipo2partido3.Text = "EQUIPO 1 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;

                i++;
                EntPersona1 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).PrimerJugadorE);
                EntPersona2 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).SegundoJugadorE);
                grupoAequipo3partido2.Text = "EQUIPO 2 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;
                grupoAequipo3partido3.Text = "EQUIPO 2 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;

                //GRUPO B
                i++;
                EntPersona1 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).PrimerJugadorE);
                EntPersona2 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).SegundoJugadorE);
                grupoBequipo1partido1.Text = "EQUIPO 1 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;
                grupoBequipo1partido2.Text = "EQUIPO 1 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;

                i++;
                EntPersona1 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).PrimerJugadorE);
                EntPersona2 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).SegundoJugadorE);
                grupoBequipo2partido1.Text = "EQUIPO 2 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;
                grupoBequipo2partido3.Text = "EQUIPO 1 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;

                i++;
                EntPersona1 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).PrimerJugadorE);
                EntPersona2 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).SegundoJugadorE);
                grupoBequipo3partido2.Text = "EQUIPO 2 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;
                grupoBequipo3partido3.Text = "EQUIPO 2 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;

                //GRUPO C
                i++;
                EntPersona1 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).PrimerJugadorE);
                EntPersona2 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).SegundoJugadorE);
                grupoCequipo1partido1.Text = "EQUIPO 1 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;
                grupoCequipo1partido2.Text = "EQUIPO 1 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;

                i++;
                EntPersona1 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).PrimerJugadorE);
                EntPersona2 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).SegundoJugadorE);
                grupoCequipo2partido1.Text = "EQUIPO 2 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;
                grupoCequipo2partido3.Text = "EQUIPO 1 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;

                i++;
                EntPersona1 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).PrimerJugadorE);
                EntPersona2 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).SegundoJugadorE);
                grupoCequipo3partido2.Text = "EQUIPO 2 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;
                grupoCequipo3partido3.Text = "EQUIPO 2 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;

                //GRUPO D
                i++;
                EntPersona1 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).PrimerJugadorE);
                EntPersona2 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).SegundoJugadorE);
                grupoDequipo1partido1.Text = "EQUIPO 1 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;
                grupoDequipo1partido2.Text = "EQUIPO 1 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;

                i++;
                EntPersona1 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).PrimerJugadorE);
                EntPersona2 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).SegundoJugadorE);
                grupoDequipo2partido1.Text = "EQUIPO 2 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;
                grupoDequipo2partido3.Text = "EQUIPO 1 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;

                i++;
                EntPersona1 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).PrimerJugadorE);
                EntPersona2 = OMapeo.RecuperarPersona(LEntEquipo.ElementAt(i).SegundoJugadorE);
                grupoDequipo3partido2.Text = "EQUIPO 2 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;
                grupoDequipo3partido3.Text = "EQUIPO 2 " + EntPersona1.PersonasPAdApellido + "-" + EntPersona2.PersonasPAdApellido;
            }


        }

        protected void ButtonGrupoA_Click(object sender, EventArgs e)
        {
            List<Equipos> LEntEquipos = new List<Equipos>();
            MAPEO OMapeo = new MAPEO();

            LEntEquipos = OMapeo.RecuperaEquiposTorneo(Convert.ToInt16(DropDownList1.SelectedIndex) + 1);

            Equipos EntEquipo1 = LEntEquipos.ElementAt(0);
            Equipos EntEquipo2 = LEntEquipos.ElementAt(1);
            Equipos EntEquipo3 = LEntEquipos.ElementAt(2);

            Partidos EntPartido1 = new Partidos();
            Partidos EntPartido2 = new Partidos();
            Partidos EntPartido3 = new Partidos();

            EntPartido1.TorneoId = (Convert.ToInt16(DropDownList1.SelectedIndex) + 1);
            EntPartido1.PrimerEquipoId = EntEquipo1.EquipoId;
            EntPartido1.SegundoEquipoId = EntEquipo2.EquipoId;
            EntPartido1.Set1PE = Convert.ToInt16(grupoAequipo1partido1set1.Text);
            EntPartido1.Set2PE = Convert.ToInt16(grupoAequipo1partido1set2.Text);
            EntPartido1.Set3PE = Convert.ToInt16(grupoAequipo1partido1set3.Text);
            EntPartido1.Set1SE = Convert.ToInt16(grupoAequipo2partido1set1.Text);
            EntPartido1.Set2SE = Convert.ToInt16(grupoAequipo2partido1set2.Text);
            EntPartido1.Set3SE = Convert.ToInt16(grupoAequipo2partido1set3.Text);
            EntPartido1.SetGanadosPE = Convert.ToInt16(grupoAequipo1partido1puntos1.Text);
            EntPartido1.SetGanadosSE = Convert.ToInt16(grupoAequipo2partido1puntos1.Text);
            EntPartido1.SetPerdidosSE = Convert.ToInt16(grupoAequipo1partido1puntos1.Text);
            EntPartido1.SetPerdidosPE = Convert.ToInt16(grupoAequipo2partido1puntos1.Text);
            EntPartido1.GamesGanadosPE = EntPartido1.Set1PE + EntPartido1.Set2PE + EntPartido1.Set3PE;
            EntPartido1.GamesGanadosSE = EntPartido1.Set1SE + EntPartido1.Set2SE + EntPartido1.Set3SE;
            EntPartido1.GamesPerdidosPE = EntPartido1.GamesGanadosSE;
            EntPartido1.GamesPerdidosSE = EntPartido1.GamesGanadosPE;
            EntPartido1.TipoPartido = 1;
            OMapeo.AltaPartidos(EntPartido1);

            EntPartido2.TorneoId = (Convert.ToInt16(DropDownList1.SelectedIndex) + 1);
            EntPartido2.PrimerEquipoId = EntEquipo1.EquipoId;
            EntPartido2.SegundoEquipoId = EntEquipo3.EquipoId;
            EntPartido2.Set1PE = Convert.ToInt16(grupoAequipo1partido2set1.Text);
            EntPartido2.Set2PE = Convert.ToInt16(grupoAequipo1partido2set2.Text);
            EntPartido2.Set3PE = Convert.ToInt16(grupoAequipo1partido2set3.Text);
            EntPartido2.Set1SE = Convert.ToInt16(grupoAequipo3partido2set1.Text);
            EntPartido2.Set2SE = Convert.ToInt16(grupoAequipo3partido2set2.Text);
            EntPartido2.Set3SE = Convert.ToInt16(grupoAequipo3partido2set3.Text);
            EntPartido2.SetGanadosPE = Convert.ToInt16(grupoAequipo1partido2puntos1.Text);
            EntPartido2.SetGanadosSE = Convert.ToInt16(grupoAequipo3partido2puntos1.Text);
            EntPartido2.SetPerdidosSE = Convert.ToInt16(grupoAequipo1partido2puntos1.Text);
            EntPartido2.SetPerdidosPE = Convert.ToInt16(grupoAequipo3partido2puntos1.Text);
            EntPartido2.GamesGanadosPE = EntPartido2.Set1PE + EntPartido2.Set2PE + EntPartido2.Set3PE;
            EntPartido2.GamesGanadosSE = EntPartido2.Set1SE + EntPartido2.Set2SE + EntPartido2.Set3SE;
            EntPartido2.GamesPerdidosPE = EntPartido2.GamesGanadosSE;
            EntPartido2.GamesPerdidosSE = EntPartido2.GamesGanadosPE;
            EntPartido2.TipoPartido = 1;
            OMapeo.AltaPartidos(EntPartido2);

            EntPartido3.TorneoId = (Convert.ToInt16(DropDownList1.SelectedIndex) + 1);
            EntPartido3.PrimerEquipoId = EntEquipo2.EquipoId;
            EntPartido3.SegundoEquipoId = EntEquipo3.EquipoId;
            EntPartido3.Set1PE = Convert.ToInt16(grupoAequipo2partido3set1.Text);
            EntPartido3.Set2PE = Convert.ToInt16(grupoAequipo2partido3set2.Text);
            EntPartido3.Set3PE = Convert.ToInt16(grupoAequipo2partido3set3.Text);
            EntPartido3.Set1SE = Convert.ToInt16(grupoAequipo3partido3set1.Text);
            EntPartido3.Set2SE = Convert.ToInt16(grupoAequipo3partido3set2.Text);
            EntPartido3.Set3SE = Convert.ToInt16(grupoAequipo3partido3set3.Text);
            EntPartido3.SetGanadosPE = Convert.ToInt16(grupoAequipo2partido3puntos1.Text);
            EntPartido3.SetGanadosSE = Convert.ToInt16(grupoAequipo3partido3puntos1.Text);
            EntPartido3.SetPerdidosSE = Convert.ToInt16(grupoAequipo2partido3puntos1.Text);
            EntPartido3.SetPerdidosPE = Convert.ToInt16(grupoAequipo3partido3puntos1.Text);
            EntPartido3.GamesGanadosPE = EntPartido3.Set1PE + EntPartido3.Set2PE + EntPartido3.Set3PE;
            EntPartido3.GamesGanadosSE = EntPartido3.Set1SE + EntPartido3.Set2SE + EntPartido3.Set3SE;
            EntPartido3.GamesPerdidosPE = EntPartido3.GamesGanadosSE;
            EntPartido3.GamesPerdidosSE = EntPartido3.GamesGanadosPE;
            EntPartido3.TipoPartido = 1;
            OMapeo.AltaPartidos(EntPartido3);
        }

        protected void ButtonGrupoB_Click(object sender, EventArgs e)
        {
            List<Equipos> LEntEquipos = new List<Equipos>();
            MAPEO OMapeo = new MAPEO();
            List<Partidos> LEntPartidos = new List<Partidos>();

            LEntEquipos = OMapeo.RecuperaEquiposTorneo(Convert.ToInt16(DropDownList1.SelectedIndex) + 1);

            Equipos EntEquipo1 = LEntEquipos.ElementAt(3);
            Equipos EntEquipo2 = LEntEquipos.ElementAt(4);
            Equipos EntEquipo3 = LEntEquipos.ElementAt(5);

            Partidos EntPartido1 = new Partidos();
            Partidos EntPartido2 = new Partidos();
            Partidos EntPartido3 = new Partidos();

            EntPartido1.TorneoId = (Convert.ToInt16(DropDownList1.SelectedIndex) + 1);
            EntPartido1.PrimerEquipoId = EntEquipo1.EquipoId;
            EntPartido1.SegundoEquipoId = EntEquipo2.EquipoId;
            EntPartido1.Set1PE = Convert.ToInt16(grupoBequipo1partido1set1.Text);
            EntPartido1.Set2PE = Convert.ToInt16(grupoBequipo1partido1set2.Text);
            EntPartido1.Set3PE = Convert.ToInt16(grupoBequipo1partido1set3.Text);
            EntPartido1.Set1SE = Convert.ToInt16(grupoBequipo2partido1set1.Text);
            EntPartido1.Set2SE = Convert.ToInt16(grupoBequipo2partido1set2.Text);
            EntPartido1.Set3SE = Convert.ToInt16(grupoBequipo2partido1set3.Text);
            EntPartido1.SetGanadosPE = Convert.ToInt16(grupoBequipo1partido1puntos1.Text);
            EntPartido1.SetGanadosSE = Convert.ToInt16(grupoBequipo2partido1puntos1.Text);
            EntPartido1.SetPerdidosSE = Convert.ToInt16(grupoBequipo1partido1puntos1.Text);
            EntPartido1.SetPerdidosPE = Convert.ToInt16(grupoBequipo2partido1puntos1.Text);
            EntPartido1.GamesGanadosPE = EntPartido1.Set1PE + EntPartido1.Set2PE + EntPartido1.Set3PE;
            EntPartido1.GamesGanadosSE = EntPartido1.Set1SE + EntPartido1.Set2SE + EntPartido1.Set3SE;
            EntPartido1.GamesPerdidosPE = EntPartido1.GamesGanadosSE;
            EntPartido1.GamesPerdidosSE = EntPartido1.GamesGanadosPE;
            EntPartido1.TipoPartido = 2;
            OMapeo.AltaPartidos(EntPartido1);

            EntPartido2.TorneoId = (Convert.ToInt16(DropDownList1.SelectedIndex) + 1);
            EntPartido2.PrimerEquipoId = EntEquipo1.EquipoId;
            EntPartido2.SegundoEquipoId = EntEquipo3.EquipoId;
            EntPartido2.Set1PE = Convert.ToInt16(grupoBequipo1partido2set1.Text);
            EntPartido2.Set2PE = Convert.ToInt16(grupoBequipo1partido2set2.Text);
            EntPartido2.Set3PE = Convert.ToInt16(grupoBequipo1partido2set3.Text);
            EntPartido2.Set1SE = Convert.ToInt16(grupoBequipo3partido2set1.Text);
            EntPartido2.Set2SE = Convert.ToInt16(grupoBequipo3partido2set2.Text);
            EntPartido2.Set3SE = Convert.ToInt16(grupoBequipo3partido2set3.Text);
            EntPartido2.SetGanadosPE = Convert.ToInt16(grupoBequipo1partido2puntos1.Text);
            EntPartido2.SetGanadosSE = Convert.ToInt16(grupoBequipo3partido2puntos1.Text);
            EntPartido2.SetPerdidosSE = Convert.ToInt16(grupoBequipo1partido2puntos1.Text);
            EntPartido2.SetPerdidosPE = Convert.ToInt16(grupoBequipo3partido2puntos1.Text);
            EntPartido2.GamesGanadosPE = EntPartido2.Set1PE + EntPartido2.Set2PE + EntPartido2.Set3PE;
            EntPartido2.GamesGanadosSE = EntPartido2.Set1SE + EntPartido2.Set2SE + EntPartido2.Set3SE;
            EntPartido2.GamesPerdidosPE = EntPartido2.GamesGanadosSE;
            EntPartido2.GamesPerdidosSE = EntPartido2.GamesGanadosPE;
            EntPartido2.TipoPartido = 2;
            OMapeo.AltaPartidos(EntPartido2);

            EntPartido3.TorneoId = (Convert.ToInt16(DropDownList1.SelectedIndex) + 1);
            EntPartido3.PrimerEquipoId = EntEquipo2.EquipoId;
            EntPartido3.SegundoEquipoId = EntEquipo3.EquipoId;
            EntPartido3.Set1PE = Convert.ToInt16(grupoBequipo2partido3set1.Text);
            EntPartido3.Set2PE = Convert.ToInt16(grupoBequipo2partido3set2.Text);
            EntPartido3.Set3PE = Convert.ToInt16(grupoBequipo2partido3set3.Text);
            EntPartido3.Set1SE = Convert.ToInt16(grupoBequipo3partido3set1.Text);
            EntPartido3.Set2SE = Convert.ToInt16(grupoBequipo3partido3set2.Text);
            EntPartido3.Set3SE = Convert.ToInt16(grupoBequipo3partido3set3.Text);
            EntPartido3.SetGanadosPE = Convert.ToInt16(grupoBequipo2partido3puntos1.Text);
            EntPartido3.SetGanadosSE = Convert.ToInt16(grupoBequipo3partido3puntos1.Text);
            EntPartido3.SetPerdidosSE = Convert.ToInt16(grupoBequipo2partido3puntos1.Text);
            EntPartido3.SetPerdidosPE = Convert.ToInt16(grupoBequipo3partido3puntos1.Text);
            EntPartido3.GamesGanadosPE = EntPartido3.Set1PE + EntPartido3.Set2PE + EntPartido3.Set3PE;
            EntPartido3.GamesGanadosSE = EntPartido3.Set1SE + EntPartido3.Set2SE + EntPartido3.Set3SE;
            EntPartido3.GamesPerdidosPE = EntPartido3.GamesGanadosSE;
            EntPartido3.GamesPerdidosSE = EntPartido3.GamesGanadosPE;
            EntPartido3.TipoPartido = 2;
            OMapeo.AltaPartidos(EntPartido3);
        }

        protected void ButtonGrupoC_Click(object sender, EventArgs e)
        {
            List<Equipos> LEntEquipos = new List<Equipos>();
            MAPEO OMapeo = new MAPEO();
            List<Partidos> LEntPartidos = new List<Partidos>();

            LEntEquipos = OMapeo.RecuperaEquiposTorneo(Convert.ToInt16(DropDownList1.SelectedIndex) + 1);

            Equipos EntEquipo1 = LEntEquipos.ElementAt(6);
            Equipos EntEquipo2 = LEntEquipos.ElementAt(7);
            Equipos EntEquipo3 = LEntEquipos.ElementAt(8);

            Partidos EntPartido1 = new Partidos();
            Partidos EntPartido2 = new Partidos();
            Partidos EntPartido3 = new Partidos();

            EntPartido1.TorneoId = (Convert.ToInt16(DropDownList1.SelectedIndex) + 1);
            EntPartido1.PrimerEquipoId = EntEquipo1.EquipoId;
            EntPartido1.SegundoEquipoId = EntEquipo2.EquipoId;
            EntPartido1.Set1PE = Convert.ToInt16(grupoCequipo1partido1set1.Text);
            EntPartido1.Set2PE = Convert.ToInt16(grupoCequipo1partido1set2.Text);
            EntPartido1.Set3PE = Convert.ToInt16(grupoCequipo1partido1set3.Text);
            EntPartido1.Set1SE = Convert.ToInt16(grupoCequipo2partido1set1.Text);
            EntPartido1.Set2SE = Convert.ToInt16(grupoCequipo2partido1set2.Text);
            EntPartido1.Set3SE = Convert.ToInt16(grupoCequipo2partido1set3.Text);
            EntPartido1.SetGanadosPE = Convert.ToInt16(grupoCequipo1partido1puntos1.Text);
            EntPartido1.SetGanadosSE = Convert.ToInt16(grupoCequipo2partido1puntos1.Text);
            EntPartido1.SetPerdidosSE = Convert.ToInt16(grupoCequipo1partido1puntos1.Text);
            EntPartido1.SetPerdidosPE = Convert.ToInt16(grupoCequipo2partido1puntos1.Text);
            EntPartido1.GamesGanadosPE = EntPartido1.Set1PE + EntPartido1.Set2PE + EntPartido1.Set3PE;
            EntPartido1.GamesGanadosSE = EntPartido1.Set1SE + EntPartido1.Set2SE + EntPartido1.Set3SE;
            EntPartido1.GamesPerdidosPE = EntPartido1.GamesGanadosSE;
            EntPartido1.GamesPerdidosSE = EntPartido1.GamesGanadosPE;
            EntPartido1.TipoPartido = 3;
            OMapeo.AltaPartidos(EntPartido1);

            EntPartido2.TorneoId = (Convert.ToInt16(DropDownList1.SelectedIndex) + 1);
            EntPartido2.PrimerEquipoId = EntEquipo1.EquipoId;
            EntPartido2.SegundoEquipoId = EntEquipo3.EquipoId;
            EntPartido2.Set1PE = Convert.ToInt16(grupoCequipo1partido2set1.Text);
            EntPartido2.Set2PE = Convert.ToInt16(grupoCequipo1partido2set2.Text);
            EntPartido2.Set3PE = Convert.ToInt16(grupoCequipo1partido2set3.Text);
            EntPartido2.Set1SE = Convert.ToInt16(grupoCequipo3partido2set1.Text);
            EntPartido2.Set2SE = Convert.ToInt16(grupoCequipo3partido2set2.Text);
            EntPartido2.Set3SE = Convert.ToInt16(grupoCequipo3partido2set3.Text);
            EntPartido2.SetGanadosPE = Convert.ToInt16(grupoCequipo1partido2puntos1.Text);
            EntPartido2.SetGanadosSE = Convert.ToInt16(grupoCequipo3partido2puntos1.Text);
            EntPartido2.SetPerdidosSE = Convert.ToInt16(grupoCequipo1partido2puntos1.Text);
            EntPartido2.SetPerdidosPE = Convert.ToInt16(grupoCequipo3partido2puntos1.Text);
            EntPartido2.GamesGanadosPE = EntPartido2.Set1PE + EntPartido2.Set2PE + EntPartido2.Set3PE;
            EntPartido2.GamesGanadosSE = EntPartido2.Set1SE + EntPartido2.Set2SE + EntPartido2.Set3SE;
            EntPartido2.GamesPerdidosPE = EntPartido2.GamesGanadosSE;
            EntPartido2.GamesPerdidosSE = EntPartido2.GamesGanadosPE;
            EntPartido2.TipoPartido = 3;
            OMapeo.AltaPartidos(EntPartido2);

            EntPartido3.TorneoId = (Convert.ToInt16(DropDownList1.SelectedIndex) + 1);
            EntPartido3.PrimerEquipoId = EntEquipo2.EquipoId;
            EntPartido3.SegundoEquipoId = EntEquipo3.EquipoId;
            EntPartido3.Set1PE = Convert.ToInt16(grupoCequipo2partido3set1.Text);
            EntPartido3.Set2PE = Convert.ToInt16(grupoCequipo2partido3set2.Text);
            EntPartido3.Set3PE = Convert.ToInt16(grupoCequipo2partido3set3.Text);
            EntPartido3.Set1SE = Convert.ToInt16(grupoCequipo3partido3set1.Text);
            EntPartido3.Set2SE = Convert.ToInt16(grupoCequipo3partido3set2.Text);
            EntPartido3.Set3SE = Convert.ToInt16(grupoCequipo3partido3set3.Text);
            EntPartido3.SetGanadosPE = Convert.ToInt16(grupoCequipo2partido3puntos1.Text);
            EntPartido3.SetGanadosSE = Convert.ToInt16(grupoCequipo3partido3puntos1.Text);
            EntPartido3.SetPerdidosSE = Convert.ToInt16(grupoCequipo2partido3puntos1.Text);
            EntPartido3.SetPerdidosPE = Convert.ToInt16(grupoCequipo3partido3puntos1.Text);
            EntPartido3.GamesGanadosPE = EntPartido3.Set1PE + EntPartido3.Set2PE + EntPartido3.Set3PE;
            EntPartido3.GamesGanadosSE = EntPartido3.Set1SE + EntPartido3.Set2SE + EntPartido3.Set3SE;
            EntPartido3.GamesPerdidosPE = EntPartido3.GamesGanadosSE;
            EntPartido3.GamesPerdidosSE = EntPartido3.GamesGanadosPE;
            EntPartido3.TipoPartido = 3;
            OMapeo.AltaPartidos(EntPartido3);
        }

        protected void ButtonGrupoD_Click(object sender, EventArgs e)
        {
            List<Equipos> LEntEquipos = new List<Equipos>();
            MAPEO OMapeo = new MAPEO();
            List<Partidos> LEntPartidos = new List<Partidos>();

            LEntEquipos = OMapeo.RecuperaEquiposTorneo(Convert.ToInt16(DropDownList1.SelectedIndex) + 1);

            Equipos EntEquipo1 = LEntEquipos.ElementAt(9);
            Equipos EntEquipo2 = LEntEquipos.ElementAt(10);
            Equipos EntEquipo3 = LEntEquipos.ElementAt(11);

            Partidos EntPartido1 = new Partidos();
            Partidos EntPartido2 = new Partidos();
            Partidos EntPartido3 = new Partidos();

            EntPartido1.TorneoId = (Convert.ToInt16(DropDownList1.SelectedIndex) + 1);
            EntPartido1.PrimerEquipoId = EntEquipo1.EquipoId;
            EntPartido1.SegundoEquipoId = EntEquipo2.EquipoId;
            EntPartido1.Set1PE = Convert.ToInt16(grupoDequipo1partido1set1.Text);
            EntPartido1.Set2PE = Convert.ToInt16(grupoDequipo1partido1set2.Text);
            EntPartido1.Set3PE = Convert.ToInt16(grupoDequipo1partido1set3.Text);
            EntPartido1.Set1SE = Convert.ToInt16(grupoDequipo2partido1set1.Text);
            EntPartido1.Set2SE = Convert.ToInt16(grupoDequipo2partido1set2.Text);
            EntPartido1.Set3SE = Convert.ToInt16(grupoDequipo2partido1set3.Text);
            EntPartido1.SetGanadosPE = Convert.ToInt16(grupoDequipo1partido1puntos1.Text);
            EntPartido1.SetGanadosSE = Convert.ToInt16(grupoDequipo2partido1puntos1.Text);
            EntPartido1.SetPerdidosSE = Convert.ToInt16(grupoDequipo1partido1puntos1.Text);
            EntPartido1.SetPerdidosPE = Convert.ToInt16(grupoDequipo2partido1puntos1.Text);
            EntPartido1.GamesGanadosPE = EntPartido1.Set1PE + EntPartido1.Set2PE + EntPartido1.Set3PE;
            EntPartido1.GamesGanadosSE = EntPartido1.Set1SE + EntPartido1.Set2SE + EntPartido1.Set3SE;
            EntPartido1.GamesPerdidosPE = EntPartido1.GamesGanadosSE;
            EntPartido1.GamesPerdidosSE = EntPartido1.GamesGanadosPE;
            EntPartido1.TipoPartido = 4;
            OMapeo.AltaPartidos(EntPartido1);

            EntPartido2.TorneoId = (Convert.ToInt16(DropDownList1.SelectedIndex) + 1);
            EntPartido2.PrimerEquipoId = EntEquipo1.EquipoId;
            EntPartido2.SegundoEquipoId = EntEquipo3.EquipoId;
            EntPartido2.Set1PE = Convert.ToInt16(grupoDequipo1partido2set1.Text);
            EntPartido2.Set2PE = Convert.ToInt16(grupoDequipo1partido2set2.Text);
            EntPartido2.Set3PE = Convert.ToInt16(grupoDequipo1partido2set3.Text);
            EntPartido2.Set1SE = Convert.ToInt16(grupoDequipo3partido2set1.Text);
            EntPartido2.Set2SE = Convert.ToInt16(grupoDequipo3partido2set2.Text);
            EntPartido2.Set3SE = Convert.ToInt16(grupoDequipo3partido2set3.Text);
            EntPartido2.SetGanadosPE = Convert.ToInt16(grupoDequipo1partido2puntos1.Text);
            EntPartido2.SetGanadosSE = Convert.ToInt16(grupoDequipo3partido2puntos1.Text);
            EntPartido2.SetPerdidosSE = Convert.ToInt16(grupoDequipo1partido2puntos1.Text);
            EntPartido2.SetPerdidosPE = Convert.ToInt16(grupoDequipo3partido2puntos1.Text);
            EntPartido2.GamesGanadosPE = EntPartido2.Set1PE + EntPartido2.Set2PE + EntPartido2.Set3PE;
            EntPartido2.GamesGanadosSE = EntPartido2.Set1SE + EntPartido2.Set2SE + EntPartido2.Set3SE;
            EntPartido2.GamesPerdidosPE = EntPartido2.GamesGanadosSE;
            EntPartido2.GamesPerdidosSE = EntPartido2.GamesGanadosPE;
            EntPartido2.TipoPartido = 4;
            OMapeo.AltaPartidos(EntPartido2);

            EntPartido3.TorneoId = (Convert.ToInt16(DropDownList1.SelectedIndex) + 1);
            EntPartido3.PrimerEquipoId = EntEquipo2.EquipoId;
            EntPartido3.SegundoEquipoId = EntEquipo3.EquipoId;
            EntPartido3.Set1PE = Convert.ToInt16(grupoDequipo2partido3set1.Text);
            EntPartido3.Set2PE = Convert.ToInt16(grupoDequipo2partido3set2.Text);
            EntPartido3.Set3PE = Convert.ToInt16(grupoDequipo2partido3set3.Text);
            EntPartido3.Set1SE = Convert.ToInt16(grupoDequipo3partido3set1.Text);
            EntPartido3.Set2SE = Convert.ToInt16(grupoDequipo3partido3set2.Text);
            EntPartido3.Set3SE = Convert.ToInt16(grupoDequipo3partido3set3.Text);
            EntPartido3.SetGanadosPE = Convert.ToInt16(grupoDequipo2partido3puntos1.Text);
            EntPartido3.SetGanadosSE = Convert.ToInt16(grupoDequipo3partido3puntos1.Text);
            EntPartido3.SetPerdidosSE = Convert.ToInt16(grupoDequipo2partido3puntos1.Text);
            EntPartido3.SetPerdidosPE = Convert.ToInt16(grupoDequipo3partido3puntos1.Text);
            EntPartido3.GamesGanadosPE = EntPartido3.Set1PE + EntPartido3.Set2PE + EntPartido3.Set3PE;
            EntPartido3.GamesGanadosSE = EntPartido3.Set1SE + EntPartido3.Set2SE + EntPartido3.Set3SE;
            EntPartido3.GamesPerdidosPE = EntPartido3.GamesGanadosSE;
            EntPartido3.GamesPerdidosSE = EntPartido3.GamesGanadosPE;
            EntPartido3.TipoPartido = 4;
            OMapeo.AltaPartidos(EntPartido3);
            Panel2.Visible = true;


            //CARGA LOS 4TOS
            List<Partidos> LEntPartidos2 = new List<Partidos>();

            LEntPartidos2 = OMapeo.RecuperaPartidosTorneo(Convert.ToInt16(DropDownList1.SelectedIndex) + 1);

            List<Partidos> LEntPartidosA = new List<Partidos>();
            List<Partidos> LEntPartidosB = new List<Partidos>();
            List<Partidos> LEntPartidosC = new List<Partidos>();
            List<Partidos> LEntPartidosD = new List<Partidos>();

            LEntPartidosA = LEntPartidos2.FindAll(x => x.TipoPartido == 1);
            LEntPartidosB = LEntPartidos2.FindAll(x => x.TipoPartido == 2);
            LEntPartidosC = LEntPartidos2.FindAll(x => x.TipoPartido == 3);
            LEntPartidosD = LEntPartidos2.FindAll(x => x.TipoPartido == 4);

            OMapeo.Clasificacion(LEntPartidosA);
            OMapeo.Clasificacion(LEntPartidosB);
            OMapeo.Clasificacion(LEntPartidosC);
            OMapeo.Clasificacion(LEntPartidosD);

            // TRAIGO LAS CLASIFICACIONES PARA VER LOS 4TOS

            List<Clasificacion> Clasificacion1 = new List<Clasificacion>();
            List<Clasificacion> Clasificacion2 = new List<Clasificacion>();

            Clasificacion1 = OMapeo.OrdenarDescendenteClasificacion((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), 1);
            Clasificacion2 = OMapeo.OrdenarAscendenteClasificacion((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), 2);




            //CARGA PRIMER CUARTO
            EntEquipo1 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), Convert.ToInt16(Clasificacion1.ElementAt(0).IdEquipo));
            EntEquipo2 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), Convert.ToInt16(Clasificacion2.ElementAt(0).IdEquipo));

            cuarto1equipo1.Text = "EQUIPO 1 " + OMapeo.RecuperarPersona(EntEquipo1.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo1.SegundoJugadorE).PersonasPAdApellido;
            cuarto1equipo2.Text = "EQUIPO 2 " + OMapeo.RecuperarPersona(EntEquipo2.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo2.SegundoJugadorE).PersonasPAdApellido;


            //CARGA SEGUNDO CUARTO
            Equipos EntEquipo4 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), Convert.ToInt16(Clasificacion1.ElementAt(1).IdEquipo));
            Equipos EntEquipo5 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), Convert.ToInt16(Clasificacion2.ElementAt(1).IdEquipo));

            cuarto2equipo1.Text = "EQUIPO 1 " + OMapeo.RecuperarPersona(EntEquipo4.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo4.SegundoJugadorE).PersonasPAdApellido;
            cuarto2equipo2.Text = "EQUIPO 2 " + OMapeo.RecuperarPersona(EntEquipo5.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo5.SegundoJugadorE).PersonasPAdApellido;

            //CARGA TERCER CUARTO
            Equipos EntEquipo6 = new Equipos();
            Equipos EntEquipo7 = new Equipos();
            EntEquipo6 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), Convert.ToInt16(Clasificacion1.ElementAt(2).IdEquipo));
            EntEquipo7 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), Convert.ToInt16(Clasificacion2.ElementAt(2).IdEquipo));

            cuarto3equipo1.Text = "EQUIPO 1 " + OMapeo.RecuperarPersona(EntEquipo6.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo6.SegundoJugadorE).PersonasPAdApellido;
            cuarto3equipo2.Text = "EQUIPO 2 " + OMapeo.RecuperarPersona(EntEquipo7.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo7.SegundoJugadorE).PersonasPAdApellido;

            //CARGA CUARTO CUARTO
            Equipos EntEquipo8 = new Equipos();
            Equipos EntEquipo9 = new Equipos();
            EntEquipo8 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), Convert.ToInt16(Clasificacion1.ElementAt(3).IdEquipo));
            EntEquipo9 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), Convert.ToInt16(Clasificacion2.ElementAt(3).IdEquipo));

            cuarto4equipo1.Text = "EQUIPO 1 " + OMapeo.RecuperarPersona(EntEquipo8.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo8.SegundoJugadorE).PersonasPAdApellido;
            cuarto4equipo2.Text = "EQUIPO 2 " + OMapeo.RecuperarPersona(EntEquipo9.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo9.SegundoJugadorE).PersonasPAdApellido;

            Session["Clasificacion1"] = Clasificacion1;
            Session["Clasificacion2"] = Clasificacion2;
        }

        protected void ButtonGenerarCuartos_Click(object sender, EventArgs e)
        {
            List<Clasificacion> Clasificacion1 = new List<Clasificacion>();
            List<Clasificacion> Clasificacion2 = new List<Clasificacion>();

            Clasificacion1 = (List<Clasificacion>)Session["Clasificacion1"];
            Clasificacion2 = (List<Clasificacion>)Session["Clasificacion2"];

            Partidos EntPartido1 = new Partidos();
            Partidos EntPartido2 = new Partidos();
            Partidos EntPartido3 = new Partidos();
            Partidos EntPartido4 = new Partidos();

            MAPEO OMapeo = new MAPEO();

            EntPartido1.TorneoId = (Convert.ToInt16(DropDownList1.SelectedIndex) + 1);
            EntPartido1.PrimerEquipoId = Convert.ToInt16(Clasificacion1.ElementAt(0).IdEquipo);
            EntPartido1.SegundoEquipoId = Convert.ToInt16(Clasificacion2.ElementAt(0).IdEquipo);
            EntPartido1.Set1PE = Convert.ToInt16(cuarto1equipo1partido1set1.Text);
            EntPartido1.Set2PE = Convert.ToInt16(cuarto1equipo1partido1set2.Text);
            EntPartido1.Set3PE = Convert.ToInt16(cuarto1equipo1partido1set3.Text);
            EntPartido1.Set1SE = Convert.ToInt16(cuarto1equipo2partido1set1.Text);
            EntPartido1.Set2SE = Convert.ToInt16(cuarto1equipo2partido1set2.Text);
            EntPartido1.Set3SE = Convert.ToInt16(cuarto1equipo2partido1set3.Text);
            EntPartido1.SetGanadosPE = Convert.ToInt16(cuarto1equipo1partido1puntos.Text);
            EntPartido1.SetGanadosSE = Convert.ToInt16(cuarto1equipo2partido1puntos.Text);
            EntPartido1.SetPerdidosSE = Convert.ToInt16(cuarto1equipo1partido1puntos.Text);
            EntPartido1.SetPerdidosPE = Convert.ToInt16(cuarto1equipo2partido1puntos.Text);
            EntPartido1.GamesGanadosPE = EntPartido1.Set1PE + EntPartido1.Set2PE + EntPartido1.Set3PE;
            EntPartido1.GamesGanadosSE = EntPartido1.Set1SE + EntPartido1.Set2SE + EntPartido1.Set3SE;
            EntPartido1.GamesPerdidosPE = EntPartido1.GamesGanadosSE;
            EntPartido1.GamesPerdidosSE = EntPartido1.GamesGanadosPE;
            EntPartido1.TipoPartido = 5;
            OMapeo.AltaPartidos(EntPartido1);

            EntPartido2.TorneoId = (Convert.ToInt16(DropDownList1.SelectedIndex) + 1);
            EntPartido2.PrimerEquipoId = Convert.ToInt16(Clasificacion1.ElementAt(1).IdEquipo);
            EntPartido2.SegundoEquipoId = Convert.ToInt16(Clasificacion2.ElementAt(1).IdEquipo);
            EntPartido2.Set1PE = Convert.ToInt16(cuarto2equipo1partido1set1.Text);
            EntPartido2.Set2PE = Convert.ToInt16(cuarto2equipo1partido1set2.Text);
            EntPartido2.Set3PE = Convert.ToInt16(cuarto2equipo1partido1set3.Text);
            EntPartido2.Set1SE = Convert.ToInt16(cuarto2equipo2partido1set1.Text);
            EntPartido2.Set2SE = Convert.ToInt16(cuarto2equipo2partido1set2.Text);
            EntPartido2.Set3SE = Convert.ToInt16(cuarto2equipo2partido1set3.Text);
            EntPartido2.SetGanadosPE = Convert.ToInt16(cuarto2equipo1partido1puntos.Text);
            EntPartido2.SetGanadosSE = Convert.ToInt16(cuarto2equipo2partido1puntos.Text);
            EntPartido2.SetPerdidosSE = Convert.ToInt16(cuarto2equipo1partido1puntos.Text);
            EntPartido2.SetPerdidosPE = Convert.ToInt16(cuarto2equipo2partido1puntos.Text);
            EntPartido2.GamesGanadosPE = EntPartido2.Set1PE + EntPartido2.Set2PE + EntPartido2.Set3PE;
            EntPartido2.GamesGanadosSE = EntPartido2.Set1SE + EntPartido2.Set2SE + EntPartido2.Set3SE;
            EntPartido2.GamesPerdidosPE = EntPartido2.GamesGanadosSE;
            EntPartido2.GamesPerdidosSE = EntPartido2.GamesGanadosPE;
            EntPartido2.TipoPartido = 5;
            OMapeo.AltaPartidos(EntPartido2);

            EntPartido3.TorneoId = (Convert.ToInt16(DropDownList1.SelectedIndex) + 1);
            EntPartido3.PrimerEquipoId = Convert.ToInt16(Clasificacion1.ElementAt(2).IdEquipo);
            EntPartido3.SegundoEquipoId = Convert.ToInt16(Clasificacion2.ElementAt(2).IdEquipo);
            EntPartido3.Set1PE = Convert.ToInt16(cuarto3equipo1partido1set1.Text);
            EntPartido3.Set2PE = Convert.ToInt16(cuarto3equipo1partido1set2.Text);
            EntPartido3.Set3PE = Convert.ToInt16(cuarto3equipo1partido1set3.Text);
            EntPartido3.Set1SE = Convert.ToInt16(cuarto3equipo2partido1set1.Text);
            EntPartido3.Set2SE = Convert.ToInt16(cuarto3equipo2partido1set2.Text);
            EntPartido3.Set3SE = Convert.ToInt16(cuarto3equipo2partido1set3.Text);
            EntPartido3.SetGanadosPE = Convert.ToInt16(cuarto3equipo1partido1puntos.Text);
            EntPartido3.SetGanadosSE = Convert.ToInt16(cuarto3equipo2partido1puntos.Text);
            EntPartido3.SetPerdidosSE = Convert.ToInt16(cuarto3equipo1partido1puntos.Text);
            EntPartido3.SetPerdidosPE = Convert.ToInt16(cuarto3equipo2partido1puntos.Text);
            EntPartido3.GamesGanadosPE = EntPartido3.Set1PE + EntPartido3.Set2PE + EntPartido3.Set3PE;
            EntPartido3.GamesGanadosSE = EntPartido3.Set1SE + EntPartido3.Set2SE + EntPartido3.Set3SE;
            EntPartido3.GamesPerdidosPE = EntPartido3.GamesGanadosSE;
            EntPartido3.GamesPerdidosSE = EntPartido3.GamesGanadosPE;
            EntPartido3.TipoPartido = 5;
            OMapeo.AltaPartidos(EntPartido3);

            EntPartido4.TorneoId = (Convert.ToInt16(DropDownList1.SelectedIndex) + 1);
            EntPartido4.PrimerEquipoId = Convert.ToInt16(Clasificacion1.ElementAt(3).IdEquipo);
            EntPartido4.SegundoEquipoId = Convert.ToInt16(Clasificacion2.ElementAt(3).IdEquipo);
            EntPartido4.Set1PE = Convert.ToInt16(cuarto4equipo1partido1set1.Text);
            EntPartido4.Set2PE = Convert.ToInt16(cuarto4equipo1partido1set2.Text);
            EntPartido4.Set3PE = Convert.ToInt16(cuarto4equipo1partido1set3.Text);
            EntPartido4.Set1SE = Convert.ToInt16(cuarto4equipo2partido1set1.Text);
            EntPartido4.Set2SE = Convert.ToInt16(cuarto4equipo2partido1set2.Text);
            EntPartido4.Set3SE = Convert.ToInt16(cuarto4equipo2partido1set3.Text);
            EntPartido4.SetGanadosPE = Convert.ToInt16(cuarto4equipo1partido1puntos.Text);
            EntPartido4.SetGanadosSE = Convert.ToInt16(cuarto4equipo2partido1puntos.Text);
            EntPartido4.SetPerdidosSE = Convert.ToInt16(cuarto4equipo1partido1puntos.Text);
            EntPartido4.SetPerdidosPE = Convert.ToInt16(cuarto4equipo2partido1puntos.Text);
            EntPartido4.GamesGanadosPE = EntPartido4.Set1PE + EntPartido4.Set2PE + EntPartido4.Set3PE;
            EntPartido4.GamesGanadosSE = EntPartido4.Set1SE + EntPartido4.Set2SE + EntPartido4.Set3SE;
            EntPartido4.GamesPerdidosPE = EntPartido4.GamesGanadosSE;
            EntPartido4.GamesPerdidosSE = EntPartido4.GamesGanadosPE;
            EntPartido4.TipoPartido = 5;
            OMapeo.AltaPartidos(EntPartido4);


            Equipos EntEquipo1 = new Equipos();
            Equipos EntEquipo2 = new Equipos();
            Equipos EntEquipo3 = new Equipos();
            Equipos EntEquipo4 = new Equipos();

            if (EntPartido1.SetGanadosPE > EntPartido1.SetGanadosSE)
            {
                EntEquipo1 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), EntPartido1.PrimerEquipoId);
                semi1equipo1.Text = "EQUIPO 1 " + OMapeo.RecuperarPersona(EntEquipo1.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo1.SegundoJugadorE).PersonasPAdApellido;
            }
            else
            {
                EntEquipo1 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), EntPartido1.SegundoEquipoId);
                semi1equipo1.Text = "EQUIPO 1 " + OMapeo.RecuperarPersona(EntEquipo1.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo1.SegundoJugadorE).PersonasPAdApellido;
            }
            if (EntPartido2.SetGanadosPE > EntPartido2.SetGanadosSE)
            {
                EntEquipo2 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), EntPartido2.PrimerEquipoId);
                semi1equipo2.Text = "EQUIPO 2 " + OMapeo.RecuperarPersona(EntEquipo2.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo2.SegundoJugadorE).PersonasPAdApellido;
            }
            else
            {
                EntEquipo2 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), EntPartido2.SegundoEquipoId);
                semi1equipo2.Text = "EQUIPO 2 " + OMapeo.RecuperarPersona(EntEquipo2.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo2.SegundoJugadorE).PersonasPAdApellido;
            }
            if (EntPartido3.SetGanadosPE > EntPartido3.SetGanadosSE)
            {
                EntEquipo3 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), EntPartido3.PrimerEquipoId);
                semi2equipo1.Text = "EQUIPO 1 " + OMapeo.RecuperarPersona(EntEquipo3.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo3.SegundoJugadorE).PersonasPAdApellido;
            }
            else
            {
                EntEquipo3 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), EntPartido3.SegundoEquipoId);
                semi2equipo1.Text = "EQUIPO 1 " + OMapeo.RecuperarPersona(EntEquipo3.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo3.SegundoJugadorE).PersonasPAdApellido;
            }
            if (EntPartido4.SetGanadosPE > EntPartido4.SetGanadosSE)
            {
                EntEquipo4 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), EntPartido4.PrimerEquipoId);
                semi2equipo2.Text = "EQUIPO 2 " + OMapeo.RecuperarPersona(EntEquipo4.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo4.SegundoJugadorE).PersonasPAdApellido;
            }
            else
            {
                EntEquipo4 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), EntPartido4.SegundoEquipoId);
                semi2equipo2.Text = "EQUIPO 2 " + OMapeo.RecuperarPersona(EntEquipo4.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo4.SegundoJugadorE).PersonasPAdApellido;
            }

            List<Equipos> LEntEquipo = new List<Equipos>();

            LEntEquipo.Add(EntEquipo1);
            LEntEquipo.Add(EntEquipo2);
            LEntEquipo.Add(EntEquipo3);
            LEntEquipo.Add(EntEquipo4);

            Session["LEntEquipo"] = LEntEquipo;
        }

        protected void ButtonGenerarSemifinal_Click(object sender, EventArgs e)
        {
            List<Equipos> LEntEquipo = new List<Equipos>();

            LEntEquipo = (List<Equipos>)Session["LEntEquipo"];

            Partidos EntPartido1 = new Partidos();
            Partidos EntPartido2 = new Partidos();

            MAPEO OMapeo = new MAPEO();

            EntPartido1.TorneoId = (Convert.ToInt16(DropDownList1.SelectedIndex) + 1);
            EntPartido1.PrimerEquipoId = Convert.ToInt16(LEntEquipo.ElementAt(0).EquipoId);
            EntPartido1.SegundoEquipoId = Convert.ToInt16(LEntEquipo.ElementAt(1).EquipoId);
            EntPartido1.Set1PE = Convert.ToInt16(semi1equipo1set1.Text);
            EntPartido1.Set2PE = Convert.ToInt16(semi1equipo1set2.Text);
            EntPartido1.Set3PE = Convert.ToInt16(semi1equipo1set3.Text);
            EntPartido1.Set1SE = Convert.ToInt16(semi1equipo2set1.Text);
            EntPartido1.Set2SE = Convert.ToInt16(semi1equipo2set2.Text);
            EntPartido1.Set3SE = Convert.ToInt16(semi1equipo2set3.Text);
            EntPartido1.SetGanadosPE = Convert.ToInt16(semi1equipo1puntos.Text);
            EntPartido1.SetGanadosSE = Convert.ToInt16(semi1equipo2puntos.Text);
            EntPartido1.SetPerdidosSE = Convert.ToInt16(semi1equipo1puntos.Text);
            EntPartido1.SetPerdidosPE = Convert.ToInt16(semi1equipo2puntos.Text);
            EntPartido1.GamesGanadosPE = EntPartido1.Set1PE + EntPartido1.Set2PE + EntPartido1.Set3PE;
            EntPartido1.GamesGanadosSE = EntPartido1.Set1SE + EntPartido1.Set2SE + EntPartido1.Set3SE;
            EntPartido1.GamesPerdidosPE = EntPartido1.GamesGanadosSE;
            EntPartido1.GamesPerdidosSE = EntPartido1.GamesGanadosPE;
            EntPartido1.TipoPartido = 6;
            OMapeo.AltaPartidos(EntPartido1);

            EntPartido2.TorneoId = (Convert.ToInt16(DropDownList1.SelectedIndex) + 1);
            EntPartido2.PrimerEquipoId = Convert.ToInt16(LEntEquipo.ElementAt(2).EquipoId);
            EntPartido2.SegundoEquipoId = Convert.ToInt16(LEntEquipo.ElementAt(3).EquipoId);
            EntPartido2.Set1PE = Convert.ToInt16(semi2equipo1set1.Text);
            EntPartido2.Set2PE = Convert.ToInt16(semi2equipo1set2.Text);
            EntPartido2.Set3PE = Convert.ToInt16(semi2equipo1set3.Text);
            EntPartido2.Set1SE = Convert.ToInt16(semi2equipo2set1.Text);
            EntPartido2.Set2SE = Convert.ToInt16(semi2equipo2set2.Text);
            EntPartido2.Set3SE = Convert.ToInt16(semi2equipo2set3.Text);
            EntPartido2.SetGanadosPE = Convert.ToInt16(semi2equipo1puntos.Text);
            EntPartido2.SetGanadosSE = Convert.ToInt16(semi2equipo2puntos.Text);
            EntPartido2.SetPerdidosSE = Convert.ToInt16(semi2equipo1puntos.Text);
            EntPartido2.SetPerdidosPE = Convert.ToInt16(semi2equipo2puntos.Text);
            EntPartido2.GamesGanadosPE = EntPartido2.Set1PE + EntPartido2.Set2PE + EntPartido2.Set3PE;
            EntPartido2.GamesGanadosSE = EntPartido2.Set1SE + EntPartido2.Set2SE + EntPartido2.Set3SE;
            EntPartido2.GamesPerdidosPE = EntPartido2.GamesGanadosSE;
            EntPartido2.GamesPerdidosSE = EntPartido2.GamesGanadosPE;
            EntPartido2.TipoPartido = 6;
            OMapeo.AltaPartidos(EntPartido2);

            Equipos EntEquipo1 = new Equipos();
            Equipos EntEquipo2 = new Equipos();

            if (EntPartido1.SetGanadosPE > EntPartido1.SetGanadosSE)
            {
                EntEquipo1 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), EntPartido1.PrimerEquipoId);
                finalequipo1.Text = "EQUIPO 1 " + OMapeo.RecuperarPersona(EntEquipo1.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo1.SegundoJugadorE).PersonasPAdApellido;
            }
            else
            {
                EntEquipo1 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), EntPartido1.SegundoEquipoId);
                finalequipo1.Text = "EQUIPO 1 " + OMapeo.RecuperarPersona(EntEquipo1.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo1.SegundoJugadorE).PersonasPAdApellido;
            }
            if (EntPartido2.SetGanadosPE > EntPartido2.SetGanadosSE)
            {
                EntEquipo2 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), EntPartido2.PrimerEquipoId);
                finalequipo2.Text = "EQUIPO 2 " + OMapeo.RecuperarPersona(EntEquipo2.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo2.SegundoJugadorE).PersonasPAdApellido;
            }
            else
            {
                EntEquipo2 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), EntPartido2.SegundoEquipoId);
                finalequipo2.Text = "EQUIPO 2 " + OMapeo.RecuperarPersona(EntEquipo2.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo2.SegundoJugadorE).PersonasPAdApellido;
            }

            List<Equipos> LEntEquipoFinal = new List<Equipos>();

            LEntEquipoFinal.Add(EntEquipo1);
            LEntEquipoFinal.Add(EntEquipo2);

            Session["LEntEquipoFinal"] = LEntEquipoFinal;
        }

        protected void ButtonGenerarGanador_Click(object sender, EventArgs e)
        {
            LabelGanador.Visible = true;

            List<Equipos> LEntEquipoFinal = new List<Equipos>();

            LEntEquipoFinal = (List<Equipos>)Session["LEntEquipoFinal"];

            Partidos EntPartido1 = new Partidos();

            MAPEO OMapeo = new MAPEO();

            EntPartido1.TorneoId = (Convert.ToInt16(DropDownList1.SelectedIndex) + 1);
            EntPartido1.PrimerEquipoId = Convert.ToInt16(LEntEquipoFinal.ElementAt(0).EquipoId);
            EntPartido1.SegundoEquipoId = Convert.ToInt16(LEntEquipoFinal.ElementAt(1).EquipoId);
            EntPartido1.Set1PE = Convert.ToInt16(finalequipo1set1.Text);
            EntPartido1.Set2PE = Convert.ToInt16(finalequipo1set2.Text);
            EntPartido1.Set3PE = Convert.ToInt16(finalequipo1set3.Text);
            EntPartido1.Set1SE = Convert.ToInt16(finalequipo2set1.Text);
            EntPartido1.Set2SE = Convert.ToInt16(finalequipo2set2.Text);
            EntPartido1.Set3SE = Convert.ToInt16(finalequipo2set3.Text);
            EntPartido1.SetGanadosPE = Convert.ToInt16(finalequipo1puntos.Text);
            EntPartido1.SetGanadosSE = Convert.ToInt16(finalequipo2puntos.Text);
            EntPartido1.SetPerdidosSE = Convert.ToInt16(finalequipo1puntos.Text);
            EntPartido1.SetPerdidosPE = Convert.ToInt16(finalequipo2puntos.Text);
            EntPartido1.GamesGanadosPE = EntPartido1.Set1PE + EntPartido1.Set2PE + EntPartido1.Set3PE;
            EntPartido1.GamesGanadosSE = EntPartido1.Set1SE + EntPartido1.Set2SE + EntPartido1.Set3SE;
            EntPartido1.GamesPerdidosPE = EntPartido1.GamesGanadosSE;
            EntPartido1.GamesPerdidosSE = EntPartido1.GamesGanadosPE;
            EntPartido1.TipoPartido = 7;
            OMapeo.AltaPartidos(EntPartido1);

            Equipos EntEquipo1 = new Equipos();

            if (EntPartido1.SetGanadosPE > EntPartido1.SetGanadosSE)
            {
                EntEquipo1 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), EntPartido1.PrimerEquipoId);
                LabelGanador.Text = "GANADOR EQUIPO " + OMapeo.RecuperarPersona(EntEquipo1.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo1.SegundoJugadorE).PersonasPAdApellido;
            }
            else
            {
                EntEquipo1 = OMapeo.RecuperaUnEquipoTorneo((Convert.ToInt16(DropDownList1.SelectedIndex) + 1), EntPartido1.SegundoEquipoId);
                LabelGanador.Text = "GANADOR EQUIPO " + OMapeo.RecuperarPersona(EntEquipo1.PrimerJugadorE).PersonasPAdApellido + "-" + OMapeo.RecuperarPersona(EntEquipo1.SegundoJugadorE).PersonasPAdApellido;
            }

            Torneo EntTorneo = new Torneo();

            OMapeo.ModificarTorneo(EntEquipo1.EquipoId, (Convert.ToInt16(DropDownList1.SelectedIndex) + 1));
        }
    }
}