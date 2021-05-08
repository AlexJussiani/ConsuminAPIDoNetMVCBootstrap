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
            DataResponse teste = new ServiceLoterica().GetDataResponse("https://lotericas.io/api/v1/jogos/megasena/lasted");         
            return View();
        }
        public IActionResult Diadesorte()
        {
            DataResponse teste = new ServiceLoterica().GetDataResponse("https://lotericas.io/api/v1/jogos/diadesorte/lasted");
            Console.WriteLine(teste.Data[0].NomeMunicipioUFSorteio);
            return View();
        }
        public IActionResult Duplasena()
        {
            DataResponse teste = new ServiceLoterica().GetDataResponse("https://lotericas.io/api/v1/jogos/duplasena/lasted");
            return View();
        }
        public IActionResult Federal()
        {
            DataResponse teste = new ServiceLoterica().GetDataResponse("https://lotericas.io/api/v1/jogos/federal/lasted");
            return View();
        }
        public IActionResult Loteca()
        {
            DataResponse teste = new ServiceLoterica().GetDataResponse("https://lotericas.io/api/v1/jogos/loteca/lasted");
            return View();
        }
        public IActionResult LotoFacil()
        {
            DataResponse teste = new ServiceLoterica().GetDataResponse("https://lotericas.io/api/v1/jogos/lotofacil/lasted");
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
