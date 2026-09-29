using PAW.DataAccess.MSSQL;
using PAW.Repositories;
using PawUser = PAW.Models.User;

namespace PAW.DataAccess.Repositories;

// Define el contrato del repositorio de usuarios, heredando las operaciones básicas de IRepositoryBase.
public interface IUserRepository : IRepositoryBase<PawUser>
{
}

// Repositorio encargado de realizar las operaciones de acceso a datos relacionadas con los usuarios.
public class UserRepository
    : RepositoryBase<PawUser>, IUserRepository
{
    // Recibe el contexto de la base de datos y lo envía a la clase base para realizar las operaciones de acceso a datos.
    public UserRepository(ProductDbContext context) : base(context)
    {
    }
}