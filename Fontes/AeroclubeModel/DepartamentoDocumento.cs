using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class DepartamentoDocumento
    {
        public int CdDepartamentoDocumento { get; set; }
        public int CdDepartamento { get; set; }
        public int CdDocumento { get; set; }

        public virtual Departamento CdDepartamentoNavigation { get; set; }
        public virtual Documento CdDocumentoNavigation { get; set; }
    }
}
