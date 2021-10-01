using System;
using System.Collections.Generic;

namespace GradeBook
{ 
    public class Book //with no access modifier, internal is default
    {
        public Book(string name) //example of a constructor
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach(var grade in grades) // This is a loop
            {
                result.Low = Math.Min(grade , result.Low); 
                result.High = Math.Max(grade , result.High);
                result.Average += grade;
            };
            result.Average /= grades.Count;

            return result;
        }


        private List<double> grades; //example of a field
        public string Name; //another example of a field?
        
    }
}

    