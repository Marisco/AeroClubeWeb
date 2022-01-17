using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class UsuarioArquivo
    {
        public int CdUsuarioArquivo { get; set; }
        public int CdUsuario { get; set; }
        public int CdArquivo { get; set; }

        public virtual Arquivo CdArquivoNavigation { get; set; }
        public virtual Usuario CdUsuarioNavigation { get; set; }
    }
}
