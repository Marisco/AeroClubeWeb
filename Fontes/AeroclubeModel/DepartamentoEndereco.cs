using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class DepartamentoEndereco
    {
        public int CdDepartamentoEndereco { get; set; }
        public int CdDepartamento { get; set; }
        public int CdEndereco { get; set; }

        public virtual Departamento CdDepartamentoNavigation { get; set; }
        public virtual Endereco CdEnderecoNavigation { get; set; }
    }
}
