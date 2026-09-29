using APW.Architecture;
using PAW.Architecture.Providers;
using PAW.Models.DTO;

namespace PAW.Web.Services;

// Define el contrato del servicio encargado de obtener los usuarios desde la API.
public interface IUserService
{
    Task<IEnumerable<UserDTO>> GetUsersAsync();
}

// Servicio encargado de consumir la API para obtener la información relacionada con los usuarios.
public class UserService : ServiceBase, IUserService
{
    // Ruta del endpoint de la API utilizado para consultar los usuarios.
    private const string _path = "User";

    private readonly IRestProvider _restProvider;

    // Recibe el proveedor encargado de realizar las solicitudes HTTP.
    public UserService(IRestProvider restProvider)
    {
        _restProvider = restProvider;
    }

    // Obtiene todos los usuarios desde la API de forma asíncrona, convierte la respuesta en una colección de UserDTOy retorna una colección vacía si no se obtienen resultados.
    public async Task<IEnumerable<UserDTO>> GetUsersAsync()
    {
        var response = await _restProvider.GetAsync(
            SetPathUrl(_path),
            id: null
        );

        var users =
            await JsonProvider.DeserializeAsync<IEnumerable<UserDTO>>(
                response
            );

        return users ?? Array.Empty<UserDTO>();
    }
}