using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConsuminAPIDoNetMVCBootstrap.Models;
using ConsuminAPIDoNetMVCBootstrap.Services;

namespace ConsuminAPIDoNetMVCBootstrap.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

         public IActionResult MegaSena()
        {
            //  DataResponse teste = new ServiceDataResponse().GetDataResponse("https://lotericas.io/api/v1/jogos/megasena/lasted");           
            //  Console.WriteLine("teste");
            //  Console.WriteLine(teste.Data[0].NumeroJogo);
            //  Console.WriteLine(teste.Data[0].Observacao);
            //  Console.WriteLine(teste.Data[0].TipoPublicacao);
            //  Console.WriteLine(teste.Data[0].ValorAcumuladoConcursoEspecial);
            return View();
        }
        public IActionResult Diadesorte()
        {
            return View();
        }
        public IActionResult Duplasena()
        {
            return View();
        }
        public IActionResult Federal()
        {
            return View();
        }
        public IActionResult Loteca()
        {
            return View();
        }
        public IActionResult LotoFacil()
        {
            return View();
        }

        
        public IActionResult Lotomania()
        {
            return View();
        }
        public IActionResult Quina()
        {
            return View();
        }
        public IActionResult Timemania()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
