using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void CsharpCanPassByRef()
        {
           var book1 = GetBook("QiFu");
          GetBookSetName(ref book1, "FaZhou");
          Assert.Equal("FaZhou", book1.Owner);
        }

        [Fact]
        public void ChangesName()
        {
           var book1 = GetBook("QiFu");
          ChangeName(book1, "FaZhou");
          Assert.Equal("FaZhou", book1.Owner);
        }
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
           var book1 = GetBook("QiFu");
           var book2 = GetBook("FaZhou");
           Assert.Equal("QiFu", book1.Owner);
           Assert.Equal("FaZhou", book2.Owner);
        }
        [Fact]
        public void VariablesReferenceSameObject()
        {
           var book1 = GetBook("QiFu");
           var book2 = book1;
           Assert.Same(book1, book2);
           Assert.True(Object.ReferenceEquals(book1, book2));
           
        }
        internal Book GetBook(string owner) {
            return new Book(owner);
        }   
        internal void ChangeName(Book book, string name) {
            book.Owner = name;
        }
        internal void GetBookSetName(ref Book book, string owner) {
            book = new Book(owner);
        }
    }
}
