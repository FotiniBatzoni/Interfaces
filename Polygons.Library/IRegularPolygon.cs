using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    internal interface IRegularPolygon
    {
         int NumberOfSides { get; set; }
         double SideLength { get; set; }

        double GetPerimeter();
        double GetArea();
    }
}
