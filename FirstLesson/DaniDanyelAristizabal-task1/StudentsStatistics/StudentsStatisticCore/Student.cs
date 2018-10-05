using System;

namespace StudentsStatistics
{
    public class Student
    {
        public string Date { get; private set; }
        public string Name { get; private set; }
        public string Course { get; private set; }
        public string Institute { get; private set; }
        public string Dormitory { get; private set; }

        public Student(string date, string name, string course, string insitute, string dormitory)
        {
            Date = date ?? throw new ArgumentNullException();
            Name = name ?? throw new ArgumentNullException();
            Course = course ?? throw new ArgumentNullException();
            Institute = insitute ?? throw new ArgumentNullException();
            Dormitory = dormitory ?? throw new ArgumentNullException();
        }
    }
}

