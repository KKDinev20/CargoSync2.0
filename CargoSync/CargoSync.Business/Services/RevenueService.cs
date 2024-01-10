using CargoSync.Business.Interfaces;
using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Models;

namespace CargoSync.Business.Services
{
    public class RevenueService : IRevenueService
    {
        private IRevenueRepository _revenueRepository;

        public RevenueService(IRevenueRepository revenueRepository)
        {
            _revenueRepository = revenueRepository;
        }

        public async Task<List<Revenue>> GetRevenues()
        {
            return await Task.Run(() => _revenueRepository.GetRevenues());
        }
    }
}
