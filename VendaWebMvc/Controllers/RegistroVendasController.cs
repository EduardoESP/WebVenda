using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaWebMvc.Models;
using VendaWebMvc.Models.ViewModel;
using VendaWebMvc.Services;
using VendaWebMvc.Services.Exceptions;
using System.Diagnostics;

namespace VendaWebMvc.Controllers
{
    public class RegistroVendasController : Controller
    {
        private readonly RegistroVendasService _registroVendasService;

        private readonly VendedoresService _vendedoresService;

        public RegistroVendasController(RegistroVendasService registroVendasService, VendedoresService vendedoresService)
        {
            _registroVendasService = registroVendasService;
            _vendedoresService = vendedoresService;
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

        //Busca de Grupo por Setor
        public async Task<IActionResult> BuscaGrupo(DateTime? minDate, DateTime? maxDate)
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

            var resultado = await _registroVendasService.ListarPorDataAgrupadaSetorAsync(minDate, maxDate);
            return View(resultado);
        }

        //Daqui em diante CRUD************************************************************************************************************

        public async Task<IActionResult> Criar()
        {
           var vendedores = await _vendedoresService.ListarVendedoresAsync();
           var viewModel = new FormularioRegistroVendasViewModel {Vendedores = vendedores};
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(RegistroVendas vendas)
        {
            if (!ModelState.IsValid)
            {
                var vendedores = await _vendedoresService.ListarVendedoresAsync();

                var viewModel = new FormularioRegistroVendasViewModel {RegistroVendas = vendas, Vendedores = vendedores };
                return View(viewModel);
            }
            await _registroVendasService.InserirAsync(vendas);
            return RedirectToAction("Index");

        }

        //***********************************************************************************************************************************************************

        public async Task<IActionResult> Deletar(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "ID NÃO FORNECIDO" });
            }

            var obj = await _registroVendasService.EncontrarPorIdAsync(id.Value);
            if (obj == null)
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
                await _registroVendasService.RemoverAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegridadeExcecao e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }

        }

        //**********************************************************************************************************
        public async Task<IActionResult> Detalhe(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "ID NÃO FORNECIDO" });
            }

            var obj = await _registroVendasService.EncontrarPorIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "ID NÃO ENCONTRADO" });
            }

            return View(obj);
        }
        //**********************************************************************************************************
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "ID NÃO FORNECIDO" });
            }

            var obj = await _registroVendasService.EncontrarPorIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "ID NÃO ENCONTRADO" });
            }

            List<Vendedor> vendedores = await _vendedoresService.ListarVendedoresAsync();
            FormularioRegistroVendasViewModel viewModel = new FormularioRegistroVendasViewModel { RegistroVendas = obj, Vendedores = vendedores };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, RegistroVendas venda)
        {
            if (!ModelState.IsValid)
            {
                var vendedor = await _vendedoresService.ListarVendedoresAsync();
                var viewModel = new FormularioRegistroVendasViewModel { RegistroVendas = venda, Vendedores = vendedor };
                return View(viewModel);
            }
            if (id != venda.Id)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "ID NÃO CORRESPONDE" });
            }

            try
            {
                await _registroVendasService.UpdateAsync(venda);
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

        //**********************************************************************************************************
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
