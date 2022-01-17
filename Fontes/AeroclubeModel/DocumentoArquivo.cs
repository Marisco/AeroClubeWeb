using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class DocumentoArquivo
    {
        public int CdDocumentoArquivo { get; set; }
        public int CdDocumento { get; set; }
        public int CdArquivo { get; set; }

        public virtual Arquivo CdArquivoNavigation { get; set; }
        public virtual Documento CdDocumentoNavigation { get; set; }
    }
}
