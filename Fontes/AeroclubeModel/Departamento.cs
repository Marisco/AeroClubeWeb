using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class Departamento
    {
        public Departamento()
        {
            DepartamentoAgendaReserva = new HashSet<DepartamentoAgendaReserva>();
            DepartamentoArquivo = new HashSet<DepartamentoArquivo>();
            DepartamentoDocumento = new HashSet<DepartamentoDocumento>();
            DepartamentoEmail = new HashSet<DepartamentoEmail>();
            DepartamentoEndereco = new HashSet<DepartamentoEndereco>();
            DepartamentoTelefone = new HashSet<DepartamentoTelefone>();
        }

        public int CdDepartamento { get; set; }
        public string DsDepartamento { get; set; }
        public int CdTipoDepartamento { get; set; }

        public virtual ICollection<DepartamentoAgendaReserva> DepartamentoAgendaReserva { get; set; }
        public virtual ICollection<DepartamentoArquivo> DepartamentoArquivo { get; set; }
        public virtual ICollection<DepartamentoDocumento> DepartamentoDocumento { get; set; }
        public virtual ICollection<DepartamentoEmail> DepartamentoEmail { get; set; }
        public virtual ICollection<DepartamentoEndereco> DepartamentoEndereco { get; set; }
        public virtual ICollection<DepartamentoTelefone> DepartamentoTelefone { get; set; }
        public virtual TipoDepartamento CdTipoDepartamentoNavigation { get; set; }
    }
}
