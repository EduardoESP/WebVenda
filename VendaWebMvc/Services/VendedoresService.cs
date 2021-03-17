using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaWebMvc.Data;
using VendaWebMvc.Models;

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

        public List<Vendedor> ListarVendedores()
        {
            return _contexto.Vendedor.ToList();
        }

        public void Inserir(Vendedor obj)
        {
            _contexto.Add(obj);
            _contexto.SaveChanges();

        }
    }
}
