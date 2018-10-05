using System;
using StudentsStatistics;

namespace StudentsStatisticsConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //  var path = Console.ReadLine();
            var path = "/Users/danielaristizabaljaramillo/Desktop/SE/StudentsStatistics/StudentsStatistics/bin/Debug/Тестирование.csv"; 
            var loadedStudents = StudentsCreator.ReadStudents(path);

            var studentsStat = new StudentStatisticCalc();

            var result = studentsStat.CountInDorm(loadedStudents);

            Console.WriteLine($"1: {result.FirstCourse} 2: {result.SecondCourse} 3: {result.ThirdCourse} total: {result.Total}");
        }
    }
}
