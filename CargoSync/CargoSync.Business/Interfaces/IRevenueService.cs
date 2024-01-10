using CargoSync.DataAccess.Models;


namespace CargoSync.Business.Interfaces
{
    public interface IRevenueService
    {
        public Task<List<Revenue>> GetRevenues();
    }
}
