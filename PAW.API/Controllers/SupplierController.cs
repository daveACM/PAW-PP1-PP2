using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess.Repositories;
using PAW.Models.DTO;

namespace PAW.API.Controllers;


[ApiController]
[Route("[controller]")]

//Controller que hereda de ControllerBase para manejar las solicitudes HTTP relacionadas con la entidad Supplier
public class SupplierController : ControllerBase
{
    private readonly ISupplierRepository _supplierRepository;

    //Constructor que recibe una instancia de ISupplierRepository para acceder a los métodos de acceso a datos de la entidad Supplier
    public SupplierController(ISupplierRepository supplierRepository)
    {
        _supplierRepository = supplierRepository;
    }

    //GET endpoint para obtener todos los proveedores
    [HttpGet]
    public async Task<IEnumerable<SupplierDTO>> GetAll()
    {
        var suppliers = await _supplierRepository.ReadAsync();
        return suppliers.Select(SupplierDTO.ConvertFrom);
    }
}
