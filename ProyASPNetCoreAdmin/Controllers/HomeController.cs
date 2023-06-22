using Microsoft.AspNetCore.Mvc;
using ProyASPNetCoreAdmin.Models;
using System.Diagnostics;

namespace ProyASPNetCoreAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly DbseguimientoGastosContext _dbContext;

        public HomeController(DbseguimientoGastosContext Context)
        {
            _dbContext = Context;
        }
        
        /*
        [HttpPost]
        public IActionResult GetResult() {
            var data = _dbContext.Usuarios.ToList();
            return Json(data);

        }
        */

        /*
          private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */
     

        public IActionResult Index()
        {
            return View();
        }

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