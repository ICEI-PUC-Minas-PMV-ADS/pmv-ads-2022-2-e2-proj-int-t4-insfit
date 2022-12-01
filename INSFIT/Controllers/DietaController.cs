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
    public class DietaController : Controller
    {
        private readonly INSFITContext _context;

        public DietaController(INSFITContext context)
        {
            _context = context;
        }

        // GET: Dieta
        public async Task<IActionResult> Index()
        {
              return View(await _context.Dieta.ToListAsync());
        }

        // GET: Dieta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Dieta == null)
            {
                return NotFound();
            }

            var dieta = await _context.Dieta
                .FirstOrDefaultAsync(m => m.Id_Dieta == id);
            if (dieta == null)
            {
                return NotFound();
            }

            return View(dieta);
        }

        // GET: Dieta/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dieta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Dieta,Date,CampoImgem,CampodePesquisa,DataPublicacao")] Dieta dieta)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(dieta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dieta);
        }

        // GET: Dieta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Dieta == null)
            {
                return NotFound();
            }

            var dieta = await _context.Dieta.FindAsync(id);
            if (dieta == null)
            {
                return NotFound();
            }
            return View(dieta);
        }

        // POST: Dieta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Dieta,Date,CampoImgem,CampodePesquisa,DataPublicacao,IdUser")] Dieta dieta)
        {
            if (id != dieta.Id_Dieta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dieta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DietaExists(dieta.Id_Dieta))
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
            return View(dieta);
        }

        // GET: Dieta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Dieta == null)
            {
                return NotFound();
            }

            var dieta = await _context.Dieta
                .FirstOrDefaultAsync(m => m.Id_Dieta == id);
            if (dieta == null)
            {
                return NotFound();
            }

            return View(dieta);
        }

        // POST: Dieta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Dieta == null)
            {
                return Problem("Entity set 'INSFITContext.Dieta'  is null.");
            }
            var dieta = await _context.Dieta.FindAsync(id);
            if (dieta != null)
            {
                _context.Dieta.Remove(dieta);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DietaExists(int id)
        {
          return _context.Dieta.Any(e => e.Id_Dieta == id);
        }
    }
}
