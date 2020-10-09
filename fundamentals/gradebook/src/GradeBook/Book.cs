using System;
using System.Collections.Generic;

namespace GradeBook {
    public class Book {

        public Book(string name) {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade) {
           grades.Add(grade);
        }

        public Statistics GetStatistics() {

            var result = new Statistics();
            result.Average = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;

            foreach(var grade in this.grades) {
                // if (number > highGrade) {
                //     highGrade = number;
                // }
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }

            result.Average /= grades.Count;

            return result;
        }
        
        private List<double> grades;
        private string name;
    }
}