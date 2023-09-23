using Microsoft.AspNetCore.Mvc;

namespace Estate_UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
