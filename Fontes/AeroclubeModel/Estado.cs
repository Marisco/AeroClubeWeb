using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class Estado
    {
        public int CdEstado { get; set; }
        public string SgEstado { get; set; }
        public string DsEstado { get; set; }
        public int CdPais { get; set; }

        public virtual Estado CdEstadoNavigation { get; set; }
        public virtual Estado InverseCdEstadoNavigation { get; set; }
        public virtual Pais CdPaisNavigation { get; set; }
    }
}
