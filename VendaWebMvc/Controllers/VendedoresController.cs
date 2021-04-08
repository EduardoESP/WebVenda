using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VendaWebMvc.Models;
using VendaWebMvc.Models.ViewModel;
using VendaWebMvc.Services;
using VendaWebMvc.Services.Exceptions;

namespace VendaWebMvc.Controllers
{
    public class VendedoresController : Controller
    {
        //Dependencias dos serviços
        private readonly VendedoresService _servicoVendedor;

        private readonly DepartamentoService _departamentoService;

        public VendedoresController(VendedoresService servicoVendedor, DepartamentoService departamentoService)
        {
            _servicoVendedor = servicoVendedor;
            _departamentoService = departamentoService;

        }


        public IActionResult Index()
        {
            var list = _servicoVendedor.ListarVendedores();
            return View(list);
        }

        public IActionResult Criar()
         {
            
            var departamentos = _departamentoService.ListarDepartamento();
            var viewModel = new FormularioVendedorViewModel { Departamento = departamentos };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Vendedor vendedor)
        {
            if (!ModelState.IsValid)
            {
                var departamento = _departamentoService.ListarDepartamento();
                var viewModel = new FormularioVendedorViewModel { Vendedor = vendedor, Departamento = departamento };
                return View(viewModel);
            }
            _servicoVendedor.Inserir(vendedor);
            return RedirectToAction("Index");

        }

        public IActionResult Deletar(int? id)
        {
            if(id == null)
            {
                return RedirectToAction(nameof(Erro), new {mensagem = "ID NÃO FORNECIDO" });
            }

            var obj = _servicoVendedor.EncontrarPorId(id.Value);
            if(obj == null)
            {
                return RedirectToAction(nameof(Erro), new { mensagem = "ID NÃO ENCONTRADO" });
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Deletar(int id)
        {
            _servicoVendedor.Remover(id);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Detalhe(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Erro), new { mensagem = "ID NÃO FORNECIDO" });
            }

            var obj = _servicoVendedor.EncontrarPorId(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Erro), new { mensagem = "ID NÃO ENCONTRADO" });
            }

            return View(obj);
        }

        public IActionResult Editar(int? id)
        {
            if(id == null)
            {
                return RedirectToAction(nameof(Erro), new { mensagem = "ID NÃO FORNECIDO" });
            }

            var obj = _servicoVendedor.EncontrarPorId(id.Value);
            if(obj == null)
            {
                return RedirectToAction(nameof(Erro), new { mensagem = "ID NÃO ENCONTRADO" });
            }

            List<Departamento> departamento = _departamentoService.ListarDepartamento();
            FormularioVendedorViewModel viewModel = new FormularioVendedorViewModel { Vendedor = obj, Departamento = departamento };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(int id, Vendedor vendedor)
        {
            if (!ModelState.IsValid)
            {
                var departamento = _departamentoService.ListarDepartamento();
                var viewModel = new FormularioVendedorViewModel { Vendedor = vendedor, Departamento = departamento };
                return View(viewModel);
            }
            if (id != vendedor.Id)
            {
                return RedirectToAction(nameof(Erro), new { mensagem = "ID NÃO CORRESPONDE" });
            }

            try
            {
                _servicoVendedor.Update(vendedor);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException e)
            {
                return RedirectToAction(nameof(Erro), new { mensagem = e.Message });
            }
            catch (DbConcurrencyException e)
            {
                return RedirectToAction(nameof(Erro), new { mensagem = e.Message });
            }
        }

        public IActionResult Erro(string mensagem)
        {
            var viewModel = new ErrorViewModel
            {
                Mensagem = mensagem,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}
