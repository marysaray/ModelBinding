using Microsoft.AspNetCore.Mvc;

namespace ModelBinding.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
