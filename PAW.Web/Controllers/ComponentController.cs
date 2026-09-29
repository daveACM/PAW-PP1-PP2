using Microsoft.AspNetCore.Mvc;
using PAW.Web.Services;

namespace PAW.Web.Controllers;

public class ComponentController : Controller
{
    private readonly IComponentService _componentService;

    public ComponentController(IComponentService componentService)
    {
        _componentService = componentService;
    }

    public async Task<IActionResult> Index()
    {
        var components = await _componentService.GetComponentsAsync();

        return View(components);
    }
}