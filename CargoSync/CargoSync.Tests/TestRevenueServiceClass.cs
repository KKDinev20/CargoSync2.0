using CargoSync.Business.Services;
using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Models;

namespace CargoSync.Tests
{
    [TestFixture]
    public class RevenueServiceTests
    {
        [Test]
        public async Task TestGetRevenuesAsync_ShouldReturnRevenueList()
        {
            // Arrange
            Mock<IRevenueRepository> mockRepository = new Mock<IRevenueRepository>();
            List<Revenue> revenues = new List<Revenue> { new Revenue { RevenueId = 1, Amount = 100.50M, Month = "January" } };

            mockRepository.Setup(repo => repo.GetRevenues())
                          .Returns(revenues);

            RevenueService revenueService = new RevenueService(mockRepository.Object);

            // Act
            List<Revenue> result = await revenueService.GetRevenues();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<List<Revenue>>(result);
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].Amount, Is.EqualTo(100.50M));
            Assert.That(result[0].Month, Is.EqualTo("January"));
        }

        [Test]
        public async Task TestGetRevenuesAsync_ShouldReturnEmptyListWhenNoRevenues()
        {
            // Arrange
            Mock<IRevenueRepository> mockRepository = new Mock<IRevenueRepository>();
            mockRepository.Setup(repo => repo.GetRevenues())
                          .Returns(new List<Revenue>());

            RevenueService revenueService = new RevenueService(mockRepository.Object);

            // Act
            List<Revenue> result = await revenueService.GetRevenues();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsEmpty(result);
        }

        [Test]
        public void TestConstructor_ShouldThrowArgumentNullException_WhenRevenueRepositoryIsNull()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentNullException>(() => new RevenueService(null));
        }

        [Test]
        public async Task TestGetRevenuesAsync_ShouldPropagateRepositoryException()
        {
            // Arrange
            Mock<IRevenueRepository> mockRepository = new Mock<IRevenueRepository>();
            mockRepository.Setup(repo => repo.GetRevenues())
                          .Throws(new Exception()); // Replace with an appropriate exception type

            RevenueService revenueService = new RevenueService(mockRepository.Object);

            // Act & Assert
            Assert.ThrowsAsync<Exception>(async () => await revenueService.GetRevenues());
        }

        [Test]
        public void TestGetRevenuesAsyncShouldReturnDistinctResultsForConcurrentAccess()
        {
            // Arrange
            Mock<IRevenueRepository> mockRepository = new Mock<IRevenueRepository>();
            List<Revenue> revenues1 = new List<Revenue> { new Revenue { RevenueId = 1, Amount = 100.50M, Month = "January" } };
            List<Revenue> revenues2 = new List<Revenue> { new Revenue { RevenueId = 2, Amount = 200.75M, Month = "February" } };

            mockRepository.SetupSequence(repo => repo.GetRevenues())
                          .Returns(revenues1)
                          .Returns(revenues2);

            RevenueService revenueService = new RevenueService(mockRepository.Object);

            // Act
            List<Revenue> result1 = null;
            List<Revenue> result2 = null;

            var thread1 = new Task(() => result1 = revenueService.GetRevenues().GetAwaiter().GetResult());
            var thread2 = new Task(() => result2 = revenueService.GetRevenues().GetAwaiter().GetResult());

            thread1.Start();
            thread2.Start();

            Task.WaitAll(thread1, thread2);

            // Assert
            Assert.IsNotNull(result1);
            Assert.IsNotNull(result2);
            Assert.That(result2, Is.Not.EqualTo(result1));
        }
    }
}
