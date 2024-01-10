using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Models;


namespace CargoSync.DataAccess.Data.Repositories
{
    public class CargoRepository : ICargoRepository
    {
        private CargoSyncDbContext _context;

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