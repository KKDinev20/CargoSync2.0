using CargoSync.DataAccess.Models;


namespace CargoSync.Business.Interfaces
{
    public interface IUserService
    {
        public Task<List<User>> GetUsersAsync();
    }
}
