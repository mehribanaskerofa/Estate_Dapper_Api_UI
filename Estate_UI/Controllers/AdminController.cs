using Microsoft.AspNetCore.Mvc;

namespace Estate_UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
