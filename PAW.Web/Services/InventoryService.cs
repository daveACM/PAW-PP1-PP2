using APW.Architecture;
using PAW.Architecture.Providers;
using PAW.Models.DTO;

namespace PAW.Web.Services;

public interface IInventoryService
{
    Task<IEnumerable<InventoryDTO>> GetInventoriesAsync();
}

public class InventoryService : ServiceBase, IInventoryService
{

    //Ruta base para los endpoints de componentes
    private const string _path = "Inventory";
    private readonly IRestProvider _restProvider;


    //Constructor para InventoryService que recibe una instancia de IRestProvider
    public InventoryService(IRestProvider restProvider)
    {
        _restProvider = restProvider;
    }


    //Obtiene los componentes desde el endpoint de la API y los deserializa a DTO
    public async Task<IEnumerable<InventoryDTO>> GetInventoriesAsync()
    {
        var response = await _restProvider.GetAsync(SetPathUrl(_path), id: null);

        var inventories = await JsonProvider.DeserializeAsync<IEnumerable<InventoryDTO>>(response);

        return inventories ?? Array.Empty<InventoryDTO>();
    }

}
