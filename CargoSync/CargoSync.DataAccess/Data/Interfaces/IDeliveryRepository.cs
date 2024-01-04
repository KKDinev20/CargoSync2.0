using CargoSync.DataAccess.Models;

public interface IDeliveryRepository
{
    List<Delivery> GetDeliveries(int page, int pageSize);
    int GetTotalDeliveriesCount();
    void AddDelivery(Delivery delivery);
    void RemoveDelivery(int deliveryId);
}