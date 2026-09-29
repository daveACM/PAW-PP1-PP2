using Microsoft.AspNetCore.Mvc;
using PAW.Web.Services;

namespace PAW.Web.Controllers;

public class NotificationController : Controller
{
    private readonly INotificationService _notificationService;


    //Constructor for the NotificationController that receives an instance of INotificationService
    public NotificationController(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    // Obtener las Notifications desde el servicio y pasarlas a la vista
    public async Task<IActionResult> Index()
    {
        var notifications = await _notificationService.GetNotificationsAsync();
        return View(notifications);
    }
}
