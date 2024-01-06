using CargoSync.DataAccess.Models;

public interface IDeliveryRepository
{
    List<Delivery> GetDeliveries(int page, int pageSize);
    int GetTotalDeliveriesCount();
    Delivery GetDeliveryById(int id);

    void AddDelivery(Delivery delivery);

    void RemoveDelivery(int id);
}