using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class UsuarioPrestacao
    {
        public UsuarioPrestacao()
        {
            UsuarioPagamento = new HashSet<UsuarioPagamento>();
            UsuarioRecebimento = new HashSet<UsuarioRecebimento>();
        }

        public int CdPrestacao { get; set; }
        public string DsPrestacao { get; set; }
        public decimal? VlPrestacao { get; set; }
        public int CdUsuario { get; set; }
        public int CdCursoDetalhe { get; set; }

        public virtual ICollection<UsuarioPagamento> UsuarioPagamento { get; set; }
        public virtual ICollection<UsuarioRecebimento> UsuarioRecebimento { get; set; }
        public virtual CursoDetalhe CdCursoDetalheNavigation { get; set; }
        public virtual Usuario CdUsuarioNavigation { get; set; }
    }
}
