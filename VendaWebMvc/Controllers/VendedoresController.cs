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


        public async Task<IActionResult> Index()
        {
            var list = await _servicoVendedor.ListarVendedoresAsync();
            return View(list);
        }

        //*****************************************************************************************************
        public async Task<IActionResult> Criar()
         {
            
            var departamentos = await _departamentoService.ListarDepartamentoAsync();
            var viewModel = new FormularioVendedorViewModel { Departamento = departamentos };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(Vendedor vendedor)
        {
            if (!ModelState.IsValid)
            {
                var departamento = await _departamentoService.ListarDepartamentoAsync();
                var viewModel = new FormularioVendedorViewModel { Vendedor = vendedor, Departamento = departamento };
                return View(viewModel);
            }
             await _servicoVendedor.InserirAsync(vendedor);
            return RedirectToAction("Index");

        }
        //*****************************************************************************************************
        public async Task<IActionResult> Deletar(int? id)
        {
            if(id == null)
            {
                return RedirectToAction(nameof(Error), new {mensagem = "ID NÃO FORNECIDO" });
            }

            var obj = await _servicoVendedor.EncontrarPorIdAsync(id.Value);
            if(obj == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "ID NÃO ENCONTRADO" });
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletar(int id)
        {
            try
            {
                await _servicoVendedor.RemoverAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegridadeExcecao e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }

        }

        public async Task<IActionResult> Detalhe(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "ID NÃO FORNECIDO" });
            }

            var obj = await _servicoVendedor.EncontrarPorIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "ID NÃO ENCONTRADO" });
            }

            return View(obj);
        }

        public async Task<IActionResult> Editar(int? id)
        {
            if(id == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "ID NÃO FORNECIDO" });
            }

            var obj = await _servicoVendedor.EncontrarPorIdAsync(id.Value);
            if(obj == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "ID NÃO ENCONTRADO" });
            }

            List<Departamento> departamento = await _departamentoService.ListarDepartamentoAsync();
            FormularioVendedorViewModel viewModel = new FormularioVendedorViewModel { Vendedor = obj, Departamento = departamento };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, Vendedor vendedor)
        {
            if (!ModelState.IsValid)
            {
                var departamento = await _departamentoService.ListarDepartamentoAsync();
                var viewModel = new FormularioVendedorViewModel { Vendedor = vendedor, Departamento = departamento };
                return View(viewModel);
            }
            if (id != vendedor.Id)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "ID NÃO CORRESPONDE" });
            }

            try
            {
                await _servicoVendedor.UpdateAsync(vendedor);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException e)
            {
                return RedirectToAction(nameof(Error), new { mensagem = e.Message });
            }
            catch (DbConcurrencyException e)
            {
                return RedirectToAction(nameof(Error), new { mensagem = e.Message });
            }
        }

        public IActionResult Error(string mensagem)
        {
            var viewModel = new ErrorViewModel
            {
                Message = mensagem,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}
