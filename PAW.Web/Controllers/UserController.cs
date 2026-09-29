using Microsoft.AspNetCore.Mvc;
using PAW.Web.Services;

namespace PAW.Web.Controllers;


// Controlador encargado de gestionar las solicitudes relacionadas con los users
public class UserController : Controller
{
    private readonly IUserService _userService;


    // Recibe el Service de Users mediante inyección de dependencias.
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    // Obtiene la lista de User mediante el service y la envía a la vista Index para mostrarla al usuario.
    public async Task<IActionResult> Index()
    {
        var users = await _userService.GetUsersAsync();

        return View(users);
    }
}