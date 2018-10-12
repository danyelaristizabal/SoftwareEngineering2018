using System;
using System.Collections.Generic;

namespace RentCars
{
    public class CarPark
    {
        public List<string> AvaiableCars {get; set; }
        public List<Car> TotalCars { get; set; }

        public CarPark(){


            AvaiableCars = new List<string>();
            TotalCars = new List<Car>(); 

        }
        public void AddCarToPark(Car carToAdd, CarPark carPark)
        {
            carPark.TotalCars.Add(carToAdd);
        }

        public List<string> CheckDisponibilityOfCarsOnSpecificInterval(Interval Intended ){
            bool avaiable;
            for (int i = 0; i < TotalCars.Count; i++)
            {
                avaiable = true; 
                for (int j = 0; j < TotalCars[i].RentedIntervals.Count; j++)
                {

                        avaiable = TotalCars[i].RentedIntervals[j].TimeIntervalChecker(Intended); 
                        
                }
                if (avaiable == true)
                {

                    AvaiableCars.Add(TotalCars[i].Id);

                }
            }
            return AvaiableCars;


        }
        public List<string> ShowAvaiableCars(){

            for (int i = 0; i < AvaiableCars.Count; i++)
            {
                 Console.WriteLine(AvaiableCars[i]); 
            }
            return AvaiableCars; 
        } 

       

    }
}
