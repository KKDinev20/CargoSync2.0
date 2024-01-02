using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoSync.DataAccess.Models
{
    public class User
    {
        public int UserID { get; set; }
        public int DeliveryID { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
    }
}
