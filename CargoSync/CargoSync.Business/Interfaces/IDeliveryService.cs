using CargoSync.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CargoSync.Business.Interfaces
{
    public interface IDeliveryService
    {
        List<Delivery> GetRecentOrders(int count);

        int GetNewPackagesCount();
        int GetInTransitPackagesCount();
        int GetDeliveredPackagesCount();

    }
}