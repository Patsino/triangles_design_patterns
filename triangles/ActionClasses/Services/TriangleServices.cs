using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triangles.EntityClasses.Entities;

namespace triangles.ActionClasses.Services
{
    public static class TriangleServices
    {
        public static double CalculateAreaCoords(Point p1, Point p2, Point p3)
        {
            //Sabc=1/2 |(x2 – x1)(y3 –y1) – (x3 – x1)(y2 – y1)|

            return Math.Abs((p2.X - p1.X) * (p3.Y - p1.Y) - (p3.X - p1.X)*(p2.Y - p1.Y)) / 2;
        }


        public static double CalculateArea(Point a, Point b, Point c)
        {
            double ab = Distance(a, b);
            double bc = Distance(b, c);
            double ca = Distance(c, a);

            double semiPerimeter = (ab + bc + ca) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - ab) * (semiPerimeter - bc) * (semiPerimeter - ca));
        }

        public static double CalculatePerimeter(Point a, Point b, Point c)
        {
            double ab = Distance(a, b);
            double bc = Distance(b, c);
            double ca = Distance(c, a);

            return ab + bc + ca;
        }

        public static TriangleType DetermineTriangleType(Point a, Point b, Point c)
        {
            double ab = Distance(a, b);
            double bc = Distance(b, c);
            double ca = Distance(c, a);

            if (!IsValidTriangle(a, b, c))
            {
                return TriangleType.Invalid;
            }

            TriangleType type = 0;

            if (IsRightTriangle(ab, bc, ca))
            {
                type |= TriangleType.Right;
            }


            if (ab == bc || bc == ca || ca == ab)
            {
                if (ab == bc && bc == ca)
                {
                    type |= TriangleType.Equilateral;
                }
                else
                {
                    type |= TriangleType.Isosceles;

                }
            }


            if (IsAcuteTriangle(ab, bc, ca))
            {
                type |= TriangleType.Acute;
            }
            else if (IsObtuseTriangle(ab, bc, ca))
            {
                type |= TriangleType.Obtuse;
            }

            return type;
        }

        private static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        private static bool IsValidTriangle(Point a, Point b, Point c) => CalculateArea(a, b, c) <= double.Epsilon;

        private static bool IsRightTriangle(double ab, double bc, double ca)
        {
            double[] sides = [ab, bc, ca];
            Array.Sort(sides);
            return sides[2] * sides[2] == (sides[0] * sides[0] + sides[1] * sides[1]) ;
        }

        private static bool IsAcuteTriangle(double ab, double bc, double ca)
        {
            //ostrii
            double[] sides = { ab, bc, ca };
            Array.Sort(sides);
            return sides[2] * sides[2] < sides[0] * sides[0] + sides[1] * sides[1];
        }

        private static bool IsObtuseTriangle(double ab, double bc, double ca)
        {
            // tupoi
            double[] sides = { ab, bc, ca };
            Array.Sort(sides);
            return sides[2] * sides[2] > sides[0] * sides[0] + sides[1] * sides[1];
        }
    }
}
