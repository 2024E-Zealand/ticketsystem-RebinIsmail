using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;

namespace Testing 
{
    [TestClass]
    public class MCTest
    {
        [TestMethod]
        public void TestPrice()
        {
            // Arrange
            var mc = new MC();

            // Act
            double price = mc.Price();

            // Assert
            Assert.AreEqual(125, price);
        }

        [TestMethod]
        public void TestVehicleType()
        {
            // Arrange
            var mc = new MC();

            // Act
            string vehicleType = mc.VehicleType();

            // Assert
            Assert.AreEqual("MC", vehicleType);
        }
    }
}