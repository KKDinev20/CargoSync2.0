using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoSync.DataAccess.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CargoSyncDbContext _dbContext;

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
