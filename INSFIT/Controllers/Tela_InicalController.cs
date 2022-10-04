using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using INSFIT.Models;

namespace INSFIT.Controllers
{
    public class Tela_InicalController : Controller
    {
        private readonly ConexaoBD _context;

        public Tela_InicalController(ConexaoBD context)
        {
            _context = context;
        }

        // GET: Tela_Inical
        public async Task<IActionResult> Index()
        {
              return View(await _context.Tela_Inical.ToListAsync());
        }

        // GET: Tela_Inical/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Tela_Inical == null)
            {
                return NotFound();
            }

            var tela_Inical = await _context.Tela_Inical
                .FirstOrDefaultAsync(m => m.id == id);
            if (tela_Inical == null)
            {
                return NotFound();
            }

            return View(tela_Inical);
        }

        // GET: Tela_Inical/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tela_Inical/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id")] Tela_Inical tela_Inical)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tela_Inical);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tela_Inical);
        }

        // GET: Tela_Inical/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Tela_Inical == null)
            {
                return NotFound();
            }

            var tela_Inical = await _context.Tela_Inical.FindAsync(id);
            if (tela_Inical == null)
            {
                return NotFound();
            }
            return View(tela_Inical);
        }

        // POST: Tela_Inical/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id")] Tela_Inical tela_Inical)
        {
            if (id != tela_Inical.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tela_Inical);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Tela_InicalExists(tela_Inical.id))
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
            return View(tela_Inical);
        }

        // GET: Tela_Inical/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Tela_Inical == null)
            {
                return NotFound();
            }

            var tela_Inical = await _context.Tela_Inical
                .FirstOrDefaultAsync(m => m.id == id);
            if (tela_Inical == null)
            {
                return NotFound();
            }

            return View(tela_Inical);
        }

        // POST: Tela_Inical/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Tela_Inical == null)
            {
                return Problem("Entity set 'ConexaoBD.Tela_Inical'  is null.");
            }
            var tela_Inical = await _context.Tela_Inical.FindAsync(id);
            if (tela_Inical != null)
            {
                _context.Tela_Inical.Remove(tela_Inical);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Tela_InicalExists(int id)
        {
          return _context.Tela_Inical.Any(e => e.id == id);
        }
    }
}
