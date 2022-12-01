using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using INSFIT.Data;
using INSFIT.Models;

namespace INSFIT.Controllers
{
    public class PerfilController : Controller
    {
        private readonly INSFITContext _context;

        public PerfilController(INSFITContext context)
        {
            _context = context;
        }

        // GET: Perfil
        public async Task<IActionResult> Index()
        {
            var iNSFITContext = _context.Perfil.Include(p => p.Cadastro);
            return View(await iNSFITContext.ToListAsync());
        }

        // GET: Perfil/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Perfil == null)
            {
                return NotFound();
            }

            var perfil = await _context.Perfil
                .Include(p => p.Cadastro)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (perfil == null)
            {
                return NotFound();
            }

            return View(perfil);
        }

        // GET: Perfil/Create
        public IActionResult Create()
        {
            ViewData["indetificador"] = new SelectList(_context.Cadastro, "id_cadastro", "email");
            return View();
        }

        // POST: Perfil/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Altura,Peso,Telefone,Usuario,indetificador")] Perfil perfil)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(perfil);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["indetificador"] = new SelectList(_context.Cadastro, "id_cadastro", "email", perfil.indetificador);
            return View(perfil);
        }

        // GET: Perfil/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Perfil == null)
            {
                return NotFound();
            }

            var perfil = await _context.Perfil.FindAsync(id);
            if (perfil == null)
            {
                return NotFound();
            }
            ViewData["indetificador"] = new SelectList(_context.Cadastro, "id_cadastro", "email", perfil.indetificador);
            return View(perfil);
        }

        // POST: Perfil/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Altura,Peso,Telefone,Usuario,indetificador")] Perfil perfil)
        {
            if (id != perfil.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(perfil);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PerfilExists(perfil.Id))
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
            ViewData["indetificador"] = new SelectList(_context.Cadastro, "id_cadastro", "email", perfil.indetificador);
            return View(perfil);
        }

        // GET: Perfil/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Perfil == null)
            {
                return NotFound();
            }

            var perfil = await _context.Perfil
                .Include(p => p.Cadastro)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (perfil == null)
            {
                return NotFound();
            }

            return View(perfil);
        }

        // POST: Perfil/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Perfil == null)
            {
                return Problem("Entity set 'INSFITContext.Perfil'  is null.");
            }
            var perfil = await _context.Perfil.FindAsync(id);
            if (perfil != null)
            {
                _context.Perfil.Remove(perfil);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PerfilExists(int id)
        {
          return _context.Perfil.Any(e => e.Id == id);
        }
    }
}
