using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class TipoTelefone
    {
        public TipoTelefone()
        {
            Telefone = new HashSet<Telefone>();
        }

        public int CdTipoTelefone { get; set; }
        public string DsTipoTelefone { get; set; }

        public virtual ICollection<Telefone> Telefone { get; set; }
    }
}
