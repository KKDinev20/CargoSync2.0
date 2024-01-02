using CargoSync.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoSync.Business.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetUsersAsync();
    }
}
