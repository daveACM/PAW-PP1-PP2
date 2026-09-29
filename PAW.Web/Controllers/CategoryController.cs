using Microsoft.AspNetCore.Mvc;
using PAW.Web.Services;

namespace PAW.Web.Controllers;

public class CategoryController : Controller
{

    private readonly ICategoryService _categoryService;

    // Constructor
    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }


    // Obtener las categorías desde el servicio y pasarlas a la vista
    public async Task<IActionResult> Index()
    {
        var categories = await _categoryService.GetCategoriesAsync();
        return View(categories);
    }

}
