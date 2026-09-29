using PAW.DataAccess.MSSQL;
using PAW.Models;
using PAW.Repositories;

namespace PAW.DataAccess.Repositories;

//Interface que hereda de IRepository<Supplier> para definir los métodos específicos para la entidad Supplier
public interface ISupplierRepository : IRepositoryBase<Supplier>
{
}
//Clase que implementa la interfaz ISupplierRepository y hereda de Repository<Supplier> para proporcionar la implementación de los métodos de acceso a datos para la entidad Supplier
public class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
{
    public SupplierRepository(ProductDbContext context) : base(context)
    {
    }

}
