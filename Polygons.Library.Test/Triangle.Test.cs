using Xunit;

namespace Polygons.Library.Test
{
    public class TriangleTest
    {
        [Fact]
        public void TriangleHappyPath()
        {
            //Arrange
           var polygon = new Triangle(5);
            var perimeter = 15;
            var area = 10.825317547305483;

            //Act
            var actualPerimeter = polygon.GetPerimeter();
            var actualArea = polygon.GetArea();


            //Assert
            Assert.Equal(perimeter, actualPerimeter);
            Assert.Equal(area, actualArea);
        }

        public void TriangleLengthIsZero()
        {
            //Arrange
            var polygon = new Triangle(0);
            var perimeter = 0;
            var area = 5;

            //Act
            var actualPerimeter = polygon.GetPerimeter();
            var actualArea = polygon.GetArea();


            //Assert
            Assert.Equal(perimeter, actualPerimeter);
            Assert.Equal(area, actualArea);
        }

        public void TriangleLengthIsZeroPointFive()
        {
            //Arrange
            var polygon = new Triangle(0.5);
            var perimeter = 1.5;
            var area = 0.108253175473055;

            //Act
            var actualPerimeter = polygon.GetPerimeter();
            var actualArea = polygon.GetArea();


            //Assert
            Assert.Equal(perimeter, actualPerimeter);
            Assert.Equal(area, actualArea);
        }

        public void TriangleLengthIs1000()
        {
            //Arrange
            var polygon = new Triangle(1000);
            var perimeter = 3000;
            var area = 433012.701892219;

            //Act
            var actualPerimeter = polygon.GetPerimeter();
            var actualArea = polygon.GetArea();


            //Assert
            Assert.Equal(perimeter, actualPerimeter);
            Assert.Equal(area, actualArea);
        }


    }
}