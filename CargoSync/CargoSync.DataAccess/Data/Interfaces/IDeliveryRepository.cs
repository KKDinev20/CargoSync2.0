using CargoSync.DataAccess.Models;

namespace CargoSync.DataAccess.Data.Interfaces
{
    public interface IDeliveryRepository
    {
        Task<List<Delivery>> GetRecentDeliveriesAsync();
    }
}
