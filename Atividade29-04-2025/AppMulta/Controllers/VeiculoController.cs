﻿using AppMulta.Context;
using AppMulta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppMulta.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly ContextBD _context;

        public VeiculoController(ContextBD context)
        {
            _context = context;
        }

        public async Task<List<Veiculo>> ListaDeVeiculos()
        {
            var veiculos = await _context.Veiculos.Include(x => x.Multas).ToListAsync();
            return veiculos;
        }

        public async Task<Veiculo> GetVeiculo(string placa)
        {
            var veiculo = await _context.Veiculos.Include(m => m.Multas).Where(v => v.Placa == placa).FirstOrDefaultAsync();
            return veiculo;
        }

        //Método para cadastrar veículos
        public async Task Add(Veiculo veiculo)
        {
            await _context.Veiculos.AddAsync(veiculo);
        }

        public async Task Salvar()
        {
            await _context.SaveChangesAsync();
        }
    }
}
