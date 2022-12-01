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
    public class RelatorioController : Controller
    {
        private readonly INSFITContext _context;

        public RelatorioController(INSFITContext context)
        {
            _context = context;
        }

        // GET: Relatorio
        public async Task<IActionResult> Index()
        {
              return View(await _context.Relatorio.ToListAsync());
        }

        // GET: Relatorio/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Relatorio == null)
            {
                return NotFound();
            }

            var relatorio = await _context.Relatorio
                .FirstOrDefaultAsync(m => m.Id_relatorio == id);
            if (relatorio == null)
            {
                return NotFound();
            }

            return View(relatorio);
        }

        // GET: Relatorio/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Relatorio/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_relatorio,nome,peso,altura")] Relatorio relatorio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(relatorio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(relatorio);
        }

        // GET: Relatorio/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Relatorio == null)
            {
                return NotFound();
            }

            var relatorio = await _context.Relatorio.FindAsync(id);
            if (relatorio == null)
            {
                return NotFound();
            }
            return View(relatorio);
        }

        // POST: Relatorio/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_relatorio,nome,peso,altura")] Relatorio relatorio)
        {
            if (id != relatorio.Id_relatorio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(relatorio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RelatorioExists(relatorio.Id_relatorio))
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
            return View(relatorio);
        }

        // GET: Relatorio/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Relatorio == null)
            {
                return NotFound();
            }

            var relatorio = await _context.Relatorio
                .FirstOrDefaultAsync(m => m.Id_relatorio == id);
            if (relatorio == null)
            {
                return NotFound();
            }

            return View(relatorio);
        }

        // POST: Relatorio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Relatorio == null)
            {
                return Problem("Entity set 'INSFITContext.Relatorio'  is null.");
            }
            var relatorio = await _context.Relatorio.FindAsync(id);
            if (relatorio != null)
            {
                _context.Relatorio.Remove(relatorio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RelatorioExists(int id)
        {
          return _context.Relatorio.Any(e => e.Id_relatorio == id);
        }
    }
}
