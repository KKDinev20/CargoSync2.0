using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CargoSync.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using CargoSync.DataAccess.Data;
using CargoSync.Business.Interfaces;
using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Data.Repositories;

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

        public List<Delivery> GetRecentOrders(int count)
        {
            return _dbContext.Deliveries
                .OrderByDescending(d => d.DeliveryID)
                .Take(count)
                .ToList();
        }

        public List<Delivery> GetOrders()
        {
            return _dbContext.Deliveries
                .OrderByDescending(d => d.DeliveryID)
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
