using AppConcurso.Contexto;
using AppConcurso.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppConcurso.Controllers
{
    public class CargoController : Controller
    {
        private readonly ContextBD _context;
        public CargoController(ContextBD context)
        {
            _context = context;
        }

        public async Task<List<Cargo>> ListaCargo()
        {
            var cargo = await _context.Cargos.Include(x => x.Inscricoes).ToListAsync();
            return cargo;
        }

        public async Task Add(Cargo cargo)
        {
            await _context.Cargos.AddAsync(cargo);
        }

        public async Task Salvar()
        {
            await _context.SaveChangesAsync();
        }

    }
}
