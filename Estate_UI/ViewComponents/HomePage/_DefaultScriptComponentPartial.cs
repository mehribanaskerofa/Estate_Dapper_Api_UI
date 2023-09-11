using Microsoft.AspNetCore.Mvc;

namespace Estate_UI.ViewComponents.HomePage
{
    public class _DefaultScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
