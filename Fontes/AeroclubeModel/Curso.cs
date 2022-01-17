using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class Curso
    {
        public Curso()
        {
            DisciplinaCurso = new HashSet<DisciplinaCurso>();
        }

        public int CdCurso { get; set; }
        public string FlAtivo { get; set; }
        public string NmCurso { get; set; }
        public int CdTipoCurso { get; set; }

        public virtual ICollection<DisciplinaCurso> DisciplinaCurso { get; set; }
        public virtual TipoCurso CdTipoCursoNavigation { get; set; }
    }
}
