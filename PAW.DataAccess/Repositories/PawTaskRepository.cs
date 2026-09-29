using PAW.DataAccess.MSSQL;
using PAW.Repositories;
using PawTask = PAW.Models.Task;

namespace PAW.DataAccess.Repositories;

//Interface for PawTaskRepository, hereda de IRepositoryBase<PawTask>
public interface IPawTaskRepository : IRepositoryBase<PawTask>
{
}

//Repository for PawTask, hereda de RepositoryBase<PawTask> e implementa IPawTaskRepository
public class PawTaskRepository : RepositoryBase<PawTask>, IPawTaskRepository
{
    public PawTaskRepository(ProductDbContext context) : base(context)
    {
    }
}
