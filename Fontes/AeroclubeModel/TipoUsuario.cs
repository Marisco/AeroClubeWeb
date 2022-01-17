using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class TipoUsuario
    {
        public TipoUsuario()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int CdTipoUsuario { get; set; }
        public string DsTipoUsuario { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
