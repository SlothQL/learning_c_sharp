using System;
using System.Collections.Generic;

namespace GradeBook {
    public class Book {

        public Book(string name) {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade) {
            if (grade <= 100 && grade >= 0) {
                grades.Add(grade);
            }
            else {
                Console.WriteLine("Invalid Value");
            }
        }

        public Statistics GetStatistics() {

            var result = new Statistics();
            result.Average = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;
            
            // foreach(var grade in this.grades)
            
            for(var index = 0; index < grades.Count; index++) {
                // if (number > highGrade) {
                //     highGrade = number;
                // }
                result.High = Math.Max(grades[index], result.High);
                result.Low = Math.Min(grades[index], result.Low);
                result.Average += grades[index];
            }

            result.Average /= grades.Count;

            return result;
        }
        
        private List<double> grades;
        public string Name;
    }
}