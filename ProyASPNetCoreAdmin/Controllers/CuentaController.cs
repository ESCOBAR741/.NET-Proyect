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
        public IActionResult Login(Usuario model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Usuarios.FirstOrDefault(u => u.Usuario1 == model.Usuario1 && u.Contraseña == model.Contraseña);
                if (user != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim (ClaimTypes.Name,user.Usuario1)
                    };

                    var identity = new ClaimsIdentity(claims, "Login");
                    var principal = new ClaimsPrincipal(identity);

                    HttpContext.SignInAsync(principal).Wait();

                    return RedirectToAction("Index", "Home"); ;
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
