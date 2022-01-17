using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class Telefone
    {
        public Telefone()
        {
            DepartamentoTelefone = new HashSet<DepartamentoTelefone>();
            UsuarioTelefone = new HashSet<UsuarioTelefone>();
        }

        public int CdTelefone { get; set; }
        public string NrCodigoArea { get; set; }
        public string NrTelefone { get; set; }
        public int CdTipoTelefone { get; set; }

        public virtual ICollection<DepartamentoTelefone> DepartamentoTelefone { get; set; }
        public virtual ICollection<UsuarioTelefone> UsuarioTelefone { get; set; }
        public virtual TipoTelefone CdTipoTelefoneNavigation { get; set; }
    }
}
