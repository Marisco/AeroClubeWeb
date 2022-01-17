using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class DepartamentoArquivo
    {
        public int CdDepartamentoArquivo { get; set; }
        public int CdDepartamento { get; set; }
        public int CdArquivo { get; set; }

        public virtual Arquivo CdArquivoNavigation { get; set; }
        public virtual Departamento CdDepartamentoNavigation { get; set; }
    }
}
