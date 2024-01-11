using CargoSync.Business.Interfaces;
using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Models;

namespace CargoSync.Business.Services
{
    // Class implementing the IUserService interface to manage user-related operations
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        // Constructor accepting IUserRepository dependency
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // Implementation of the GetUsersAsync method specified in the IUserService interface
        public async Task<List<User>> GetUsersAsync()
        {
            // Using Task.Run to execute the synchronous method asynchronously
            return await Task.Run(() => _userRepository.GetUsers());
        }
    }
}
