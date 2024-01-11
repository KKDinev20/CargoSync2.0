using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Models;

// Repository class for revenue-related data access operations
namespace CargoSync.DataAccess.Data.Repositories
{
    public class RevenueRepository : IRevenueRepository
    {
        private CargoSyncDbContext _dbContext;

        // Constructor to initialize the repository with the database context
        public RevenueRepository(CargoSyncDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Implementation of GetRevenues method to retrieve a list of revenues
        public List<Revenue> GetRevenues()
        {
            return _dbContext.Revenue.ToList();
        }
    }
}
