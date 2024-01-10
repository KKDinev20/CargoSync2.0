using CargoSync.Business.Interfaces;
using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Models;

namespace CargoSync.Business.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await Task.Run(() => _userRepository.GetUsers());
        }
    }
}
