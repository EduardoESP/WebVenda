using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaWebMvc.Models.Enums;

namespace VendaWebMvc.Models.ViewModel
{
    public class FormularioRegistroVendasViewModel
    {
        public RegistroVendas RegistroVendas { get; set; }

        public ICollection<Vendedor> Vendedores { get; set; }

      //  public ICollection<StatusVenda> Status { get; set; }
    }
}
