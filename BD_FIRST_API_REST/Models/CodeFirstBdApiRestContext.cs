using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BD_FIRST_API_REST.Models;

public partial class CodeFirstBdApiRestContext : DbContext
{
    public CodeFirstBdApiRestContext()
    {
    }

    public CodeFirstBdApiRestContext(DbContextOptions<CodeFirstBdApiRestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<Disciplina> Disciplinas { get; set; }

    public virtual DbSet<Professor> Professors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-ANVV0SF\\SQLEXPRESS;Database=CODE_FIRST_BD_API_REST;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Curso>(entity =>
        {
            entity.ToTable("Curso");

            entity.HasIndex(e => e.DisciplinaId, "IX_Curso_DisciplinaId");

            entity.HasIndex(e => e.ProfessorId, "IX_Curso_ProfessorId");

            entity.HasOne(d => d.Disciplina).WithMany(p => p.Cursos).HasForeignKey(d => d.DisciplinaId);

            //entity.HasOne(d => d.Professor).WithMany(p => p.Cursos).HasForeignKey(d => d.ProfessorId);
        });

        modelBuilder.Entity<Disciplina>(entity =>
        {
            entity.ToTable("Disciplina");
        });

        modelBuilder.Entity<Professor>(entity =>
        {
            entity.ToTable("Professor");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
