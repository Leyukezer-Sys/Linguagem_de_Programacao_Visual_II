using AppConcurso_v2.Contexto;
using AppConcurso_v2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppConcurso_v2.Controllers
{
    public class CandidatoController : Controller
    {
        private readonly ContextBD _context;

        public CandidatoController(ContextBD context)
        {
            _context = context;
        }

        public async Task<List<Candidato>> ListaCandidato()
        {
            var candidatos = await _context.Candidatos.Include(x => x.Inscricoes).ToListAsync();
            return candidatos;

        }
        public async Task Add(Candidato candidato)
        {
            await _context.Candidatos.AddAsync(candidato);
        }

        public async Task SalvarCandidato()
        {
            await _context.SaveChangesAsync();
        }
    }
}
