using Microsoft.AspNetCore.Mvc;

namespace Sistema_Web.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult CategoriaHome()
        {
            return View();
        }
    }
}
