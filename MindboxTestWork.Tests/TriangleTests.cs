using System;
using Xunit;
using MindboxTestWork;

namespace MindboxTestWork.Tests
{
    public class TriangleTests
    {
        // Положительный аргумент
        [Fact]
        public void GetSquareGoodArgument()
        {
            // Arrange
            GeometricFigure figure = new Triangle(4, 3, 6);

            // Act
            double result = figure.GetSquare();

            // Assert
            Assert.Equal(5.332682251925386, result);
        }

        // Треугольник с заданными сторонами не существует (сторона А больше других)
        [Fact]
        public void NonexistentTriangleArgAMore()
        {
            // Arrange and Act
            Action result = () => new Triangle(6, 2, 3);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(result);
        }

        // Треугольник с заданными сторонами не существует (сторона B больше других)
        [Fact]
        public void NonexistentTriangleArgBMore()
        {
            // Arrange and Act
            Action result = () => new Triangle(12, 20, 5);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(result);
        }

        // Треугольник с заданными сторонами не существует (сторона C больше других)
        [Fact]
        public void NonexistentTriangleArgCMore()
        {
            // Arrange and Act
            Action result = () => new Triangle(1, 2, 3);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(result);
        }

        // Аргумент а отрицательный
        [Fact]
        public void ArgumntAIsNegative()
        {
            // Arrange and Act
            Action result = () => new Triangle(-4, 3, 6);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentOutOfRangeException>(result);
        }

        // Аргумент b отрицательный
        [Fact]
        public void ArgumntBIsNegative()
        {
            // Arrange and Act
            Action result = () => new Triangle(4, -3, 6);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentOutOfRangeException>(result);
        }

        // Аргумент c отрицательный
        [Fact]
        public void ArgumntCIsNegative()
        {
            // Arrange and Act
            Action result = () => new Triangle(4, 3, -6);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentOutOfRangeException>(result);
        }

        // Все аргументы отрицательные
        [Fact]
        public void ArgumntsIsNegative()
        {
            // Arrange and Act
            Action result = () => new Triangle(-4, -3, -6);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentOutOfRangeException>(result);
        }

        // Аргумент а равен 0
        [Fact]
        public void ArgumntAIsZero()
        {
            // Arrange and Act
            Action result = () => new Triangle(0, 3, 6);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentOutOfRangeException>(result);
        }

        // Аргумент b равен 0
        [Fact]
        public void ArgumntBIsZero()
        {
            // Arrange and Act
            Action result = () => new Triangle(4, 0, 6);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentOutOfRangeException>(result);
        }

        // Аргумент c равен 0
        [Fact]
        public void ArgumntCIsZero()
        {
            // Arrange and Act
            Action result = () => new Triangle(4, 3, 0);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentOutOfRangeException>(result);
        }

        // Все аргументы равны 0
        [Fact]
        public void ArgumntsIsZero()
        {
            // Arrange and Act
            Action result = () => new Triangle(0, 0, 0);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentOutOfRangeException>(result);
        }

        // Треугольник прямоугольный
        [Fact]
        public void IsRectangular()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            // Act
            bool result = triangle.IsRectangular();

            // Assert
            Assert.True(result);
        }

        // Треугольник не прямоугольный
        [Fact]
        public void IsNotRectangular()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 7, 8);

            // Act
            bool result = triangle.IsRectangular();

            // Assert
            Assert.False(result);
        }
    }
}
