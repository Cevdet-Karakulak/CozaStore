using CozaStore.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace CozaStore.ViewComponents
{
    public class _DefaultProductDetailComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public _DefaultProductDetailComponent(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            return View(product);
        }
    }
}
