using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Tests
{
    public class StudentTests
    {
        [TestCase(new int[] { 2, 2, 2, 2 }, ExpectedResult = 2)]
        [TestCase(new int[] { 7, 9, 8, 9 }, ExpectedResult = 8)]
        [TestCase(new int[] { 5, 10 }, ExpectedResult = 7)]
        public int GetAverage_CorrectData_ReturnsResult(int[] marks)
        {
            //Arrange
            var student = new Student();

            //Act
            return student.GetAverage(marks);
        }

        [Test]
        public void GetAverage_WrongData_ThrowsException()
        {
            //Arrange
            var student = new Student();

            //Act
            Assert.Throws<ArgumentException>(() => student.GetAverage(new int[] { }));
        }
    }
}
