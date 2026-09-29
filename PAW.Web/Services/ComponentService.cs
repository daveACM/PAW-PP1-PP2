using APW.Architecture;
using PAW.Architecture.Providers;
using PAW.Models.DTO;

namespace PAW.Web.Services;

//Interface para ComponentService que define el método GetComponentsAsync
public interface IComponentService
{
    Task<IEnumerable<ComponentDTO>> GetComponentsAsync();
}


public class ComponentService : ServiceBase, IComponentService
{

    //Ruta base para los endpoints de componentes
    private const string _path = "Component";
    private readonly IRestProvider _restProvider;

    //Constructor para ComponentService que recibe una instancia de IRestProvider
    public ComponentService(IRestProvider restProvider)
    {
        _restProvider = restProvider;
    }

    //Obtiene los componentes desde el endpoint de la API y los deserializa a DTO
    public async Task<IEnumerable<ComponentDTO>> GetComponentsAsync()
    {
        var response = await _restProvider.GetAsync(SetPathUrl(_path), id: null);

        var components = await JsonProvider.DeserializeAsync<IEnumerable<ComponentDTO>>(response);

        return components ?? Array.Empty<ComponentDTO>();
    }
}