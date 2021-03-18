
using System.Collections.Generic;


namespace VendaWebMvc.Models.ViewModel
{
    public class FormularioVendedorViewModel
    {
        public Vendedor Vendedor { get; set; }

        public ICollection<Departamento> Departamento { get; set; }

    }
}
