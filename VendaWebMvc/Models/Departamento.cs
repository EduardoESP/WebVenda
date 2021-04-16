using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VendaWebMvc.Models
{
    public class Departamento
    {   [Key()]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public string Nome{ get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {

        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Vendedores.Sum(vendedor => vendedor.TotalVendas(inicial, final));
        }
    }
    
}
