using CargoSync.DataAccess.Models;


namespace CargoSync.Business.Interfaces
{
    // Interface representing the abstraction of a user service
    public interface IUserService
    {
        // Returns: Task<List<User>> - Asynchronous operation that returns a list of User objects
        public Task<List<User>> GetUsersAsync();
    }
}
