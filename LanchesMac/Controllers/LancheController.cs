using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List(string categoria)
        {
            //Antes da ViewModel

            ////ViewData["Titulo"] = "Todos os Lanches";
            ////ViewData["Data"] = DateTime.Now;
            //var lanches = _lancheRepository.Lanches;
            //var totalLanches = lanches.Count();
            ////ViewBag.Total = "Total de lanches:";
            ////ViewBag.TotalLanches = totalLanches;

            //return View(lanches);

            //Depois da viewModel
            //var lancheListViewModel = new LancheListViewModel();
            //lancheListViewModel.Lanches = _lancheRepository.Lanches;
            //lancheListViewModel.CategoriaAtual = "Categoria Atual";

            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(x => x.LancheId);
                categoriaAtual = "Todos os Lanches";
            }
            else
            {
                lanches = _lancheRepository.Lanches
                .Where(x => x.Categoria.Nome.Equals(categoria))
                .OrderBy(x => x.Nome);

                categoriaAtual = categoria;
            }

            var lancheListViewModel = new LancheListViewModel
            {
                CategoriaAtual = categoriaAtual,
                Lanches = lanches
            };

            return View(lancheListViewModel);

        }
    }
}
