using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class TipoDisciplina
    {
        public TipoDisciplina()
        {
            Disciplina = new HashSet<Disciplina>();
        }

        public int CdTipoDisciplina { get; set; }
        public string DsTipoDisciplina { get; set; }

        public virtual ICollection<Disciplina> Disciplina { get; set; }
    }
}
