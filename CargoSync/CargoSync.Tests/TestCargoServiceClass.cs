using CargoSync.Business.Services;
using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Models;
using Moq;

namespace CargoSync.Tests
{
    [TestFixture]
    public class CargoServiceTests
    {

        [Test]
        public void GetAllCargoShouldReturnCorrectResults()
        {
            // Arrange
            Mock<ICargoRepository> mockRepository = new Mock<ICargoRepository>();
            List<Cargo> cargos = new List<Cargo>
            {
                new Cargo { CargoId = 1, Description = "Cargo1", Quantity = 10 },
                new Cargo { CargoId = 2, Description = "Cargo2", Quantity = 20 }
            };

            mockRepository.Setup(repo => repo.GetAllCargo())
                          .Returns(() =>
                          {
                              Thread.Sleep(100);
                              return new List<Cargo>(cargos);
                          });

            CargoService cargoService = new CargoService(mockRepository.Object);

            // Act
            List<Cargo> result1 = null;
            List<Cargo> result2 = null;

            Thread thread1 = new Thread(() => result1 = cargoService.GetAllCargo());
            Thread thread2 = new Thread(() => result2 = cargoService.GetAllCargo());

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            // Assert
            Assert.IsNotNull(result1);
            Assert.IsNotNull(result2);
            Assert.That(result1.Count, Is.EqualTo(cargos.Count));
            Assert.That(result2.Count, Is.EqualTo(cargos.Count));
        }

        [Test]
        public void GetAllCargoShouldNotInterfereWithEachOther()
        {
            // Arrange
            Mock<ICargoRepository> mockRepository = new Mock<ICargoRepository>();
            List<Cargo> cargos1 = new List<Cargo>
            {
                new Cargo { CargoId = 1, DeliveryId = 1, Description = "Cargo1", Quantity = 10 }
            };
            List<Cargo> cargos2 = new List<Cargo>
            {
                new Cargo { CargoId = 2, DeliveryId = 2, Description = "Cargo2", Quantity = 20 }
            };

            mockRepository.SetupSequence(repo => repo.GetAllCargo())
                          .Returns(cargos1)
                          .Returns(cargos2);

            CargoService cargoService = new CargoService(mockRepository.Object);

            // Act
            List<Cargo>? result1 = null;
            List<Cargo>? result2 = null;

            Thread thread1 = new Thread(() => result1 = cargoService.GetAllCargo());
            Thread thread2 = new Thread(() => result2 = cargoService.GetAllCargo());

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            // Assert
            Assert.IsNotNull(result1);
            Assert.IsNotNull(result2);
            Assert.That(result1.Count, Is.EqualTo(cargos1.Count));
            Assert.That(result2.Count, Is.EqualTo(cargos2.Count));
        }


        [Test]
        public void GetAllCargo_ShouldHandleEmptyRepository()
        {
            // Arrange
            Mock<ICargoRepository> mockRepository = new Mock<ICargoRepository>();
            mockRepository.Setup(repo => repo.GetAllCargo())
                          .Returns(new List<Cargo>());

            CargoService cargoService = new CargoService(mockRepository.Object);

            // Act
            List<Cargo> result = cargoService.GetAllCargo();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsEmpty(result);
        }

        [Test]
        public void GetAllCargoShouldHandleExceptionFromRepository()
        {
            // Arrange
            Mock<ICargoRepository> mockRepository = new Mock<ICargoRepository>();
            mockRepository.Setup(repo => repo.GetAllCargo())
                          .Throws(new Exception()); 

            CargoService cargoService = new CargoService(mockRepository.Object);

            // Act & Assert
            Assert.Throws<Exception>(() => cargoService.GetAllCargo());
        }

        [Test]
        public void GetAllCargo_ConcurrentAccess_ShouldReturnDistinctResults()
        {
            // Arrange
            Mock<ICargoRepository> mockRepository = new Mock<ICargoRepository>();
            List<Cargo> cargos1 = new List<Cargo>
            {
                new Cargo { CargoId = 1, DeliveryId = 1, Description = "Cargo1", Quantity = 10 }
            };
            List<Cargo> cargos2 = new List<Cargo>
            {
                new Cargo { CargoId = 2, DeliveryId = 2, Description = "Cargo2", Quantity = 20 }
            };

            mockRepository.SetupSequence(repo => repo.GetAllCargo())
                          .Returns(cargos1)
                          .Returns(cargos2);

            CargoService cargoService = new CargoService(mockRepository.Object);

            // Act
            List<Cargo> result1 = null;
            List<Cargo> result2 = null;

            Thread thread1 = new Thread(() => result1 = cargoService.GetAllCargo());
            Thread thread2 = new Thread(() => result2 = cargoService.GetAllCargo());

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            // Assert
            Assert.IsNotNull(result1);
            Assert.IsNotNull(result2);
            Assert.That(result2, Is.Not.EqualTo(result1));
        }

    }
}
