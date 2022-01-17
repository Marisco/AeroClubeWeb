using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class DepartamentoEmail
    {
        public int CdDepartamentoEmail { get; set; }
        public int CdDepartamento { get; set; }
        public int CdEmail { get; set; }

        public virtual Departamento CdDepartamentoNavigation { get; set; }
        public virtual Email CdEmailNavigation { get; set; }
    }
}
