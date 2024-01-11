using CargoSync.DataAccess.Models;

namespace CargoSync.DataAccess.Data.Interfaces
{
    // Interface for user-related data access operations
    public interface IUserRepository
    {
        // Declaration of the GetUsers method to retrieve a list of users
        List<User> GetUsers();
    }
}
