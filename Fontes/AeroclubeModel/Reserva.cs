using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class Reserva
    {
        public Reserva()
        {
            AgendaReserva = new HashSet<AgendaReserva>();
            GradeReserva = new HashSet<GradeReserva>();
        }

        public int CdReserva { get; set; }
        public string NrReserva { get; set; }
        public DateTime DtAgenda { get; set; }
        public DateTime DtResernva { get; set; }
        public DateTime HrReservaIni { get; set; }
        public DateTime HrReservaFin { get; set; }

        public virtual ICollection<AgendaReserva> AgendaReserva { get; set; }
        public virtual ICollection<GradeReserva> GradeReserva { get; set; }
    }
}
