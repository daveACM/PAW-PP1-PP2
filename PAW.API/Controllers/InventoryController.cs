using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess.Repositories;
using PAW.Models.DTO;

namespace PAW.API.Controllers;

[ApiController]
[Route("[controller]")]
public class InventoryController : ControllerBase
{
    private readonly IInventoryRepository _inventoryRepository;

    //Constructor for the InventoryController
    public InventoryController(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;
    }

    // GET: /Inventory

    [HttpGet]
    public async Task<IEnumerable<InventoryDTO>> GetAll()
    {
        var inventories = await _inventoryRepository.ReadAsync();

        return inventories.Select(InventoryDTO.ConvertFrom);
    }
}
