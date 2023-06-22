using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyASPNetCoreAdmin.Models;
using System.Security.Claims;

namespace ProyASPNetCoreAdmin.Controllers
{
    public class CuentaController : Controller
    {
        private readonly DbseguimientoGastosContext _context;
        string mensaje;

        public CuentaController(DbseguimientoGastosContext context)
        {
            _context = context;
        }

        // GET: CuentaController1
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public IActionResult Login(Administradore model)
        {

            if (ModelState.IsValid)
            {
                var user = _context.Administradores.FirstOrDefault(a => a.NombreAdmin == model.NombreAdmin && a.ContraseñaAdmin == model.ContraseñaAdmin);
                if (user != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim (ClaimTypes.Name,user.NombreAdmin)
                    };

                    var identity = new ClaimsIdentity(claims, "login");
                    var principal = new ClaimsPrincipal(identity);

                    HttpContext.SignInAsync(principal).Wait();

                    return RedirectToAction("Index", "Home"); 
                }
                else
                {
                    mensaje = "Error de usuuario y/o contraseña";
                    ViewData["Mensaje"] = mensaje;
                }

            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            _context.Dispose();
            /* Remover usuario en caso de ser necesario
            HttpContext.Session.Remove("Usuario");
            HttpContext.Session.Clear();
            */

            return RedirectToAction("Index", "Cuenta");
        }
    }
}