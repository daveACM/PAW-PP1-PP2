using Microsoft.AspNetCore.Mvc;
using PAW.Web.Services;

namespace PAW.Web.Controllers;

public class InventoryController : Controller
{
    private readonly IInventoryService _inventoryService;

    //Constructor for the InventoryController that receives an instance of IInventoryService
    public InventoryController(IInventoryService inventoryService)
    {
        _inventoryService = inventoryService;
    }

    // Obtener las Inventories desde el servicio y pasarlas a la vista
    public async Task<IActionResult> Index()
    {
        var inventories = await _inventoryService.GetInventoriesAsync();

        return View(inventories);
    }
}
