using System;

namespace ShapeTheShape
{
    class Program
    {
        public void showcasePointClass(int a, int b) {
            Point point1 = new Point();
            Console.WriteLine("Created Point obj with coordinates ({0}, {1})", point1.X, point1.Y);
            Console.WriteLine("DisplayCoordinates() displays the point's coordinates.");
            point1.DisplayCoordinates();

            Point point2 = new Point(a, b);
            Console.WriteLine("\nCreated Point obj with coordinates ({0}, {1})", point2.X, point2.Y);

            Console.WriteLine("\nCalculateDistanceFromOrigin() calculates the distance from\nthe point to the origin. For our point ({0}, {1}), it's {2:.000} to 3dp", point2.X, point2.Y, point2.CalculateDistanceFromOrigin());

            Console.WriteLine("\nTranslatePointByVector(a, b) moves our point along the axes.\nIf we want to move our point ({0},{1}) by (3, -10)", point2.X, point2.Y);
            point2.TranslatePointByVector(3, -10);
            Console.WriteLine("our new coordinates are({0},{1})", point2.X, point2.Y);

            Console.WriteLine("\nPoint.MultiplyXByScalar and Point.MultiplyYByScalar multiply the\nx and y values by scalar values, e.g. 2 and 3.");
            point2.DisplayCoordinates();
            point2.MutliplyXByScalar = 2;
            point2.MultiplyYByScalar = 3;
            point2.DisplayCoordinates();

            Console.WriteLine("\nPoint[0] accesses the x-value, and Point[1] accesses the y-value.\nCoordinates are: ({0},{1}). Any other index will return an error\nE.g. Point[5]: {2}", point2[0], point2[1], point2[5]);

            Console.WriteLine("\nPoint++ increases both x and y by 1.");
            point2.DisplayCoordinates();
            point2++;
            point2.DisplayCoordinates();

            Console.WriteLine("\nPoint-- decreases both x and y by 1.");
            point2.DisplayCoordinates();
            point2--;
            point2.DisplayCoordinates();

            Console.WriteLine("Point + a adds a to the x and the y value of the point. Eg. adding 10 to our coordinates.");
            point2.DisplayCoordinates();
            point2 += 10;
            point2.DisplayCoordinates();
        }
    }
}
