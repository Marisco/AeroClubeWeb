using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class Documento
    {
        public Documento()
        {
            AeronaveDocumento = new HashSet<AeronaveDocumento>();
            DepartamentoDocumento = new HashSet<DepartamentoDocumento>();
            DocumentoArquivo = new HashSet<DocumentoArquivo>();
            UsuarioDocumento = new HashSet<UsuarioDocumento>();
        }

        public int CdDocumento { get; set; }
        public string NrDocumento { get; set; }
        public int CdTipoDocumento { get; set; }

        public virtual ICollection<AeronaveDocumento> AeronaveDocumento { get; set; }
        public virtual ICollection<DepartamentoDocumento> DepartamentoDocumento { get; set; }
        public virtual ICollection<DocumentoArquivo> DocumentoArquivo { get; set; }
        public virtual ICollection<UsuarioDocumento> UsuarioDocumento { get; set; }
        public virtual TipoDocumento CdTipoDocumentoNavigation { get; set; }
    }
}
