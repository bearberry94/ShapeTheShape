using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTheShape
{
    class Point
    {
        private int x, y;

        public int X { set; get; }

        public int Y { set; get; }

        public int MutliplyXByScalar
        {
            set { X *= value; }
        }

        public int MultiplyYByScalar
        {
            set { Y *= value; }
        }

        public int this[int i]
        {
            get
            {
                if (i == 0) { return X; }
                else if (i == 1) { return Y; }
                else { throw new Exception("Error: invalid index"); }
            }
        }
        
        public void DisplayCoordinates()
        {
            Console.WriteLine(">> Coordinates: ({0}, {1})", X, Y);
        }

        public double CalculateDistanceFromOrigin()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }

        public void TranslatePointByVector(int a, int b)
        {
            X += a;
            Y += b;
        }

        public static Point operator ++(Point point) {
            point.X += 1;
            point.Y += 1;
            return point;
        }

        public static Point operator --(Point point)
        {
            point.X -= 1;
            point.Y -= 1;
            return point;
        }

        public static bool operator true(Point point)
        {
            if (point.X == point.Y) { return true; }
            else { return false; }
        }

        public static bool operator false(Point point)
        {
            if (point.X != point.Y) { return false; }
            else { return true; }
        }

        public static Point operator +(Point point, int scalar)
        {
            point.X += scalar;
            point.Y += scalar;
            return point;
        }

        public Point(int x=0, int y=0)
        {
            X = x;
            Y = y;
        }
    }
}
