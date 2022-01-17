using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class AeronaveArquivo
    {
        public int CdAeronaveArquivo { get; set; }
        public int CdAeronave { get; set; }
        public int CdArquivo { get; set; }

        public virtual Aeronave CdAeronaveNavigation { get; set; }
        public virtual Arquivo CdArquivoNavigation { get; set; }
    }
}
