using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class UsuarioEndereco
    {
        public int CdUsuarioEndereco { get; set; }
        public int CdUsuario { get; set; }
        public int CdEndereco { get; set; }

        public virtual Endereco CdEnderecoNavigation { get; set; }
        public virtual Usuario CdUsuarioNavigation { get; set; }
    }
}
