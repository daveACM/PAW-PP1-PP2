using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess.Repositories;
using PAW.Models.DTO;

namespace PAW.API.Controllers;


[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryRepository _categoryRepository;

    // Constructor
    public CategoryController(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    // GET: /Category
    [HttpGet]
    public async Task<IEnumerable<CategoryDTO>> GetAll()
    {
        var categories = await _categoryRepository.ReadAsync();
        return categories.Select(CategoryDTO.ConvertFrom);
    }


}
