using CargoSync.DataAccess.Data;
using CargoSync.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoSync.DataAccess.Data.Repositories
{
    public class DeliveryRepository : IDeliveryRepository
    {
        private readonly CargoSyncDbContext _context;

        public DeliveryRepository(CargoSyncDbContext context)
        {
            _context = context;
        }

        public async Task<List<Delivery>> GetRecentDeliveriesAsync()
        {
            return await _context.Deliveries
                                   .OrderByDescending(d => d.ETA)
                                   .Take(5)
                                   .ToListAsync();
        }
    }
}