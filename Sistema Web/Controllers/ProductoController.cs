using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_Web.Models;

namespace Sistema_Web.Controllers
{
    public class ProductoController : Controller
    {
        private readonly AppDbContext _context;

        public ProductoController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> ProductoHome()
        {
            var products = await _context.Productos.Include(p => p.Categoria).ToListAsync();
            return View(products);
        }

        public async Task<IActionResult> ProductoCreate()
        {
            var categories = await _context.Categorias.ToListAsync();
            ViewData["CategoriaId"] = new SelectList(categories, "CategoriaId", "Nombre");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProductoCreate(Producto P)
        {
            if(P != null)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(P);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(ProductoHome));
                }
                else
                {
                    ModelState.AddModelError("", 
                        "Ha ocurrido un Error al intentar guardar el Producto!");
                    return View(P);
                }
            }
            else
            {
                return View();
            }
        }
    }
}
