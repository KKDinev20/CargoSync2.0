using CargoSync.DataAccess.Models;
using System.Collections.Generic;

namespace CargoSync.Business.Interfaces
{
    public interface ICargoService
    {
        List<Cargo> GetAllCargo();
    }
}