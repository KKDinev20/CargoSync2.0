using CargoSync.DataAccess.Models;

namespace CargoSync.DataAccess.Data.Interfaces
{
    public interface IUserRepository
    {
        public List<User> GetUsers();
    }

}
