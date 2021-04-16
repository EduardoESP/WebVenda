using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaWebMvc.Data;
using VendaWebMvc.Models;
using Microsoft.EntityFrameworkCore;
using VendaWebMvc.Services.Exceptions;

namespace VendaWebMvc.Services
{
    public class RegistroVendasService
    {
        private readonly VendaWebMvcContext _contexto;

        public RegistroVendasService(VendaWebMvcContext contexto)
        {
            _contexto = contexto;
        }

        //Busca simples de vendas
        public async Task<List<RegistroVendas>> ListarPorDataAsync( DateTime? minDate, DateTime? maxDate)
        {
            var resultado = from obj in _contexto.RegistroVendas select obj;

            if (minDate.HasValue)
            {
                resultado = resultado.Where(x => x.Data >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                resultado = resultado.Where(x => x.Data <= maxDate.Value);
            }

            return await resultado
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.Data)
                .ToListAsync();
        }

        //Busca agrupada por setor
        public async Task<List<IGrouping<Departamento, RegistroVendas>>> ListarPorDataAgrupadaSetorAsync(DateTime? minDate, DateTime? maxDate)
        {
            var resultado = from obj in _contexto.RegistroVendas select obj;

            if (minDate.HasValue)
            {
                resultado = resultado.Where(x => x.Data >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                resultado = resultado.Where(x => x.Data <= maxDate.Value);
            }

            return await resultado
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.Data)
                .GroupBy(x => x.Vendedor.Departamento)
                .ToListAsync();
        }

        //Daqui em diante CRUD

        public async Task InserirAsync(RegistroVendas obj)
        {
            _contexto.Add(obj);
            await _contexto.SaveChangesAsync();

        }


        public async Task<List<RegistroVendas>> ListarRegistroVendasAsync()
        {
            return await _contexto.RegistroVendas.ToListAsync();
        }


        public async Task<RegistroVendas> EncontrarPorIdAsync(int id)
        {
            return await _contexto.RegistroVendas.Include(obj => obj.Vendedor).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoverAsync(int id)
        {
            try
            {
                var obj = await _contexto.RegistroVendas.FindAsync(id);
                _contexto.RegistroVendas.Remove(obj);
                await _contexto.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegridadeExcecao("Venda Não pode ser deletada.");
            }
        }

        public async Task UpdateAsync(RegistroVendas obj)
        {
            bool hasAny = await _contexto.RegistroVendas.AnyAsync(x => x.Id == obj.Id);
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
