using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAveraegeGrade()
        {
            ////arrange - put together test data and objects and values youa re going to use
            var book = new Book(""); //Book is in a different project so we need to tell this project to look in the other GradeBook project
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            // // act - invoke a method to perform a computation or calculation to produce a result
            var result = book.GetStatistics();
            
            // //assert - assert something about the value that was computed
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal(90.5, result.High, 1);
        
        }
    }
}
