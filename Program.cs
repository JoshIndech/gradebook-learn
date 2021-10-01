using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // testestse
            var book = new Book("Josh's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.1);
            book.AddGrade(77.5);
            book.GetStatistics();

            var stats = book.GetStatistics();
            
            Console.WriteLine($"The highest grade is {stats.High:N1}");
            Console.WriteLine($"The lowest grade is {stats.Low:N1}");
            Console.WriteLine($"The Average grade is {stats.Average:N1}");
        }
    }
}