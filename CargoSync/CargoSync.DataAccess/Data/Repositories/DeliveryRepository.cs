using CargoSync.DataAccess.Data;
using CargoSync.DataAccess.Models;
using CargoSync.DataAccess.Data.Interfaces;

// Repository class for delivery-related data access operations
public class DeliveryRepository : IDeliveryRepository
{
    private CargoSyncDbContext _dbContext;

    // Constructor to initialize the repository with the database context
    public DeliveryRepository(CargoSyncDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    // Implementation of GetDeliveries method to retrieve a paginated list of deliveries
    public List<Delivery> GetDeliveries(int page, int pageSize)
    {
        return _dbContext.Deliveries
            .OrderBy(d => d.DeliveryId)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();
    }

    // Implementation of GetTotalDeliveriesCount method to get the total count of deliveries
    public int GetTotalDeliveriesCount()
    {
        return _dbContext.Deliveries.Count();
    }

    // Implementation of GetDeliveryById method to get a delivery by its ID
    public Delivery GetDeliveryById(int id)
    {
        return _dbContext.Deliveries.Find(id);
    }

    // Implementation of AddDelivery method to add a new delivery
    public void AddDelivery(Delivery delivery)
    {
        _dbContext.Deliveries.Add(delivery);
        _dbContext.SaveChanges();
    }

    // Implementation of DeleteDelivery method to delete a delivery by its ID
    public void DeleteDelivery(int id)
    {
        Delivery delivery = _dbContext.Deliveries.Find(id);

        if (delivery != null)
        {
            _dbContext.Deliveries.Remove(delivery);
            _dbContext.SaveChanges();
        }
    }

    // Implementation of UpdateDeliveryIds method to update the delivery IDs
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