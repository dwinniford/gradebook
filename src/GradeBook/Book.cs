using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class Book
    {       
        public Book(string owner = "Grant") {
            grades = new List<double>();
            Owner = owner;
        }
        public void AddGrade(double n) {
            grades.Add(n);
        }
        public void AddGrades(List<double> arr) {
            foreach (var item in arr)
            {
                AddGrade(item);
            }
        }
        public double HighGrade() {
            double highGrade = double.MinValue;
            foreach (var item in grades)
            {
                highGrade = Math.Max(item, highGrade);
            }
            return highGrade;
        }
        public double LowGrade() {
            double lowGrade = double.MaxValue;
            foreach (var item in grades)
            {
                lowGrade = Math.Min(item, lowGrade);
            }
            return lowGrade;
        }
        public double Sum() {
            var sum = 0.0;
            foreach (var n in grades) 
            {
                sum += n;
            }
            return sum;
        }
        public double Average() {
            return Sum() / grades.Count;
        }

        public string Report() {
            return $"Hello Professor {Owner}! the sum is {Sum()}. average is {Average():N1}. Highest grade is {HighGrade()}. Lowest grade is {LowGrade()}.";
        }
        public Statistics GetStatistics() {
            var result = new Statistics(this);
            return result;
        }
        public string Owner;
        List<double> grades;

    }
    
}