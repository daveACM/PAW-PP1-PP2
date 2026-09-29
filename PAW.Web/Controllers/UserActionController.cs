using Microsoft.AspNetCore.Mvc;
using PAW.Web.Services;

namespace PAW.Web.Controllers;

// Controller encargado de gestionar las solicitudes relacionadas con las acciones de usuario en la aplicación web.
public class UserActionController : Controller
{
    private readonly IUserActionService _userActionService;

    // Recibe el service de acciones de usuario mediante inyección de dependencias.
    public UserActionController(IUserActionService userActionService)
    {
        _userActionService = userActionService;
    }

    // Obtiene la lista de acciones de usuario mediante el service y la envía a la vista Index para mostrarla al usuario.
    public async Task<IActionResult> Index()
    {
        var userActions =
            await _userActionService.GetUserActionsAsync();

        return View(userActions);
    }
}