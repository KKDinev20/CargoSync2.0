using CargoSync.DataAccess.Models;

namespace CargoSync.DataAccess.Data.Interfaces
{
    // Interface for delivery-related data access operations
    public interface IDeliveryRepository
    {
        // Declaration of the GetDeliveries method to retrieve a list of deliveries with pagination
        List<Delivery> GetDeliveries(int page, int pageSize);

        // Declaration of the GetTotalDeliveriesCount method to retrieve the total count of deliveries
        int GetTotalDeliveriesCount();

        // Declaration of the GetDeliveryById method to retrieve a specific delivery by its id
        Delivery GetDeliveryById(int id);

        // Declaration of the AddDelivery method to add a new delivery

        void AddDelivery(Delivery delivery);

        // Declaration of the DeleteDelivery method to delete a delivery by its id
  
        void DeleteDelivery(int id);

        // Declaration of the UpdateDeliveryIds method to update delivery ids (if needed)
        void UpdateDeliveryIds();
    }
}
