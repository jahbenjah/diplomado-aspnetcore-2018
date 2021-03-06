﻿using System;
using System.Collections.Generic;

namespace Core.Entidades.DB
{
    public partial class Partido
    {
        public Partido()
        {
            Apuesta = new HashSet<Apuesta>();
            Evento = new HashSet<Evento>();
        }

        public int PartidoId { get; set; }
        public int FaseId { get; set; }
        public int EquipoIdLocal { get; set; }
        public int EquipoIdVisitante { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }

        public Equipo EquipoIdLocalNavigation { get; set; }
        public Equipo EquipoIdVisitanteNavigation { get; set; }
        public Fase Fase { get; set; }
        public ICollection<Apuesta> Apuesta { get; set; }
        public ICollection<Evento> Evento { get; set; }
    }
}
