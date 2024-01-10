using CargoSync.DataAccess.Data;
using CargoSync.DataAccess.Models;
using CargoSync.DataAccess.Data.Interfaces;

public class DeliveryRepository : IDeliveryRepository
{
    private CargoSyncDbContext _dbContext;

    public DeliveryRepository(CargoSyncDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Delivery> GetDeliveries(int page, int pageSize)
    {
        return _dbContext.Deliveries
            .OrderBy(d => d.DeliveryId)
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
        Delivery delivery = _dbContext.Deliveries.Find(id);

        if (delivery != null)
        {
            _dbContext.Deliveries.Remove(delivery);
            _dbContext.SaveChanges();
        }
    }

    public void UpdateDeliveryIds()
    {
        List<Delivery> deliveries = _dbContext.Deliveries.OrderBy(d => d.DeliveryId).ToList();

        for (int i = 0; i < deliveries.Count; i++)
        {
            deliveries[i].DeliveryId = i + 1;
        }

        _dbContext.SaveChanges();
    }
}
