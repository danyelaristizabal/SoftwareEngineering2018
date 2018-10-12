using System;
using RentCars;
using Xunit;
namespace RentCarsTest
{
    public class IntervalLogicTest
    {
        [Fact]
        public void TimeIntervalInterfereTest()
        {
            // Arrange 
            DateTimeOffset date1 = new DateTimeOffset(2018, 10, 1, 0, 0, 0, DateTimeOffset.Now.Offset);
            DateTimeOffset date2 = new DateTimeOffset(2018, 10, 10, 0, 0, 0, DateTimeOffset.Now.Offset);
            var firstInterval = new Interval(date1, date2);
            DateTimeOffset date3 = new DateTimeOffset(2018, 10, 3, 0, 0, 0, DateTimeOffset.Now.Offset);
            DateTimeOffset date4 = new DateTimeOffset(2018, 10, 20, 0, 0, 0, DateTimeOffset.Now.Offset);
            var secondInterval = new Interval(date3, date4);
            // Act
            bool result = firstInterval.TimeIntervalChecker(secondInterval);
            // Assert 
            Assert.False(result);
        }
        [Fact]
        public void AddMaintainanceInterval( ){
            // Arrange 
            DateTimeOffset date1 = new DateTimeOffset(2018, 10, 1, 0, 0, 0, DateTimeOffset.Now.Offset);
            DateTimeOffset date2 = new DateTimeOffset(2018, 10, 10, 0, 0, 0, DateTimeOffset.Now.Offset);
            var firstInterval = new Interval(date1, date2);
            //Act
            firstInterval.MaintenanceInterval();
            DateTimeOffset expected = new DateTimeOffset(2018, 10, 17, 0, 0, 0, DateTimeOffset.Now.Offset);
            //Assert
            bool result; 
            if(expected == firstInterval.Date2){
                result = true; 
            }else{
                result = false;
            }
            Assert.True(result);


        }
    }
}