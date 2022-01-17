using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class TipoDocumento
    {
        public TipoDocumento()
        {
            Documento = new HashSet<Documento>();
        }

        public int CdTipoDocumento { get; set; }
        public string DsTipoDocumento { get; set; }

        public virtual ICollection<Documento> Documento { get; set; }
    }
}
