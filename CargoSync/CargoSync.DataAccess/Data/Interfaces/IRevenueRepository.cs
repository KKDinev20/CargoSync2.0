using CargoSync.DataAccess.Models;

namespace CargoSync.DataAccess.Data.Interfaces
{
    public interface IRevenueRepository
    {
        public List<Revenue> GetRevenues();
    }
}
