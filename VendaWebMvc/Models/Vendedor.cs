using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VendaWebMvc.Models
{
    public class Vendedor
    {   [Key()]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} deve ter entre 3 e 60 caracteres")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "Entre com um e-mail válido")]
        [Required(ErrorMessage = "{0} obrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Salário Base")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        [Range(1045.0, 50000.0, ErrorMessage = "{0} deve ser entre {1} to {2}")]
        public double SalarioBase { get; set; }

        [ForeignKey("Departamento")]
        public int DepartamentoId { get; set; }
        public virtual Departamento Departamento { get; set; }

       
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
