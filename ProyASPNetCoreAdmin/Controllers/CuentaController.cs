using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyASPNetCoreAdmin.Models;

namespace ProyASPNetCoreAdmin.Controllers
{
    public class CuentaController : Controller
    {
       /* private readonly DbseguimientoGastosContext _context;

        public CuentaController(DbseguimientoGastosContext context)
        {
            _context = context;
        }
       */

        // GET: CuentaController1
        public ActionResult Index()
        {
            return View("Login");
        }

        // GET: CuentaController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CuentaController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CuentaController1/Create
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

        // GET: CuentaController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CuentaController1/Edit/5
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

        // GET: CuentaController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CuentaController1/Delete/5
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
    }
}
