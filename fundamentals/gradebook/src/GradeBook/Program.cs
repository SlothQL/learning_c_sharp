using System;
using System.Collections.Generic;

namespace GradeBook
{   
    class Program
    {
        static void Main(string[] args)
        {
            var book = new InMemoryBook("Scott's Grade Book");

            book.GradeAdded += OneGradeAdded;
            EnterGrades(book);

            var stats = book.GetStatistics();

            Console.WriteLine($"The average grade is: {stats.Average}");
            Console.WriteLine($"The highest grade is: {stats.High}");
            Console.WriteLine($"The lowest grade is: {stats.Low}");
            Console.WriteLine($"The letter grade is: {stats.Letter}");
        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {

                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                } // finally will always execute even after an error
                finally
                {
                    Console.WriteLine("**");
                }
            }
        }

        static void OneGradeAdded(object sender, EventArgs e) {
            Console.WriteLine("Grade Added");
        }
    }
}
