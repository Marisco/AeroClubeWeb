using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class DepartamentoTelefone
    {
        public int CdDepartamentoTelefone { get; set; }
        public int CdTelefone { get; set; }
        public int CdDepartamento { get; set; }

        public virtual Departamento CdDepartamentoNavigation { get; set; }
        public virtual Telefone CdTelefoneNavigation { get; set; }
    }
}
