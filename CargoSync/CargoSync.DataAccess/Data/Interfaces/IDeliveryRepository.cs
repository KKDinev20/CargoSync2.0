using CargoSync.DataAccess.Models;


namespace CargoSync.DataAccess.Data.Interfaces
{
    public interface IDeliveryRepository
    {
        public List<Delivery> GetDeliveries(int page, int pageSize);
        public int GetTotalDeliveriesCount();
        public Delivery GetDeliveryById(int id);
        public void AddDelivery(Delivery delivery);
        public void DeleteDelivery(int id);
        public void UpdateDeliveryIds();
    }
}
