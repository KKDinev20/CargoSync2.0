using CargoSync.DataAccess.Models;
using System.Collections.Generic;
using CargoSync.Business.Interfaces;
using CargoSync.DataAccess.Data.Interfaces;

namespace CargoSync.Business.Services
{
    public class CargoService : ICargoService
    {
        private readonly ICargoRepository _cargoRepository;

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