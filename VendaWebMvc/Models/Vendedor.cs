using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime Nascimento { get; set; }

        public double SalarioBase { get; set; }

        public Departamento Departamento { get; set; }

        public int DepartamentoId { get; set; }

        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>();

        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, DateTime nascimento, double salarioBase)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Nascimento = nascimento;
            SalarioBase = salarioBase;
        }

        public void AddVenda(RegistroVendas registro)
        {
            Vendas.Add(registro);

        }

        public void RemoverVenda(RegistroVendas registro)
        {
            Vendas.Remove(registro);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Vendas.Where(registro => registro.Data >= inicial && registro.Data <= final).Sum(registro => registro.Valor);
        }

    }
}
