using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Models;

namespace CargoSync.DataAccess.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private CargoSyncDbContext _dbContext;

        public UserRepository(CargoSyncDbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        public List<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }
    }
}
