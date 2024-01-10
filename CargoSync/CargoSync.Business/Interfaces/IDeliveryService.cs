using CargoSync.DataAccess.Models;

namespace CargoSync.Business.Interfaces
{
    public interface IDeliveryService
    {
        public List<Delivery> GetRecentOrders(int count);

        public int GetNewPackagesCount();
        public int GetInTransitPackagesCount();
        public int GetDeliveredPackagesCount();
        public List<Delivery> GetOrders();
    }
}