using PAW.DataAccess.MSSQL;
using PAW.Models;
using PAW.Repositories;

namespace PAW.DataAccess.Repositories;


//Interface for the ComponentRepository hereda metodos de IRepositoryBase
public interface IInventoryRepository : IRepositoryBase<Inventory>
{

}
//Implementation of the RoleRepository
public class InventoryRepository : RepositoryBase<Inventory>, IInventoryRepository
{
    public InventoryRepository(ProductDbContext context) : base(context)
    {
    }
}