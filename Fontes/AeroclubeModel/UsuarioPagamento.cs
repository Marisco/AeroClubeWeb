using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class UsuarioPagamento
    {
        public int CdPagamento { get; set; }
        public string DsPagamento { get; set; }
        public decimal? TxJuros { get; set; }
        public decimal? VlJuros { get; set; }
        public decimal? TxDesconto { get; set; }
        public decimal? VlDesconto { get; set; }
        public decimal? VlPagamento { get; set; }
        public int CdUsuario { get; set; }
        public int? CdPrestacao { get; set; }

        public virtual UsuarioPrestacao CdPrestacaoNavigation { get; set; }
        public virtual Usuario CdUsuarioNavigation { get; set; }
    }
}
