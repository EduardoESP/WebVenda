using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaWebMvc.Data;
using VendaWebMvc.Models;
using VendaWebMvc.Services.Exceptions;

namespace VendaWebMvc.Services
{
    public class VendedoresService
    {
        //dependencia com o banco
        private readonly VendaWebMvcContext _contexto; 

        public VendedoresService(VendaWebMvcContext contexto)
        {
            _contexto = contexto;

        }

        public async Task<List<Vendedor>> ListarVendedoresAsync()
        {
            return await _contexto.Vendedor.ToListAsync();
        }

        public async Task InserirAsync(Vendedor obj)
        {
            _contexto.Add(obj);
           await _contexto.SaveChangesAsync();

        }

        public async Task<Vendedor> EncontrarPorIdAsync(int id)
        {
            return await _contexto.Vendedor.Include(obj => obj.Departamento).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoverAsync(int id)
        {
            try
            {
                var obj = await _contexto.Vendedor.FindAsync(id);
                _contexto.Vendedor.Remove(obj);
                await _contexto.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegridadeExcecao("Este Vendedor tem venda registrada e não pode ser deletado.");
            }
        }

        public async Task UpdateAsync(Vendedor obj)
        {
            bool hasAny = await _contexto.Vendedor.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id não encontrado");
            }
            try
            {
                _contexto.Update(obj);
                await _contexto.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbUpdateConcurrencyException(e.Message);
            }
        }
    }
}
