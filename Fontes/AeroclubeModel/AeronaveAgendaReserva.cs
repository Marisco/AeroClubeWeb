using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class AeronaveAgendaReserva
    {
        public int CdAeronave { get; set; }
        public int CdAgendaReserva { get; set; }

        public virtual Aeronave CdAeronaveNavigation { get; set; }
        public virtual AgendaReserva CdAgendaReservaNavigation { get; set; }
    }
}
