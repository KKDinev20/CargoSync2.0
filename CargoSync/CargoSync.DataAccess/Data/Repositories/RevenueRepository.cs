using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Models;

namespace CargoSync.DataAccess.Data.Repositories
{
    public class RevenueRepository : IRevenueRepository
    {
        private CargoSyncDbContext _dbContext;

        public RevenueRepository(CargoSyncDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Revenue> GetRevenues()
        {
            return _dbContext.Revenue.ToList();
        }
    }
}
