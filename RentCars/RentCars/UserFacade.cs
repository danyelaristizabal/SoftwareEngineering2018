using System;
namespace RentCars
{
    public class UserFacade
    {
        public Costumer Costumer { get; }

        public UserFacade(Costumer costumer)
        {
            Costumer = costumer;
        }
        public void ShowCostumerHistory(){

            Costumer.ShowCostumerHistory(); 

        }
        public Rent CreateNewRent(Car rentedcar, Costumer costumerrenting, Interval rentedinterval)
        {
            var NewRent = new Rent(rentedcar, costumerrenting, rentedinterval);
            return NewRent;
        }

    }
}
