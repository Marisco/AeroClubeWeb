using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class UsuarioAgendaReserva
    {
        public int CdUsuario { get; set; }
        public int CdAgendaReserva { get; set; }

        public virtual AgendaReserva CdAgendaReservaNavigation { get; set; }
        public virtual Usuario CdUsuarioNavigation { get; set; }
    }
}
