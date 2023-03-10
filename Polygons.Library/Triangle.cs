using System;

namespace Polygons.Library
{
    public class Triangle : AbstractRegularPolygon
    {
        //constructor
        public Triangle(double length) : base(3, length) { }

        public override double GetArea()
        {
            return SideLength * SideLength * Math.Sqrt(3) / 4;
        }
    }
}
