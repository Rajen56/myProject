using Microsoft.AspNetCore.Mvc;

namespace myProject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
