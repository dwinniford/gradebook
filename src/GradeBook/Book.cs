using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class Book
    {       
        // changes i don't want in test 1 branch
        public Book(string owner = "Grant") {
            grades = new List<double>();
            Owner = owner;
        }
        public void AddGrade(double n) {
            if(n <= 100 && n >= 0)
            {
                grades.Add(n);
            } else 
            {
                Console.WriteLine("invalid grade was not added.");
            }

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
        public int Count() {
            return grades.Count;
        }

        public string Report() {
            var result = GetStatistics();
            return $"Hello Professor {Owner}! average is {result.average:N1}. Highest grade is {result.high}. Lowest grade is {result.low}.";
        }
        public Statistics GetStatistics() {
            var result = new Statistics(this);
            result.low = double.MaxValue;
            result.high = double.MinValue;
            result.average = 0.0;
            result.sum = 0;
            result.count = grades.Count;

            // var index = 0;
            // while (index < grades.Count)
            // {
            //     result.low = Math.Min(grades[index], result.low);
            //     result.high = Math.Max(grades[index], result.high);
            //     result.sum += grades[index];
            //     index ++;
            // }; 
            for (int i = 0; i < grades.Count; i++)
            {
                result.low = Math.Min(grades[i], result.low);
                result.high = Math.Max(grades[i], result.high);
                result.sum += grades[i];
            }
            result.average = result.sum / result.count;
            return result;
        }
        public string Owner;
        List<double> grades;

    }
    
}