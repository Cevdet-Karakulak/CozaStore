using Microsoft.AspNetCore.Mvc;

namespace CozaStore.ViewComponents
{
    public class _AdminSidebarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
