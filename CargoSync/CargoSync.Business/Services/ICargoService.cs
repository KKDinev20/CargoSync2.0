using CargoSync.DataAccess.Models;
using System.Collections.Generic;

namespace CargoSync.Business.Services
{
    public interface ICargoService
    {
        List<Cargo> GetAllCargo();
    }
}