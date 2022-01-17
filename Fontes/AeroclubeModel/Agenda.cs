using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class Agenda
    {
        public Agenda()
        {
            AgendaReserva = new HashSet<AgendaReserva>();
        }

        public int CdAgenda { get; set; }
        public int NrAgenda { get; set; }
        public int NrAno { get; set; }

        public virtual ICollection<AgendaReserva> AgendaReserva { get; set; }
    }
}
