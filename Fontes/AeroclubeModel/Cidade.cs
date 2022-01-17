using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class Cidade
    {
        public Cidade()
        {
            Endereco = new HashSet<Endereco>();
            Usuario = new HashSet<Usuario>();
        }

        public int CdCidade { get; set; }
        public string DsCidade { get; set; }
        public string NrIbge { get; set; }
        public int CdEstado { get; set; }
        public int CdPais { get; set; }

        public virtual ICollection<Endereco> Endereco { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
