using System;
using RentCars;
using Xunit;

namespace RentCarsTest
{

    public class CarTest
    {

        [Fact]
        public void CheckMaintenance()
        {
            // Arrange 
            var newCar = new Car("Red");
            // Act
            DateTimeOffset date1 = new DateTimeOffset(2018, 11, 1, 0, 0, 0, DateTimeOffset.Now.Offset);
            DateTimeOffset date2 = new DateTimeOffset(2018, 11, 10, 0, 0, 0, DateTimeOffset.Now.Offset);
            var firstInterval = new Interval(date1, date2);
            newCar.RentCounter = newCar.RentCounter + 10;
            bool result =  newCar.CheckMaintenance();
            bool expected = true;
            //Asert 
            Assert.True(result == expected); 
        }



    }
}
