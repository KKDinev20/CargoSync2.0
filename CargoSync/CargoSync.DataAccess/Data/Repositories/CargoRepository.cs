using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Models;

namespace CargoSync.DataAccess.Data.Repositories
{
    // Repository class for cargo-related data access operations
    public class CargoRepository : ICargoRepository
    {
        private CargoSyncDbContext _context;

        // Constructor to initialize the repository with the database context
        public CargoRepository(CargoSyncDbContext context)
        {
            _context = context;
        }

        // Implementation of the GetAllCargo method to retrieve all cargo items
        public List<Cargo> GetAllCargo()
        {
            return _context.Cargos.ToList();
        }
    }
}
