using Microsoft.AspNetCore.Mvc;
using PAW.Web.Services;


namespace PAW.Web.Controllers;



public class SupplierController : Controller
{
    // Inyección de dependencia del servicio de proveedores
    private readonly ISupplierService _supplierService;

    // Constructor que recibe una instancia de ISupplierService para acceder a los métodos del servicio de proveedores
    public SupplierController(ISupplierService supplierService)
    {
        _supplierService = supplierService;
    }
    // Acción que maneja la solicitud GET para la vista de índice de proveedores
    public async Task<IActionResult> Index()
    {
        var suppliers = await _supplierService.GetAllSuppliersAsync();
        return View(suppliers);
    }
}
