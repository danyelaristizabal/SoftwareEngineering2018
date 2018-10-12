using System;
using System.Collections.Generic;

namespace RentCars
{
    public class Car
    {
        public string Id { get; }
        public int RentCounter { get; set; }
        public List<Interval> RentedIntervals { get; set; }

        public Car(string id)
        {
            Id = id;
            RentCounter = new int();
            RentedIntervals = new List<Interval>(); 
        }
        public bool CheckMaintenance()
        {
            bool Maintenance; 
            if (RentCounter <= 10)
            {
                Maintenance = true; 
                return Maintenance;
            }
            else
            {
                Maintenance = false;
                return Maintenance;
            }
        }

        public void DoMaintenance(Interval Dayofstart)
        {
            Dayofstart.MaintenanceInterval();
            RentedIntervals.Add(Dayofstart);


        }

        public bool Disponibility(Interval IntentionalInterval)
        {

            bool Disponible = true;

            for (int i = 0; i < RentedIntervals.Count; i++)
            {
                if (RentedIntervals[i].TimeIntervalChecker(IntentionalInterval) != true)
                {

                    return Disponible = false;

                }

            }

            return Disponible;


        }

    }

}
