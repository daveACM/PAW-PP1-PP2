using APW.Architecture;
using PAW.Architecture.Providers;
using PAW.Models.DTO;

namespace PAW.Web.Services;


public interface INotificationService
{
    Task<IEnumerable<NotificationDTO>> GetNotificationsAsync();
}
public class NotificationService : ServiceBase, INotificationService
{

    //Ruta base para los endpoints de componentes
    private const string _path = "Notification";
    private readonly IRestProvider _restProvider;


    //Constructor para NotificationService que recibe una instancia de IRestProvider
    public NotificationService(IRestProvider restProvider)
    {
        _restProvider = restProvider;
    }

    //Obtiene los componentes desde el endpoint de la API y los deserializa a DTO
    public async Task<IEnumerable<NotificationDTO>> GetNotificationsAsync()
    {
        var response = await _restProvider.GetAsync(SetPathUrl(_path), id: null);
        var notifications = await JsonProvider.DeserializeAsync<IEnumerable<NotificationDTO>>(response);
        return notifications ?? Array.Empty<NotificationDTO>();
    }
}
