using APW.Architecture;
using PAW.Architecture.Providers;
using PAW.Models.DTO;

namespace PAW.Web.Services;


// Interfaz que define los métodos del servicio de proveedores
public interface ISupplierService 
{
    Task<IEnumerable<SupplierDTO>> GetAllSuppliersAsync();
}
public class SupplierService : ServiceBase, ISupplierService
{
    private const string _path = "Supplier";
    private readonly IRestProvider _restProvider;

    public SupplierService(IRestProvider restProvider)
    {
        _restProvider = restProvider;
    }

    public async Task<IEnumerable<SupplierDTO>> GetAllSuppliersAsync()
    {
        var response = await _restProvider.GetAsync(SetPathUrl(_path), id: null);

        var suppliers = await JsonProvider.DeserializeAsync<IEnumerable<SupplierDTO>>(response);

        return suppliers ?? Array.Empty<SupplierDTO>();
    }
}
