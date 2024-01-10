using CargoSync.DataAccess.Models;

namespace CargoSync.DataAccess.Data.Interfaces
{
    public interface ICargoRepository
    {
        public List<Cargo> GetAllCargo();
    }
}
