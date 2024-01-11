using CargoSync.DataAccess.Models;

namespace CargoSync.DataAccess.Data.Interfaces
{
    // Interface for cargo-related data access operations
    public interface ICargoRepository
    {
        // Declaration of the GetAllCargo method to retrieve a list of all cargo items
        List<Cargo> GetAllCargo();
    }
}
