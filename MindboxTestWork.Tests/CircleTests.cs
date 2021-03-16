using System;
using Xunit;
using MindboxTestWork;

namespace MindboxTestWork.Tests
{
    // Тестирование класса Circle
    public class CircleTests
    {
        // Положительный аргумент
        [Fact]
        public void GetSquareGoodArgument()
        {
            // Arrange
            Circle circle = new Circle(1);

            // Act
            double result = circle.GetSquare();

            // Assert
            Assert.Equal(3.141592653589793, result);
        }

        // Положительный аргумент №2
        [Fact]
        public void GetSquareGoodArgument2()
        {
            // Arrange
            Circle circle = new Circle(10);

            // Act
            double result = circle.GetSquare();

            // Assert
            Assert.Equal(314.1592653589793, result);
        }

        // Нулевой аргумент
        [Fact]
        public void GetSquareZeroArgument()
        {
            // Arrange
            Circle circle = new Circle(0);

            // Act
            double result = circle.GetSquare();

            // Assert
            Assert.Equal(0, result);
        }

        // Отрицательный аргумент
        [Fact]
        public void GetSquareMinusArgument()
        {
            // Arrange and Act
            Action result = () => new Circle(-1);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentOutOfRangeException>(result);
        }
    }
}
