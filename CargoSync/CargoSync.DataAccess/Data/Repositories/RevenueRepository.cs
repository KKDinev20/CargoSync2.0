using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoSync.DataAccess.Data.Repositories
{
    public class RevenueRepository : IRevenueRepository
    {
        private readonly CargoSyncDbContext _dbContext;

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
