using System;
using RentCars;
using Xunit;
namespace RentCarsTest
{
    public class RentTest
    {
        [Fact]
        public void CreateRentTest()
        {
            // Arrange 
            DateTimeOffset date1 = new DateTimeOffset(2018, 10, 1, 0, 0, 0, DateTimeOffset.Now.Offset);
            DateTimeOffset date2 = new DateTimeOffset(2018, 10, 10, 0, 0, 0, DateTimeOffset.Now.Offset);
            var firstInterval = new Interval(date1, date2);
            var newCar = new Car("Red");
            var NewCostumer = new Costumer("CostumerName");
            // Act
            var NewRent = new Rent(newCar, NewCostumer, firstInterval);
            bool result = false;
            if(NewRent.RentedCar.Id == "Red" && NewRent.CostumerRenting.CostumerID == "CostumerName"){
                result = true;
            }
            bool expected = true; 
            //Asert 
            Assert.True(result == expected);
        }
    }
}
