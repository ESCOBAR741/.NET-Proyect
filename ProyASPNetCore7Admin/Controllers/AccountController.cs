using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyASPNetCore7Admin.Models;
using System.Security.Claims;

namespace ProyASPNetCore7Admin.Controllers
{
    public class AccountController : Controller
    {
        private readonly DbseguimientoGastosContext _context;
        string mensaje;

        public AccountController(DbseguimientoGastosContext context)
        {
            _context = context;
        }

        // GET: AccountController
        public ActionResult Index()
        {
            return View("Login");
        }

        // POST: AdminMantenedore/Details/5
        [HttpPost]
        public ActionResult Login(AdminMantenedore model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.AdminMantenedores.FirstOrDefault(a => a.UsuarioAm == model.UsuarioAm && a.PasswordAm == model.PasswordAm);
                if (user != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim (ClaimTypes.Name,user.UsuarioAm)
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

            return RedirectToAction("Index", "Account");
        }
        /*
        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */
    }
}
