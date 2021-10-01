using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        { 
            var x = GetInt();

            Assert.Equal(3, x);  
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
         public void CSharpCanPassByRef() //default is always to pass by value
        {
            // arrange and act - put together test data and objects and values youa re going to use invoke a method to perform a computation or calculation to produce a result
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name"); //ref and out are key words are used for pass by reference. for out, CSharp assumes the reference has not been initialized....
            
            //assert - assert something about the value that was computed
            Assert.Equal("New Name",book1.Name);
        }

        private void GetBookSetName(ref Book book, string name) // It hink this is reducdant code
        {
            book = new Book(name);
        }

        [Fact]
         public void CSharpIsPassByValue() //default is always to pass by value
        {
            // arrange and act - put together test data and objects and values youa re going to use invoke a method to perform a computation or calculation to produce a result
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");
            
            //assert - assert something about the value that was computed
            Assert.Equal("Book 1",book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
            book.Name = name;
        }

        [Fact]
         public void CanSetNameFromReference()
        {
            // arrange and act - put together test data and objects and values youa re going to use invoke a method to perform a computation or calculation to produce a result
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");
            
            //assert - assert something about the value that was computed
            Assert.Equal("New Name",book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            // arrange and act - put together test data and objects and values youa re going to use invoke a method to perform a computation or calculation to produce a result
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            
            //assert - assert something about the value that was computed
            Assert.Equal("Book 1",book1.Name);
            Assert.Equal("Book 2",book2.Name);
            Assert.NotSame(book1, book2);
        }
        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            // arrange and act - put together test data and objects and values youa re going to use invoke a method to perform a computation or calculation to produce a result
            var book1 = GetBook("Book 1");
            var book2 = book1;
            
            //assert - assert something about the value that was computed
            Assert.Same(book1,book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
            Assert.Equal("Book 1",book1.Name);
            Assert.Equal("Book 1",book2.Name);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
        //
    }
}
