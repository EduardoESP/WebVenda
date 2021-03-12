using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaWebMvc.Models.Enums;

namespace VendaWebMvc.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }

        public StatusVenda Status { get; set; }

        public RegistroVendas()
        {

        }

        public RegistroVendas(int id, DateTime data, double valor, StatusVenda status)
        {
            Id = id;
            Data = data;
            Valor = valor;
            Status = status;
        }
    }
}
