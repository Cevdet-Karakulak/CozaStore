using Microsoft.AspNetCore.Mvc;

namespace CozaStore.ViewComponents
{
    public class _AdminNavbarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
