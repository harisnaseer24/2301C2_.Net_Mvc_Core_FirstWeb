using Microsoft.AspNetCore.Mvc;

namespace _2301C2firstWeb.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult AllProducts()
        {
            return View();
        }
    }
}
