using AppMulta.Models;
using Microsoft.EntityFrameworkCore;

namespace AppMulta.Context
{
    public class ContextBD : DbContext
    {
        public ContextBD(DbContextOptions<ContextBD> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }

        public DbSet<Multa> Multas { get; set; }
    }
}
