using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class AgendaReserva
    {
        public AgendaReserva()
        {
            AeronaveAgendaReserva = new HashSet<AeronaveAgendaReserva>();
            DepartamentoAgendaReserva = new HashSet<DepartamentoAgendaReserva>();
            UsuarioAgendaReserva = new HashSet<UsuarioAgendaReserva>();
        }

        public int CdAgendaReserva { get; set; }
        public int CdReserva { get; set; }
        public int CdAgenda { get; set; }

        public virtual ICollection<AeronaveAgendaReserva> AeronaveAgendaReserva { get; set; }
        public virtual ICollection<DepartamentoAgendaReserva> DepartamentoAgendaReserva { get; set; }
        public virtual ICollection<UsuarioAgendaReserva> UsuarioAgendaReserva { get; set; }
        public virtual Agenda CdAgendaNavigation { get; set; }
        public virtual Reserva CdReservaNavigation { get; set; }
    }
}
