using Microsoft.AspNetCore.Mvc;

namespace CozaStore.ViewComponents
{
    public class _AdminHeaderComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
