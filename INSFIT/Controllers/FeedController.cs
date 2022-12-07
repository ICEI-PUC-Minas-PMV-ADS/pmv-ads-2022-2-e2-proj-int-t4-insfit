using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using INSFIT.Data;
using INSFIT.Models;
using Microsoft.AspNetCore.Http;

namespace INSFIT.Controllers
{
    public class FeedController : Controller
    {
        private readonly INSFITContext _context;
        private string _filePath;

        public FeedController(INSFITContext context, IWebHostEnvironment env)
        {
            _filePath = env.WebRootPath;
            _context = context;
        }

        // GET: Feed
        public async Task<IActionResult> Index()
        {
            ViewBag.Path = _filePath;
            return View(await _context.Feed.ToListAsync());
        }

        // GET: Feed/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Feed == null)
            {
                return NotFound();
            }

            var feed = await _context.Feed
                .FirstOrDefaultAsync(m => m.Id_Feed == id);
            if (feed == null)
            {
                return NotFound();
            }

            return View(feed);
        }

        // GET: Feed/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Feed/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Feed,CampoTexto,CampoImgem,DataPublicacao,Comentario")] Feed feed, IFormFile fotos)
        {
            if (ModelState.IsValid)
            {
                var nome = SalvarArquivo(fotos);
                feed.CampoImgem = nome;

                _context.Add(feed);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(feed);
        }
        public string SalvarArquivo(IFormFile fotos)
        {
            var nome = Guid.NewGuid().ToString() + fotos.FileName;

            var filePath = _filePath + "\\imagens";
            if (Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            using (var stream = System.IO.File.Create(filePath + "\\" + nome))
            {
                fotos.CopyToAsync(stream);
            }

            return nome;
        }



        // GET: Feed/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Feed == null)
            {
                return NotFound();
            }

            var feed = await _context.Feed.FindAsync(id);
            if (feed == null)
            {
                return NotFound();
            }
            return View(feed);
        }

        // POST: Feed/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Feed,CampoTexto,CampoImgem,DataPublicacao,Comentario")] Feed feed)
        {
            if (id != feed.Id_Feed)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(feed);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FeedExists(feed.Id_Feed))
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
            return View(feed);
        }

        // GET: Feed/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Feed == null)
            {
                return NotFound();
            }

            var feed = await _context.Feed
                .FirstOrDefaultAsync(m => m.Id_Feed == id);
            if (feed == null)
            {
                return NotFound();
            }

            return View(feed);
        }

        // POST: Feed/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Feed == null)
            {
                return Problem("Entity set 'INSFITContext.Feed'  is null.");
            }
            var feed = await _context.Feed.FindAsync(id);

            if (feed != null)
            {
                _context.Feed.Remove(feed);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FeedExists(int id)
        {
          return _context.Feed.Any(e => e.Id_Feed == id);
        }

    }
}
