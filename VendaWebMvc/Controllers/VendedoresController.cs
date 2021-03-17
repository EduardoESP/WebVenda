using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaWebMvc.Models;
using VendaWebMvc.Services;

namespace VendaWebMvc.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedoresService _servicoVendedor;

        public VendedoresController(VendedoresService servicoVendedor)
        {
            _servicoVendedor = servicoVendedor;

        }


        public IActionResult Index()
        {
            var list = _servicoVendedor.ListarVendedores();
            return View(list);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Vendedor vendedor)
        {
            _servicoVendedor.Inserir(vendedor);
            return RedirectToAction("Index");

        }

    }
}
