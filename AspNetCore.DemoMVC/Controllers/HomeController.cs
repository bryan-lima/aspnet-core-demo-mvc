using AspNetCore.DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.DemoMVC.Controllers
{
    [Route("gestao-clientes")]
    public class HomeController : Controller
    {
        [Route("pagina-inicial")]
        public IActionResult Index(string id, string categoria)
        {
            return View();
        }

        [Route("privacidade")]
        public IActionResult Privacy()
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
