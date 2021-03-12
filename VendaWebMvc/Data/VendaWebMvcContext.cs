using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VendaWebMvc.Models;

namespace VendaWebMvc.Data
{
    public class VendaWebMvcContext : DbContext
    {
        public VendaWebMvcContext (DbContextOptions<VendaWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<RegistroVendas> RegistroVendas { get; set; }

      

    }
}
