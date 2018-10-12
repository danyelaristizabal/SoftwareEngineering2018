using System;
namespace RentCars
{
    public class Interval
    {

        public DateTimeOffset Date1 { get; set; }
        public DateTimeOffset Date2 { get; set; }

        public Interval(DateTimeOffset date1, DateTimeOffset date2)
        {

            Date1 = date1;
            Date2 = date2;
        }

        public bool TimeIntervalChecker(Interval IntervalToCheck )
        {
            bool Result = false; 
            if(DateTimeOffset.Compare(Date1, IntervalToCheck.Date1) > 0 && DateTimeOffset.Compare(Date1, IntervalToCheck.Date2) > 0){
                Result = true; 
            }if(DateTimeOffset.Compare(Date2, IntervalToCheck.Date1) < 0 && DateTimeOffset.Compare(Date2, IntervalToCheck.Date1) < 0)
            {
                Result = true; 
            }
            return Result; 
        }


        public Interval MaintenanceInterval(){
            Date2 = Date2.AddDays(7);
            var TenDaysInterval = new Interval(Date1, Date2);
            return TenDaysInterval;
        }
 


    }
}
