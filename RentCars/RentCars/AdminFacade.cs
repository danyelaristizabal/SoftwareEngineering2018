using System;
namespace RentCars
{
    public class AdminFacade
    {
        string Name { get;  } 
        public AdminFacade(string name)
        {
            Name = name;
        }
        public void AddCar(Car car, CarPark carPark)
        {
            carPark.AddCarToPark(car, carPark);
        }
        public Rent CreateNewRent(Car rentedcar, Costumer costumerrenting, Interval rentedinterval)
        {
            var NewRent = new Rent(rentedcar, costumerrenting, rentedinterval);
            return NewRent; 
        }
    }
}
