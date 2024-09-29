using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;

namespace Testing 
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void TestCarLicensePlate()
        {
            // Arrange
            var car = new Car();
            string longLicensePlate = "ABCDEFGHI"; // indeholder 9 characters

            // Act & Assert
            var exception = Assert.ThrowsException<ArgumentException>(() => car.Licenseplate = longLicensePlate);
            Assert.AreEqual("Nummerpladen må ikke overstige 7 tegn.", exception.Message);
        }

        [TestMethod]
        public void TestMCLicensePlateLength_ThrowsException()
        {
            // Arrange
            var mc = new MC();
            string longLicensePlate = "12345678"; // indeholder 8 characters

            // Act & Assert
            var exception = Assert.ThrowsException<ArgumentException>(() => mc.Licenseplate = longLicensePlate);
            Assert.AreEqual("Nummerpladen må ikke overstige 7 tegn.", exception.Message);
        }
    }
}