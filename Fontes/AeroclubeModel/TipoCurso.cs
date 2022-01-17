using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class TipoCurso
    {
        public TipoCurso()
        {
            Curso = new HashSet<Curso>();
        }

        public int CdTipoCurso { get; set; }
        public string DsTipoCurso { get; set; }

        public virtual ICollection<Curso> Curso { get; set; }
    }
}
