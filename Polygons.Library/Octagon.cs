using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    public class Octagon : IRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public double SideLength { get; set; }

        public Octagon(double length)
        {
            NumberOfSides = 8;
            SideLength = length;
        }

        public double GetArea()
        {
            return NumberOfSides * SideLength;
        }

        public double GetPerimeter()
        {
           return SideLength * SideLength * (2 + 2 *  Math.Sqrt(2));
        }
    }
}
