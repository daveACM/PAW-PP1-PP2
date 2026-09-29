using PAW.DataAccess.MSSQL;
using PAW.Models;
using PAW.Repositories;

namespace PAW.DataAccess.Repositories;

//Interface for the NotificationRepository hereda metodos de IRepositoryBase
public interface INotificationRepository : IRepositoryBase<Notification>
{
}

public class NotificationRepository : RepositoryBase<Notification>, INotificationRepository
{
    public NotificationRepository(ProductDbContext context) : base(context)
    {
    }
}


