using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess.Repositories;
using PAW.Models.DTO;

namespace PAW.API.Controllers;


[ApiController]
[Route("[controller]")]
public class NotificationController : ControllerBase
{
    private readonly INotificationRepository _notificationRepository;


    //Constructor for the NotificationController
    public NotificationController(INotificationRepository notificationRepository)
    {
        _notificationRepository = notificationRepository;
    }

    // GET: /Notification
    [HttpGet]
    public async Task<IEnumerable<NotificationDTO>> GetAll()
    {
        var notifications = await _notificationRepository.ReadAsync();
        return notifications.Select(NotificationDTO.ConvertFrom);
    }
}
