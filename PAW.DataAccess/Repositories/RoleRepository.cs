using PAW.DataAccess.MSSQL;
using PAW.Models;
using PAW.Repositories;

namespace PAW.DataAccess.Repositories;

//Interface for the ComponentRepository hereda metodos de IRepositoryBase
public interface IRoleRepository : IRepositoryBase<Role>
{
}

//Implementation of the RoleRepository
public class RoleRepository : RepositoryBase<Role>, IRoleRepository
{
    public RoleRepository(ProductDbContext context) : base(context)
    {
    }
}
