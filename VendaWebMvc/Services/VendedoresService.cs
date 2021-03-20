using Microsoft.EntityFrameworkCore;
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

        public Vendedor EncontrarPorId(int id)
        {
            return _contexto.Vendedor.Include(obj => obj.Departamento).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remover(int id)
        {
            var obj = _contexto.Vendedor.Find(id);
            _contexto.Vendedor.Remove(obj);
            _contexto.SaveChanges();
        }
    }
}
