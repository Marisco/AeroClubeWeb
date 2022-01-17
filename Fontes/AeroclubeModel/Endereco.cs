using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class Endereco
    {
        public Endereco()
        {
            DepartamentoEndereco = new HashSet<DepartamentoEndereco>();
            UsuarioEndereco = new HashSet<UsuarioEndereco>();
        }

        public int CdEndereco { get; set; }
        public string NrCep { get; set; }
        public string DsLogradouro { get; set; }
        public string DsEndereco { get; set; }
        public string NrNumero { get; set; }
        public string DsComplemento { get; set; }
        public string DsGeoLocalizacao { get; set; }
        public int CdTipoEndereco { get; set; }
        public int CdCidade { get; set; }

        public virtual ICollection<DepartamentoEndereco> DepartamentoEndereco { get; set; }
        public virtual ICollection<UsuarioEndereco> UsuarioEndereco { get; set; }
        public virtual Cidade CdCidadeNavigation { get; set; }
        public virtual TipoEndereco CdTipoEnderecoNavigation { get; set; }
    }
}
