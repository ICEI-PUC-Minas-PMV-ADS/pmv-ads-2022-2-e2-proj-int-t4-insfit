using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using INSFIT.Data;
using INSFIT.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace INSFIT.Controllers
{
    public class CadastroController : Controller
    {
        private readonly INSFITContext _context;

        public CadastroController(INSFITContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        //Validando e-mail e senha no banco
        [HttpPost]
        public async Task<IActionResult> Login([Bind("email,senha")]Cadastro cadastro)
        {
            var user = await _context.Cadastro
                .FirstOrDefaultAsync(m => m.email == cadastro.email);

            if (user == null) {
                ViewBag.Message = "E-mail e/ou Senha inválidos!";
                return View();
            }

            bool isSenhaOk = BCrypt.Net.BCrypt.Verify(cadastro.senha, user.senha);

            if (isSenhaOk)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, cadastro.name),
                    new Claim(ClaimTypes.NameIdentifier, cadastro.name),
                    new Claim(ClaimTypes.Role, user.Perfil.ToString())
                };

                var userIdentity = new ClaimsIdentity(claims, "login");

                var props = new AuthenticationProperties
                {

                }

                ViewBag.Message = "Bem vindo";
            }

            return View();
        }


        // GET: Cadastro
        public async Task<IActionResult> Index()
        {
              return View(await _context.Cadastro.ToListAsync());
        }

        // GET: Cadastro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cadastro == null)
            {
                return NotFound();
            }

            var cadastro = await _context.Cadastro
                .FirstOrDefaultAsync(m => m.id_cadastro == id);
            if (cadastro == null)
            {
                return NotFound();
            }

            return View(cadastro);
        }

        // GET: Cadastro/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cadastro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_cadastro,name,email,senha,tipoUsuario")] Cadastro cadastro)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(cadastro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastro);
        }

        // GET: Cadastro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cadastro == null)
            {
                return NotFound();
            }

            var cadastro = await _context.Cadastro.FindAsync(id);
            if (cadastro == null)
            {
                return NotFound();
            }
            return View(cadastro);
        }

        // POST: Cadastro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_cadastro,name,email,senha,tipoUsuario")] Cadastro cadastro)
        {
            if (id != cadastro.id_cadastro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroExists(cadastro.id_cadastro))
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
            return View(cadastro);
        }

        // GET: Cadastro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cadastro == null)
            {
                return NotFound();
            }

            var cadastro = await _context.Cadastro
                .FirstOrDefaultAsync(m => m.id_cadastro == id);
            if (cadastro == null)
            {
                return NotFound();
            }

            return View(cadastro);
        }

        // POST: Cadastro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cadastro == null)
            {
                return Problem("Entity set 'INSFITContext.Cadastro'  is null.");
            }
            var cadastro = await _context.Cadastro.FindAsync(id);
            if (cadastro != null)
            {
                _context.Cadastro.Remove(cadastro);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroExists(int id)
        {
          return _context.Cadastro.Any(e => e.id_cadastro == id);
        }
    }
}
