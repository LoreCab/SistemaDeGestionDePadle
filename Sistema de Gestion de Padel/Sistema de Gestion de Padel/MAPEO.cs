using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_de_Gestion_de_Padel
{
    public class MAPEO
    {
        #region ALTAS
        public void AltaPersona(PersonasPad UnaPersona)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            UnaPersona.PersonasPadId = Convert.ToInt16(MiBase.PersonasPad.Count());
            MiBase.PersonasPad.InsertOnSubmit(UnaPersona);
            MiBase.SubmitChanges();
        }

        public void AltaCancha(Cancha UnaCancha)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            UnaCancha.CanchaId = Convert.ToInt16(MiBase.Cancha.Count() + 1);
            MiBase.Cancha.InsertOnSubmit(UnaCancha);
            MiBase.SubmitChanges();
        }

        public void AltaReserva(ReservaCanPad UnaReserva)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            UnaReserva.ReservaCanPadId = Convert.ToInt16(MiBase.ReservaCanPad.Count() + 1);
            MiBase.ReservaCanPad.InsertOnSubmit(UnaReserva);
            MiBase.SubmitChanges();
        }

        public void AltaTurnoFijo(TurnoFijoCanPad UnTurno)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            UnTurno.TurnoFijoCanPadId = Convert.ToInt16(MiBase.TurnoFijoCanPad.Count() + 1);
            MiBase.TurnoFijoCanPad.InsertOnSubmit(UnTurno);
            MiBase.SubmitChanges();
        }

        public void AltaHistorial(Historial UnHistorial)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            UnHistorial.HistorialId = Convert.ToInt16(MiBase.Historial.Count() + 1);
            MiBase.Historial.InsertOnSubmit(UnHistorial);
            MiBase.SubmitChanges();
        }

        public void AltaEquipos(Equipos UnEquipo)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            UnEquipo.EquipoId = Convert.ToInt16(MiBase.Equipos.Count() + 1);
            MiBase.Equipos.InsertOnSubmit(UnEquipo);
            MiBase.SubmitChanges();
        }

        public void AltaTorneos(Torneo UnTorneo)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            UnTorneo.TorneoId = Convert.ToInt16(MiBase.Torneo.Count() + 1);
            MiBase.Torneo.InsertOnSubmit(UnTorneo);
            MiBase.SubmitChanges();
        }

        public void AltaPartidos(Partidos UnPartido)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            UnPartido.PartidosId = Convert.ToInt16(MiBase.Partidos.Count() + 1);
            MiBase.Partidos.InsertOnSubmit(UnPartido);
            MiBase.SubmitChanges();
        }

        public void AltaClasificacion(Clasificacion UnaClasificacion)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            UnaClasificacion.IdClasificacion = Convert.ToInt16(MiBase.Clasificacion.Count() + 1);
            MiBase.Clasificacion.InsertOnSubmit(UnaClasificacion);
            MiBase.SubmitChanges();
        }
        #endregion

        #region MODIFICACIONES
        public void ModificaPersona(PersonasPad UnaPersona, int cod)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            PersonasPad EntPersona = MiBase.PersonasPad.Single(p => p.PersonasPadId == cod);
            EntPersona.PersonasPadDni = UnaPersona.PersonasPadDni;
            EntPersona.PersonasPadNombre = UnaPersona.PersonasPadNombre;
            EntPersona.PersonasPAdApellido = UnaPersona.PersonasPAdApellido;
            EntPersona.LocalidadPId = UnaPersona.LocalidadPId;
            EntPersona.PersonasPadTelefono = UnaPersona.PersonasPadTelefono;
            EntPersona.PersonasPadFecNac = UnaPersona.PersonasPadFecNac;
            EntPersona.PersonasPadDeuda = UnaPersona.PersonasPadDeuda;
            EntPersona.PersonasPadEstado = UnaPersona.PersonasPadEstado;
            MiBase.SubmitChanges();
        }

        public void ModificarCancha(Cancha UnaCancha, int cod)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            Cancha EntCancha = MiBase.Cancha.Single(p => p.CanchaId == cod);
            EntCancha.CanchaDescripcion = UnaCancha.CanchaDescripcion;
            EntCancha.EstadoCancha = UnaCancha.EstadoCancha;
            MiBase.SubmitChanges();
        }

        public void ModificarTurnoFijo(TurnoFijoCanPad UnTurno, int cod)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            TurnoFijoCanPad EntTurno = MiBase.TurnoFijoCanPad.Single(p => p.TurnoFijoCanPadId == cod);
            EntTurno.TurnoFijoCanPadDia = UnTurno.TurnoFijoCanPadDia;
            EntTurno.TurnoFijoCanPadFecha = UnTurno.TurnoFijoCanPadFecha;
            EntTurno.TurnoFijoCanPadHora = UnTurno.TurnoFijoCanPadHora;
            EntTurno.PersonasPadId = UnTurno.PersonasPadId;
            EntTurno.CanchaId = UnTurno.CanchaId;
            EntTurno.TurnoFijoCanPadEstado = UnTurno.TurnoFijoCanPadEstado;
            MiBase.SubmitChanges();
        }

        public void ModificarReserva(ReservaCanPad UnaReserva, int cod)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            ReservaCanPad EntReserva = MiBase.ReservaCanPad.Single(p => p.ReservaCanPadId == cod);
            EntReserva.ReservaCanPadDia = UnaReserva.ReservaCanPadDia;
            EntReserva.ReservaCanPadFecha = UnaReserva.ReservaCanPadFecha;
            EntReserva.ReservaCanPadHora = UnaReserva.ReservaCanPadHora;
            EntReserva.PersonasPadId = UnaReserva.PersonasPadId;
            EntReserva.CanchaId = UnaReserva.CanchaId;
            EntReserva.ReservaCanPadEstado = UnaReserva.ReservaCanPadEstado;
            EntReserva.ReservaCanPadPago = UnaReserva.ReservaCanPadPago;
            EntReserva.ReservaCanPadFechaPago = UnaReserva.ReservaCanPadFechaPago;
            EntReserva.ReservaCanPadTipo = UnaReserva.ReservaCanPadTipo;
            MiBase.SubmitChanges();
        }

        public void ModificarHistorial(Historial UnHistorial, int cod)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            Historial EntHistorial = MiBase.Historial.Single(p => p.HistorialId == cod);
            EntHistorial.Fecha = UnHistorial.Fecha;
            EntHistorial.GananciasDiarias = UnHistorial.GananciasDiarias;
            EntHistorial.GananciasExtra = UnHistorial.GananciasExtra;
            MiBase.SubmitChanges();
        }

        public void ModificarTorneo(int ganador, int cod)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            Torneo EntTorneo = MiBase.Torneo.Single(p => p.TorneoId == cod);
            EntTorneo.IdGanador = ganador;
            EntTorneo.Estado = 0;
            MiBase.SubmitChanges();
        }

        public void ModificarEquipo(Equipos UnEquipo, int cod)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            Equipos EntEquipos = MiBase.Equipos.Single(p => p.EquipoId == cod);
            EntEquipos.TorneoId = UnEquipo.TorneoId;
            EntEquipos.PrimerJugadorE = UnEquipo.PrimerJugadorE;
            EntEquipos.SegundoJugadorE = UnEquipo.SegundoJugadorE;
            EntEquipos.GrupoEquipo = UnEquipo.GrupoEquipo;
            MiBase.SubmitChanges();
        }

        public void ModificarPartido(Partidos UnPartido, int cod)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            Partidos EntPartido = MiBase.Partidos.Single(p => p.PartidosId == cod);
            EntPartido.TorneoId = UnPartido.TorneoId;
            EntPartido.PrimerEquipoId = UnPartido.PrimerEquipoId;
            EntPartido.SegundoEquipoId = UnPartido.SegundoEquipoId;
            EntPartido.Set1PE = UnPartido.Set1PE;
            EntPartido.Set1SE = UnPartido.Set1SE;
            EntPartido.Set2PE = UnPartido.Set2PE;
            EntPartido.Set2SE = UnPartido.Set2SE;
            EntPartido.Set3PE = UnPartido.Set3PE;
            EntPartido.Set3SE = UnPartido.Set3SE;
            EntPartido.SetGanadosPE = UnPartido.SetGanadosPE;
            EntPartido.SetGanadosSE = UnPartido.SetGanadosSE;
            EntPartido.SetPerdidosPE = UnPartido.SetPerdidosPE;
            EntPartido.SetPerdidosSE = UnPartido.SetPerdidosSE;
            EntPartido.GamesGanadosPE = UnPartido.GamesGanadosPE;
            EntPartido.GamesGanadosSE = UnPartido.GamesGanadosSE;
            EntPartido.GamesPerdidosPE = UnPartido.GamesPerdidosPE;
            EntPartido.GamesPerdidosSE = UnPartido.GamesPerdidosSE;
            EntPartido.TipoPartido = UnPartido.TipoPartido;
            MiBase.SubmitChanges();
        }
        #endregion

        #region ELIMINACIONES
        public void EliminarPersona(int cod)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            PersonasPad EntPersona = MiBase.PersonasPad.Single(p => p.PersonasPadId == cod);
            EntPersona.PersonasPadEstado = 0;
            MiBase.SubmitChanges();
        }

        public void EliminarCancha(int cod)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            Cancha EntCancha = MiBase.Cancha.Single(p => p.CanchaId == cod);
            EntCancha.EstadoCancha = 0;
            MiBase.SubmitChanges();
        }

        #endregion

        #region CONSULTAS
        public PersonasPad RecuperarPersona(int cod) //Recupera una persona por su id
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            return MiBase.PersonasPad.First(p => p.PersonasPadId == cod);
        }

        public LocalidadP RecuperarLocalidad(int cod) //Recupera una localidad por su id
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            return MiBase.LocalidadP.First(p => p.LocalidadPId == cod);
        }

        public Cancha RecuperarCancha(Int32 cod) //Recupera una cancha por su id
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            return MiBase.Cancha.First(p => p.CanchaId == cod);
        }

        public ReservaCanPad RecuperaReservaCod(int cod) //Recupera una reserva por su id
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            return MiBase.ReservaCanPad.First(p => p.ReservaCanPadId == cod);
        }

        public int RecuperaUltimaCancha()
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            return MiBase.Cancha.Count();
        }

        public PersonasPad RecuperarPersonaDNI(int cod)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            return MiBase.PersonasPad.FirstOrDefault(p => p.PersonasPadDni == cod);
        }


        public ReservaCanPad RecuperarReserva(int hora, DateTime dia, int cancha)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            return MiBase.ReservaCanPad.FirstOrDefault(a => ((Convert.ToDateTime(a.ReservaCanPadFecha).Date == dia.Date) && (a.ReservaCanPadHora == Convert.ToByte(hora)) && (a.CanchaId == cancha) && (a.ReservaCanPadEstado == Convert.ToByte(1))));
        }

        public TurnoFijoCanPad RecuperarTurno(int hora, int dia, int cancha)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            return MiBase.TurnoFijoCanPad.FirstOrDefault(a => ((a.TurnoFijoCanPadDia == dia) && (a.TurnoFijoCanPadHora == hora) && (a.CanchaId == cancha) && (a.TurnoFijoCanPadEstado == 1)));
        }

        public TurnoFijoCanPad RecuperaTurnoLibre(int hora, int dia, int cancha)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            return MiBase.TurnoFijoCanPad.FirstOrDefault(a => ((a.TurnoFijoCanPadDia == dia) && (a.TurnoFijoCanPadHora == hora) && (a.CanchaId == cancha) && (a.TurnoFijoCanPadEstado == 0)));
        }

        public List<TurnoFijoCanPad> RecuperaTurnosFecha(int dia)
        {
            List<TurnoFijoCanPad> LTurno = new List<TurnoFijoCanPad>();
            ContextoDataContext MiBase = new ContextoDataContext();

            var resultado = from a in MiBase.TurnoFijoCanPad where (a.TurnoFijoCanPadDia == dia && a.TurnoFijoCanPadEstado == 1) select a;

            foreach (TurnoFijoCanPad e in resultado)
                LTurno.Add(e);
            return LTurno;
        }

        public ReservaCanPad RecuperaUnaReserva(int cod)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            return MiBase.ReservaCanPad.FirstOrDefault(p => p.ReservaCanPadId == cod);
        }

        public TurnoFijoCanPad RecuperaUnTurnoFijo(int cod)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            return MiBase.TurnoFijoCanPad.FirstOrDefault(p => p.TurnoFijoCanPadId == cod);
        }

        public ReservaCanPad RecuperarReservaDia(int hora, DateTime hoy, int cancha, int socio, int dia)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            return MiBase.ReservaCanPad.FirstOrDefault(a => ((Convert.ToDateTime(a.ReservaCanPadFecha).Date >= hoy.Date) && (a.ReservaCanPadHora == Convert.ToByte(hora)) && (a.CanchaId == cancha) && (a.PersonasPadId == socio) &&(a.ReservaCanPadDia == dia) && (a.ReservaCanPadEstado == Convert.ToByte(1))));
        }

        public List<ReservaCanPad> RecuperaReservaFecha(DateTime fecha)
        {
            List<ReservaCanPad> LReserva = new List<ReservaCanPad>();
            ContextoDataContext MiBase = new ContextoDataContext();

            var resultado = from a in MiBase.ReservaCanPad where ((((Convert.ToDateTime(a.ReservaCanPadFecha)).Date == fecha.Date) || ((Convert.ToDateTime(a.ReservaCanPadFechaPago)).Date == fecha.Date)) && (a.ReservaCanPadEstado == 1))  select a;

            foreach (ReservaCanPad e in resultado)
                LReserva.Add(e);
            return LReserva;
        }

        public List<ReservaCanPad> RecuperarReservaSocio(int socio)
        {
            List<ReservaCanPad> LReserva = new List<ReservaCanPad>();
            ContextoDataContext MiBase = new ContextoDataContext();

            var resultado = from a in MiBase.ReservaCanPad where ((a.PersonasPadId == socio) && (a.ReservaCanPadPago == 0)) select a;

            foreach (ReservaCanPad e in resultado)
                LReserva.Add(e);
            return LReserva;
        }

        public List<ReservaCanPad> RecuperarReservaActivasSocio(int socio)
        {
            List<ReservaCanPad> LReserva = new List<ReservaCanPad>();
            ContextoDataContext MiBase = new ContextoDataContext();

            var resultado = from a in MiBase.ReservaCanPad where ((a.PersonasPadId == socio) && (a.ReservaCanPadPago == 0) && (a.ReservaCanPadEstado == 1)) select a;

            foreach (ReservaCanPad e in resultado)
                LReserva.Add(e);
            return LReserva;
        }

        public List<ReservaCanPad> RecuperarTodasReservaSocio(int socio) //Recupera una lista con todas las reservas de un socio
        {
            List<ReservaCanPad> LReserva = new List<ReservaCanPad>();
            ContextoDataContext MiBase = new ContextoDataContext();

            var resultado = from a in MiBase.ReservaCanPad where (a.PersonasPadId == socio) select a;

            foreach (ReservaCanPad e in resultado)
                LReserva.Add(e);
            return LReserva;
        }

        public List<TurnoFijoCanPad> RecuperarTodosTurnosSocio(int socio) //Recupera una lista con todos los turnos fijos de un socio
        {
            List<TurnoFijoCanPad> LTurno = new List<TurnoFijoCanPad>();
            ContextoDataContext MiBase = new ContextoDataContext();

            var resultado = from a in MiBase.TurnoFijoCanPad where (a.PersonasPadId == socio) select a;

            foreach (TurnoFijoCanPad e in resultado)
                LTurno.Add(e);
            return LTurno;
        }


        public List<TurnoFijoCanPad> RecuperaTurnosDiaCancha(int dia, int cancha)
        {
            List<TurnoFijoCanPad> LTurno = new List<TurnoFijoCanPad>();
            ContextoDataContext MiBase = new ContextoDataContext();

            var resultado = from a in MiBase.TurnoFijoCanPad where (a.TurnoFijoCanPadDia == dia && a.CanchaId == cancha) select a;

            foreach (TurnoFijoCanPad e in resultado)
                LTurno.Add(e);
            return LTurno;
        }

        public Historial RecuperarHistorial(DateTime fecha) //Recupera el ultimo historial
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            return MiBase.Historial.FirstOrDefault(p => p.Fecha.Date == fecha.Date);
        }

        public List<ReservaCanPad> RecuperaReservaSoloFecha(DateTime fecha)
        {
            List<ReservaCanPad> LReserva = new List<ReservaCanPad>();
            ContextoDataContext MiBase = new ContextoDataContext();

            var resultado = from a in MiBase.ReservaCanPad where (((Convert.ToDateTime(a.ReservaCanPadFecha)).Date == fecha.Date) && (a.ReservaCanPadEstado == 1)) select a;

            foreach (ReservaCanPad e in resultado)
                LReserva.Add(e);
            return LReserva;
        }

        public int RecuperaUltimoTorneo()
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            return MiBase.Torneo.Count();
        }

        public Equipos RecuperaUnEquipo(int idtorneo, int idequipo)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            return MiBase.Equipos.FirstOrDefault(p => p.TorneoId == idtorneo && p.GrupoEquipo == idequipo);
        }

        public Equipos RecuperaUnEquipoTorneo(int idtorneo, int idequipo)
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            return MiBase.Equipos.FirstOrDefault(p => p.TorneoId == idtorneo && p.EquipoId == idequipo);
        }

        public List<Equipos> RecuperaEquiposTorneo(int torneo)
        {
            List<Equipos> LEquipos = new List<Equipos>();
            ContextoDataContext MiBase = new ContextoDataContext();

            var resultado = from a in MiBase.Equipos where (a.TorneoId == torneo) select a;

            foreach (Equipos e in resultado)
                LEquipos.Add(e);
            return LEquipos;
        }

        public List<Partidos> RecuperaPartidosTorneo(int torneo)
        {
            List<Partidos> LPartidos = new List<Partidos>();
            ContextoDataContext MiBase = new ContextoDataContext();

            var resultado = from a in MiBase.Partidos where (a.TorneoId == torneo) select a;

            foreach (Partidos e in resultado)
                LPartidos.Add(e);
            return LPartidos;
        }

        public void Clasificacion(List<Partidos> LPartido)
        {
            Partidos Partido1 = LPartido.ElementAt(0);
            Partidos Partido2 = LPartido.ElementAt(1);
            Partidos Partido3 = LPartido.ElementAt(2);

            int Equipo1 = 0, Equipo2 = 0, Equipo3 = 0;

            int Ds1 = 0, Ds2 = 0, Ds3 = 0;

            int Dg1 = 0, Dg2 = 0, Dg3 = 0;

            int Sf1 = 0, Sf2 = 0, Sf3 = 0;

            int Gf1 = 0, Gf2 = 0, Gf3 = 0;

            if (Partido1.SetGanadosPE > Partido1.SetGanadosSE)
            {
                Equipo1++;
            }
            else
            {
                Equipo2++;
            }

            if (Partido2.SetGanadosPE > Partido2.SetGanadosSE)
            {
                Equipo1++;
            }
            else
            {
                Equipo3++;
            }
            if (Partido3.SetGanadosPE > Partido3.SetGanadosSE)
            {
                Equipo2++;
            }
            else
            {
                Equipo3++;
            }

            Ds1 = Partido1.SetGanadosPE - Partido1.SetPerdidosPE + Partido2.SetGanadosPE - Partido2.SetPerdidosPE;
            Ds2 = Partido1.SetGanadosSE - Partido1.SetPerdidosSE + Partido3.SetGanadosPE - Partido3.SetPerdidosPE;
            Ds3 = Partido2.SetGanadosSE - Partido2.SetPerdidosSE + Partido3.SetGanadosSE - Partido3.SetPerdidosSE;

            Dg1 = Partido1.GamesGanadosPE - Partido1.GamesPerdidosPE + Partido2.GamesGanadosPE - Partido2.GamesPerdidosPE;
            Dg2 = Partido1.GamesGanadosSE - Partido1.GamesPerdidosSE + Partido3.GamesGanadosPE - Partido3.GamesPerdidosPE;
            Dg3 = Partido2.GamesGanadosSE - Partido2.GamesPerdidosSE + Partido3.GamesGanadosSE - Partido3.GamesPerdidosSE;

            Sf1 = Partido1.SetGanadosPE + Partido2.SetGanadosPE;
            Sf2 = Partido1.SetGanadosSE + Partido3.SetGanadosPE;
            Sf3 = Partido2.SetGanadosSE + Partido3.SetGanadosSE;

            Gf1 = Partido1.GamesGanadosPE + Partido2.GamesGanadosPE;
            Gf2 = Partido1.GamesGanadosSE + Partido3.GamesGanadosPE;
            Gf3 = Partido2.GamesGanadosSE + Partido3.GamesGanadosSE;

            Clasificacion EntClasificacion1 = new Clasificacion();
            Clasificacion EntClasificacion2 = new Clasificacion();
            Clasificacion EntClasificacion3 = new Clasificacion();

            EntClasificacion1.IdEquipo = Partido1.PrimerEquipoId;
            EntClasificacion1.IdTorneo = Partido1.TorneoId;
            EntClasificacion1.PG = Equipo1;
            EntClasificacion1.DS = Ds1;
            EntClasificacion1.DG = Dg1;
            EntClasificacion1.SF = Sf1;
            EntClasificacion1.GF = Gf1;

            EntClasificacion2.IdEquipo = Partido1.SegundoEquipoId;
            EntClasificacion2.IdTorneo = Partido1.TorneoId;
            EntClasificacion2.PG = Equipo2;
            EntClasificacion2.DS = Ds2;
            EntClasificacion2.DG = Dg2;
            EntClasificacion2.SF = Sf2;
            EntClasificacion2.GF = Gf2;

            EntClasificacion3.IdEquipo = Partido3.SegundoEquipoId;
            EntClasificacion3.IdTorneo = Partido1.TorneoId;
            EntClasificacion3.PG = Equipo3;
            EntClasificacion3.DS = Ds3;
            EntClasificacion3.DG = Dg3;
            EntClasificacion3.SF = Sf3;
            EntClasificacion3.GF = Gf3;

            List<Clasificacion> LEntClasificacion = new List<Clasificacion>();
            MAPEO OMapeo = new MAPEO();

            LEntClasificacion.Add(EntClasificacion1);
            LEntClasificacion.Add(EntClasificacion2);
            LEntClasificacion.Add(EntClasificacion3);

            LEntClasificacion = LEntClasificacion.OrderByDescending(x => x.PG).ToList();

            if (LEntClasificacion.ElementAt(0).PG != LEntClasificacion.ElementAt(1).PG)//HAY UNO CON MAYOR PUNTAJE EN PG
            {
                EntClasificacion1 = LEntClasificacion.ElementAt(0);
                EntClasificacion1.Puesto = 1;
                LEntClasificacion.RemoveAt(0);
                if (LEntClasificacion.ElementAt(0).PG != LEntClasificacion.ElementAt(1).PG) //EXISTE EL 2DO PUNTAJE MAYOR EN PG
                {
                    EntClasificacion2 = LEntClasificacion.ElementAt(0);
                    EntClasificacion2.Puesto = 2;
                    EntClasificacion3 = LEntClasificacion.ElementAt(1);
                    EntClasificacion3.Puesto = 3;
                }
                else
                {
                    LEntClasificacion = LEntClasificacion.OrderByDescending(x => x.DS).ToList();
                    if (LEntClasificacion.ElementAt(0).DS != LEntClasificacion.ElementAt(1).DS) //EXISTE EL 2DO CON DS
                    {
                        EntClasificacion2 = LEntClasificacion.ElementAt(0);
                        EntClasificacion2.Puesto = 2;
                        EntClasificacion3 = LEntClasificacion.ElementAt(1);
                        EntClasificacion3.Puesto = 3;
                    }
                    else
                    {
                        LEntClasificacion = LEntClasificacion.OrderByDescending(x => x.DG).ToList();
                        if (LEntClasificacion.ElementAt(0).DG != LEntClasificacion.ElementAt(1).DG) //EXISTE 2DO CON DG
                        {
                            EntClasificacion2 = LEntClasificacion.ElementAt(0);
                            EntClasificacion2.Puesto = 2;
                            EntClasificacion3 = LEntClasificacion.ElementAt(1);
                            EntClasificacion3.Puesto = 3;
                        }
                        else
                        {
                            LEntClasificacion = LEntClasificacion.OrderByDescending(x => x.SF).ToList();
                            if (LEntClasificacion.ElementAt(0).SF != LEntClasificacion.ElementAt(1).SF) // EXISTE 2DO CON SF
                            {
                                EntClasificacion2 = LEntClasificacion.ElementAt(0);
                                EntClasificacion2.Puesto = 2;
                                EntClasificacion3 = LEntClasificacion.ElementAt(1);
                                EntClasificacion3.Puesto = 3;
                            }
                            else
                            {
                                LEntClasificacion = LEntClasificacion.OrderByDescending(x => x.GF).ToList();
                                if (LEntClasificacion.ElementAt(0).GF != LEntClasificacion.ElementAt(1).GF) //EXISTE 2DO CON GF
                                {
                                    EntClasificacion2 = LEntClasificacion.ElementAt(0);
                                    EntClasificacion2.Puesto = 2;
                                    EntClasificacion3 = LEntClasificacion.ElementAt(1);
                                    EntClasificacion3.Puesto = 3;
                                }
                                else //CLASIFICAN CON LOS MISMOS PUNTAJES Y DESEMPATAN CON EL GANADOR DEL SET
                                {
                                    Partidos EntPartido = new Partidos();
                                    List<Partidos> ListPartidos = new List<Partidos>();

                                    ListPartidos = OMapeo.RecuperaPartidosTorneo(Convert.ToInt16(LEntClasificacion.ElementAt(0).IdTorneo));

                                    EntPartido = ListPartidos.Find(x => (x.PrimerEquipoId == LEntClasificacion.ElementAt(0).IdEquipo || x.SegundoEquipoId == LEntClasificacion.ElementAt(0).IdEquipo) && (x.PrimerEquipoId == LEntClasificacion.ElementAt(1).IdEquipo || x.SegundoEquipoId == LEntClasificacion.ElementAt(1).IdEquipo));

                                    if (EntPartido.SetGanadosPE > EntPartido.SetGanadosSE)
                                    {
                                        EntClasificacion2 = LEntClasificacion.Find(x => x.IdEquipo == EntPartido.PrimerEquipoId);
                                        EntClasificacion3 = LEntClasificacion.Find(x => x.IdEquipo == EntPartido.SegundoEquipoId);
                                        EntClasificacion2.Puesto = 2;
                                        EntClasificacion3.Puesto = 3;
                                    }
                                    else
                                    {
                                        EntClasificacion2 = LEntClasificacion.Find(x => x.IdEquipo == EntPartido.SegundoEquipoId);
                                        EntClasificacion3 = LEntClasificacion.Find(x => x.IdEquipo == EntPartido.PrimerEquipoId);
                                        EntClasificacion2.Puesto = 2;
                                        EntClasificacion3.Puesto = 3;
                                    }
                                }
                            }
                        }
                    }
                }

            }
            else //Son iguales los 3 partidos
            {
                    LEntClasificacion = LEntClasificacion.OrderByDescending(x => x.DS).ToList();
                    if (LEntClasificacion.ElementAt(0).DS != LEntClasificacion.ElementAt(1).DS) //EXISTE EL 2DO CON DS
                    {
                        EntClasificacion1 = LEntClasificacion.ElementAt(0);
                        EntClasificacion1.Puesto = 1;
                        LEntClasificacion.RemoveAt(0);
                        if (LEntClasificacion.ElementAt(0).DS != LEntClasificacion.ElementAt(1).DS)
                        {
                            EntClasificacion2 = LEntClasificacion.ElementAt(0);
                            EntClasificacion2.Puesto = 2;
                            EntClasificacion3 = LEntClasificacion.ElementAt(1);
                            EntClasificacion3.Puesto = 3;
                        }
                    }
                    else
                    {
                        LEntClasificacion = LEntClasificacion.OrderByDescending(x => x.DG).ToList();
                        if (LEntClasificacion.ElementAt(0).DG != LEntClasificacion.ElementAt(1).DG) //EXISTE 2DO CON DG
                        {
                            EntClasificacion2 = LEntClasificacion.ElementAt(0);
                            EntClasificacion2.Puesto = 2;
                            EntClasificacion3 = LEntClasificacion.ElementAt(1);
                            EntClasificacion3.Puesto = 3;
                        }
                        else
                        {
                            LEntClasificacion = LEntClasificacion.OrderByDescending(x => x.SF).ToList();
                            if (LEntClasificacion.ElementAt(0).SF != LEntClasificacion.ElementAt(1).SF) // EXISTE 2DO CON SF
                            {
                                EntClasificacion2 = LEntClasificacion.ElementAt(0);
                                EntClasificacion2.Puesto = 2;
                                EntClasificacion3 = LEntClasificacion.ElementAt(1);
                                EntClasificacion3.Puesto = 3;
                            }
                            else
                            {
                                LEntClasificacion = LEntClasificacion.OrderByDescending(x => x.GF).ToList();
                                if (LEntClasificacion.ElementAt(0).GF != LEntClasificacion.ElementAt(1).GF) //EXISTE 2DO CON GF
                                {
                                    EntClasificacion2 = LEntClasificacion.ElementAt(0);
                                    EntClasificacion2.Puesto = 2;
                                    EntClasificacion3 = LEntClasificacion.ElementAt(1);
                                    EntClasificacion3.Puesto = 3;
                                }
                                else //CLASIFICAN CON LOS MISMOS PUNTAJES Y DESEMPATAN CON EL GANADOR DEL SET
                                {
                                    Partidos EntPartido = new Partidos();
                                    List<Partidos> ListPartidos = new List<Partidos>();

                                    ListPartidos = OMapeo.RecuperaPartidosTorneo(Convert.ToInt16(LEntClasificacion.ElementAt(0).IdTorneo));

                                    EntPartido = ListPartidos.Find(x => (x.PrimerEquipoId == LEntClasificacion.ElementAt(0).IdEquipo || x.SegundoEquipoId == LEntClasificacion.ElementAt(0).IdEquipo) && (x.PrimerEquipoId == LEntClasificacion.ElementAt(1).IdEquipo || x.SegundoEquipoId == LEntClasificacion.ElementAt(1).IdEquipo));

                                    if (EntPartido.SetGanadosPE > EntPartido.SetGanadosSE)
                                    {
                                        EntClasificacion2 = LEntClasificacion.Find(x => x.IdEquipo == EntPartido.PrimerEquipoId);
                                        EntClasificacion3 = LEntClasificacion.Find(x => x.IdEquipo == EntPartido.SegundoEquipoId);
                                        EntClasificacion2.Puesto = 2;
                                        EntClasificacion3.Puesto = 3;
                                    }
                                    else
                                    {
                                        EntClasificacion2 = LEntClasificacion.Find(x => x.IdEquipo == EntPartido.SegundoEquipoId);
                                        EntClasificacion3 = LEntClasificacion.Find(x => x.IdEquipo == EntPartido.PrimerEquipoId);
                                        EntClasificacion2.Puesto = 2;
                                        EntClasificacion3.Puesto = 3;
                                    }
                                }
                            }
                        }
                    }
                }


            OMapeo.AltaClasificacion(EntClasificacion1);
            OMapeo.AltaClasificacion(EntClasificacion2);
            OMapeo.AltaClasificacion(EntClasificacion3);
        }

        public List<Clasificacion> OrdenarDescendenteClasificacion(int torneo, int posicion)
        {
            List<Clasificacion> LClasificacion = new List<Clasificacion>();
            ContextoDataContext MiBase = new ContextoDataContext();

            var resultado = from a in MiBase.Clasificacion where (a.IdTorneo == torneo && a.Puesto == posicion) orderby a.PG descending, a.DS descending, a.DG descending, a.SF descending, a.GF descending select a;

            foreach (Clasificacion e in resultado)
                LClasificacion.Add(e);
            return LClasificacion;
        }

        public List<Clasificacion> OrdenarAscendenteClasificacion(int torneo, int posicion)
        {
            List<Clasificacion> LClasificacion = new List<Clasificacion>();
            ContextoDataContext MiBase = new ContextoDataContext();

            var resultado = from a in MiBase.Clasificacion where (a.IdTorneo == torneo && a.Puesto == posicion) orderby a.PG, a.DS, a.DG, a.SF, a.GF select a;

            foreach (Clasificacion e in resultado)
                LClasificacion.Add(e);
            return LClasificacion;
        }


        public Torneo RecuperarTorneo(int cod) //Recupera una persona por su id
        {
            ContextoDataContext MiBase = new ContextoDataContext();
            return MiBase.Torneo.First(p => p.TorneoId == cod);
        }
        #endregion
    }
}