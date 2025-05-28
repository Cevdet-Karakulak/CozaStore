using Microsoft.AspNetCore.Mvc;

namespace CozaStore.ViewComponents
{
    public class _DefaultHeadComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
