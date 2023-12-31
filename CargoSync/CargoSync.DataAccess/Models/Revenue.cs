using System;

namespace CargoSync.DataAccess.Models
{
    public class Revenue
    {
        public int RevenueID { get; set; } 
        public int TransactionID { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        public Delivery Delivery { get; set; }
    }
}
