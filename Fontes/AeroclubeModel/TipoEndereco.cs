using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class TipoEndereco
    {
        public TipoEndereco()
        {
            Endereco = new HashSet<Endereco>();
        }

        public int CdTipoEndereco { get; set; }
        public string DsTipoEndereco { get; set; }

        public virtual ICollection<Endereco> Endereco { get; set; }
    }
}
