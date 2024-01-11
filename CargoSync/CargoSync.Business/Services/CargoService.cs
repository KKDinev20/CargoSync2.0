using CargoSync.DataAccess.Models;
using CargoSync.Business.Interfaces;
using CargoSync.DataAccess.Data.Interfaces;

namespace CargoSync.Business.Services
{
    // Class implementing the ICargoService interface to manage cargo-related operations
    public class CargoService : ICargoService
    {
        private ICargoRepository _cargoRepository;

        // Constructor accepting an ICargoRepository dependency for data access
        public CargoService(ICargoRepository cargoRepository)
        {
            _cargoRepository = cargoRepository;
        }

        // Returns: List<Cargo> - List of cargo objects retrieved from the repository
        public List<Cargo> GetAllCargo()
        {
            return _cargoRepository.GetAllCargo();
        }
    }
}
