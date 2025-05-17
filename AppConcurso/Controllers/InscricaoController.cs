using AppConcurso.Contexto;
using AppConcurso.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppConcurso.Controllers
{
    public class InscricaoController : Controller
    {
        private readonly ContextBD _context;

        public InscricaoController(ContextBD context)
        {
            _context = context;
        }
        public async Task<List<Inscricao>> ListaInscricoes()
        {
            var inscricoes = await _context.Inscricoes.Include(x => x.Cargo).Include(x => x.Candidato).ToListAsync();
            return inscricoes;
        }
        public async Task Add(Inscricao inscricao)
        {
            await _context.Inscricoes.AddAsync(inscricao);
        }
        public void Update(Inscricao inscricao)
        {
            _context.Inscricoes.Update(inscricao);
        }

        public async Task SalvarInscricao()
        {
            await _context.SaveChangesAsync(); 
        }

    }
}
