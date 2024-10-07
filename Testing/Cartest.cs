using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;

public class Program
{
    public static void Main(string[] args)
    {
        /// Hej Martin. Af en eller anden dum årsag, virker unit test ikke hvis jeg ikke har "Public Static void Main"... Underligt!!! :(
    }
}
namespace Testing
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void TestPrice()
        {
            // Arrange
            var car = new Car();

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(240, price);
        }

        [TestMethod]
        public void TestVehicleType()
        {
            // Arrange
            var car = new Car();

            // Act
            string vehicleType = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", vehicleType);
        }
    }
}