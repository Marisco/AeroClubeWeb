using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class Disciplina
    {
        public Disciplina()
        {
            DisciplinaAluno = new HashSet<DisciplinaAluno>();
            DisciplinaCurso = new HashSet<DisciplinaCurso>();
            DisciplinaInstrutor = new HashSet<DisciplinaInstrutor>();
        }

        public int CdDisciplina { get; set; }
        public string FlAtivo { get; set; }
        public string NmDisciplina { get; set; }
        public string DsDisciplina { get; set; }
        public int CdTipoDisciplina { get; set; }

        public virtual ICollection<DisciplinaAluno> DisciplinaAluno { get; set; }
        public virtual ICollection<DisciplinaCurso> DisciplinaCurso { get; set; }
        public virtual ICollection<DisciplinaInstrutor> DisciplinaInstrutor { get; set; }
        public virtual TipoDisciplina CdTipoDisciplinaNavigation { get; set; }
    }
}
