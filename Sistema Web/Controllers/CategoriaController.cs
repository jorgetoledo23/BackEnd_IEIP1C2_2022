using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_Web.Models;

namespace Sistema_Web.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly AppDbContext _context;

        public CategoriaController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> CategoriaHome()
        {
            var categories = await _context.Categorias.ToListAsync();
            return View(categories);
        }

        [HttpGet]
        public IActionResult CategoriaCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoriaCreate(Categoria C)
        {
            if (ModelState.IsValid)
            {
                _context.Categorias.Add(C);
                _context.SaveChanges();
                return RedirectToAction(nameof(CategoriaHome));
            }
            else
            {
                ModelState.AddModelError("", "Ocurrio un Error!");
                return View(C);
            }
            
        }

        public IActionResult EliminarCategoria(int Id)
        {
            var Categoria = _context.Categorias.Find(Id);
            if(Categoria != null)
            {
                _context.Categorias.Remove(Categoria);
                _context.SaveChanges();
                return RedirectToAction(nameof(CategoriaHome));
            }
            else
            {
                return NotFound();
            }
        }


        [HttpGet]
        public IActionResult CategoriaEdit(int Id)
        {
            var Categoria = _context.Categorias.Find(Id);
            if (Categoria != null)
            {
                return View(Categoria);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpPost]
        public IActionResult CategoriaEdit(Categoria C)
        {
            if (ModelState.IsValid)
            {
                _context.Update(C);
                _context.SaveChanges();
                return RedirectToAction(nameof(CategoriaHome));
            }
            else
            {
                ModelState.AddModelError("", "Ocurrio un Error!");
                return View(C);
            }
        }

    }
}
