using Microsoft.AspNetCore.Mvc;

namespace Sistema_Web.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult ProductoHome()
        {
            return View();
        }
    }
}
