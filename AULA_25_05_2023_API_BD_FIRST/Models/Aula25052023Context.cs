using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AULA_25_05_2023_API_BD_FIRST.Models;

public partial class Aula25052023Context : DbContext
{
    public Aula25052023Context()
    {
    }

    public Aula25052023Context(DbContextOptions<Aula25052023Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Atividade> Atividades { get; set; }

    public virtual DbSet<Treino> Treinos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-ANVV0SF\\SQLEXPRESS;Database=AULA_25_05_2023;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Atividade>(entity =>
        {
            entity.ToTable("Atividade");

            entity.HasIndex(e => e.TreinoId, "IX_Atividade_TreinoId");

            entity.HasOne(d => d.Treino).WithMany(p => p.Atividades).HasForeignKey(d => d.TreinoId);
        });

        modelBuilder.Entity<Treino>(entity =>
        {
            entity.ToTable("Treino");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
