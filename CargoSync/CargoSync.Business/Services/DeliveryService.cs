using CargoSync.DataAccess.Models;
using CargoSync.DataAccess.Data;
using CargoSync.Business.Interfaces;
using CargoSync.DataAccess.Data.Interfaces;

namespace CargoSync.Business.Services
{
    // Class implementing the IDeliveryService interface to manage delivery-related operations
    public class DeliveryService : IDeliveryService
    {
        private IDeliveryRepository _deliveryRepository;
        private CargoSyncDbContext _dbContext;

        // Modified constructor accepting IDeliveryRepository and CargoSyncDbContext dependencies
      
        public DeliveryService(IDeliveryRepository deliveryRepository, CargoSyncDbContext dbContext)
        {
            _deliveryRepository = deliveryRepository;
            _dbContext = dbContext;
        }

        // Implementation of the GetRecentOrders method specified in the IDeliveryService interface
        public List<Delivery> GetRecentOrders(int count)
        {
            return _dbContext.Deliveries
                .OrderByDescending(d => d.DeliveryId)
                .Take(count)
                .ToList();
        }

        // Implementation of the GetOrders method specified in the IDeliveryService interface
        public List<Delivery> GetOrders()
        {
            return _dbContext.Deliveries
                .OrderByDescending(d => d.DeliveryId)
                .ToList();
        }

        // Implementation of the GetNewPackagesCount method specified in the IDeliveryService interface
        public int GetNewPackagesCount()
        {
            return _dbContext.Deliveries.Count();
        }

        // Implementation of the GetInTransitPackagesCount method specified in the IDeliveryService interface
        public int GetInTransitPackagesCount()
        {
            return _dbContext.Deliveries.Count(d => d.Status == "On going");
        }

        // Implementation of the GetDeliveredPackagesCount method specified in the IDeliveryService interface
        public int GetDeliveredPackagesCount()
        {
            return _dbContext.Deliveries.Count(d => d.Status == "Finished");
        }
    }
}
