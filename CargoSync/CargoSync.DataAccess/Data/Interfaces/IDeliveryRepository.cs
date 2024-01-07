// In DataAccess.Data.Repositories namespace
using CargoSync.DataAccess.Models;
using System.Collections.Generic;

namespace CargoSync.DataAccess.Data.Repositories
{
    public interface IDeliveryRepository
    {
        List<Delivery> GetDeliveries(int page, int pageSize);
        int GetTotalDeliveriesCount();
        Delivery GetDeliveryById(int id);
        void AddDelivery(Delivery delivery);
        void DeleteDelivery(int id);
        void UpdateDeliveryIds();
    }
}
