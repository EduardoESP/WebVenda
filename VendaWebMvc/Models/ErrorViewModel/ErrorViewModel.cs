using System;

namespace VendaWebMvc.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public string Mensagem { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
