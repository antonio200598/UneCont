using Microsoft.EntityFrameworkCore;
using UneContAPI.Models;

namespace UneContAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Models.NotaFiscal> NotaFiscal { get; set; }

    public DbSet<Models.Prestador> Prestador { get; set; }

    public DbSet<Models.Tomador> Tomador { get; set; }

    public DbSet<Models.Servico> Servico { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<NotaFiscal>().ToTable("NotaFiscal");
      modelBuilder.Entity<Prestador>().ToTable("NotaFiscal_Prestador");
      modelBuilder.Entity<Tomador>().ToTable("NotaFiscal_Tomador");
      modelBuilder.Entity<Servico>().ToTable("NotaFiscal_Servico");

      modelBuilder.Entity<NotaFiscal>()
          .HasOne(n => n.Prestador)
          .WithMany()
          .HasForeignKey(n => n.PrestadorId)
          .HasConstraintName("FK_Prestador");

      modelBuilder.Entity<NotaFiscal>()
          .HasOne(n => n.Tomador)
          .WithMany()
          .HasForeignKey(n => n.TomadorId)
          .HasConstraintName("FK_Tomador");

      modelBuilder.Entity<NotaFiscal>()
          .HasOne(n => n.Servico)
          .WithMany()
          .HasForeignKey(n => n.ServicoId)
          .HasConstraintName("FK_Servico");
    }
}
