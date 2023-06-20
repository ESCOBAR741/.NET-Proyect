using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyASPNetCoreAdmin.Models;

namespace ProyASPNetCoreAdmin.Controllers
{
    public class DepartamentosController : Controller
    {
        private readonly DbseguimientoGastosContext _context;

        public DepartamentosController(DbseguimientoGastosContext context)
        {
            _context = context;
        }

        // GET: Departamentos
        public async Task<IActionResult> Index()
        {
            var dbseguimientoGastosContext = _context.Departamentos.Include(d => d.IdAdminNavigation);
            return View(await dbseguimientoGastosContext.ToListAsync());
        }

        // GET: Departamentos/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null || _context.Departamentos == null)
            {
                return NotFound();
            }

            var departamento = await _context.Departamentos
                .Include(d => d.IdAdminNavigation)
                .FirstOrDefaultAsync(m => m.IdDepto == id);
            if (departamento == null)
            {
                return NotFound();
            }

            return View(departamento);
        }

        // GET: Departamentos/Create
        public IActionResult Create()
        {
            ViewData["IdAdmin"] = new SelectList(_context.Administradores, "IdAdmin", "IdAdmin");
            return View();
        }

        // POST: Departamentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDepto,NombreDepto,IdAdmin")] Departamento departamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(departamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdAdmin"] = new SelectList(_context.Administradores, "IdAdmin", "IdAdmin", departamento.IdAdmin);
            return View(departamento);
        }

        // GET: Departamentos/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null || _context.Departamentos == null)
            {
                return NotFound();
            }

            var departamento = await _context.Departamentos.FindAsync(id);
            if (departamento == null)
            {
                return NotFound();
            }
            ViewData["IdAdmin"] = new SelectList(_context.Administradores, "IdAdmin", "IdAdmin", departamento.IdAdmin);
            return View(departamento);
        }

        // POST: Departamentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("IdDepto,NombreDepto,IdAdmin")] Departamento departamento)
        {
            if (id != departamento.IdDepto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(departamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartamentoExists(departamento.IdDepto))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdAdmin"] = new SelectList(_context.Administradores, "IdAdmin", "IdAdmin", departamento.IdAdmin);
            return View(departamento);
        }

        // GET: Departamentos/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null || _context.Departamentos == null)
            {
                return NotFound();
            }

            var departamento = await _context.Departamentos
                .Include(d => d.IdAdminNavigation)
                .FirstOrDefaultAsync(m => m.IdDepto == id);
            if (departamento == null)
            {
                return NotFound();
            }

            return View(departamento);
        }

        // POST: Departamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            if (_context.Departamentos == null)
            {
                return Problem("Entity set 'DbseguimientoGastosContext.Departamentos'  is null.");
            }
            var departamento = await _context.Departamentos.FindAsync(id);
            if (departamento != null)
            {
                _context.Departamentos.Remove(departamento);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DepartamentoExists(byte id)
        {
          return (_context.Departamentos?.Any(e => e.IdDepto == id)).GetValueOrDefault();
        }
    }
}
