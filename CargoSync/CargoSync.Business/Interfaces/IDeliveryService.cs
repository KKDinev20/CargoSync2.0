using CargoSync.DataAccess.Models;

namespace CargoSync.Business.Interfaces
{
    public interface IDeliveryService
    {
        List<Delivery> GetRecentOrders(int count);

        int GetNewPackagesCount();
        int GetInTransitPackagesCount();
        int GetDeliveredPackagesCount();
        List<Delivery> GetOrders();
    }
}