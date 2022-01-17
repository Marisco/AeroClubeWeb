using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class Grade
    {
        public int CdGrade { get; set; }
        public string DsGrade { get; set; }
        public int CdCursoDetalhe { get; set; }

        public virtual GradeReserva GradeReserva { get; set; }
        public virtual CursoDetalhe CdCursoDetalheNavigation { get; set; }
    }
}
