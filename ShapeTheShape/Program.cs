using System;

namespace ShapeTheShape
{
    class Program
    {
        public static void ShowcasePointClass(int a, int b) {
            Point point = new Point(a, b);
            Console.WriteLine("\nCreated Point obj with coordinates ({0}, {1})", point.X, point.Y);

            Console.WriteLine("\nCalculateDistanceFromOrigin() calculates the distance from\nthe point to the origin. For our point ({0}, {1}), it's {2:.000} to 3dp", point.X, point.Y, point.CalculateDistanceFromOrigin());

            Console.WriteLine("\nTranslatePointByVector(a, b) moves our point along the axes.\nIf we want to move our point ({0},{1}) by (3, -10)", point.X, point.Y);
            point.TranslatePointByVector(3, -10);
            Console.WriteLine("our new coordinates are({0},{1})", point.X, point.Y);

            Console.WriteLine("\nPoint.MultiplyXByScalar and Point.MultiplyYByScalar multiply the\nx and y values by scalar values, e.g. 2 and 3.");
            point.DisplayCoordinates();
            point.MutliplyXByScalar = 2;
            point.MultiplyYByScalar = 3;
            point.DisplayCoordinates();

            Console.WriteLine("\nPoint[0] accesses the x-value, and Point[1] accesses the y-value.\nCoordinates are: ({0},{1}). Any other index will return an error", point[0], point[1]);
            Console.WriteLine("If the index is out of bounds, the program will exit with an error.\nFor the sake of this exercise, we will catch the error and continue with the code.\nE.g. Point[8] results in:");
            try
            {
                Console.WriteLine(point[8]);
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("\nPoint++ increases both x and y by 1.");
            point.DisplayCoordinates();
            point++;
            point.DisplayCoordinates();

            Console.WriteLine("\nPoint-- decreases both x and y by 1.");
            point.DisplayCoordinates();
            point--;
            point.DisplayCoordinates();

            Console.WriteLine("Point + a adds a to the x and the y value of the point. Eg. adding 10 to our coordinates.");
            point.DisplayCoordinates();
            point += 10;
            point.DisplayCoordinates();
        }

        public static void ShowcaseTriangleClass(int a, int b, int c)
        {
            Triangle triangle = new Triangle(a, b, c);
            Console.WriteLine("\nCreated Triangle obj with sides {0}, {1}, {2}", triangle.A, triangle.B, triangle.C);
            triangle.DisplaySides();

            Console.WriteLine("\nCalculatePerimeter() calculates the triangle's perimeter. Perimeter = {0}", triangle.CalculatePerimeter());

            Console.WriteLine("\nCalculateArea() calculates the triangle's area. Area = {0:.00}", triangle.CalculateArea());

            Console.WriteLine("\nTriangle true/false establishes whether such a triangle can even exist. Does our triangle exist?: {0}", triangle.TriangleExists());
            
            Console.WriteLine("\nTriangle[0/1/2] access the triangle's a/b/c side.. Any other index will throw an error\n. E.g. Triangle ({0}, {1}, {2})", triangle[0], triangle[1], triangle[2]);
            Console.WriteLine("If the index is out of bounds, the program will exit with an error.\nFor the sake of this exercise, we will catch the error and continue with the code.\n");
            try
            {
                Console.WriteLine(triangle[8]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("\nTriangle++ increases all the triangle's sides by 1.");
            triangle++;
            triangle.DisplaySides();

            Console.WriteLine("\nTriangle-- decreases all the triangle's sides by 1.");
            triangle--;
            triangle.DisplaySides();

            Console.WriteLine("\nTriangle * x multiplies all the triangle's sides by x. E.g. multiply by 5.");
            triangle.DisplaySides();
            triangle *= 5;
            triangle.DisplaySides();  
        }

        public static void ShowcaseRectangleClass(int a, int b)
        {
            Rectangle rectangle = new Rectangle(a, b);
            Console.WriteLine("\nCreated Rectangle obj with sides {0}, {1}", rectangle.A, rectangle.B);
            rectangle.DisplaySides();

            Console.WriteLine("\nCalculatePerimeter() calculates the rectangle's perimeter. Perimeter = {0}", rectangle.CalculatePerimeter());

            Console.WriteLine("\nCalculateArea() calculates the rectangle's area. Area = {0}", rectangle.CalculateArea());

            Console.WriteLine("\nRectangle true/false establishes whether the rectangle is a square.\nIs our rectangle a square: {0}", rectangle.CheckIfSquare());

            Console.WriteLine("\nRectangle[0/1/2] access the rectangle's a/b side.. Any other index will throw an error\n. E.g. Rectangle ({0}, {1})", rectangle[0], rectangle[1]);
            Console.WriteLine("If the index is out of bounds, the program will exit with an error.\nFor the sake of this exercise, we will catch the error and continue with the code.\n");
            try
            {
                Console.WriteLine(rectangle[8]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("\nRectangle++ increases all the rectangle's sides by 1.");
            rectangle++;
            rectangle.DisplaySides();

            Console.WriteLine("\nRectangle-- decreases all the rectangle's sides by 1.");
            rectangle--;
            rectangle.DisplaySides();

            Console.WriteLine("\nRectangle * x multiplies all the rectangle's sides by x. E.g. multiply by 5.");
            rectangle.DisplaySides();
            rectangle *= 5;
            rectangle.DisplaySides();
        }
        static void Main(string[] args)
        {
            //ShowcasePointClass(5, 7);
            //ShowcaseTriangleClass(4, 2, 5);
            ShowcaseRectangleClass(4, 4);
        }
    }
}
