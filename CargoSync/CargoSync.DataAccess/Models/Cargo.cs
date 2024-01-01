namespace CargoSync.DataAccess.Models
{
    public class Cargo
    {
        public int CargoID { get; set; }
        public int DeliveryID { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}