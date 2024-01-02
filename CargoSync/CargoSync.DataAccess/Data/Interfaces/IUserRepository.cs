using CargoSync.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoSync.DataAccess.Data.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetUsers();
    }

}
