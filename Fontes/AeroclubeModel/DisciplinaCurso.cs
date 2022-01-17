using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class DisciplinaCurso
    {
        public int CdDisciplinaCurso { get; set; }
        public int CdCurso { get; set; }
        public int CdDisciplina { get; set; }

        public virtual Curso CdCursoNavigation { get; set; }
        public virtual Disciplina CdDisciplinaNavigation { get; set; }
    }
}
