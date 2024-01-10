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
            var mockRepository = new Mock<ICargoRepository>();
            var cargos = new List<Cargo>
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

            var cargoService = new CargoService(mockRepository.Object);

            // Act
            List<Cargo> result1 = null;
            List<Cargo> result2 = null;

            var thread1 = new Thread(() => result1 = cargoService.GetAllCargo());
            var thread2 = new Thread(() => result2 = cargoService.GetAllCargo());

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
            var mockRepository = new Mock<ICargoRepository>();
            var cargos1 = new List<Cargo>
            {
                new Cargo { CargoId = 1, DeliveryId = 1, Description = "Cargo1", Quantity = 10 }
            };
            var cargos2 = new List<Cargo>
            {
                new Cargo { CargoId = 2, DeliveryId = 2, Description = "Cargo2", Quantity = 20 }
            };

            mockRepository.SetupSequence(repo => repo.GetAllCargo())
                          .Returns(cargos1)
                          .Returns(cargos2);

            var cargoService = new CargoService(mockRepository.Object);

            // Act
            List<Cargo>? result1 = null;
            List<Cargo>? result2 = null;

            var thread1 = new Thread(() => result1 = cargoService.GetAllCargo());
            var thread2 = new Thread(() => result2 = cargoService.GetAllCargo());

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
            var mockRepository = new Mock<ICargoRepository>();
            mockRepository.Setup(repo => repo.GetAllCargo())
                          .Returns(new List<Cargo>());

            var cargoService = new CargoService(mockRepository.Object);

            // Act
            var result = cargoService.GetAllCargo();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsEmpty(result);
        }

        [Test]
        public void GetAllCargoShouldHandleExceptionFromRepository()
        {
            // Arrange
            var mockRepository = new Mock<ICargoRepository>();
            mockRepository.Setup(repo => repo.GetAllCargo())
                          .Throws(new Exception()); 

            var cargoService = new CargoService(mockRepository.Object);

            // Act & Assert
            Assert.Throws<Exception>(() => cargoService.GetAllCargo());
        }

        [Test]
        public void GetAllCargo_ConcurrentAccess_ShouldReturnDistinctResults()
        {
            // Arrange
            var mockRepository = new Mock<ICargoRepository>();
            var cargos1 = new List<Cargo>
            {
                new Cargo { CargoId = 1, DeliveryId = 1, Description = "Cargo1", Quantity = 10 }
            };
            var cargos2 = new List<Cargo>
            {
                new Cargo { CargoId = 2, DeliveryId = 2, Description = "Cargo2", Quantity = 20 }
            };

            mockRepository.SetupSequence(repo => repo.GetAllCargo())
                          .Returns(cargos1)
                          .Returns(cargos2);

            var cargoService = new CargoService(mockRepository.Object);

            // Act
            List<Cargo> result1 = null;
            List<Cargo> result2 = null;

            var thread1 = new Thread(() => result1 = cargoService.GetAllCargo());
            var thread2 = new Thread(() => result2 = cargoService.GetAllCargo());

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
