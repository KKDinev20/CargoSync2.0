using CargoSync.Business.Interfaces;
using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Models;

namespace CargoSync.Business.Services
{
    // Class implementing the IRevenueService interface to manage revenue-related operations
    public class RevenueService : IRevenueService
    {
        private IRevenueRepository _revenueRepository;

        // Constructor accepting IRevenueRepository dependency
        public RevenueService(IRevenueRepository revenueRepository)
        {
            _revenueRepository = revenueRepository;
        }

        // Implementation of the GetRevenues method specified in the IRevenueService interface
        public async Task<List<Revenue>> GetRevenues()
        {
            // Using Task.Run to execute the synchronous method asynchronously
            return await Task.Run(() => _revenueRepository.GetRevenues());
        }
    }
}
