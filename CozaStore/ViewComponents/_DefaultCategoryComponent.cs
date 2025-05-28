using CozaStore.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace CozaStore.ViewComponents
{
    public class _DefaultCategoryComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _DefaultCategoryComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _categoryService.GetAllCategoryAsync();
            return View(values);
        }
    }
}