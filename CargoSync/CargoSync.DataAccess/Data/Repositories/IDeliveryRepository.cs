using CargoSync.DataAccess.Models;

namespace CargoSync.DataAccess.Data.Repositories
{
    public interface IDeliveryRepository
    {
        Task<List<Delivery>> GetRecentDeliveriesAsync();
    }
}
