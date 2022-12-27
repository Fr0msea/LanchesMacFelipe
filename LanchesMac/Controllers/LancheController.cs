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

        public IActionResult List()
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
            var lancheListViewModel = new LancheListViewModel();
            lancheListViewModel.Lanches = _lancheRepository.Lanches;
            lancheListViewModel.CategoriaAtual = "Categoria Atual";

            return View(lancheListViewModel);

        }
    }
}
