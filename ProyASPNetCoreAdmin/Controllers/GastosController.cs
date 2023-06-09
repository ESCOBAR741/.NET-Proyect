﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyASPNetCoreAdmin.Models;

namespace ProyASPNetCoreAdmin.Controllers
{
    public class GastosController : Controller
    {
        private readonly DbseguimientoGastosContext _context;

        public GastosController(DbseguimientoGastosContext context)
        {
            _context = context;
        }

        // GET: Gastos
        public async Task<IActionResult> Index()
        {
            var dbseguimientoGastosContext = _context.Gastos.Include(g => g.IdAdminNavigation).Include(g => g.IdUsuarioNavigation);
            return View(await dbseguimientoGastosContext.ToListAsync());
        }

        // GET: Gastos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Gastos == null)
            {
                return NotFound();
            }

            var gasto = await _context.Gastos
                .Include(g => g.IdAdminNavigation)
                .Include(g => g.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdGasto == id);
            if (gasto == null)
            {
                return NotFound();
            }

            return View(gasto);
        }

        // GET: Gastos/Create
        public IActionResult Create()
        {
            ViewData["IdAdmin"] = new SelectList(_context.Administradores, "IdAdmin", "IdAdmin");
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario");
            return View();
        }

        // POST: Gastos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdGasto,TipoGasto,Detalle,Descripcion,Monto,IdUsuario,IdAdmin,FechaGasto")] Gasto gasto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gasto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdAdmin"] = new SelectList(_context.Administradores, "IdAdmin", "IdAdmin", gasto.IdAdmin);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", gasto.IdUsuario);
            return View(gasto);
        }

        // GET: Gastos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Gastos == null)
            {
                return NotFound();
            }

            var gasto = await _context.Gastos.FindAsync(id);
            if (gasto == null)
            {
                return NotFound();
            }
            ViewData["IdAdmin"] = new SelectList(_context.Administradores, "IdAdmin", "IdAdmin", gasto.IdAdmin);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", gasto.IdUsuario);
            return View(gasto);
        }

        // POST: Gastos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdGasto,TipoGasto,Detalle,Descripcion,Monto,IdUsuario,IdAdmin,FechaGasto")] Gasto gasto)
        {
            if (id != gasto.IdGasto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gasto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GastoExists(gasto.IdGasto))
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
            ViewData["IdAdmin"] = new SelectList(_context.Administradores, "IdAdmin", "IdAdmin", gasto.IdAdmin);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", gasto.IdUsuario);
            return View(gasto);
        }

        // GET: Gastos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Gastos == null)
            {
                return NotFound();
            }

            var gasto = await _context.Gastos
                .Include(g => g.IdAdminNavigation)
                .Include(g => g.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdGasto == id);
            if (gasto == null)
            {
                return NotFound();
            }

            return View(gasto);
        }

        // POST: Gastos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Gastos == null)
            {
                return Problem("Entity set 'DbseguimientoGastosContext.Gastos'  is null.");
            }
            var gasto = await _context.Gastos.FindAsync(id);
            if (gasto != null)
            {
                _context.Gastos.Remove(gasto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GastoExists(int id)
        {
          return (_context.Gastos?.Any(e => e.IdGasto == id)).GetValueOrDefault();
        }
    }
}
