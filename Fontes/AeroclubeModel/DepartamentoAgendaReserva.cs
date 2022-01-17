using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class DepartamentoAgendaReserva
    {
        public int CdDepartamento { get; set; }
        public int CdAgendaReserva { get; set; }

        public virtual AgendaReserva CdAgendaReservaNavigation { get; set; }
        public virtual Departamento CdDepartamentoNavigation { get; set; }
    }
}
