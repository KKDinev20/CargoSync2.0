using CargoSync.Business.Services;
using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Models;

namespace CargoSync.Tests
{
    [TestFixture]
    public class UserServiceTests
    {
        [Test]
        public async Task GetUsersAsync_ShouldReturnUserList()
        {
            // Arrange
            Mock<IUserRepository> mockRepository = new Mock<IUserRepository>();
            List<User> users = new List<User> { new User { UserId = 1, UserName = "TestUser", UserType = "Customer"} };

            mockRepository.Setup(repo => repo.GetUsers())
                          .Returns(users);

            UserService userService = new UserService(mockRepository.Object);

            // Act
            List<User> result = await userService.GetUsersAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<List<User>>(result);
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].UserName, Is.EqualTo("TestUser"));
        }

        [Test]
        public async Task GetUsersAsync_ShouldReturnEmptyListWhenNoUsers()
        {
            // Arrange
            Mock<IUserRepository> mockRepository = new Mock<IUserRepository>();
            mockRepository.Setup(repo => repo.GetUsers())
                          .Returns(new List<User>());

            UserService userService = new UserService(mockRepository.Object);

            // Act
            List<User> result = await userService.GetUsersAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsEmpty(result);
        }

        [Test]
        public void GetUsersAsync_ShouldReturnUserListSynchronously()
        {
            // Arrange
            Mock<IUserRepository> mockRepository = new Mock<IUserRepository>();
            List<User> users = new List<User> { new User { UserId = 1, UserName = "TestUser" } };

            mockRepository.Setup(repo => repo.GetUsers())
                          .Returns(users);

            UserService userService = new UserService(mockRepository.Object);

            // Act
            List<User> result = userService.GetUsersAsync().GetAwaiter().GetResult();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<List<User>>(result);
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].UserName, Is.EqualTo("TestUser"));
        }

        [Test]
        public void Constructor_ShouldThrowArgumentNullException_WhenUserRepositoryIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new UserService(null));
        }

        [Test]
        public async Task GetUsersAsyncShouldPropagateRepositoryException()
        {
            // Arrange
            Mock<IUserRepository> mockRepository = new Mock<IUserRepository>();
            mockRepository.Setup(repo => repo.GetUsers())
                          .Throws(new Exception());

            UserService userService = new UserService(mockRepository.Object);

            // Act & Assert
            Assert.ThrowsAsync<Exception>(async () => await userService.GetUsersAsync());
        }
    }
}
