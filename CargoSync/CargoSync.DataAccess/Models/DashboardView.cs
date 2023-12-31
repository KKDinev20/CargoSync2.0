using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoSync.DataAccess.Models
{
    public class DashboardView
    {
        public List<Delivery> Deliveries { get; set; }
        public List<Revenue> Revenues { get; set; }
        public int NewPackagesCount { get; set; }
        public int InTransitCount { get; set; }
        public int DeliveredCount { get; set; }
    }
}
