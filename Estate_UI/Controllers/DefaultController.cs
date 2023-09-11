using Microsoft.AspNetCore.Mvc;

namespace Estate_UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
