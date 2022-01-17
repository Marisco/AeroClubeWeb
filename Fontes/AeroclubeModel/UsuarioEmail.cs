using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class UsuarioEmail
    {
        public int CdUsuarioEmail { get; set; }
        public int CdUsuario { get; set; }
        public int CdEmail { get; set; }

        public virtual Email CdEmailNavigation { get; set; }
        public virtual Usuario CdUsuarioNavigation { get; set; }
    }
}
