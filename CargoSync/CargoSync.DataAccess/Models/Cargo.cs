namespace CargoSync.DataAccess.Models
{
    public class Cargo
    {
        public int CargoId { get; set; }
        public int DeliveryId { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
    }
}