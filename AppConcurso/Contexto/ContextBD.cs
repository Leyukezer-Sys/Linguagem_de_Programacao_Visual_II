using AppConcurso_v2.Models;
using Microsoft.EntityFrameworkCore;

namespace AppConcurso_v2.Contexto
{
    public class ContextBD : DbContext
    {
        public ContextBD(DbContextOptions<ContextBD> options) : base(options) { }

        public DbSet<Candidato> Candidatos { get; set; }

        public DbSet<Cargo> Cargos { get; set; }

        public DbSet<Inscricao> Inscricoes { get; set; }
    }
}
