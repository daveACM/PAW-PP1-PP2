using PAW.DataAccess.MSSQL;
using PAW.Models;
using PAW.Repositories;

namespace PAW.DataAccess.Repositories;

//Interface for the ComponentRepository hereda metodos de IRepositoryBase
public interface IComponentRepository : IRepositoryBase<Component>
{
}

public class ComponentRepository : RepositoryBase<Component>, IComponentRepository
{
    public ComponentRepository(ProductDbContext context) : base(context)
    {
    }
}
