using CargoSync.DataAccess.Models;

namespace CargoSync.DataAccess.Data.Interfaces
{
    // Interface for revenue-related data access operations
    public interface IRevenueRepository
    {
        // Declaration of the GetRevenues method to retrieve a list of revenues
        List<Revenue> GetRevenues();
    }
}
