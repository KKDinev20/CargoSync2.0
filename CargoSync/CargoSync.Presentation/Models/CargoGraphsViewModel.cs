using CargoSync.DataAccess.Models;

namespace CargoSync.Presentation.Models
{
    public class CargoGraphsViewModel
    {
        public List<Cargo> Cargos { get; set; }
        public List<Revenue> Revenues { get; set; }
        public List<User> Users { get; set; }
    }
}
