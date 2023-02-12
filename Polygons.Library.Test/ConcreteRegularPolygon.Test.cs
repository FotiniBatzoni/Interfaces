using Xunit;

namespace Polygons.Library.Test
{
    public class ConcreteRegularPolygonTest
    {
        [Fact]
        public void ConcreteRegularPolygonHappyPath()
        {
            //Arrange
           var polygon = new ConcreteRegularPolygon(3,5);
            var expected = 15;

            //Act
            var actual = polygon.GetPerimeter();

            //Assert
            Assert.Equal(expected, actual);
        }

        public void ConcreteRegularPolygonLengthIsZero()
        {
            //Arrange
            var polygon = new ConcreteRegularPolygon(3, 0);
            var expected = 0;

            //Act
            var actual = polygon.GetPerimeter();

            //Assert
            Assert.Equal(expected, actual);
        }

        public void ConcreteRegularPolygonLengthIsZeroPointFive()
        {
            //Arrange
            var polygon = new ConcreteRegularPolygon(3, 0.5);
            var expected = 0.25;

            //Act
            var actual = polygon.GetPerimeter();

            //Assert
            Assert.Equal(expected, actual);
        }

        public void ConcreteRegularPolygonLengthIs1000()
        {
            //Arrange
            var polygon = new ConcreteRegularPolygon(3, 1000);
            var expected =1000000;

            //Act
            var actual = polygon.GetPerimeter();

            //Assert
            Assert.Equal(expected, actual);
        }

        public void ConcreteRegularPolygonSideis5LengthIs1000()
        {
            //Arrange
            var polygon = new ConcreteRegularPolygon(5, 1000);
            var expected = 1000000;

            //Act
            var actual = polygon.GetPerimeter();

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}