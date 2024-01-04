using CargoSync.DataAccess.Data;
using CargoSync.DataAccess.Models;

public class DeliveryRepository : IDeliveryRepository
{
    private readonly CargoSyncDbContext _context;

    public DeliveryRepository(CargoSyncDbContext context)
    {
        _context = context;
    }

    public List<Delivery> GetDeliveries(int page, int pageSize)
    {
        return _context.Deliveries
            .OrderBy(d => d.DeliveryID)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();
    }

    public int GetTotalDeliveriesCount()
    {
        return _context.Deliveries.Count();
    }

    public void AddDelivery(Delivery delivery)
    {
        _context.Deliveries.Add(delivery);
        _context.SaveChanges();
    }

    public void RemoveDelivery(int deliveryId)
    {
        var delivery = _context.Deliveries.Find(deliveryId);

        if (delivery != null)
        {
            _context.Deliveries.Remove(delivery);
            _context.SaveChanges();
        }
    }
}