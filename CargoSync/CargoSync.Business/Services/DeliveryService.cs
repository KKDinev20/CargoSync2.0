using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CargoSync.DataAccess.Models;
using CargoSync.DataAccess.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using CargoSync.DataAccess.Data;

namespace CargoSync.Business.Services
{
    public class DeliveryService : IDeliveryService
    {
        private  IDeliveryRepository _deliveryRepository;
        private  CargoSyncDbContext _dbContext; 

        public DeliveryService(IDeliveryRepository deliveryRepository, CargoSyncDbContext dbContext) // Modify the constructor
        {
            _deliveryRepository = deliveryRepository;
            _dbContext = dbContext;
        }

        public async Task<List<Delivery>> GetRecentDeliveriesAsync()
        {
            return await _deliveryRepository.GetRecentDeliveriesAsync();
        }

        public List<Delivery> GetRecentOrders(int count)
        {
            return _dbContext.Deliveries
                .OrderByDescending(d => d.DeliveryID)
                .Take(count)
                .ToList();
        }

        public int GetNewPackagesCount()
        {
            return _dbContext.Deliveries.Count();
        }

        public int GetInTransitPackagesCount()
        {
            return _dbContext.Deliveries.Count(d => d.Status == "On going"); 
        }

        public int GetDeliveredPackagesCount()
        {
            return _dbContext.Deliveries.Count(d => d.Status == "Finished"); 
        }
    }
}
