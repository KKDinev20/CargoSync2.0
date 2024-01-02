using CargoSync.DataAccess.Data;
using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace CargoSync.DataAccess.Repositories
{
    public class CargoRepository : ICargoRepository
    {
        private readonly CargoSyncDbContext _context;

        public CargoRepository(CargoSyncDbContext context)
        {
            _context = context;
        }

        public List<Cargo> GetAllCargo()
        {
            return _context.Cargos.ToList();
        }
    }
}