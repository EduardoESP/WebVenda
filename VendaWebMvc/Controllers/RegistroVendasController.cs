using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaWebMvc.Services;

namespace VendaWebMvc.Controllers
{
    public class RegistroVendasController : Controller
    {
        private readonly RegistroVendasService _registroVendasService;

        public RegistroVendasController(RegistroVendasService registroVendasService)
        {
            _registroVendasService = registroVendasService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BuscaSimples(DateTime? minDate, DateTime? maxDate)
        {
            //Testa se tem valor na caixa de entrada da data, se não tiver passa o primeiro dia do ano vigente
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }

            //Testa se tem valor na caixa de entrada da data, se não tiver passa o dia atual
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;

            }

            //Passa os valores para as  caixas 

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var resultado = await _registroVendasService.ListarPorDataAsync(minDate, maxDate);
            return View(resultado);
        }

        public IActionResult BuscaGrupo()
        {
            return View();
        }
    }
}
