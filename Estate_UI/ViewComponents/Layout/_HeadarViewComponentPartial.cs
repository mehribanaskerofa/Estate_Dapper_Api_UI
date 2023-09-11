using Microsoft.AspNetCore.Mvc;

namespace Estate_UI.ViewComponents.Layout
{
    public class _HeadarViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
