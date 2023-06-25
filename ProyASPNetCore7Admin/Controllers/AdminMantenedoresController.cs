using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyASPNetCore7Admin.Models;

namespace ProyASPNetCore7Admin.Controllers
{
    public class AdminMantenedoresController : Controller
    {
        private readonly DbseguimientoGastosContext _context;

        public AdminMantenedoresController(DbseguimientoGastosContext context)
        {
            _context = context;
        }

        // GET: AdminMantenedores
        public async Task<IActionResult> Index()
        {
              return _context.AdminMantenedores != null ? 
                          View(await _context.AdminMantenedores.ToListAsync()) :
                          Problem("Entity set 'DbseguimientoGastosContext.AdminMantenedores'  is null.");
        }

        // GET: AdminMantenedores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AdminMantenedores == null)
            {
                return NotFound();
            }

            var adminMantenedore = await _context.AdminMantenedores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adminMantenedore == null)
            {
                return NotFound();
            }

            return View(adminMantenedore);
        }

        // GET: AdminMantenedores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminMantenedores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombres,Apellidos,Run,UsuarioAm,PasswordAm")] AdminMantenedore adminMantenedore)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adminMantenedore);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adminMantenedore);
        }

        // GET: AdminMantenedores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AdminMantenedores == null)
            {
                return NotFound();
            }

            var adminMantenedore = await _context.AdminMantenedores.FindAsync(id);
            if (adminMantenedore == null)
            {
                return NotFound();
            }
            return View(adminMantenedore);
        }

        // POST: AdminMantenedores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombres,Apellidos,Run,UsuarioAm,PasswordAm")] AdminMantenedore adminMantenedore)
        {
            if (id != adminMantenedore.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adminMantenedore);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminMantenedoreExists(adminMantenedore.Id))
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
            return View(adminMantenedore);
        }

        // GET: AdminMantenedores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AdminMantenedores == null)
            {
                return NotFound();
            }

            var adminMantenedore = await _context.AdminMantenedores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adminMantenedore == null)
            {
                return NotFound();
            }

            return View(adminMantenedore);
        }

        // POST: AdminMantenedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AdminMantenedores == null)
            {
                return Problem("Entity set 'DbseguimientoGastosContext.AdminMantenedores'  is null.");
            }
            var adminMantenedore = await _context.AdminMantenedores.FindAsync(id);
            if (adminMantenedore != null)
            {
                _context.AdminMantenedores.Remove(adminMantenedore);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminMantenedoreExists(int id)
        {
          return (_context.AdminMantenedores?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
