using Microsoft.EntityFrameworkCore;
using AgendamentoMedico.Modelos;
using System;

namespace AgendamentoMedico.Dados
{
    public class ContextoClinica : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=clinica.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar entidade Paciente
            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.NomeCompleto).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Telefone).HasMaxLength(20);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.DataNascimento).IsRequired();
                entity.Property(e => e.CriadoEm).HasDefaultValueSql("datetime('now')");
            });

            // Configurar entidade Medico
            modelBuilder.Entity<Medico>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.NomeCompleto).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Especialidade).IsRequired().HasMaxLength(100);
                entity.Property(e => e.CRM).IsRequired().HasMaxLength(20);
                entity.Property(e => e.Telefone).HasMaxLength(20);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.CriadoEm).HasDefaultValueSql("datetime('now')");
                
                // Restrição única no CRM
                entity.HasIndex(e => e.CRM).IsUnique();
            });

            // Configurar entidade Agendamento
            modelBuilder.Entity<Agendamento>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.DataHoraAgendamento).IsRequired();
                entity.Property(e => e.Status).IsRequired().HasMaxLength(20).HasDefaultValue("Agendado");
                entity.Property(e => e.Observacoes).HasMaxLength(500);
                entity.Property(e => e.CriadoEm).HasDefaultValueSql("datetime('now')");

                // Configurar relacionamentos
                entity.HasOne(e => e.Paciente)
                    .WithMany(p => p.Agendamentos)
                    .HasForeignKey(e => e.PacienteId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Medico)
                    .WithMany(d => d.Agendamentos)
                    .HasForeignKey(e => e.MedicoId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}