using AULA_25_05_2023_API_CODE_FIRST.Models;
using Microsoft.EntityFrameworkCore;

namespace AULA_25_05_2023_API_CODE_FIRST.Contexts
{
    public class ContextoBD:DbContext
    {
        public ContextoBD(DbContextOptions<ContextoBD> options)
        : base(options)
        {
        }

        public DbSet<Atividade> Atividades { get; set; }
        public DbSet<Treino> Treinos { get; set; }
    }
}
