using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {   

        [Fact]
        public void Test() {
            var x = GetInt();

            Assert.Equal(3, x);
        }   

        private int GetInt() {
            return 3;
        }

        [Fact]
        public void CSharpCanPassedByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookAndSetName(out book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookAndSetName(out Book book, string name) {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassedByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name) {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameForReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);

        }

        private void SetName(Book book, string name) {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

        [Fact]
        public void TwoVariablesCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            //Assert.Equal("Book 1", book1.Name);
            //Assert.Equal("Book 1", book2.Name);
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name) {
            return new Book(name);
        }
    }
}
