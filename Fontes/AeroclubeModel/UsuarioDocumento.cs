using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class UsuarioDocumento
    {
        public int CdUsuarioDocumento { get; set; }
        public int CdUsuario { get; set; }
        public int CdDocumento { get; set; }

        public virtual Documento CdDocumentoNavigation { get; set; }
        public virtual Usuario CdUsuarioNavigation { get; set; }
    }
}
