using CodeLouisvilleUnitTestProject;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace CodeLouisvilleUnitTestProjectTests
{
    public class CarTests
    {
        [Fact]
        public void NewCarIsAVehicleAndHas4TiresTest()
        {
            Car car = new( 4, 30, "Honda", "Odessey", 20);

            car.NumberOfTires.Should().Be(4);
        }
    }
}
