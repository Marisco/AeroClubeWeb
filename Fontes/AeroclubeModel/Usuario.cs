using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class Usuario
    {
        public Usuario()
        {
            DisciplinaAluno = new HashSet<DisciplinaAluno>();
            DisciplinaInstrutor = new HashSet<DisciplinaInstrutor>();
            UsuarioAgendaReserva = new HashSet<UsuarioAgendaReserva>();
            UsuarioArquivo = new HashSet<UsuarioArquivo>();
            UsuarioDocumento = new HashSet<UsuarioDocumento>();
            UsuarioEmail = new HashSet<UsuarioEmail>();
            UsuarioEndereco = new HashSet<UsuarioEndereco>();
            UsuarioPagamento = new HashSet<UsuarioPagamento>();
            UsuarioPrestacao = new HashSet<UsuarioPrestacao>();
            UsuarioRecebimento = new HashSet<UsuarioRecebimento>();
            UsuarioTelefone = new HashSet<UsuarioTelefone>();
        }

        public int CdUsuario { get; set; }
        public string FlAtivo { get; set; }
        public string NmUsuario { get; set; }
        public string DsEstadoCivil { get; set; }
        public DateTime? DtNascimento { get; set; }
        public string DsSenha { get; set; }
        public int? CdCidade { get; set; }
        public int CdTipoUsuario { get; set; }

        public virtual ICollection<DisciplinaAluno> DisciplinaAluno { get; set; }
        public virtual ICollection<DisciplinaInstrutor> DisciplinaInstrutor { get; set; }
        public virtual ICollection<UsuarioAgendaReserva> UsuarioAgendaReserva { get; set; }
        public virtual ICollection<UsuarioArquivo> UsuarioArquivo { get; set; }
        public virtual ICollection<UsuarioDocumento> UsuarioDocumento { get; set; }
        public virtual ICollection<UsuarioEmail> UsuarioEmail { get; set; }
        public virtual ICollection<UsuarioEndereco> UsuarioEndereco { get; set; }
        public virtual ICollection<UsuarioPagamento> UsuarioPagamento { get; set; }
        public virtual ICollection<UsuarioPrestacao> UsuarioPrestacao { get; set; }
        public virtual ICollection<UsuarioRecebimento> UsuarioRecebimento { get; set; }
        public virtual ICollection<UsuarioTelefone> UsuarioTelefone { get; set; }
        public virtual Cidade CdCidadeNavigation { get; set; }
        public virtual TipoUsuario CdTipoUsuarioNavigation { get; set; }
    }
}
