using APW.Architecture;
using PAW.Architecture.Providers;
using PAW.Models.DTO;

namespace PAW.Web.Services;

// Define el contrato del servicio encargado de obtener las acciones de usuario desde la API.
public interface IUserActionService
{
    Task<IEnumerable<UserActionDTO>> GetUserActionsAsync();
}

// Servicio encargado de consumir la API para obtener  la información relacionada con las acciones de usuario.
public class UserActionService : ServiceBase, IUserActionService
{
    // Ruta del endpoint de la API utilizado para consultar las acciones de usuario.
    private const string _path = "UserAction";

    private readonly IRestProvider _restProvider;

    // Recibe el proveedor encargado de realizar las solicitudes HTTP.
    public UserActionService(IRestProvider restProvider)
    {
        _restProvider = restProvider;
    }

    // Obtiene todas las acciones de usuario desde la API de forma asíncrona, convierte la respuesta en una colección de UserActionDTOy retorna una colección vacía si no se obtienen resultados.
    public async Task<IEnumerable<UserActionDTO>> GetUserActionsAsync()
    {
        var response = await _restProvider.GetAsync(
            SetPathUrl(_path),
            id: null
        );

        var userActions =
            await JsonProvider.DeserializeAsync<IEnumerable<UserActionDTO>>(
                response
            );

        return userActions ?? Array.Empty<UserActionDTO>();
    }
}