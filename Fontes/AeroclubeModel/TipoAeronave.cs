using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class TipoAeronave
    {
        public TipoAeronave()
        {
            Aeronave = new HashSet<Aeronave>();
        }

        public int CdTipoAeronave { get; set; }
        public string DsTipoAeronave { get; set; }

        public virtual ICollection<Aeronave> Aeronave { get; set; }
    }
}
