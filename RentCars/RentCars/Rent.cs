using System;
namespace RentCars
{
    public class Rent
    {
        public Car RentedCar { set; get; }
        public Costumer CostumerRenting { set; get; }
        public Interval RentedInterval { get; set; }

        public Rent(Car rentedcar, Costumer costumerrenting, Interval rentedinterval)
        {

            RentedCar = rentedcar;
            CostumerRenting = costumerrenting;
            RentedInterval = rentedinterval;

            if (RentedCar.Disponibility(RentedInterval) & RentedCar.CheckMaintenance())
            {
                CostumerRenting.Rents.Add(RentedInterval);
                CostumerRenting.RentHistory.Add(RentedCar.Id);
                RentedCar.RentCounter++;

            }
            if (RentedCar.CheckMaintenance() == false)
            {
                RentedCar.DoMaintenance(RentedInterval);
                Console.WriteLine("Cannot rent this car is going to Maintenance");
            }else {
                Console.WriteLine("Can not rent this car, it is going to Maintenance");

            } 
        }
    }
}
