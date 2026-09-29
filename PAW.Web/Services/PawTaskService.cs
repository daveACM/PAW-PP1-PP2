using APW.Architecture;
using PAW.Architecture.Providers;
using PAW.Models.DTO;

namespace PAW.Web.Services;

// Define el contrato para obtener la lista de tareas (PawTasks) de forma asíncrona.
public interface IPawTaskService
{
    Task<IEnumerable<PawTaskDTO>> GetTasksAsync();
}
// Servicio encargado de obtener las tareas desde la API e implementar las operaciones definidas en IPawTaskService.
public class PawTaskService : ServiceBase, IPawTaskService
{
    // Ruta del endpoint utilizado para consultar las tareas.
    private const string _path = "PawTask";

    private readonly IRestProvider _restProvider;

    // Recibe el proveedor encargado de realizar las solicitudes HTTP.
    public PawTaskService(IRestProvider restProvider)
    {
        _restProvider = restProvider;
    }

    // Obtiene todas las tareas desde la API de forma asíncrona, convierte la respuesta en una colección de PawTaskDTO  y retorna una colección vacía si no se obtienen resultados.
    public async Task<IEnumerable<PawTaskDTO>> GetTasksAsync()
    {
        var response = await _restProvider.GetAsync(SetPathUrl(_path), id: null);

        var tasks = await JsonProvider.DeserializeAsync<IEnumerable<PawTaskDTO>>(response);

        return tasks ?? Array.Empty<PawTaskDTO>();
    }
}
