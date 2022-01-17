using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class Email
    {
        public Email()
        {
            DepartamentoEmail = new HashSet<DepartamentoEmail>();
            UsuarioEmail = new HashSet<UsuarioEmail>();
        }

        public int CdEmail { get; set; }
        public string DsEmail { get; set; }

        public virtual ICollection<DepartamentoEmail> DepartamentoEmail { get; set; }
        public virtual ICollection<UsuarioEmail> UsuarioEmail { get; set; }
    }
}
