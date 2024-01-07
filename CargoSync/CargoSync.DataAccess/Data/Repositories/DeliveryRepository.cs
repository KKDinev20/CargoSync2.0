// In DataAccess.Data.Repositories namespace
using System.Linq;
using CargoSync.DataAccess.Data.Repositories;
using CargoSync.DataAccess.Data;
using CargoSync.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

public class DeliveryRepository : IDeliveryRepository
{
    private readonly CargoSyncDbContext _dbContext;

    public DeliveryRepository(CargoSyncDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Delivery> GetDeliveries(int page, int pageSize)
    {
        return _dbContext.Deliveries
            .OrderBy(d => d.DeliveryID)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();
    }

    public int GetTotalDeliveriesCount()
    {
        return _dbContext.Deliveries.Count();
    }

    public Delivery GetDeliveryById(int id)
    {
        return _dbContext.Deliveries.Find(id);
    }

    public void AddDelivery(Delivery delivery)
    {
        _dbContext.Deliveries.Add(delivery);
        _dbContext.SaveChanges();
    }

    public void DeleteDelivery(int id)
    {
        var delivery = _dbContext.Deliveries.Find(id);

        if (delivery != null)
        {
            _dbContext.Deliveries.Remove(delivery);
            _dbContext.SaveChanges();
        }
    }

    public void UpdateDeliveryIds()
    {
        var deliveries = _dbContext.Deliveries.OrderBy(d => d.DeliveryID).ToList();

        for (int i = 0; i < deliveries.Count; i++)
        {
            deliveries[i].DeliveryID = i + 1;
        }

        _dbContext.SaveChanges();
    }
}
