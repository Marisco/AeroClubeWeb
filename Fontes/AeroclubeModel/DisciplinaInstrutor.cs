using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class DisciplinaInstrutor
    {
        public int CdDisciplinaInstrutor { get; set; }
        public int CdDisciplina { get; set; }
        public int CdUsuario { get; set; }

        public virtual Disciplina CdDisciplinaNavigation { get; set; }
        public virtual Usuario CdUsuarioNavigation { get; set; }
    }
}
