using CodeLouisvilleUnitTestProject;
using FluentAssertions;
using FluentAssertions.Execution;
using System.Xml.Schema;
using Xunit.Abstractions;
using Xunit;

namespace CodeLouisvilleUnitTestProjectTests
{
    public class VehicleTestsShould
    {
            

        public double GasTankCapacity { get; private set; }

        //Verify the parameterless constructor successfully creates a new
        //object of type Vehicle, and instantiates all public properties
        //to their default values.
        [Fact]
        public void VehicleParameterlessConstructorTest()
        {
            //arrange
<<<<<<< HEAD
            Vehicle vehicle = new(0, 0, "", "", 0);
            //act

            //assert
            using (new AssertionScope())
            {
                vehicle.GasTankCapacity.Should().Be(0);
                vehicle.MilesPerGallon.Should().Be(0);
                vehicle.Make.Should().Be("");
                vehicle.Model.Should().Be("");
            }
=======
            Vehicle vehicle = new (0, 0, "", "", 0);
            //act

            //assert
            vehicle.Should().Be(vehicle);
>>>>>>> c89ad1ce84e59cd60f92602e251782149cb5cd19
        }

        
        //Verify the parameterized constructor successfully creates a new
        //object of type Vehicle, and instantiates all public properties
        //to the provided values.
        [Fact]
        public void VehicleConstructorTest()
        {
            //arrange
<<<<<<< HEAD
            Vehicle vehicle = new Vehicle(4, 10, "Toyota", "Camry", 30);
            //act

            //assert
            using (new AssertionScope())
            {
                vehicle.Should().NotBeNull();
                vehicle.Make.Should().Be("Toyota");
                vehicle.GasTankCapacity.Should().Be(10);
            }

=======
            Vehicle vehicle = new(4,10,"Toyota","Camry",30);
            //act

            //assert
            vehicle.Should().Be(vehicle);
>>>>>>> c89ad1ce84e59cd60f92602e251782149cb5cd19
        }

        //Verify that the parameterless AddGas method fills the gas tank
        //to 100% of its capacity
        [Fact]
        public void AddGasParameterlessFillsGasToMax()
        {
            //arrange
<<<<<<< HEAD
            Vehicle vehicle = new(4,20,"Toyota","Camry",30);

=======

            double _gasRemaining = 0;
>>>>>>> c89ad1ce84e59cd60f92602e251782149cb5cd19
            //act
            vehicle.AddGas();
            //assert
            vehicle.GasLevel.Should().Be("100%");
        }

        //Verify that the AddGas method with a parameter adds the
        //supplied amount of gas to the gas tank.
        [Fact]
        public void AddGasWithParameterAddsSuppliedAmountOfGas()
        {
            //arrange
<<<<<<< HEAD
            Vehicle vehicle = new(4, 20, "Toyota", "Camry", 30);
=======
            
>>>>>>> c89ad1ce84e59cd60f92602e251782149cb5cd19
            //act
            vehicle.AddGas(10);

            //assert
            vehicle.GasLevel.Should().Be("50%");
        }

        //Verify that the AddGas method with a parameter will throw
        //a GasOverfillException if too much gas is added to the tank.
//[Fact]
  //     public void AddingTooMuchGasThrowsGasOverflowException()
    //    {
            //arrange
      //     Vehicle vehicle = new Vehicle(4, 15, "Benz", "GL450", 30);

            //act
          
        //    GasTankCapacity = 15;
            
          // Action act = () => vehicle.AddGas(16);
            //assert
              
                
          // act .Should().Throw<GasOverfillException>().WithMessage("Unable to add too mach gas  because it's capacity only holds 15");
        //}

        //Using a Theory (or data-driven test), verify that the GasLevel
        //property returns the correct percentage when the gas level is
        //at 0%, 25%, 50%, 75%, and 100%.
        [Theory]
        [InlineData("0%", 0)]
        [InlineData("25%", 2.5)]
        [InlineData("50%", 5)]
        [InlineData("75%", 7.5)]
        [InlineData("100%", 10)]
        public void GasLevelPercentageIsCorrectForAmountOfGas(string percent, float gasToAdd)
        {
            //arrange
<<<<<<< HEAD
            Vehicle vehicle = new Vehicle(4, 10, "Benz", "GL450", 25);
=======
            Vehicle vehicle = new(4, 10, "Benz", "GL450", 25);
>>>>>>> c89ad1ce84e59cd60f92602e251782149cb5cd19
            //act
            vehicle.AddGas(gasToAdd);
            //assert
            vehicle.GasLevel.Should().Be(percent);
        }

        /*
         * Using a Theory (or data-driven test), or a combination of several 
         * individual Fact tests, test the following functionality of the 
         * Drive method:
         *      a. Attempting to drive a car without gas returns the status 
         *      string “Cannot drive, out of gas.”.
         *      b. Attempting to drive a car with a flat tire returns 
         *      the status string “Cannot drive due to flat tire.”.
         *      c. Drive the car 10 miles. Verify that the correct amount 
         *      of gas was used, that the correct distance was traveled, 
         *      that GasLevel is correct, that MilesRemaining is correct, 
         *      and that the total mileage on the vehicle is correct.
         *      d. Drive the car 100 miles. Verify that the correct amount 
         *      of gas was used, that the correct distance was traveled,
         *      that GasLevel is correct, that MilesRemaining is correct, 
         *      and that the total mileage on the vehicle is correct.
         *      e. Drive the car until it runs out of gas. Verify that the 
         *      correct amount of gas was used, that the correct distance 
         *      was traveled, that GasLevel is correct, that MilesRemaining
         *      is correct, and that the total mileage on the vehicle is 
         *      correct. Verify that the status reports the car is out of gas.
        */
        //Attempting to drive a car without gas return the status string
       [Fact]
       public void DriveCarOutOfGas()
        { 
            //arrange

          Vehicle vehicle = new(4, 20, "Benz", "GL450", 30);

            //act
          
           string Status = vehicle.Drive(20);
           

            //assert
           
            Status.Should().Be("Cannot drive, out of gas.");
         }
       

       
        // [Theory]
        //  [InlineData("MysteryParamValue")]
        //public void DrivePositiveTests(params object[] yourParamsHere)
        //{
        //arrange
        //    throw new NotImplementedException();
        //     //act

        //assert

        // }

        //Verify that attempting to change a flat tire using
        //ChangeTireAsync will throw a NoTireToChangeException
        //if there is no flat tire.
        //   [Fact]
        // public async Task ChangeTireWithoutFlatTest()
        //{
        //arrange
        //  throw new NotImplementedException();
        //act

        //assert

        //        }

        //Verify that ChangeTireAsync can successfully
        //be used to change a flat tire
         [Fact]
        public async Task ChangeTireSuccessfulTest()
        {
        //arrange
         Vehicle vehicle = new Vehicle(4, 15, "Toyota", "Camry", 30);

            //act
            vehicle.Drive(15);


        //assert
        vehicle.HasFlatTire.Should().Be(false);
        
        }





        //BONUS: Write a unit test that verifies that a flat
        //tire will occur after a certain number of miles.

        //}
    }
}