using CozaStore.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace CozaStore.ViewComponents
{
    public class _DefaultProductComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public _DefaultProductComponent(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productService.GetAllProductAsync();
            return View(values);
        }
    }
}
