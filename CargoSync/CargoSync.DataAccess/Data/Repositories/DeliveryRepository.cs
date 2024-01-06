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

    public Delivery GetDeliveryById(int id)
    {
        return _context.Deliveries.Find(id);
    }

    public void AddDelivery(Delivery delivery)
    {
        _context.Deliveries.Update(delivery);
        _context.SaveChanges();
    }

    public void RemoveDelivery(int id)
    {
        var delivery = _context.Deliveries.Find(id);
        if (delivery != null)
        {
            _context.Deliveries.Remove(delivery);
            _context.SaveChanges();
        }
    }
}