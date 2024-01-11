using CargoSync.DataAccess.Models;

namespace CargoSync.Business.Interfaces
{
    // Interface representing the abstraction of a cargo service
    public interface ICargoService
    {
        //Encapsulation
        public List<Cargo> GetAllCargo();
    }
}