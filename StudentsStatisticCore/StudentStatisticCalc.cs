using System.Collections.Generic;
using StudentsStatistics.Views;
using System;
using StudentsStatistics.Exceptions;

namespace StudentsStatistics
{
    public class StudentStatisticCalc
    {
        public StatisticView CountInDorm(List<Student> studentsList)
        {
            if (studentsList == null) throw new ArgumentNullException();
            if (studentsList.Count == 0) throw new StudentsListIsEmptyException(); 
            var indorm = new int[] { };
            var result = new StatisticView();

            foreach (var element in studentsList)
            {

                result.Total++;
                if (element.Course == "1 бакалавриат" && element.Dormitory == "Да")
                {
                    result.FirstCourse++;

                }
                if (element.Course == "2 бакалавриат" && element.Dormitory == "Да")
                {
                    result.SecondCourse++;

                }
                if (element.Course == "3 бакалавриат" && element.Dormitory == "Да")
                {
                    result.ThirdCourse++;
                }
            }

            return result;
        }
    }
}
