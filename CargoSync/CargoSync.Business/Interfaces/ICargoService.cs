using CargoSync.DataAccess.Models;

namespace CargoSync.Business.Interfaces
{
    public interface ICargoService
    {
        public List<Cargo> GetAllCargo();
    }
}