using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class DisciplinaAluno
    {
        public int CdDisciplinaAluno { get; set; }
        public int CdDisciplina { get; set; }
        public int CdUsuario { get; set; }

        public virtual Disciplina CdDisciplinaNavigation { get; set; }
        public virtual Usuario CdUsuarioNavigation { get; set; }
    }
}
