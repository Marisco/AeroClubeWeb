using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Aeroclube
{
    public partial class AeroClubeContext : DbContext
    {
        public virtual DbSet<Aeronave> Aeronave { get; set; }
        public virtual DbSet<AeronaveAgendaReserva> AeronaveAgendaReserva { get; set; }
        public virtual DbSet<AeronaveArquivo> AeronaveArquivo { get; set; }
        public virtual DbSet<AeronaveDocumento> AeronaveDocumento { get; set; }
        public virtual DbSet<Agenda> Agenda { get; set; }
        public virtual DbSet<AgendaReserva> AgendaReserva { get; set; }
        public virtual DbSet<Arquivo> Arquivo { get; set; }
        public virtual DbSet<Cidade> Cidade { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<CursoDetalhe> CursoDetalhe { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<DepartamentoAgendaReserva> DepartamentoAgendaReserva { get; set; }
        public virtual DbSet<DepartamentoArquivo> DepartamentoArquivo { get; set; }
        public virtual DbSet<DepartamentoDocumento> DepartamentoDocumento { get; set; }
        public virtual DbSet<DepartamentoEmail> DepartamentoEmail { get; set; }
        public virtual DbSet<DepartamentoEndereco> DepartamentoEndereco { get; set; }
        public virtual DbSet<DepartamentoTelefone> DepartamentoTelefone { get; set; }
        public virtual DbSet<Disciplina> Disciplina { get; set; }
        public virtual DbSet<DisciplinaAluno> DisciplinaAluno { get; set; }
        public virtual DbSet<DisciplinaCurso> DisciplinaCurso { get; set; }
        public virtual DbSet<DisciplinaInstrutor> DisciplinaInstrutor { get; set; }
        public virtual DbSet<Documento> Documento { get; set; }
        public virtual DbSet<DocumentoArquivo> DocumentoArquivo { get; set; }
        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<GradeReserva> GradeReserva { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Reserva> Reserva { get; set; }
        public virtual DbSet<Telefone> Telefone { get; set; }
        public virtual DbSet<TipoAeronave> TipoAeronave { get; set; }
        public virtual DbSet<TipoCurso> TipoCurso { get; set; }
        public virtual DbSet<TipoDepartamento> TipoDepartamento { get; set; }
        public virtual DbSet<TipoDisciplina> TipoDisciplina { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
        public virtual DbSet<TipoEndereco> TipoEndereco { get; set; }
        public virtual DbSet<TipoTelefone> TipoTelefone { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioAgendaReserva> UsuarioAgendaReserva { get; set; }
        public virtual DbSet<UsuarioArquivo> UsuarioArquivo { get; set; }
        public virtual DbSet<UsuarioDocumento> UsuarioDocumento { get; set; }
        public virtual DbSet<UsuarioEmail> UsuarioEmail { get; set; }
        public virtual DbSet<UsuarioEndereco> UsuarioEndereco { get; set; }
        public virtual DbSet<UsuarioPagamento> UsuarioPagamento { get; set; }
        public virtual DbSet<UsuarioPrestacao> UsuarioPrestacao { get; set; }
        public virtual DbSet<UsuarioRecebimento> UsuarioRecebimento { get; set; }
        public virtual DbSet<UsuarioTelefone> UsuarioTelefone { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-NJM4VO3;Database=AeroClube;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aeronave>(entity =>
            {
                entity.HasKey(e => e.CdAeronave)
                    .HasName("PK__aeronave__39B9CB9AD42C7D0B");

                entity.ToTable("aeronave");

                entity.Property(e => e.CdAeronave)
                    .HasColumnName("cd_aeronave")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdTipoAeronave).HasColumnName("cd_tipo_aeronave");

                entity.Property(e => e.DsAeronave)
                    .IsRequired()
                    .HasColumnName("ds_aeronave")
                    .HasMaxLength(50);

                entity.Property(e => e.NrAeronave)
                    .IsRequired()
                    .HasColumnName("nr_aeronave")
                    .HasMaxLength(20);

                entity.HasOne(d => d.CdTipoAeronaveNavigation)
                    .WithMany(p => p.Aeronave)
                    .HasForeignKey(d => d.CdTipoAeronave)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_tipo_aeronave");
            });

            modelBuilder.Entity<AeronaveAgendaReserva>(entity =>
            {
                entity.HasKey(e => new { e.CdAeronave, e.CdAgendaReserva })
                    .HasName("PK__aeronave__DAC6FDEDA7EF68F9");

                entity.ToTable("aeronave_agenda_reserva");

                entity.Property(e => e.CdAeronave).HasColumnName("cd_aeronave");

                entity.Property(e => e.CdAgendaReserva).HasColumnName("cd_agenda_reserva");

                entity.HasOne(d => d.CdAeronaveNavigation)
                    .WithMany(p => p.AeronaveAgendaReserva)
                    .HasForeignKey(d => d.CdAeronave)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fkaeronave_agenda_reserva_1");

                entity.HasOne(d => d.CdAgendaReservaNavigation)
                    .WithMany(p => p.AeronaveAgendaReserva)
                    .HasForeignKey(d => d.CdAgendaReserva)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_aeronave_agenda_reserva_2");
            });

            modelBuilder.Entity<AeronaveArquivo>(entity =>
            {
                entity.HasKey(e => e.CdAeronaveArquivo)
                    .HasName("PK__aeronave__F4D08F120C569735");

                entity.ToTable("aeronave_arquivo");

                entity.Property(e => e.CdAeronaveArquivo)
                    .HasColumnName("cd_aeronave_arquivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdAeronave).HasColumnName("cd_aeronave");

                entity.Property(e => e.CdArquivo).HasColumnName("cd_arquivo");

                entity.HasOne(d => d.CdAeronaveNavigation)
                    .WithMany(p => p.AeronaveArquivo)
                    .HasForeignKey(d => d.CdAeronave)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_aeronave_arquivo_1");

                entity.HasOne(d => d.CdArquivoNavigation)
                    .WithMany(p => p.AeronaveArquivo)
                    .HasForeignKey(d => d.CdArquivo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_aeronave_arquivo_2");
            });

            modelBuilder.Entity<AeronaveDocumento>(entity =>
            {
                entity.HasKey(e => e.CdAeronaveDocumento)
                    .HasName("PK__aeronave__F6240E7AF64FCE1A");

                entity.ToTable("aeronave_documento");

                entity.Property(e => e.CdAeronaveDocumento)
                    .HasColumnName("cd_aeronave_documento")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdAeronave).HasColumnName("cd_aeronave");

                entity.Property(e => e.CdDocumento).HasColumnName("cd_documento");

                entity.HasOne(d => d.CdAeronaveNavigation)
                    .WithMany(p => p.AeronaveDocumento)
                    .HasForeignKey(d => d.CdAeronave)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_aeronave_documento_1");

                entity.HasOne(d => d.CdDocumentoNavigation)
                    .WithMany(p => p.AeronaveDocumento)
                    .HasForeignKey(d => d.CdDocumento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_aeronave_documento_2");
            });

            modelBuilder.Entity<Agenda>(entity =>
            {
                entity.HasKey(e => e.CdAgenda)
                    .HasName("PK__agenda__B7F5D2C0B12EADA2");

                entity.ToTable("agenda");

                entity.Property(e => e.CdAgenda)
                    .HasColumnName("cd_agenda")
                    .ValueGeneratedNever();

                entity.Property(e => e.NrAgenda).HasColumnName("nr_agenda");

                entity.Property(e => e.NrAno).HasColumnName("nr_ano");
            });

            modelBuilder.Entity<AgendaReserva>(entity =>
            {
                entity.HasKey(e => e.CdAgendaReserva)
                    .HasName("PK__agenda_r__37F3677FBE9DDB05");

                entity.ToTable("agenda_reserva");

                entity.Property(e => e.CdAgendaReserva)
                    .HasColumnName("cd_agenda_reserva")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdAgenda).HasColumnName("cd_agenda");

                entity.Property(e => e.CdReserva).HasColumnName("cd_reserva");

                entity.HasOne(d => d.CdAgendaNavigation)
                    .WithMany(p => p.AgendaReserva)
                    .HasForeignKey(d => d.CdAgenda)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_agenda_reserva_1");

                entity.HasOne(d => d.CdReservaNavigation)
                    .WithMany(p => p.AgendaReserva)
                    .HasForeignKey(d => d.CdReserva)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_agenda_reserva_2");
            });

            modelBuilder.Entity<Arquivo>(entity =>
            {
                entity.HasKey(e => e.CdArquivo)
                    .HasName("PK__arquivo__1C6CAE000504BFC9");

                entity.ToTable("arquivo");

                entity.Property(e => e.CdArquivo)
                    .HasColumnName("cd_arquivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsArquivo)
                    .HasColumnName("ds_arquivo")
                    .HasMaxLength(100);

                entity.Property(e => e.ImArquivo).HasColumnName("im_arquivo");

                entity.Property(e => e.NmArquivo)
                    .HasColumnName("nm_arquivo")
                    .HasMaxLength(50);

                entity.Property(e => e.TpArquivo)
                    .HasColumnName("tp_arquivo")
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.HasKey(e => e.CdCidade)
                    .HasName("PK__cidade__3679C3409F23BD4D");

                entity.ToTable("cidade");

                entity.Property(e => e.CdCidade)
                    .HasColumnName("cd_cidade")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdEstado).HasColumnName("cd_estado");

                entity.Property(e => e.CdPais).HasColumnName("cd_pais");

                entity.Property(e => e.DsCidade)
                    .HasColumnName("ds_cidade")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NrIbge)
                    .HasColumnName("nr_ibge")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.HasKey(e => e.CdCurso)
                    .HasName("PK__curso__3267DD410D9577C1");

                entity.ToTable("curso");

                entity.Property(e => e.CdCurso)
                    .HasColumnName("cd_curso")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdTipoCurso).HasColumnName("cd_tipo_curso");

                entity.Property(e => e.FlAtivo)
                    .IsRequired()
                    .HasColumnName("fl_ativo")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'S'");

                entity.Property(e => e.NmCurso)
                    .IsRequired()
                    .HasColumnName("nm_curso")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CdTipoCursoNavigation)
                    .WithMany(p => p.Curso)
                    .HasForeignKey(d => d.CdTipoCurso)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_tipo_cursocurso");
            });

            modelBuilder.Entity<CursoDetalhe>(entity =>
            {
                entity.HasKey(e => e.CdCursoDetalhe)
                    .HasName("PK__curso_de__3A07251D60B65FD4");

                entity.ToTable("curso_detalhe");

                entity.Property(e => e.CdCursoDetalhe)
                    .HasColumnName("cd_curso_detalhe")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsCursoDetalhe).HasColumnName("ds_curso_detalhe");

                entity.Property(e => e.DtFin)
                    .HasColumnName("dt_fin")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtIni)
                    .HasColumnName("dt_ini")
                    .HasColumnType("datetime");

                entity.Property(e => e.TxDesconto)
                    .HasColumnName("tx_desconto")
                    .HasColumnType("numeric");

                entity.Property(e => e.VlCurso)
                    .HasColumnName("vl_curso")
                    .HasColumnType("numeric");

                entity.Property(e => e.VlDesconto)
                    .HasColumnName("vl_desconto")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.CdDepartamento)
                    .HasName("PK__departam__5F6417DDABC3C3A3");

                entity.ToTable("departamento");

                entity.Property(e => e.CdDepartamento)
                    .HasColumnName("cd_departamento")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdTipoDepartamento).HasColumnName("cd_tipo_departamento");

                entity.Property(e => e.DsDepartamento)
                    .IsRequired()
                    .HasColumnName("ds_departamento")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CdTipoDepartamentoNavigation)
                    .WithMany(p => p.Departamento)
                    .HasForeignKey(d => d.CdTipoDepartamento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_tipo_departamento");
            });

            modelBuilder.Entity<DepartamentoAgendaReserva>(entity =>
            {
                entity.HasKey(e => new { e.CdDepartamento, e.CdAgendaReserva })
                    .HasName("PK__departam__BC1B21AA3814773C");

                entity.ToTable("departamento_agenda_reserva");

                entity.Property(e => e.CdDepartamento).HasColumnName("cd_departamento");

                entity.Property(e => e.CdAgendaReserva).HasColumnName("cd_agenda_reserva");

                entity.HasOne(d => d.CdAgendaReservaNavigation)
                    .WithMany(p => p.DepartamentoAgendaReserva)
                    .HasForeignKey(d => d.CdAgendaReserva)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_departamento_agenda_reserva_2");

                entity.HasOne(d => d.CdDepartamentoNavigation)
                    .WithMany(p => p.DepartamentoAgendaReserva)
                    .HasForeignKey(d => d.CdDepartamento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_departamento_agenda_reserva_1");
            });

            modelBuilder.Entity<DepartamentoArquivo>(entity =>
            {
                entity.HasKey(e => e.CdDepartamentoArquivo)
                    .HasName("PK__departam__F4529E85CB990E9C");

                entity.ToTable("departamento_arquivo");

                entity.Property(e => e.CdDepartamentoArquivo)
                    .HasColumnName("cd_departamento_arquivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdArquivo).HasColumnName("cd_arquivo");

                entity.Property(e => e.CdDepartamento).HasColumnName("cd_departamento");

                entity.HasOne(d => d.CdArquivoNavigation)
                    .WithMany(p => p.DepartamentoArquivo)
                    .HasForeignKey(d => d.CdArquivo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_departamento_arquivo_2");

                entity.HasOne(d => d.CdDepartamentoNavigation)
                    .WithMany(p => p.DepartamentoArquivo)
                    .HasForeignKey(d => d.CdDepartamento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_departamento_arquivo_1");
            });

            modelBuilder.Entity<DepartamentoDocumento>(entity =>
            {
                entity.HasKey(e => e.CdDepartamentoDocumento)
                    .HasName("PK__departam__13841660E94FAEE4");

                entity.ToTable("departamento_documento");

                entity.Property(e => e.CdDepartamentoDocumento)
                    .HasColumnName("cd_departamento_documento")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdDepartamento).HasColumnName("cd_departamento");

                entity.Property(e => e.CdDocumento).HasColumnName("cd_documento");

                entity.HasOne(d => d.CdDepartamentoNavigation)
                    .WithMany(p => p.DepartamentoDocumento)
                    .HasForeignKey(d => d.CdDepartamento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_departamento_documento_1");

                entity.HasOne(d => d.CdDocumentoNavigation)
                    .WithMany(p => p.DepartamentoDocumento)
                    .HasForeignKey(d => d.CdDocumento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_departamento_documento_2");
            });

            modelBuilder.Entity<DepartamentoEmail>(entity =>
            {
                entity.HasKey(e => e.CdDepartamentoEmail)
                    .HasName("PK__departam__72183DC3EC411F32");

                entity.ToTable("departamento_email");

                entity.Property(e => e.CdDepartamentoEmail)
                    .HasColumnName("cd_departamento_email")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdDepartamento).HasColumnName("cd_departamento");

                entity.Property(e => e.CdEmail).HasColumnName("cd_email");

                entity.HasOne(d => d.CdDepartamentoNavigation)
                    .WithMany(p => p.DepartamentoEmail)
                    .HasForeignKey(d => d.CdDepartamento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_departamento_email_1");

                entity.HasOne(d => d.CdEmailNavigation)
                    .WithMany(p => p.DepartamentoEmail)
                    .HasForeignKey(d => d.CdEmail)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_departamento_email_2");
            });

            modelBuilder.Entity<DepartamentoEndereco>(entity =>
            {
                entity.HasKey(e => e.CdDepartamentoEndereco)
                    .HasName("PK__departam__F8C97B31A635388E");

                entity.ToTable("departamento_endereco");

                entity.Property(e => e.CdDepartamentoEndereco)
                    .HasColumnName("cd_departamento_endereco")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdDepartamento).HasColumnName("cd_departamento");

                entity.Property(e => e.CdEndereco).HasColumnName("cd_endereco");

                entity.HasOne(d => d.CdDepartamentoNavigation)
                    .WithMany(p => p.DepartamentoEndereco)
                    .HasForeignKey(d => d.CdDepartamento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_departamento_endereco_1");

                entity.HasOne(d => d.CdEnderecoNavigation)
                    .WithMany(p => p.DepartamentoEndereco)
                    .HasForeignKey(d => d.CdEndereco)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_departamento_endereco_2");
            });

            modelBuilder.Entity<DepartamentoTelefone>(entity =>
            {
                entity.HasKey(e => e.CdDepartamentoTelefone)
                    .HasName("PK__departam__13502E9817BC9B20");

                entity.ToTable("departamento_telefone");

                entity.Property(e => e.CdDepartamentoTelefone)
                    .HasColumnName("cd_departamento_telefone")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdDepartamento).HasColumnName("cd_departamento");

                entity.Property(e => e.CdTelefone).HasColumnName("cd_telefone");

                entity.HasOne(d => d.CdDepartamentoNavigation)
                    .WithMany(p => p.DepartamentoTelefone)
                    .HasForeignKey(d => d.CdDepartamento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_departamento_telefone_1");

                entity.HasOne(d => d.CdTelefoneNavigation)
                    .WithMany(p => p.DepartamentoTelefone)
                    .HasForeignKey(d => d.CdTelefone)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_departamento_telefone_2");
            });

            modelBuilder.Entity<Disciplina>(entity =>
            {
                entity.HasKey(e => e.CdDisciplina)
                    .HasName("PK__discipli__19383D2BBE559241");

                entity.ToTable("disciplina");

                entity.Property(e => e.CdDisciplina)
                    .HasColumnName("cd_disciplina")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdTipoDisciplina).HasColumnName("cd_tipo_disciplina");

                entity.Property(e => e.DsDisciplina)
                    .IsRequired()
                    .HasColumnName("ds_disciplina")
                    .HasMaxLength(50);

                entity.Property(e => e.FlAtivo)
                    .IsRequired()
                    .HasColumnName("fl_ativo")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'S'");

                entity.Property(e => e.NmDisciplina)
                    .IsRequired()
                    .HasColumnName("nm_disciplina")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CdTipoDisciplinaNavigation)
                    .WithMany(p => p.Disciplina)
                    .HasForeignKey(d => d.CdTipoDisciplina)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_tipo_disciplina");
            });

            modelBuilder.Entity<DisciplinaAluno>(entity =>
            {
                entity.HasKey(e => e.CdDisciplinaAluno)
                    .HasName("PK__discipli__18BEBB6006A6B3B9");

                entity.ToTable("disciplina_aluno");

                entity.Property(e => e.CdDisciplinaAluno)
                    .HasColumnName("cd_disciplina_aluno")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdDisciplina).HasColumnName("cd_disciplina");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.HasOne(d => d.CdDisciplinaNavigation)
                    .WithMany(p => p.DisciplinaAluno)
                    .HasForeignKey(d => d.CdDisciplina)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_disciplina_aluno_1");

                entity.HasOne(d => d.CdUsuarioNavigation)
                    .WithMany(p => p.DisciplinaAluno)
                    .HasForeignKey(d => d.CdUsuario)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_disciplina_aluno_2");
            });

            modelBuilder.Entity<DisciplinaCurso>(entity =>
            {
                entity.HasKey(e => e.CdDisciplinaCurso)
                    .HasName("PK__discipli__592AF41A9ABC5547");

                entity.ToTable("disciplina_curso");

                entity.Property(e => e.CdDisciplinaCurso)
                    .HasColumnName("cd_disciplina_curso")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCurso).HasColumnName("cd_curso");

                entity.Property(e => e.CdDisciplina).HasColumnName("cd_disciplina");

                entity.HasOne(d => d.CdCursoNavigation)
                    .WithMany(p => p.DisciplinaCurso)
                    .HasForeignKey(d => d.CdCurso)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_disciplina_curso_2");

                entity.HasOne(d => d.CdDisciplinaNavigation)
                    .WithMany(p => p.DisciplinaCurso)
                    .HasForeignKey(d => d.CdDisciplina)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_disciplina_curso_1");
            });

            modelBuilder.Entity<DisciplinaInstrutor>(entity =>
            {
                entity.HasKey(e => e.CdDisciplinaInstrutor)
                    .HasName("PK__discipli__381A84E9DF86CF48");

                entity.ToTable("disciplina_instrutor");

                entity.Property(e => e.CdDisciplinaInstrutor)
                    .HasColumnName("cd_disciplina_instrutor")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdDisciplina).HasColumnName("cd_disciplina");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.HasOne(d => d.CdDisciplinaNavigation)
                    .WithMany(p => p.DisciplinaInstrutor)
                    .HasForeignKey(d => d.CdDisciplina)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_disciplina_instrutor_1");

                entity.HasOne(d => d.CdUsuarioNavigation)
                    .WithMany(p => p.DisciplinaInstrutor)
                    .HasForeignKey(d => d.CdUsuario)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_disciplina_instrutor_2");
            });

            modelBuilder.Entity<Documento>(entity =>
            {
                entity.HasKey(e => e.CdDocumento)
                    .HasName("PK__document__D2515DCF0B4F411F");

                entity.ToTable("documento");

                entity.Property(e => e.CdDocumento)
                    .HasColumnName("cd_documento")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdTipoDocumento).HasColumnName("cd_tipo_documento");

                entity.Property(e => e.NrDocumento)
                    .IsRequired()
                    .HasColumnName("nr_documento")
                    .HasMaxLength(20);

                entity.HasOne(d => d.CdTipoDocumentoNavigation)
                    .WithMany(p => p.Documento)
                    .HasForeignKey(d => d.CdTipoDocumento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_tipo_documento");
            });

            modelBuilder.Entity<DocumentoArquivo>(entity =>
            {
                entity.HasKey(e => e.CdDocumentoArquivo)
                    .HasName("PK__document__210C3D9E5ABDF95C");

                entity.ToTable("documento_arquivo");

                entity.Property(e => e.CdDocumentoArquivo)
                    .HasColumnName("cd_documento_arquivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdArquivo).HasColumnName("cd_arquivo");

                entity.Property(e => e.CdDocumento).HasColumnName("cd_documento");

                entity.HasOne(d => d.CdArquivoNavigation)
                    .WithMany(p => p.DocumentoArquivo)
                    .HasForeignKey(d => d.CdArquivo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_documento_arquivo_2");

                entity.HasOne(d => d.CdDocumentoNavigation)
                    .WithMany(p => p.DocumentoArquivo)
                    .HasForeignKey(d => d.CdDocumento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_documento_arquivo_1");
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.HasKey(e => e.CdEmail)
                    .HasName("PK__email__A9C5CECBF21128BE");

                entity.ToTable("email");

                entity.Property(e => e.CdEmail)
                    .HasColumnName("cd_email")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsEmail)
                    .IsRequired()
                    .HasColumnName("ds_email")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.HasKey(e => e.CdEndereco)
                    .HasName("PK__endereco__5652E915EDB98F8D");

                entity.ToTable("endereco");

                entity.Property(e => e.CdEndereco)
                    .HasColumnName("cd_endereco")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCidade).HasColumnName("cd_cidade");

                entity.Property(e => e.CdTipoEndereco).HasColumnName("cd_tipo_endereco");

                entity.Property(e => e.DsComplemento)
                    .HasColumnName("ds_complemento")
                    .HasMaxLength(50);

                entity.Property(e => e.DsEndereco)
                    .HasColumnName("ds_endereco")
                    .HasMaxLength(50);

                entity.Property(e => e.DsGeoLocalizacao)
                    .IsRequired()
                    .HasColumnName("ds_geo_localizacao")
                    .HasMaxLength(20);

                entity.Property(e => e.DsLogradouro)
                    .IsRequired()
                    .HasColumnName("ds_logradouro")
                    .HasMaxLength(20);

                entity.Property(e => e.NrCep)
                    .IsRequired()
                    .HasColumnName("nr_cep")
                    .HasMaxLength(10);

                entity.Property(e => e.NrNumero)
                    .HasColumnName("nr_numero")
                    .HasColumnType("varchar(5)");

                entity.HasOne(d => d.CdCidadeNavigation)
                    .WithMany(p => p.Endereco)
                    .HasForeignKey(d => d.CdCidade)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_endereco_cidade_1");

                entity.HasOne(d => d.CdTipoEnderecoNavigation)
                    .WithMany(p => p.Endereco)
                    .HasForeignKey(d => d.CdTipoEndereco)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_endereco_tipo_endereco_1");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.CdEstado)
                    .HasName("PK__estado__491FBA88DE698957");

                entity.ToTable("estado");

                entity.Property(e => e.CdEstado)
                    .HasColumnName("cd_estado")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdPais).HasColumnName("cd_pais");

                entity.Property(e => e.DsEstado)
                    .HasColumnName("ds_estado")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SgEstado)
                    .HasColumnName("sg_estado")
                    .HasColumnType("varchar(4)");

                entity.HasOne(d => d.CdEstadoNavigation)
                    .WithOne(p => p.InverseCdEstadoNavigation)
                    .HasForeignKey<Estado>(d => d.CdEstado)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_estado_1");

                entity.HasOne(d => d.CdPaisNavigation)
                    .WithMany(p => p.Estado)
                    .HasForeignKey(d => d.CdPais)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_pais");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasKey(e => e.CdGrade)
                    .HasName("PK__grade__F187D7194CCEF37B");

                entity.ToTable("grade");

                entity.Property(e => e.CdGrade)
                    .HasColumnName("cd_grade")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCursoDetalhe).HasColumnName("cd_curso_detalhe");

                entity.Property(e => e.DsGrade)
                    .IsRequired()
                    .HasColumnName("ds_grade")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CdCursoDetalheNavigation)
                    .WithMany(p => p.Grade)
                    .HasForeignKey(d => d.CdCursoDetalhe)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_curso_detalhe");
            });

            modelBuilder.Entity<GradeReserva>(entity =>
            {
                entity.HasKey(e => e.CdGrade)
                    .HasName("PK__grade_re__F187D7191292E621");

                entity.ToTable("grade_reserva");

                entity.Property(e => e.CdGrade)
                    .HasColumnName("cd_grade")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdReserva).HasColumnName("cd_reserva");

                entity.Property(e => e.GradeReserva1).HasColumnName("grade_reserva");

                entity.HasOne(d => d.CdGradeNavigation)
                    .WithOne(p => p.GradeReserva)
                    .HasForeignKey<GradeReserva>(d => d.CdGrade)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_grade_reserva_1");

                entity.HasOne(d => d.CdReservaNavigation)
                    .WithMany(p => p.GradeReserva)
                    .HasForeignKey(d => d.CdReserva)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_grade_reserva_2");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasKey(e => e.CdPais)
                    .HasName("PK__pais__84A7B73171C513F6");

                entity.ToTable("pais");

                entity.Property(e => e.CdPais)
                    .HasColumnName("cd_pais")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsPais)
                    .HasColumnName("ds_pais")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NrPais)
                    .HasColumnName("nr_pais")
                    .HasColumnType("varchar(2)");

                entity.HasOne(d => d.CdPaisNavigation)
                    .WithOne(p => p.InverseCdPaisNavigation)
                    .HasForeignKey<Pais>(d => d.CdPais)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_estado_2");
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.HasKey(e => e.CdReserva)
                    .HasName("PK__reserva__57D059B6108C8B86");

                entity.ToTable("reserva");

                entity.Property(e => e.CdReserva)
                    .HasColumnName("cd_reserva")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtAgenda)
                    .HasColumnName("dt_agenda")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtResernva)
                    .HasColumnName("dt_resernva")
                    .HasColumnType("datetime");

                entity.Property(e => e.HrReservaFin)
                    .HasColumnName("hr_reserva_fin")
                    .HasColumnType("datetime");

                entity.Property(e => e.HrReservaIni)
                    .HasColumnName("hr_reserva_ini")
                    .HasColumnType("datetime");

                entity.Property(e => e.NrReserva)
                    .HasColumnName("nr_reserva")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Telefone>(entity =>
            {
                entity.HasKey(e => e.CdTelefone)
                    .HasName("PK__telefone__85394333DC0BDE74");

                entity.ToTable("telefone");

                entity.Property(e => e.CdTelefone)
                    .HasColumnName("cd_telefone")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdTipoTelefone).HasColumnName("cd_tipo_telefone");

                entity.Property(e => e.NrCodigoArea)
                    .IsRequired()
                    .HasColumnName("nr_codigo_area")
                    .HasMaxLength(20);

                entity.Property(e => e.NrTelefone)
                    .IsRequired()
                    .HasColumnName("nr_telefone")
                    .HasMaxLength(20);

                entity.HasOne(d => d.CdTipoTelefoneNavigation)
                    .WithMany(p => p.Telefone)
                    .HasForeignKey(d => d.CdTipoTelefone)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_tipo_telefone");
            });

            modelBuilder.Entity<TipoAeronave>(entity =>
            {
                entity.HasKey(e => e.CdTipoAeronave)
                    .HasName("PK__tipo_aer__86F4CCD4C40CC11C");

                entity.ToTable("tipo_aeronave");

                entity.Property(e => e.CdTipoAeronave)
                    .HasColumnName("cd_tipo_aeronave")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsTipoAeronave)
                    .IsRequired()
                    .HasColumnName("ds_tipo_aeronave")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoCurso>(entity =>
            {
                entity.HasKey(e => e.CdTipoCurso)
                    .HasName("PK__tipo_cur__BB33CFCB353C16DB");

                entity.ToTable("tipo_curso");

                entity.Property(e => e.CdTipoCurso)
                    .HasColumnName("cd_tipo_curso")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsTipoCurso)
                    .IsRequired()
                    .HasColumnName("ds_tipo_curso")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoDepartamento>(entity =>
            {
                entity.HasKey(e => e.CdTipoDepartamento)
                    .HasName("PK__tipo_dep__828AA31919A37A7B");

                entity.ToTable("tipo_departamento");

                entity.Property(e => e.CdTipoDepartamento)
                    .HasColumnName("cd_tipo_departamento")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsTipoDepartamento)
                    .IsRequired()
                    .HasColumnName("ds_tipo_departamento")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoDisciplina>(entity =>
            {
                entity.HasKey(e => e.CdTipoDisciplina)
                    .HasName("PK__tipo_dis__ED4EEE1E9DE3C1F2");

                entity.ToTable("tipo_disciplina");

                entity.Property(e => e.CdTipoDisciplina)
                    .HasColumnName("cd_tipo_disciplina")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsTipoDisciplina)
                    .IsRequired()
                    .HasColumnName("ds_tipo_disciplina")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.HasKey(e => e.CdTipoDocumento)
                    .HasName("PK__tipo_doc__7D8F7878C8F88749");

                entity.ToTable("tipo_documento");

                entity.Property(e => e.CdTipoDocumento)
                    .HasColumnName("cd_tipo_documento")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsTipoDocumento)
                    .IsRequired()
                    .HasColumnName("ds_tipo_documento")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TipoEndereco>(entity =>
            {
                entity.HasKey(e => e.CdTipoEndereco)
                    .HasName("PK__tipo_end__0989144735DA33F9");

                entity.ToTable("tipo_endereco");

                entity.Property(e => e.CdTipoEndereco)
                    .HasColumnName("cd_tipo_endereco")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsTipoEndereco)
                    .HasColumnName("ds_tipo_endereco")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TipoTelefone>(entity =>
            {
                entity.HasKey(e => e.CdTipoTelefone)
                    .HasName("PK__tipo_tel__6755F87D15607A99");

                entity.ToTable("tipo_telefone");

                entity.Property(e => e.CdTipoTelefone)
                    .HasColumnName("cd_tipo_telefone")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsTipoTelefone)
                    .IsRequired()
                    .HasColumnName("ds_tipo_telefone")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.CdTipoUsuario)
                    .HasName("PK__tipo_usu__32B5D13926CCF568");

                entity.ToTable("tipo_usuario");

                entity.Property(e => e.CdTipoUsuario)
                    .HasColumnName("cd_tipo_usuario")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsTipoUsuario)
                    .IsRequired()
                    .HasColumnName("ds_tipo_usuario")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.CdUsuario)
                    .HasName("PK__usuario__90A0F554209AE420");

                entity.ToTable("usuario");

                entity.Property(e => e.CdUsuario)
                    .HasColumnName("cd_usuario")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCidade).HasColumnName("cd_cidade");

                entity.Property(e => e.CdTipoUsuario).HasColumnName("cd_tipo_usuario");

                entity.Property(e => e.DsEstadoCivil)
                    .HasColumnName("ds_estado_civil")
                    .HasMaxLength(15);

                entity.Property(e => e.DsSenha)
                    .IsRequired()
                    .HasColumnName("ds_senha")
                    .HasMaxLength(50);

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dt_nascimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlAtivo)
                    .IsRequired()
                    .HasColumnName("fl_ativo")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'S'");

                entity.Property(e => e.NmUsuario)
                    .IsRequired()
                    .HasColumnName("nm_usuario")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CdCidadeNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.CdCidade)
                    .HasConstraintName("fk_cd_cidade");

                entity.HasOne(d => d.CdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.CdTipoUsuario)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_tipo_usuario");
            });

            modelBuilder.Entity<UsuarioAgendaReserva>(entity =>
            {
                entity.HasKey(e => new { e.CdUsuario, e.CdAgendaReserva })
                    .HasName("PK__usuario___73DFC32308B14316");

                entity.ToTable("usuario_agenda_reserva");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.Property(e => e.CdAgendaReserva).HasColumnName("cd_agenda_reserva");

                entity.HasOne(d => d.CdAgendaReservaNavigation)
                    .WithMany(p => p.UsuarioAgendaReserva)
                    .HasForeignKey(d => d.CdAgendaReserva)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_usuario_agenda_reserva_2");

                entity.HasOne(d => d.CdUsuarioNavigation)
                    .WithMany(p => p.UsuarioAgendaReserva)
                    .HasForeignKey(d => d.CdUsuario)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_usuario_agenda_reserva_1");
            });

            modelBuilder.Entity<UsuarioArquivo>(entity =>
            {
                entity.HasKey(e => e.CdUsuarioArquivo)
                    .HasName("PK__usuario___5FCBEAF9919CD177");

                entity.ToTable("usuario_arquivo");

                entity.Property(e => e.CdUsuarioArquivo)
                    .HasColumnName("cd_usuario_arquivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdArquivo).HasColumnName("cd_arquivo");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.HasOne(d => d.CdArquivoNavigation)
                    .WithMany(p => p.UsuarioArquivo)
                    .HasForeignKey(d => d.CdArquivo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_usuario_arquivo_2");

                entity.HasOne(d => d.CdUsuarioNavigation)
                    .WithMany(p => p.UsuarioArquivo)
                    .HasForeignKey(d => d.CdUsuario)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_usuario_arquivo_1");
            });

            modelBuilder.Entity<UsuarioDocumento>(entity =>
            {
                entity.HasKey(e => e.CdUsuarioDocumento)
                    .HasName("PK__usuario___3E28D8EAB8D40CF0");

                entity.ToTable("usuario_documento");

                entity.Property(e => e.CdUsuarioDocumento)
                    .HasColumnName("cd_usuario_documento")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdDocumento).HasColumnName("cd_documento");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.HasOne(d => d.CdDocumentoNavigation)
                    .WithMany(p => p.UsuarioDocumento)
                    .HasForeignKey(d => d.CdDocumento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_usuario_documento_2");

                entity.HasOne(d => d.CdUsuarioNavigation)
                    .WithMany(p => p.UsuarioDocumento)
                    .HasForeignKey(d => d.CdUsuario)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_usuario_documento_1");
            });

            modelBuilder.Entity<UsuarioEmail>(entity =>
            {
                entity.HasKey(e => e.CdUsuarioEmail)
                    .HasName("PK__usuario___5594F144EA835534");

                entity.ToTable("usuario_email");

                entity.Property(e => e.CdUsuarioEmail)
                    .HasColumnName("cd_usuario_email")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdEmail).HasColumnName("cd_email");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.HasOne(d => d.CdEmailNavigation)
                    .WithMany(p => p.UsuarioEmail)
                    .HasForeignKey(d => d.CdEmail)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_usuario_email_2");

                entity.HasOne(d => d.CdUsuarioNavigation)
                    .WithMany(p => p.UsuarioEmail)
                    .HasForeignKey(d => d.CdUsuario)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_usuario_email_1");
            });

            modelBuilder.Entity<UsuarioEndereco>(entity =>
            {
                entity.HasKey(e => e.CdUsuarioEndereco)
                    .HasName("PK__usuario___871BAD8CF5C1D5F1");

                entity.ToTable("usuario_endereco");

                entity.Property(e => e.CdUsuarioEndereco)
                    .HasColumnName("cd_usuario_endereco")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdEndereco).HasColumnName("cd_endereco");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.HasOne(d => d.CdEnderecoNavigation)
                    .WithMany(p => p.UsuarioEndereco)
                    .HasForeignKey(d => d.CdEndereco)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_usuario_endereco_2");

                entity.HasOne(d => d.CdUsuarioNavigation)
                    .WithMany(p => p.UsuarioEndereco)
                    .HasForeignKey(d => d.CdUsuario)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_usuario_endereco_1");
            });

            modelBuilder.Entity<UsuarioPagamento>(entity =>
            {
                entity.HasKey(e => e.CdPagamento)
                    .HasName("PK__usuario___AE04938891AF278E");

                entity.ToTable("usuario_pagamento");

                entity.Property(e => e.CdPagamento)
                    .HasColumnName("cd_pagamento")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdPrestacao).HasColumnName("cd_prestacao");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.Property(e => e.DsPagamento)
                    .IsRequired()
                    .HasColumnName("ds_pagamento")
                    .HasMaxLength(50);

                entity.Property(e => e.TxDesconto)
                    .HasColumnName("tx_desconto")
                    .HasColumnType("numeric");

                entity.Property(e => e.TxJuros)
                    .HasColumnName("tx_juros")
                    .HasColumnType("numeric");

                entity.Property(e => e.VlDesconto)
                    .HasColumnName("vl_desconto")
                    .HasColumnType("numeric");

                entity.Property(e => e.VlJuros)
                    .HasColumnName("vl_juros")
                    .HasColumnType("numeric");

                entity.Property(e => e.VlPagamento)
                    .HasColumnName("vl_pagamento")
                    .HasColumnType("numeric");

                entity.HasOne(d => d.CdPrestacaoNavigation)
                    .WithMany(p => p.UsuarioPagamento)
                    .HasForeignKey(d => d.CdPrestacao)
                    .HasConstraintName("fk_usuario_pagamento_2");

                entity.HasOne(d => d.CdUsuarioNavigation)
                    .WithMany(p => p.UsuarioPagamento)
                    .HasForeignKey(d => d.CdUsuario)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_usuario_pagamento_1");
            });

            modelBuilder.Entity<UsuarioPrestacao>(entity =>
            {
                entity.HasKey(e => e.CdPrestacao)
                    .HasName("PK__usuario___B43C014F2699E55C");

                entity.ToTable("usuario_prestacao");

                entity.Property(e => e.CdPrestacao)
                    .HasColumnName("cd_prestacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCursoDetalhe).HasColumnName("cd_curso_detalhe");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.Property(e => e.DsPrestacao)
                    .IsRequired()
                    .HasColumnName("ds_prestacao")
                    .HasMaxLength(50);

                entity.Property(e => e.VlPrestacao)
                    .HasColumnName("vl_prestacao")
                    .HasColumnType("numeric");

                entity.HasOne(d => d.CdCursoDetalheNavigation)
                    .WithMany(p => p.UsuarioPrestacao)
                    .HasForeignKey(d => d.CdCursoDetalhe)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_usuario_prestacao_2");

                entity.HasOne(d => d.CdUsuarioNavigation)
                    .WithMany(p => p.UsuarioPrestacao)
                    .HasForeignKey(d => d.CdUsuario)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_usuario_prestacao_1");
            });

            modelBuilder.Entity<UsuarioRecebimento>(entity =>
            {
                entity.HasKey(e => e.CdRecebimento)
                    .HasName("PK__usuario___5B6C8AE7F3C7A0A1");

                entity.ToTable("usuario_recebimento");

                entity.Property(e => e.CdRecebimento)
                    .HasColumnName("cd_recebimento")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdPrestacao).HasColumnName("cd_prestacao");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.Property(e => e.DsRecebimento)
                    .IsRequired()
                    .HasColumnName("ds_recebimento")
                    .HasMaxLength(50);

                entity.Property(e => e.TxDesconto)
                    .HasColumnName("tx_desconto")
                    .HasColumnType("numeric");

                entity.Property(e => e.TxJuros)
                    .HasColumnName("tx_juros")
                    .HasColumnType("numeric");

                entity.Property(e => e.VlDesconto)
                    .HasColumnName("vl_desconto")
                    .HasColumnType("numeric");

                entity.Property(e => e.VlJuros)
                    .HasColumnName("vl_juros")
                    .HasColumnType("numeric");

                entity.Property(e => e.VlRecebimento)
                    .HasColumnName("vl_recebimento")
                    .HasColumnType("numeric");

                entity.HasOne(d => d.CdPrestacaoNavigation)
                    .WithMany(p => p.UsuarioRecebimento)
                    .HasForeignKey(d => d.CdPrestacao)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_usuario_recebimento_2");

                entity.HasOne(d => d.CdUsuarioNavigation)
                    .WithMany(p => p.UsuarioRecebimento)
                    .HasForeignKey(d => d.CdUsuario)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_usuario_recebimento_1");
            });

            modelBuilder.Entity<UsuarioTelefone>(entity =>
            {
                entity.HasKey(e => e.CdUsuarioTelefone)
                    .HasName("PK__usuario___9EB9706FD60ECB9B");

                entity.ToTable("usuario_telefone");

                entity.Property(e => e.CdUsuarioTelefone)
                    .HasColumnName("cd_usuario_telefone")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdTelefone).HasColumnName("cd_telefone");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.HasOne(d => d.CdTelefoneNavigation)
                    .WithMany(p => p.UsuarioTelefone)
                    .HasForeignKey(d => d.CdTelefone)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_usuario_telefone_2");

                entity.HasOne(d => d.CdUsuarioNavigation)
                    .WithMany(p => p.UsuarioTelefone)
                    .HasForeignKey(d => d.CdUsuario)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_usuario_telefone_1");
            });
        }
    }
}