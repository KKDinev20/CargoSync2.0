using System.ComponentModel.DataAnnotations;

namespace CargoSync.DataAccess.Models
{
    public class Delivery
    {
        public int DeliveryId { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z]+-[A-Za-z]+$", ErrorMessage = "Destination must be in the format 'From-To'")]
        public string? Destination { get; set; }

        [Required]
        [RegularExpression(@"^([01]?[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$", ErrorMessage = "ETA must be in the format 'HH:MM:SS'")]
        public string? ETA { get; set; }

        [Required]
        [RegularExpression("^(On going|Delivered|Delayed)$", ErrorMessage = "Status must be 'On Going', 'Delivered', or 'Delayed'")]
        public string? Status { get; set; }
    }
}
