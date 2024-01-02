using CargoSync.DataAccess.Models;
using System.Collections.Generic;

namespace CargoSync.DataAccess.Data.Interfaces
{
    public interface ICargoRepository
    {
        List<Cargo> GetAllCargo();
    }
}
