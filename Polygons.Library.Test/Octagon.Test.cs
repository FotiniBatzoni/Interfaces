using Xunit;

namespace Polygons.Library.Test
{
    public class OctagonTest
    {
        [Fact]
        public void OctagonHappyPath()
        {
            //Arrange
           var polygon = new Octagon(5);
            var perimeter = 120.71067811865474;
            var area = 40;

            //Act
            var actualPerimeter = polygon.GetPerimeter();
            var actualArea = polygon.GetArea();


            //Assert
            Assert.Equal(perimeter, actualPerimeter);
            Assert.Equal(area, actualArea);
        }

        public void OctagonLengthIsZero()
        {
            //Arrange
            var polygon = new Octagon(0);
            var perimeter = 0;
            var area = 0;

            //Act
            var actualPerimeter = polygon.GetPerimeter();
            var actualArea = polygon.GetArea();


            //Assert
            Assert.Equal(perimeter, actualPerimeter);
            Assert.Equal(area, actualArea);
        }

        public void OctagonLengthIsZeroPointFive()
        {
            //Arrange
            var polygon = new Octagon(0.5);
            var perimeter = 4;
            var area = 1.20710678118655;

            //Act
            var actualPerimeter = polygon.GetPerimeter();
            var actualArea = polygon.GetArea();


            //Assert
            Assert.Equal(perimeter, actualPerimeter);
            Assert.Equal(area, actualArea);
        }

        public void OctagonLengthIs1000()
        {
            //Arrange
            var polygon = new Octagon(1000);
            var perimeter = 8000;
            var area = 4828427.12474619;

            //Act
            var actualPerimeter = polygon.GetPerimeter();
            var actualArea = polygon.GetArea();


            //Assert
            Assert.Equal(perimeter, actualPerimeter);
            Assert.Equal(area, actualArea);
        }


    }
}