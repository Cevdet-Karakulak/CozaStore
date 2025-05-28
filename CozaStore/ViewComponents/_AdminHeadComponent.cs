using Microsoft.AspNetCore.Mvc;

namespace CozaStore.ViewComponents
{
    public class _AdminHeadComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
