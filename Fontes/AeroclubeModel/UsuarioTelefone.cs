using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class UsuarioTelefone
    {
        public int CdUsuarioTelefone { get; set; }
        public int CdTelefone { get; set; }
        public int CdUsuario { get; set; }

        public virtual Telefone CdTelefoneNavigation { get; set; }
        public virtual Usuario CdUsuarioNavigation { get; set; }
    }
}
