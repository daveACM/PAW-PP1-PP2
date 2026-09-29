using Microsoft.AspNetCore.Mvc;
using PAW.Web.Services;

namespace PAW.Web.Controllers;

// Controlador encargado de gestionar las solicitudes relacionadas con las tareas.
public class PawTaskController : Controller
{
    private readonly IPawTaskService _pawTaskService;

    // Recibe el servicio de tareas mediante inyección de dependencias.
    public PawTaskController(IPawTaskService pawTaskService)
    {
        _pawTaskService = pawTaskService;
    }

    // Obtiene la lista de tareas mediante el servicio y la envía a la vista Index para mostrarla al usuario.
    public async Task<IActionResult> Index()
    {
        var tasks = await _pawTaskService.GetTasksAsync();

        return View(tasks);
    }
}