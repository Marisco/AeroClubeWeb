using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class AeronaveDocumento
    {
        public int CdAeronaveDocumento { get; set; }
        public int CdAeronave { get; set; }
        public int CdDocumento { get; set; }

        public virtual Aeronave CdAeronaveNavigation { get; set; }
        public virtual Documento CdDocumentoNavigation { get; set; }
    }
}
