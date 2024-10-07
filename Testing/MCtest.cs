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


        [TestMethod]
        public void TestMCDate()
        {
            // Arrange
            var mc = new MC();
            DateTime expectedDate = new DateTime(2020, 10, 1);

            // Act
            mc.Date = expectedDate;
            DateTime actualDate = mc.Date;

            // Assert
            Assert.AreEqual(expectedDate, actualDate);
        }
    }



}