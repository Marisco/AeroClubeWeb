using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class CursoDetalhe
    {
        public CursoDetalhe()
        {
            Grade = new HashSet<Grade>();
            UsuarioPrestacao = new HashSet<UsuarioPrestacao>();
        }

        public int CdCursoDetalhe { get; set; }
        public int DsCursoDetalhe { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFin { get; set; }
        public decimal TxDesconto { get; set; }
        public decimal VlDesconto { get; set; }
        public decimal VlCurso { get; set; }

        public virtual ICollection<Grade> Grade { get; set; }
        public virtual ICollection<UsuarioPrestacao> UsuarioPrestacao { get; set; }
    }
}
