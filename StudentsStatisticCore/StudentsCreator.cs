using System;
using System.Collections.Generic;
using System.IO;
using StudentsStatistics.Exceptions;

namespace StudentsStatistics
{
    public static class StudentsCreator
    {
        private static Student FromLine(string line)
        {
            if (line == null) throw new ArgumentNullException();
            var data = new string[] { };
            data = line.Split(';');

            return new Student(data[0], data[1], data[2], data[3], data[4]);
        }

        public static List<Student> ReadStudents(string path)
        {
            var list = new List<Student>();
            try
            {
                foreach (var line in File.ReadLines(path))
                {
                    list.Add(FromLine(line));

                }
            }
            catch(FileNotFoundException)
            {
                throw new StudentsFileDoesNotExistsException();
            }

            return list;
        }

            
    }
}
