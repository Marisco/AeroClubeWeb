using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class GradeReserva
    {
        public int GradeReserva1 { get; set; }
        public int CdGrade { get; set; }
        public int CdReserva { get; set; }

        public virtual Grade CdGradeNavigation { get; set; }
        public virtual Reserva CdReservaNavigation { get; set; }
    }
}
