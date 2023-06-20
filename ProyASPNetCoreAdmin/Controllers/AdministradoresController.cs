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
    public class AdministradoresController : Controller
    {
        private readonly DbseguimientoGastosContext _context;

        public AdministradoresController(DbseguimientoGastosContext context)
        {
            _context = context;
        }

        // GET: Administradores
        public async Task<IActionResult> Index()
        {
              return _context.Administradores != null ? 
                          View(await _context.Administradores.ToListAsync()) :
                          Problem("Entity set 'DbseguimientoGastosContext.Administradores'  is null.");
        }

        // GET: Administradores/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null || _context.Administradores == null)
            {
                return NotFound();
            }

            var administradore = await _context.Administradores
                .FirstOrDefaultAsync(m => m.IdAdmin == id);
            if (administradore == null)
            {
                return NotFound();
            }

            return View(administradore);
        }

        // GET: Administradores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administradores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAdmin,NombreAdmin,ContraseñaAdmin,Nombres,Apellidos,Run")] Administradore administradore)
        {
            if (ModelState.IsValid)
            {
                _context.Add(administradore);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(administradore);
        }

        // GET: Administradores/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null || _context.Administradores == null)
            {
                return NotFound();
            }

            var administradore = await _context.Administradores.FindAsync(id);
            if (administradore == null)
            {
                return NotFound();
            }
            return View(administradore);
        }

        // POST: Administradores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("IdAdmin,NombreAdmin,ContraseñaAdmin,Nombres,Apellidos,Run")] Administradore administradore)
        {
            if (id != administradore.IdAdmin)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(administradore);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdministradoreExists(administradore.IdAdmin))
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
            return View(administradore);
        }

        // GET: Administradores/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null || _context.Administradores == null)
            {
                return NotFound();
            }

            var administradore = await _context.Administradores
                .FirstOrDefaultAsync(m => m.IdAdmin == id);
            if (administradore == null)
            {
                return NotFound();
            }

            return View(administradore);
        }

        // POST: Administradores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            if (_context.Administradores == null)
            {
                return Problem("Entity set 'DbseguimientoGastosContext.Administradores'  is null.");
            }
            var administradore = await _context.Administradores.FindAsync(id);
            if (administradore != null)
            {
                _context.Administradores.Remove(administradore);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdministradoreExists(byte id)
        {
          return (_context.Administradores?.Any(e => e.IdAdmin == id)).GetValueOrDefault();
        }
    }
}
