using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class Pais
    {
        public Pais()
        {
            Estado = new HashSet<Estado>();
        }

        public int CdPais { get; set; }
        public string NrPais { get; set; }
        public string DsPais { get; set; }

        public virtual ICollection<Estado> Estado { get; set; }
        public virtual Pais CdPaisNavigation { get; set; }
        public virtual Pais InverseCdPaisNavigation { get; set; }
    }
}
