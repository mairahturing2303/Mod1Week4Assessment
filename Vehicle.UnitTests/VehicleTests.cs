using System.Drawing;

namespace Vehicle.UnitTests
{
    public class VehicleTests
    {
        [Fact]
        public void WhenCreated_HasCorrectProperties()
        {
            Vehicle megansCar = new Vehicle(4, "Green");

            Assert.Equal(4, megansCar.NumberOfWheels);
            Assert.Equal("Green", megansCar.Color);
            Assert.Equal(0, megansCar.MilesDriven);
        }

        // This test needs some work!
        [Fact]
        public void Summary_ReturnsInfoAboutVehicle()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");

            var expected = "This Blue vehicle has 2 wheels and has driven 0 miles";


        }

        [Fact]

        public void  Drive_AddsFiveMilesToMilesDriven()
        {
           

            var expected = 5;

        }

        [Fact]


        public void Paint_ChangesColorOfCar()
        {
            var expected = "blue" ;
        }
    }
}