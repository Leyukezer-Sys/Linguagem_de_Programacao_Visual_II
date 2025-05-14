using AppConcurso.Models;
using Microsoft.EntityFrameworkCore;

namespace AppConcurso.Contexto
{
    public class ContextBD : DbContext
    {
        public ContextBD(DbContextOptions<ContextBD> options) : base (options) { }

        public DbSet<Candidato> Candidatos { get; set; }

        public DbSet<Cargo> Cargos { get; set; }

        public DbSet<Inscricao> Inscricoes { get; set; }
    }
}
