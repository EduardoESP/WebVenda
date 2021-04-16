using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using VendaWebMvc.Models.Enums;

namespace VendaWebMvc.Models
{
    public class RegistroVendas
    {   [Key()]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Valor { get; set; }

   
       //public StatusVenda Status { get; set; }

       [ForeignKey("Vendedor")]
        public int VendedorId { get; set; }
        
        public virtual  Vendedor Vendedor { get; set; } 

        

        public RegistroVendas()
        {

        }

        public RegistroVendas(int id, DateTime data, double valor)
        {
            Id = id;
            Data = data;
            Valor = valor;
            
            

        }
    }
}
