using CargoSync.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CargoSync.DataAccess.Data.Repositories
{
    public interface IDeliveryRepository
    {
        Task<List<Delivery>> GetRecentDeliveriesAsync();
    }
}