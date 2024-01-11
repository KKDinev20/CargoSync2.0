using CargoSync.DataAccess.Models;


namespace CargoSync.Business.Interfaces
{
    // Interface representing the abstraction of a revenue service
    public interface IRevenueService
    {
        // Returns: Task<List<Revenue>> - Asynchronous operation that returns a list of Revenue objects
        public Task<List<Revenue>> GetRevenues();
    }
}
