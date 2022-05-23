using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesStats()
        {
            var book = new Book();
            book.AddGrade(45);
            book.AddGrade(55);
            book.AddGrade(50);
            var results = book.GetStatistics();
            Assert.Equal(45, results.low);
            Assert.Equal(55, results.high);
            Assert.Equal(50, results.average);
        }
        [Fact]
        public void BookValidatesGrade()
        {
            var book = new Book();
            book.AddGrade(25);
            book.AddGrade(103);
            Assert.Equal(1, book.Count());
        }
    }
}
