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

            _ = car.NumberOfTires.Should().Be(4);
        }
        [Fact]
        public void WasModelMadeInYearAsyncNegativeTest()
        {
            Car car = new(4, 30, "Honda", "Odessey", 20);

            Action act= () =>  car.WasModelMadeInYearAsync(1993);

            act.Should().Throw<ArgumentException>().WithMessage("No data is available for years before 1995");
        }
    }
}
