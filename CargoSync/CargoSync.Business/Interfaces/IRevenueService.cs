using CargoSync.DataAccess.Models;


namespace CargoSync.Business.Interfaces
{
    public interface IRevenueService
    {
        Task<List<Revenue>> GetRevenues();
    }
}
