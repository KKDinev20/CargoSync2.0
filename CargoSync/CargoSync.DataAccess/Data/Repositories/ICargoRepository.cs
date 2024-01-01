using CargoSync.DataAccess.Models;
using System.Collections.Generic;

namespace CargoSync.DataAccess.Repositories
{
    public interface ICargoRepository
    {
        List<Cargo> GetAllCargo();
    }
}
