using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class TipoDepartamento
    {
        public TipoDepartamento()
        {
            Departamento = new HashSet<Departamento>();
        }

        public int CdTipoDepartamento { get; set; }
        public string DsTipoDepartamento { get; set; }

        public virtual ICollection<Departamento> Departamento { get; set; }
    }
}
