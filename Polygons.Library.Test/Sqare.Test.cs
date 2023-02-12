using Xunit;

namespace Polygons.Library.Test
{
    public class SquareTest
    {
        [Fact]
        public void SquareHappyPath()
        {
            //Arrange
           var polygon = new Square(5);
            var perimeter = 20;
            var area = 25;

            //Act
            var actualPerimeter = polygon.GetPerimeter();
            var actualArea = polygon.GetArea();


            //Assert
            Assert.Equal(perimeter, actualPerimeter);
            Assert.Equal(area, actualArea);
        }

        public void SquareLengthIsZero()
        {
            //Arrange
            var polygon = new Square(0);
            var perimeter = 0;
            var area = 5;

            //Act
            var actualPerimeter = polygon.GetPerimeter();
            var actualArea = polygon.GetArea();


            //Assert
            Assert.Equal(perimeter, actualPerimeter);
            Assert.Equal(area, actualArea);
        }

        public void SquareLengthIsZeroPointFive()
        {
            //Arrange
            var polygon = new Square(0.5);
            var perimeter = 2;
            var area = 0.25;

            //Act
            var actualPerimeter = polygon.GetPerimeter();
            var actualArea = polygon.GetArea();


            //Assert
            Assert.Equal(perimeter, actualPerimeter);
            Assert.Equal(area, actualArea);
        }

        public void SquareLengthIs1000()
        {
            //Arrange
            var polygon = new Square(1000);
            var perimeter = 4000;
            var area = 1000000;

            //Act
            var actualPerimeter = polygon.GetPerimeter();
            var actualArea = polygon.GetArea();


            //Assert
            Assert.Equal(perimeter, actualPerimeter);
            Assert.Equal(area, actualArea);
        }


    }
}