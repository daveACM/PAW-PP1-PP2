using PAW.DataAccess.MSSQL;
using PAW.Models;
using PAW.Repositories;

namespace PAW.DataAccess.Repositories;

// Define el contrato del repositorio de acciones de usuario,heredando las operaciones básicas de IRepositoryBase.
public interface IUserActionRepository : IRepositoryBase<UserAction>
{
}

// Repositorio encargado de realizar las operaciones de acceso a datos relacionadas con las acciones de usuario.
public class UserActionRepository
    : RepositoryBase<UserAction>, IUserActionRepository
{
    // Recibe el contexto de la base de datos y lo envía  a la clase base para realizar las operaciones de acceso a datos.
    public UserActionRepository(ProductDbContext context) : base(context)
    {
    }
}