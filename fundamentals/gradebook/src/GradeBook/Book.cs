using System;
using System.Collections.Generic;

namespace GradeBook {
    class Book {

        public Book(string name) {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade) {
           grades.Add(grade);
        }

        public void ShowStatistics() {

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var number in this.grades) {
                // if (number > highGrade) {
                //     highGrade = number;
                // }
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }

            var average = result / grades.Count;

            Console.WriteLine($"The average grade is: {average:N1}");
            Console.WriteLine($"The highest grade is: {highGrade}");
            Console.WriteLine($"The lowest grade is: {lowGrade}");
        }
        
        private List<double> grades;
        private string name;
    }
}