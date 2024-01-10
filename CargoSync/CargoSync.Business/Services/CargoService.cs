using CargoSync.DataAccess.Models;
using CargoSync.Business.Interfaces;
using CargoSync.DataAccess.Data.Interfaces;

namespace CargoSync.Business.Services
{
    public class CargoService : ICargoService
    {
        private ICargoRepository _cargoRepository;

        public CargoService(ICargoRepository cargoRepository)
        {
            _cargoRepository = cargoRepository; 
        }

        public List<Cargo> GetAllCargo()
        {
            return _cargoRepository.GetAllCargo();
        }
    }
}