using System;
using Polygons.Library;

namespace Polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            DisplayDetails("Square", square);

            var triangle = new Triangle(5);
            DisplayDetails("Triangle", triangle);

            var octagon = new Octagon(5);
            DisplayDetails("Octagon", octagon);
        }

        public static void DisplayDetails(string polygonType, dynamic polygon)
        {
            try
            {
                Console.WriteLine("{0} Number of Sides:     {1}", polygonType, polygon.NumberOfSides);
                Console.WriteLine("{0} Side Length:         {1}", polygonType, polygon.SideLength);
                Console.WriteLine("{0} Perimeter:           {1}", polygonType, polygon.GetPerimeter());
                Console.WriteLine("{0} Area:                {1}", polygonType, polygon.GetArea());
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Exception: {0}\nMessage: {1}", ex.GetType().Name, ex.Message);
                Console.WriteLine();
            }
        }
    }
}
