using CargoSync.DataAccess.Models;

namespace CargoSync.Business.Interfaces
{
    // Interface representing the abstraction of a delivery service
    public interface IDeliveryService
    {
        //Encapsulation using Access modifiers
        public List<Delivery> GetRecentOrders(int count);

        public int GetNewPackagesCount();
        public int GetInTransitPackagesCount();
        public int GetDeliveredPackagesCount();
        public List<Delivery> GetOrders();
    }
}