using Microsoft.AspNetCore.Mvc;
using PAW.Web.Services;

namespace PAW.Web.Controllers;

public class UserRoleController : Controller
{
    private readonly IUserRoleService _userRoleService;

    public UserRoleController(IUserRoleService userRoleService)
    {
        _userRoleService = userRoleService;
    }

    public async Task<IActionResult> Index()
    {
        var userRoles = await _userRoleService.GetUserRolesAsync();

        return View(userRoles);
    }
}