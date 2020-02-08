using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTheShape
{
    class Triangle
    {
        private int a, b, c;

        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public bool TriangleExists()
        {
            if (A < B + C && B < A + C && C < A + B) { return true; }
            else { return false; }
        }

        public void DisplaySides()
        {
            Console.WriteLine("Triangle with sides: {0}, {1}, {2}", A, B, C);
        }

        public int CalculatePerimeter()
        {
            return A + B + C;
        }

        public double CalculateArea()
        {
            int p = this.CalculatePerimeter();
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public int this[int i]
        {
            get
            {
                if (i == 0) { return A; }
                else if (i == 1) { return B; }
                else if (i == 2) { return C; }
                else { throw new Exception("Error: invalid index"); }
            }
        }

        public static Triangle operator ++(Triangle triangle)
        {
            triangle.A += 1;
            triangle.B += 1;
            triangle.C += 1;
            return triangle;
        }

        public static Triangle operator --(Triangle triangle)
        {
            triangle.A -= 1;
            triangle.B -= 1;
            triangle.C -= 1;
            return triangle;
        }

        public static bool operator true(Triangle triangle)
        {
            return triangle.TriangleExists();
        }

        public static bool operator false(Triangle triangle)
        {
            return !triangle.TriangleExists();
        }

        public static Triangle operator *(Triangle triangle, int scalar)
        {
            triangle.A *= scalar;
            triangle.B *= scalar;
            triangle.C *= scalar;
            return triangle;
        }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
