using APW.Architecture;
using PAW.Architecture.Providers;
using PAW.Models.DTO;

namespace PAW.Web.Services;

//Interface para CategoryService
public interface ICategoryService
{
    Task<IEnumerable<CategoryDTO>> GetCategoriesAsync();
}


public class CategoryService : ServiceBase, ICategoryService
{

    //String constante para la ruta del servicio category
    private const string _path = "Category";
    private readonly IRestProvider _restProvider;

    public CategoryService(IRestProvider restProvider)
    {
        _restProvider = restProvider;
    }

    //Task que obtiene las categorias desde la API y las convierte en una colecion de tipo CategoryDTO
    public async Task<IEnumerable<CategoryDTO>> GetCategoriesAsync()
    {
        var response = await _restProvider.GetAsync(SetPathUrl(_path),id: null);

        var categories = await JsonProvider.DeserializeAsync<IEnumerable<CategoryDTO>>(response);

        return categories ?? Array.Empty<CategoryDTO>();


    }

}
