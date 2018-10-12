using System;
using System.Collections.Generic;

namespace RentCars
{
    public class Costumer
    {
        public string CostumerID { get; }
        public List<string> RentHistory { get; set;  } 
        public List<Interval> Rents { get; set;  }

        public Costumer(string costumerid)
        {
            CostumerID = costumerid;
            RentHistory = new List<string>();
            Rents = new List<Interval>(); 
         }

        public void ShowCostumerHistory(){
            for (int i = 0; i < RentHistory.Count; i++)
            {
                Console.WriteLine(RentHistory[i]);
            }
        } 

    }
}
