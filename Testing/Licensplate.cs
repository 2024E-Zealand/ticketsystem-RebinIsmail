using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;

namespace Testing
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void TestCarLicensePlate_ThrowsException()
        {
            // Arrange
            var car = new Car();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => car.Licenseplate = "ABCD23232", "Nummerpladen skal være mindst 8 tegn");
        }

        [TestMethod]
        public void TestMCLicensePlate_ThrowsException()
        {
            // Arrange
            var mc = new MC();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => mc.Licenseplate = "12345678", "Nummerpladen mindst 8 tegn...tak!");
        }
    }
}