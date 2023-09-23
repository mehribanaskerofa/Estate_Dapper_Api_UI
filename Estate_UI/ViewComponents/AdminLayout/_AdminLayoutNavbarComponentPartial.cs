using Microsoft.AspNetCore.Mvc;

namespace Estate_UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
