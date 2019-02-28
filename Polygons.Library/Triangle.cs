using System;

namespace Polygons.Library
{
    public class Triangle : AbstractRegularPolygon
    {
        public Triangle(int length) : 
            base(3, length)
        { }

        public override double GetArea()
        {
            return Math.Round(SideLength * SideLength * Math.Sqrt(3) / 4, 2, MidpointRounding.AwayFromZero);
        }
    }
}
