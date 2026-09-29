using Microsoft.AspNetCore.Mvc;
using PAW.Web.Services;

namespace PAW.Web.Controllers;

public class RoleController : Controller
{
    private readonly IRoleService _roleService;
    //Constructor for the RoleController that receives an instance of IRoleService
    public RoleController(IRoleService roleService)
    {
        _roleService = roleService;
    }
    // Obtener las Roles desde el servicio y pasarlas a la vista
    public async Task<IActionResult> Index()
    {
        var roles = await _roleService.GetRolesAsync();
        return View(roles);
    }
}
