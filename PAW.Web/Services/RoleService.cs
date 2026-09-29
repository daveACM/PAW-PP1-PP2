using APW.Architecture;
using PAW.Architecture.Providers;
using PAW.Models.DTO;

namespace PAW.Web.Services;


public interface IRoleService
{
    Task<IEnumerable<RoleDTO>> GetRolesAsync();
}
public class RoleService : ServiceBase, IRoleService
{
    //Ruta base para los endpoints de componentes
    private const string _path = "Role";
    private readonly IRestProvider _restProvider;


    //Constructor para RoleService que recibe una instancia de IRestProvider
    public RoleService(IRestProvider restProvider)
    {
        _restProvider = restProvider;
    }

    //Obtiene los roles desde el endpoint de la API y los deserializa a DTO
    public async Task<IEnumerable<RoleDTO>> GetRolesAsync()
    {
        var response = await _restProvider.GetAsync(SetPathUrl(_path), id: null);
        var roles = await JsonProvider.DeserializeAsync<IEnumerable<RoleDTO>>(response);
        return roles ?? Array.Empty<RoleDTO>();
    }
}
