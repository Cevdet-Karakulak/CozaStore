using Microsoft.AspNetCore.Mvc;

namespace CozaStore.ViewComponents
{
    public class _AdminFooterComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
