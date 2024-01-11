using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Models;

// Repository class for user-related data access operations
namespace CargoSync.DataAccess.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private CargoSyncDbContext _dbContext;

        // Constructor to initialize the repository with the database context
        public UserRepository(CargoSyncDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Implementation of GetUsers method to retrieve a list of users
        public List<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }
    }
}
