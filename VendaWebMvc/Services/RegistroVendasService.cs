using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaWebMvc.Data;
using VendaWebMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace VendaWebMvc.Services
{
    public class RegistroVendasService
    {
        private readonly VendaWebMvcContext _contexto;

        public RegistroVendasService(VendaWebMvcContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<List<RegistroVendas>> ListarPorDataAsync( DateTime? minDate, DateTime? maxDate)
        {
            var resultado = from obj in _contexto.RegistroVendas select obj;

            if (minDate.HasValue)
            {
                resultado = resultado.Where(x => x.Data >= minDate.Value);
            }

            if (minDate.HasValue)
            {
                resultado = resultado.Where(x => x.Data <= maxDate.Value);
            }

            return await resultado
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.Data)
                .ToListAsync();
        }
    }
}
