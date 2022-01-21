using System;
using System.Collections.Generic;
// using GradeBook.Book;

namespace GradeBook
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Book book;
            if(args.Length > 0){
                book = new Book(args[0]);
            } else {
                book = new Book();
            }

            var grades = new List<double>() {6, 13.2, 14.3, 65.1}; 
            book.AddGrades(grades);
            Console.WriteLine(book.Report());
        }
    }
}
