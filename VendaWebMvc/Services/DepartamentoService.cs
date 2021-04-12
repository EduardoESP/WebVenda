using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaWebMvc.Data;
using VendaWebMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace VendaWebMvc.Services
{
    public class DepartamentoService
    {
        private readonly VendaWebMvcContext _contexto;

        public DepartamentoService(VendaWebMvcContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<List<Departamento>> ListarDepartamentoAsync()
        {
           return await _contexto.Departamento.OrderBy(x => x.Nome).ToListAsync();
        }

    }
}
