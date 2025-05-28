using Microsoft.AspNetCore.Mvc;

namespace CozaStore.ViewComponents
{
    public class _DefaultScriptComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
