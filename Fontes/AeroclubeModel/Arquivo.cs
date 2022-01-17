using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class Arquivo
    {
        public Arquivo()
        {
            AeronaveArquivo = new HashSet<AeronaveArquivo>();
            DepartamentoArquivo = new HashSet<DepartamentoArquivo>();
            DocumentoArquivo = new HashSet<DocumentoArquivo>();
            UsuarioArquivo = new HashSet<UsuarioArquivo>();
        }

        public int CdArquivo { get; set; }
        public string TpArquivo { get; set; }
        public string NmArquivo { get; set; }
        public string DsArquivo { get; set; }
        public byte[] ImArquivo { get; set; }

        public virtual ICollection<AeronaveArquivo> AeronaveArquivo { get; set; }
        public virtual ICollection<DepartamentoArquivo> DepartamentoArquivo { get; set; }
        public virtual ICollection<DocumentoArquivo> DocumentoArquivo { get; set; }
        public virtual ICollection<UsuarioArquivo> UsuarioArquivo { get; set; }
    }
}
