using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoSync.DataAccess.Models
{
    public class Delivery
    {
        public int DeliveryID { get; set; }
        public string Destination { get; set; }
        public string ETA { get; set; }
        public string Status { get; set; }

    }
}
