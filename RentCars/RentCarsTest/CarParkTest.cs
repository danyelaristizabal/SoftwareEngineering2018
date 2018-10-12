using System;
using Xunit;
using RentCars;
using System.Collections.Generic;

namespace RentCarsTest
{
    public class CarParkTest
    {
        [Fact]
        public void AddCarToPark()
        {
            // Arrange 
            var Admin = new AdminFacade("Daniel");
            var newCar = new Car("Red");
            var newCarPark = new CarPark();
            // Act
            Admin.AddCar(newCar, newCarPark);
            var expected = new List<Car>();
            expected.Add(newCar);
            //Asert 
            newCarPark.ShowAvaiableCars();
            Assert.True(expected[0] == newCarPark.TotalCars[0]);

        }
        [Fact]
        public void CheckDisponibilityOfCarsOnSpecificIntervalTestNotCoorrectDates(){

            //Arrange
            DateTimeOffset date1 = new DateTimeOffset(2018, 10, 1, 0, 0, 0, DateTimeOffset.Now.Offset);
            DateTimeOffset date2 = new DateTimeOffset(2018, 10, 10, 0, 0, 0, DateTimeOffset.Now.Offset);
            var firstInterval = new Interval(date1, date2);
            DateTimeOffset date3 = new DateTimeOffset(2018, 11, 11, 0, 0, 0, DateTimeOffset.Now.Offset);
            DateTimeOffset date4 = new DateTimeOffset(2018, 11, 20, 0, 0, 0, DateTimeOffset.Now.Offset);
            var secondInterval = new Interval(date3, date4);
            var Admin = new AdminFacade("Daniel");
            var newCar = new Car("Red");
            var newCarPark = new CarPark();
            newCar.RentedIntervals.Add(firstInterval); 
            //Act
            Admin.AddCar(newCar, newCarPark);
           List<string> result = newCarPark.CheckDisponibilityOfCarsOnSpecificInterval(secondInterval);
            var expected = new List<string>();
            expected.Add(newCar.Id);
            //Assert
            Assert.True(expected[0] == result[0]);
        }



    }
}
