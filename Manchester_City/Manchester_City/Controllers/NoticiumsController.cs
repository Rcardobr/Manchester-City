using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Manchester_City.Models.dbModels;

namespace Manchester_City.Controllers
{
    public class NoticiumsController : Controller
    {
        private readonly ManchesterCityContext _context;

        public NoticiumsController(ManchesterCityContext context)
        {
            _context = context;
        }

        // GET: Noticiums
        public async Task<IActionResult> Index()
        {
            var manchesterCityContext = _context.Noticia.Include(n => n.IdUsuarioNavigation);
            return View(await manchesterCityContext.ToListAsync());
        }

        // GET: Noticiums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Noticia == null)
            {
                return NotFound();
            }

            var noticium = await _context.Noticia
                .Include(n => n.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdNoticia == id);
            if (noticium == null)
            {
                return NotFound();
            }

            return View(noticium);
        }

        // GET: Noticiums/Create
        public IActionResult Create()
        {
            ViewData["IdUsuario"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Noticiums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdNoticia,Titulo,IdUsuario,Contenido,FechaMod,ImagenNoticia")] Noticium noticium)
        {
            if (ModelState.IsValid)
            {
                _context.Add(noticium);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdUsuario"] = new SelectList(_context.Users, "Id", "Id", noticium.IdUsuario);
            return View(noticium);
        }

        // GET: Noticiums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Noticia == null)
            {
                return NotFound();
            }

            var noticium = await _context.Noticia.FindAsync(id);
            if (noticium == null)
            {
                return NotFound();
            }
            ViewData["IdUsuario"] = new SelectList(_context.Users, "Id", "Id", noticium.IdUsuario);
            return View(noticium);
        }

        // POST: Noticiums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdNoticia,Titulo,IdUsuario,Contenido,FechaMod,ImagenNoticia")] Noticium noticium)
        {
            if (id != noticium.IdNoticia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(noticium);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NoticiumExists(noticium.IdNoticia))
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
            ViewData["IdUsuario"] = new SelectList(_context.Users, "Id", "Id", noticium.IdUsuario);
            return View(noticium);
        }

        // GET: Noticiums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Noticia == null)
            {
                return NotFound();
            }

            var noticium = await _context.Noticia
                .Include(n => n.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdNoticia == id);
            if (noticium == null)
            {
                return NotFound();
            }

            return View(noticium);
        }

        // POST: Noticiums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Noticia == null)
            {
                return Problem("Entity set 'ManchesterCityContext.Noticia'  is null.");
            }
            var noticium = await _context.Noticia.FindAsync(id);
            if (noticium != null)
            {
                _context.Noticia.Remove(noticium);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NoticiumExists(int id)
        {
          return (_context.Noticia?.Any(e => e.IdNoticia == id)).GetValueOrDefault();
        }
    }
}
