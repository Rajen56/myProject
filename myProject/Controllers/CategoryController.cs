using Microsoft.AspNetCore.Mvc;

namespace myProject.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
